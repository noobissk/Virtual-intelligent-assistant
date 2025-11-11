using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Virtual_intelligent_assistant.Models
{
    public class ViaProfile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        // Core data
        public string Conversation { get; set; } = "";

        // Relationships
        public Prompt Prompt { get; set; } = new();
        public List<ActionItem> Actions { get; set; } = new();
        public Appearance? Appearance { get; set; } // optional
    }
}
