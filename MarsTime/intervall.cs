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
        private enum _state { NESTED, OVERLAP, TOUCH, DISJOINT}

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
            if (f.GetAbsoluteTime() <= t.GetAbsoluteTime())
            {
                From = f;
                To = t;
            }
            else
            {
                throw new ArgumentException("Eines der angegebenen Intervalle ist ungültig!");
            };
        }

        public static string GetIntervallState(intervall a, intervall b) 
        {
            if ((a.From.GetAbsoluteTime() >= b.From.GetAbsoluteTime() && a.To.GetAbsoluteTime() <= b.To.GetAbsoluteTime()) || 
                (b.From.GetAbsoluteTime() >= a.From.GetAbsoluteTime() && b.To.GetAbsoluteTime() <= a.To.GetAbsoluteTime())) 
            {
               return "NESTED";
            }
            else if (a.From.GetAbsoluteTime() < b.To.GetAbsoluteTime() && b.From.GetAbsoluteTime() < a.To.GetAbsoluteTime())
            {
                return "OVERLAP";
            }
            else if (a.To.GetAbsoluteTime() == b.From.GetAbsoluteTime() || b.To.GetAbsoluteTime() == a.From.GetAbsoluteTime())
            {
                return "TOUCH";
            }
            else
            {
                return "DISJOINT";
            }
        }
        }

    
}
