using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
  public  class factor
    {
        public int ID { get; set; }
        public ICollection<kala> Kalas { get; set; } = new List<kala>();
        public float totalpric { get; set; }
       
        public int FactorNum { get; set; }
        public DateTime Date { get; set; }
        public moshtari Moshtari { get; set; }

       
    }
    
}
