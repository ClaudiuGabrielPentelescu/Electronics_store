using System;
using System.Data;

namespace LibrarieModele
{
    public class Electronic
    {
        public int IdElectronic { get; set; }
        public string Nume_produs { get; set; }
        public string Firma { get; set; }
        public string Model { get; set; }
        public string Specificatii { get; set; }
        public string Culoare { get; set; }
        public int Nr_Produse { get; set; }
        public int Pret { get; set; }


        public Electronic()
        { }
        public Electronic(int idElectronic, string  nume_produs, string firma, string model, string specificatii, string culoare, int nr_produse, int pret )
        {
            IdElectronic = idElectronic;
            Nume_produs = nume_produs;
            Firma = firma;
            Model = model;
            Specificatii = specificatii;
            Culoare = culoare;
            Nr_Produse = nr_produse;
            Pret = pret;
        }

        public Electronic(DataRow linieBD)
        {
            IdElectronic = Convert.ToInt32(linieBD["idElectronic"].ToString());
            Nume_produs = linieBD["nume_produs"].ToString();
            Firma = linieBD["firma"].ToString();
            Model = linieBD["model"].ToString();
            Specificatii = linieBD["specificatii"].ToString();
            Culoare = linieBD["culoare"].ToString();
            Nr_Produse = Convert.ToInt32(linieBD["nr_produse"].ToString());
            Pret = Convert.ToInt32(linieBD["pret"].ToString());
        }
    }
}
