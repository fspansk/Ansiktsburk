using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ansiktsburk.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string body { get; set; }
        public string author { get; set; }
        public DateTime timestamp { get; set; }
    }
}
