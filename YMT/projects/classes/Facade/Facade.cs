namespace YMT.projects.classes.Facade
{
    class Facade
    {
        private MerkezBanka merkezbanka=new MerkezBanka(); // Sınıfları içermesini sağlıyoruz
        private Kredi kredi= new Kredi();
        private Banka banka=new Banka();
        public string KrediKullan(Musteri m,string talep) // Kredi kullanma durumunu kontrol ediyoruz
        {
            if (merkezbanka.KaraListe(m.TcNo) && kredi.KrediKullanmaDurumu(m)) // Karaliste kontrolu yapıyoruz
            {
                banka.KrediyiKullan(m, talep); // Kredi çektiriyoruz
                return talep;
            }
            else
            {
                return "Kredi Kullanılamadı"; // Hata mesajı gösteriyoruz
            }
        }
    }
}
