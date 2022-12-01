namespace arayuzler_ornek{
    public class E300 : IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
            return Marka.Mercedes;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNE()
        {
            return Renk.Beyaz;
        }
    }
}