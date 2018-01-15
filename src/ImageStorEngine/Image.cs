using System;

namespace ImageStorEngine
{
    public class Image
    {
        public Image(ShortCode c, string fileName, string filePath = null)
        {
            Id = c;
            Name = fileName;
            Location = filePath ?? string.Empty;
        }

        protected Image()
        {

        }

        public ShortCode Id { get; protected set; }
        public string Name { get; protected set; }
        /// <summary>
        /// This is a *relative* path to the configured image root
        /// </summary>
        public string Location { get; protected set; }

        public override string ToString()
        {
            return $"{Id} ({Location})";
        }
    }
}
