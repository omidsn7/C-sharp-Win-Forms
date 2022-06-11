using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleATM
{
   public class CardClass
    {
        public int CardId { get; set; }
        public string CardNum { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }
        public bool IsActive { get; set; }


    }
}
