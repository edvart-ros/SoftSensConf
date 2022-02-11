using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public class Instrument
    {
        public int measurement;

        public string tagname { get; set; }
        public double lrv { get; set; }
        public double urv { get; set; }


        public Instrument(int measurement)
        {
            this.measurement = measurement;
        }

        public Instrument(string tagname, double lrv, double urv)
        {
            this.tagname = tagname;
            this.lrv = lrv;
            this.urv = urv;
        }
        public Instrument()
        {
        }

        public double Scaled()
        {
            return this.measurement / 10.0;
        }
    }
    
}
