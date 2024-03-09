using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsService.Models
{
    public class Command
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string HowTo { get; set; } = string.Empty;
        [Required]
        public string CommandLine { get; set; } = string.Empty;
        [Required]
        public int PlatformId { get; set; }
        #pragma warning disable CS8618
        public Platform Platform { get; set; }
        #pragma warning restore CS8618
    }
}