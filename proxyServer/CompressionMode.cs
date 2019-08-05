namespace Brotli
{
    public enum CompressionMode
    {
        // Default compression mode. The compressor does not know anything in advance about the properties of the input.
        Generic = 0,

        // Compression mode for UTF-8 format text input.
        Text = 1,

        // Compression mode used in WOFF 2.0.
        Font = 2
    }
}