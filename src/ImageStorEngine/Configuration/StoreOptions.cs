namespace ImageStorEngine.Configuration
{
    public class StoreOptions {
        public string ImageSavePath {get;set;} = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "images");
        public string IndexFilePath {get;set;} = "images/index.yml";
        public bool OverwriteFiles {get;set;} = true;
    }
}