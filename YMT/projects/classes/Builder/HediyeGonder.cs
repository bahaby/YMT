using System;

public class HediyeGonder
{
	public void Gonder(BuilderClass builderClass)
	{
        builderClass.SetKazanankisi();
        builderClass.SetKodu();
        builderClass.SetUrunAdi();
        //formda tablo çıkıyor öyle ben bu clasta gönderme yapmıyorum bi yere olabilir mi
        //sen forma bişey eklememişsin sanki for mbao form bu kodların usinginde yok bak abi
        //bunlar aynı klasörde oldugu için gerek yok 

    }
}
