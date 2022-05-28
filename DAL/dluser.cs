using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;
using System.Data.Entity;
namespace DAL
{
   public class dluser
    {
        DB db = new DB();

        public byte Login(string username, string password)
        {
            if (db.Users.Count() == 0)
            {
                return 0;
            }
            else
            {
                if (db.Users.Any(i => i.Username == username && i.Pasword == password))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public string Register(user u)
        {
            if (!searchbyusername(u.Username))
            {
                db.Users.Add(u);
                db.SaveChanges();
                return "اطلاعات با موفقیت ثبت گردید ";
            }
            else
            {
                return "نام کاربری مورد نظر در سیستم ثبت گردیده است";
            }
            
        }
        public bool searchbyusername(string username)
        {
            return db.Users.Any(i => i.Username == username);
        }
    }
}
