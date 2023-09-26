using System;
using System.Data;

namespace LibrarieModele
{
    public class Comercializare
    {
      
        //entitati aditionale
        public virtual Utilizator Utilizator{ get; set; }
        public virtual Electronic Electronic { get; set; }


        //entitati proprii
        public string NumeUtilizator { get; set; }
        public int IdElectronic { get; set; }
        public string Modalitate_plata { get; set; }

        public Comercializare()
        { }
        public Comercializare(string numeUtilizator, int idElectronic, string modalitate_plata)
        {
            NumeUtilizator = numeUtilizator;
            IdElectronic = idElectronic;
            Modalitate_plata = modalitate_plata;
        }

        public Comercializare(DataRow linieBD)
        {
            NumeUtilizator = linieBD["numeUtilizator"].ToString();
            IdElectronic = Convert.ToInt32(linieBD["idElectronic"].ToString());
            Modalitate_plata = linieBD["modalitate_plata"].ToString();
        }
    }
}
