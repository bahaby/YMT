﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMT.projects.classes.Proxy
{
    class Resim:IGorsel
    {
        public void Goster(PictureBox pb, string Dizin)
        {
            pb.ImageLocation = Dizin;
        }
    }
}
