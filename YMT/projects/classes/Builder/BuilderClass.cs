using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Builder
{//sanırım bu yada diğer ikisinden biri
	abstract class BuilderClass
	{
        protected Hediye hediye;
        public Hediye hediye
        {
            get
                {
                return hediye;
                }
        }
	}
    public abstract void SetUrunAdi();
    public abstract void SetKodu();
    public abstract void SetKazanankisi();
}
