using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
  public  class account_moshtari
    {
        public int Id { get; set; }
        public int moshtariid { get; set; }

        //public moshtari Moshtari { get; set; }
        public float bedhkari { get; set; }
        public float bestankari { get; set; }
        public ICollection<factor> Sefarshats { get; set; }

        
        
      

    }
}
