using System.Runtime.InteropServices;

namespace Brotli
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CompressionParameters
    {
        public CompressionMode Mode;

        // Controls the compression-speed vs compression-density tradeoffs. The higher the quality, the slower the compression. Range is 0 to 11.
        public int Quality;

        // Base 2 logarithm of the sliding window size. Range is 10 to 24.
        public int LgWin;

        // Base 2 logarithm of the maximum input block size. Range is 16 to 24. If set to 0, the value will be set based on the quality.
        public int LgBlock;

        [MarshalAs(UnmanagedType.I1)]
        public bool EnableDictionary;

        [MarshalAs(UnmanagedType.I1)]
        public bool EnableTransforms;

        [MarshalAs(UnmanagedType.I1)]
        public bool GreedyBlockSplit;

        [MarshalAs(UnmanagedType.I1)]
        public bool EnableContextModeling;
    }
}