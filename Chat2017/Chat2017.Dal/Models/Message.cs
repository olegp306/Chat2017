using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat2017.Dal.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public Chat Chat { get; set; }
        public User User { get; set; }
        public string Content { get; set; }
    }
}
