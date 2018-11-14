using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ansiktsburk.Models
{
    public class Post
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Body { get; set; }

        [Required]
        public string Author { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
