using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;
using System.Data.Entity;

namespace DAL
{
   public class dlkala
    {
        DB db = new DB();

        public string Create(kala k)
        {
            if (!search(k))
            {

                db.Kalas.Add(k);
                db.SaveChanges(); 
                return "ثبت اطلاعات با موفقیت انجام شد";
                
                
            }
            else
            {
                return "اطلاعات وارد شده تکراری است.";
            }
        }

        public bool search(kala k)
        {
            return db.Kalas.Any(i => i.Name == k.Name );
        }

        public List<kala> search_by_name(string name)
        {
            return db.Kalas.Where(i => i.Name.Contains(name)).ToList();
        }
        public kala searchbyname(string name)
        {
            var q=db.Kalas.Where(i => i.Name==name);
            if (q.Count()!=0)
            {
                return q.Single();

            }
            return null;
        }
        public List<kala> Read_all()
        {
            return db.Kalas.ToList();
        }

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

        public void update_tedad(int id,int tedad_sefaresh)
        {
            var k = new kala();
            k = search_by_id(id);
            k.tedad = k.tedad - tedad_sefaresh;
            var s = Update(id, k);
        }
    }
}
