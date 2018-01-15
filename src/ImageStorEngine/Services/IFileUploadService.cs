using System.IO;

namespace ImageStorEngine.Services
{
    public interface IFileUploadService
    {
        DirectoryInfo RootPath {get;}
        FileInfo Save(Stream file, string fileName);
        FileInfo Save(System.Uri remoteFile);
        bool Delete(FileInfo file);
    }
    
}