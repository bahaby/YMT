using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMT.projects.classes.Proxy
{
    class Proxy:IGorsel
    {
        Resim resim= null;
        bool ResimYuklendi;
        PictureBox pb;
        string Dizin;
       
        void ResimYukle(object o)
        {
            resim = new Resim();
            resim.Goster(pb, Dizin);
            ResimYuklendi = true;
        }
        public void Goster(PictureBox pb, string Dizin)
        {
            
            this.pb = pb;
            this.Dizin = Dizin;

            if (resim == null)
            {
                new System.Threading.Timer(new TimerCallback(ResimYukle), this, 2000, 0);
            }

            if (!ResimYuklendi)
            {
                pb.ImageLocation = "yukleniyor.png";
            }
        }
    }
}
