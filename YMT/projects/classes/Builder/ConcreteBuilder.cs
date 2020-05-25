using System;

 class KisilerConcreteBuilder: BuilderClass
{
	public KisilerConcreteBuilder()
    {
        hediye = new Hediye();
    }
    public override void SetKazanankisi() => hediye.SetKazanankisi = "Bahadır";
    public override void SetKodu() => hediye.SetKodu = "565";
    public override void SetUrunAdi() => hediye.SetUrunAdi = "iPhone";
}
class KazanankisiBuilder : KisilerConcreteBuilder
{
    public KazanankisiBuilder()
    {
        hediye = new Hediye();
    }
    public override void SetKazanankisi() => hediye.SetKazanankisi = "Hakan";
    public override void SetKodu() => hediye.SetKodu = "696";
    public override void SetUrunAdi() => hediye.SetUrunAdi = "Samsung";
}
class SonKazananBuilder : KisilerConcreteBuilder
{
    public SonKazananBuilder()
    {
        hediye = new Hediye();
    }
    public override void SetKazanankisi() => hediye.SetKazanankisi = "Onur";
    public override void SetKodu() => hediye.SetKodu = "896";
    public override void SetUrunAdi() => hediye.SetUrunAdi = "Xiaomi";
}
