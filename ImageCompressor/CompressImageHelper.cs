using EarlPeterG.Win;
using RunProcessAsTask;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImageCompressor
{
    public class CompressImageHelper
    {
        public static async Task<string> CompressImage(string filename, Settings settings, CancellationToken cancellationToken)
        {
            if (!File.Exists(filename)) { throw new Exception("File does not exists."); }
            var fileExtension = new FileInfo(filename).Extension.ToLower();

            var useOutputDirecty = !string.IsNullOrEmpty(settings.OutputDirectory);
            if (useOutputDirecty && !Directory.Exists(settings.OutputDirectory)) { Directory.CreateDirectory(settings.OutputDirectory); }

            string processPath, processArgs;
            string output = useOutputDirecty ? Path.Combine(settings.OutputDirectory, Path.GetFileName(filename)) : filename;


            if (fileExtension == ".jpg" || fileExtension == ".jpeg") {
                if (settings.JpegUseGuetzli) {
                    // guetzli --quality <quality> <input_filename> <output_filename>
                    processPath = settings.GuetzliExecPath;
                    processArgs = $"--quality {(settings.JpegQuality < 84 ? 84 : settings.JpegQuality)} --memlimit {settings.MemoryLimit} \"{filename}\" \"{output}\"";
                } else {
                    // jpegoptim --dest="Alternate directory" --force --max=<quality> --strip-all <filenames>
                    processPath = settings.JpegoptimExecPath;
                    processArgs = $"\"{filename}\"";
                    if (useOutputDirecty) { processArgs += $" --dest=\"{settings.OutputDirectory}\""; }
                    if (settings.RemoveMetadata) { processArgs += " --strip-all"; }
                }
            } else if (fileExtension == ".png") {
                // optiong <file> -o <levels> -out "<path>" -strip/-preserve
                processPath = settings.OptipngExecPath;
                processArgs = $"\"{filename}\" -o {settings.PngOptimPasses} {(settings.RemoveMetadata ? "-strip all" : "-preserve")}";
                if (useOutputDirecty) { processArgs += $" -dir \"{settings.OutputDirectory}\""; }
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

            return output;
        }
    }
}
