using System.IO.Compression;

namespace SystemInterface.IO.Compression
{
    public interface IDeflateStreamFactory
    {
        IDeflateStream Create(IMemoryStream memoryStream, CompressionMode compressionMode);
    }
}
