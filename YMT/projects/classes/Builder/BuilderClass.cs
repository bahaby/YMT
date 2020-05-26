using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Builder
{
    abstract class BuilderClass
    {
        protected Hediye hediye;
        public Hediye Hediye
        {
            get
            {
                return hediye;
            }
        }
        public abstract void SetUrunAdi();
        public abstract void SetKodu();
        public abstract void SetKazanankisi();
    }
}
