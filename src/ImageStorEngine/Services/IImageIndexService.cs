using System.Collections.Generic;
using System.IO;
using IdEngine;

namespace ImageStorEngine.Services
{
    public interface IImageIndexService
    {
        Dictionary<string, ImageReference> GetIndex();
        ImageReference GetImage(Id c);
        ImageReference GetImageByName(string name);
        Id AddImage(string filePath, string name = null);
        bool RemoveImage(Id code);
    }
}