using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEE;
namespace BLL
{
   
    public class bluser 
    {
        dluser dal = new dluser();

        public byte Login(string username, string password)
        {
            return dal.Login(username, password);
        }

        public void Register(user u)
        {
            dal.Register(u);
        }
    }
    public class blmoshtari 
    {
        dlmoshtari dal = new dlmoshtari ();

        public string Create(moshtari m)
        {
            return dal.Create(m);
        }

        public List<moshtari> search_by_name(string name)
        {
            return dal.search_by_name_list(name);
        }
        public moshtari searchbyname(string name)
        {
            return dal.searchbyname(name);
        }

        public List<moshtari> Read_all()
        {
            return dal.Read_all();
        }

        public moshtari search_by_id(int id)
        {
            return dal.search_by_id(id);
        }

        public string Update(int id, moshtari mnew)
        {
            return dal.Update(id, mnew);
        }

        public string Delete(int id)
        {
            return dal.Delete(id);
        }
    }
    public class blkala
    {
        dlkala dal = new dlkala();

        public string Create(kala k)
        {
            return dal.Create(k);
        }

        public List<kala> search_by_name(string name)
        {
            return dal.search_by_name(name);
        }
        public kala searchbyname(string name)
        {
            return dal.searchbyname(name);
        }
        public List<kala> Read_all()
        {
            return dal.Read_all();
        }

        public kala search_by_id(int id)
        {
            return dal.search_by_id(id);
        }

        public string Update(int id, kala knew)
        {
            return dal.Update(id, knew);
        }

        public string Delete(int id)
        {
            return dal.Delete(id);
        }
    }
   
    public class blfaktor {
        dlfactor dal = new dlfactor();
        public string Create(factor factor)
        {
          return  dal.Create(factor);
        }

    }
}
