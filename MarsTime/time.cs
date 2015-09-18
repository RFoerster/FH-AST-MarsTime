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
            set { _mhour = value; }
        }

        public int Mminute
        {
            get { return _mminute; }
            set { _mminute = value; }
        }

        public time(int h, int min)
        {
            Mhour = h;
            Mminute = min;
        }

        
    }
}
