using System;

namespace YMT.projects.classes.Builder
{
    class KisilerConcreteBuilder : BuilderClass
    {
        public KisilerConcreteBuilder()
        {
            hediye = new Hediye();
        }
        public override void SetKazanankisi() => hediye.Kazanan = "Bahadır";
        public override void SetKodu() => hediye.Kodu = 565;
        public override void SetUrunAdi() => hediye.HediyeUrun = "iPhone";
    }
    class KazanankisiBuilder : KisilerConcreteBuilder
    {
        public KazanankisiBuilder()
        {
            hediye = new Hediye();
        }
        public override void SetKazanankisi() => hediye.Kazanan = "Hakan";
        public override void SetKodu() => hediye.Kodu = 696;
        public override void SetUrunAdi() => hediye.HediyeUrun = "Samsung";
    }
    class SonKazananBuilder : KisilerConcreteBuilder
    {
        public SonKazananBuilder()
        {
            hediye = new Hediye();
        }
        public override void SetKazanankisi() => hediye.Kazanan = "Onur";
        public override void SetKodu() => hediye.Kodu = 567;
        public override void SetUrunAdi() => hediye.HediyeUrun = "Xiaomi";
    }
}