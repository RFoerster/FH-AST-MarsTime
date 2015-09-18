using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsTime
{
    class time
    {
        private int _mhour;
        private int _mminute;

        

        public int Mhour
        {
            get { return _mhour; }
            set
            {
                if (value < 0 || value >= 25) throw new ArgumentException("Eine angegebene Stunde ist falsch");
                _mhour = value;
            }
        }

        public int Mminute
        {
            get { return _mminute; }
            set 
            {
                if (value < 0 || value >= 100) throw new ArgumentException("Eine angegebene Minute ist falsch");
                _mminute = value;   
            }
        }

        public time(int h, int min)
        {
            Mhour = h;
            Mminute = min;
        }

        public double GetAbsoluteTime()
        {
            
            return Convert.ToDouble(Mhour) + (Mminute / 100d);

        }

        
    }
}
