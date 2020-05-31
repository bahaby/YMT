using System;
using System.Collections.Generic;
using System.Drawing;
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
        Image image;
       
        void ResimYukle(object o)
        {
            resim = new Resim();
            resim.Goster(pb, image);
            ResimYuklendi = true;
        }
        public void Goster(PictureBox pb, Image image)
        {
            
            this.pb = pb;
            this.image = image;

            if (resim == null)
            {
                new System.Threading.Timer(new TimerCallback(ResimYukle), this, 2000, 0);
            }

            if (!ResimYuklendi)
            {
                Image loading = Properties.Resources.yukleniyor;
                pb.Image=loading;
            }
        }
    }
}
