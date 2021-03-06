namespace Goblin.Resource.Share.Models
{
    public class GoblinResourceFileModel
    {
        public string Slug { get; set; }

        public string Folder { get; set; }

        public string Name { get; set; }

        public string Extension { get; set; }

        public string MimeType { get; set; }

        public long ContentLength { get; set; }

        public string Hash { get; set; }

        // Image
        
        public bool IsImage { get; set; }
        
        public bool IsCompressedImage { get; set; } 

        public string ImageDominantHexColor { get; set; }

        public int ImageWidthPx { get; set; } = -1;

        public int ImageHeightPx { get; set; } = -1;
        
        public long? CreatedBy { get; set; }
    }
}