using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulater.Core.Modules
{
    public class ResponseObect
    {
        public string date { get; set; }
        public Rates rates { get; set; }
    }

    public class Rates 
    {
        public float inr { get; set; }
        public float aud { get; set; }
        public float gbp { get; set; }
        public float eur { get; set; }
    }
}
