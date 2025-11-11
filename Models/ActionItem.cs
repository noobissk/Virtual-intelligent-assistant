using System.ComponentModel.DataAnnotations;

namespace Virtual_intelligent_assistant.Models
{
    public class ActionItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ActionName { get; set; } = "";

        public string ActionContext { get; set; } = "";
        public string TerminalCommands { get; set; } = "";

        // Link to VIA profile (many actions per profile)
        public int ViaProfileId { get; set; }
        public ViaProfile ViaProfile { get; set; } = null!;
    }
}
