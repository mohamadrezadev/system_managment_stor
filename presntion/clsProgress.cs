using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pr
{
   public class clsProgress
    {
        private static Thread th = new Thread(new ThreadStart(showProgressForm));
        public string text { get; set; }
        public void startProgress()
        {
            th = new Thread(new ThreadStart(showProgressForm));
            

            th.Start();
        }

        private static void showProgressForm()
        {
           formprocess sForm = new formprocess();
            //if (text!="")
            //{
            //    sForm.labletext.Text = text;
            //}
            sForm.ShowDialog();
        }

        public void stopProgress()
        {
            th.Abort();
            th = null;
        }
    }
}
