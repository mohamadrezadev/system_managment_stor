using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;
using System.Data.Entity;
namespace DAL
{
 public   class dlfactor
    {
        DB db = new DB();

        public string Create(factor factor)
        {
            try
            {
                db.Factors.Add(factor);
                db.SaveChanges();
                return "ثبت اطلاعات با موفقیت انجام شد";
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        //public bool search(factor factor)
        //{
        //    return db.Kalas.Any(i => i == factor.);
        //}

        //public List<factor> search_by_name(string name)
        //{
        //    var q = from i in db.Factors.Include(s => s.Moshtari).ThenInclude(s => s) where i.id == id select i;
        //    return db.Factors.Where(i => i.Moshtari.Name==name);
        //}

        //public List<kala> Read_all()
        //{
        //    return db.Kalas.ToList();
        //}

        public kala search_by_id(int id)
        {
            return db.Kalas.Where(i => i.ID == id).Single();
        }

        public string Update(int id, kala knew)
        {
            var k = new kala();
            k = search_by_id(id);
            k.Name = knew.Name;
            k.price = knew.price;
            k.tedad = knew.tedad;
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }

        public string Delete(int id)
        {
            var k = search_by_id(id);
            db.Kalas.Remove(k);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
    }
}
