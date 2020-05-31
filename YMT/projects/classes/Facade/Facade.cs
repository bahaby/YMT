namespace YMT.projects.classes.Facade
{
    class Facade
    {
        private MerkezBanka merkezbanka=new MerkezBanka(); 
        private Kredi kredi= new Kredi();
        private Banka banka=new Banka();
        public string KrediKullan(Musteri m,string talep) 
        {
            if (merkezbanka.KaraListe(m.TcNo) && kredi.KrediKullanmaDurumu(m)) 
            {
                banka.KrediyiKullan(m, talep); 
                return talep;
            }
            else
            {
                return "Gereken şartlar karşılanmadı."; 
            }
        }
    }
}
