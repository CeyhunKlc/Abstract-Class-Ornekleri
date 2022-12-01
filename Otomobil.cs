namespace arayuzler_ornek{ 
    public abstract class Otomobil{ 
        public int KacTekerlektenOlusur(){ 
            return 4;
        }

        public virtual Renk StandartRengiNE(){ 
            return  Renk.Beyaz;
        }

        public abstract Marka HangiMarkanınAraci(); // kısa yöntem(abstract)
    }
}