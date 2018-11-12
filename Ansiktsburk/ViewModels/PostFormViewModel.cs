using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ansiktsburk.ViewModels
{
    public class PostFormViewModel
    {
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime GetTimeStamp()
        {
            return DateTime.Now;
        }

    }
}
