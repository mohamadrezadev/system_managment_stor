using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myproject
{
   public class clsProgress
    {
        private static Thread th = new Thread(new ThreadStart(showProgressForm));
        public void startProgress()
        {
            th = new Thread(new ThreadStart(showProgressForm));

            th.Start();
        }

        private static void showProgressForm()
        {
           formprocess sForm = new formprocess();
            sForm.ShowDialog();
        }

        public void stopProgress()
        {
            th.Abort();
            th = null;
        }
    }
}
