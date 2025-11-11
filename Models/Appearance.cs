using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Virtual_intelligent_assistant.Models
{
    public class Appearance
    {
        [Key]
        public int Id { get; set; }

        // Only if image generation is supported
        public List<ViaImage> ViaImages { get; set; } = new();
        public List<UserImage> UserImages { get; set; } = new();

        // Link back
        public int ViaProfileId { get; set; }
        public ViaProfile ViaProfile { get; set; } = null!;
    }

    public class ViaImage
    {
        [Key]
        public int Id { get; set; }
        public string Path { get; set; } = ""; // file path or base64 string
        public int AppearanceId { get; set; }
        public Appearance Appearance { get; set; } = null!;
    }

    public class UserImage
    {
        [Key]
        public int Id { get; set; }
        public string Path { get; set; } = "";
        public int AppearanceId { get; set; }
        public Appearance Appearance { get; set; } = null!;
    }
}
