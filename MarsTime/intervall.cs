using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsTime
{
    class intervall
    {
        private time _from;
        private time _to;

        public time From
        {
            get { return _from; }
            set { _from = value; }
        }

        public time To
        {
            get { return _to; }
            set { _to = value; }
        }

        public intervall(time f, time t)
        {

        }

    }
}
