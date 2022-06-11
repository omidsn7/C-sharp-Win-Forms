using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleATM
{
   public static class sqlconnectionclass
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
    }
}
