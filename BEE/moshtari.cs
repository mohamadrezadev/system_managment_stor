using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
  public  class moshtari
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string phone_nuber { get; set; }
        public ICollection<factor> Factors { get; set; } 
        public account_moshtari account_Moshtari  { get; set; }

    }
}
