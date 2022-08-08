using System.Drawing;

namespace ImageCompressor {
    public class Settings
    {
        public string JpegoptimExecPath { get; set; }
        public string GuetzliExecPath { get; set; }
        public string OptipngExecPath { get; set; }

        public int JpegQuality { get; set; }
        public bool JpegUseGuetzli { get; set; }
        public decimal MemoryLimit { get; set; }
        public int PngOptimPasses { get; set; }

        public bool RemoveMetadata { get; set; }
        public string OutputDirectory { get; set; }

        public bool ResizeToMaxBounds { get; set; }
        public Size MaxResolution { get; set; }
    }
}
