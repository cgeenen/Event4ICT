using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event4ICT
{
    class OrderDate
    {
        private DateTime from;
        private DateTime until;
        
        public DateTime From
        {
            get { return from; }
            set { from = value; }
        }

        public DateTime Until
        {
            get { return until; }
            set { until = value; }
        }

        public OrderDate(DateTime from, DateTime until)
        {
            this.from = from;
            this.until = until;
        }
    }
}
