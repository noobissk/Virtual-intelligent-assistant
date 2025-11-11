using System.ComponentModel.DataAnnotations;

namespace Virtual_intelligent_assistant.Models
{
    public class Prompt
    {
        [Key]
        public int Id { get; set; }

        public string Backstory { get; set; } = "";
        public string Circumstance { get; set; } = "";
        public string UserDetails { get; set; } = "";
        public string ExpectedBehavior { get; set; } = "";
        public string Likes { get; set; } = "";
        public string Dislikes { get; set; } = "";
        public string Hobbies { get; set; } = "";
        public string FirstMessage { get; set; } = "";

        // Link back to VIA profile (1:1)
        public int ViaProfileId { get; set; }
        public ViaProfile ViaProfile { get; set; } = null!;
    }
}
