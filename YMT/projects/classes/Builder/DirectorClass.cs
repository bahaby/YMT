using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Builder
{
	class DirectorClass
    {
        public void Gonder(BuilderClass builder)
        {
            builder.SetKazanankisi();
            builder.SetKodu();
            builder.SetUrunAdi();
        }
    }
}
