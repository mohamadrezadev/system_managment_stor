using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;
using System.Data.Entity;

namespace DAL
{
   public class dlmoshtari
    {
        DB db = new DB();

        public string Create(moshtari m)
        {
            if (!search(m))
            {

                db.Moshtaris.Add(m);
                db.SaveChanges();
                return "ثبت اطلاعات با موفقیت انجام شد";


            }
            else
            {
                return "اطلاعات وارد شده تکراری است.";
            }
        }

        public bool search(moshtari m)
        {
            return db.Moshtaris.Any(i => i.Name == m.Name);
        }

        public List<moshtari> search_by_name_list(string name)
        {
            return db.Moshtaris.Where(i => i.Name.Contains(name)).ToList();
        }
        public moshtari searchbyname(string name)
        {
            return db.Moshtaris.Where(i => i.Name==name).Single();
        }

        public List<moshtari> Read_all()
        {
            return db.Moshtaris.ToList();
        }

        public moshtari search_by_id(int id)
        {
            return db.Moshtaris.Where(i => i.ID == id).Single();
        }

        public string Update(int id, moshtari mnew)
        {
            var m = new moshtari();
            m= search_by_id(id);

            m.Name = mnew.Name;
            m.phone_nuber = mnew.phone_nuber;
            
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }

        public string Delete(int id)
        {
            var m = search_by_id(id);
            db.Moshtaris.Remove(m);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }

        public void create_Factor(string name_moshtari,factor Factor)
        {
           
            var m = new moshtari();
            m = searchbyname(name_moshtari);
            
            m.Factors.Add(Factor);


        }
        //public List<factor> finfactor(string name)
        //{
        //    var m = new moshtari();
        //    m = searchbyname(name);
            


        //}
    }
}
