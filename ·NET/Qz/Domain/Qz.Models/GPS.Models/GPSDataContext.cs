using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xinchen.XLinq;

namespace Qz.GPS.Models
{
    public class GPSDataContext : DataContext
    {
        public GPSDataContext()
            : base("GPSContext")
        {

        }
    }
}
