using RunProcessAsTask;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ImageCompressor {
    public class CompressImageHelper
    {
        public static async Task<string> CompressImage(string filePath, Settings settings, CancellationToken cancellationToken)
        {
            if (!File.Exists(filePath)) { throw new Exception("File does not exists."); }

            var fileName = Path.GetFileName(filePath);
            var fileExtension = Path.GetExtension(filePath).ToLower();

            var useOutputDirectory = !string.IsNullOrEmpty(settings.OutputDirectory);

            string processPath, processArgs;

            if (useOutputDirectory) {
                // will create if non-existent
                Directory.CreateDirectory(settings.OutputDirectory);

                // copy source image to new destination
                var newFilePath = Path.Combine(settings.OutputDirectory, fileName);
                File.Copy(filePath, newFilePath);
                filePath = newFilePath;
            }

            if (settings.ResizeToMaxBounds) {
                var image = Image.FromFile(filePath);
                var baseResolution = new Size(image.Width, image.Height);
                var newResolution = CalculateNewSizeToMaxBounds(baseResolution, settings.MaxResolution);

                if (baseResolution != newResolution) {
                    var newImage = ResizeImage(image, newResolution);
                    image.Dispose();
                    newImage.Save(filePath);
                    newImage.Dispose();
                }
            }


            if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".jfif") {
                if (settings.JpegUseGuetzli) {
                    // guetzli --quality <quality> <input_filename> <output_filename>
                    processPath = settings.GuetzliExecPath;
                    processArgs = $"--quality {(settings.JpegQuality < 84 ? 84 : settings.JpegQuality)} --nomemlimit \"{filePath}\" \"{filePath}\"";
                } else {
                    // jpegoptim --force --max=<quality> --strip-all <filenames>
                    processPath = settings.JpegoptimExecPath;
                    processArgs = $"--max={settings.JpegQuality} {(settings.RemoveMetadata ? "--strip-all " : "")}\"{filePath}\"";
                }
            } else if (fileExtension == ".png") {
                // optipng <file> -o <levels> -out "<path>" -strip/-preserve
                processPath = settings.OptipngExecPath;
                processArgs = $"\"{filePath}\" -o {settings.PngOptimPasses} {(settings.RemoveMetadata ? "-strip all" : "-preserve")}";
            } else {
                throw new Exception("Unknown file format.");
            }


            var info = new ProcessStartInfo {
                FileName = processPath,
                Arguments = processArgs,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            await ProcessEx.RunAsync(info, cancellationToken);

            return filePath;
        }

        private static Size CalculateNewSizeToMaxBounds(Size image, Size boundingBox) {
            double widthScale = 0, heightScale = 0;

            if (image.Width != 0) { widthScale = (double)boundingBox.Width / image.Width; }
            if (image.Height != 0) { heightScale = (double)boundingBox.Height / image.Height; }

            var scale = Math.Min(widthScale, heightScale);

            if (scale >= 1) { return image; }

            Size result = new Size((int)(image.Width * scale), (int)(image.Height * scale));
            return result;
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, Size size) {
            var destRect = new Rectangle(0, 0, size.Width, size.Height);
            var destImage = new Bitmap(size.Width, size.Height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
