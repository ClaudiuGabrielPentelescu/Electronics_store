using System;
using System.Data;

namespace LibrarieModele
{
    public class Cos
    {
        public string Nume_Utilizator { get; set; }
        public int IdElectronic { get; set; }
        public string Nume_produs { get; set; }
        public string Firma { get; set; }
        public string Model { get; set; }
        public string Specificatii { get; set; }
        public string Culoare { get; set; }
        public decimal Pret { get; set; }
        public int Nr_Produse { get; set; }
        public decimal Total { get; set; }
        public string Modalitate_plata { get; set; }


        public Cos()
        { }
        public Cos(string Nume_utilizator,int idElectronic, string nume_produs, string firma, string model, string specificatii, string culoare, decimal pret, int nr_produse, decimal total, string modalitate_plata)
        {
            Nume_Utilizator = Nume_utilizator;
            IdElectronic = idElectronic;
            Nume_produs = nume_produs;
            Firma = firma;
            Model = model;
            Specificatii = specificatii;
            Culoare = culoare;
            Pret = pret;
            Nr_Produse = nr_produse;
            Total = total;
            Modalitate_plata = modalitate_plata;
        }

        public Cos(DataRow linieBD)
        {
            Nume_Utilizator = linieBD["Nume_utilizator"].ToString();
            IdElectronic = Convert.ToInt32(linieBD["idElectronic"].ToString());
            Nume_produs = linieBD["nume_produs"].ToString();
            Firma = linieBD["firma"].ToString();
            Model = linieBD["model"].ToString();
            Specificatii = linieBD["specificatii"].ToString();
            Culoare = linieBD["culoare"].ToString();
            Pret = Convert.ToDecimal(linieBD["pret"].ToString());
            Nr_Produse = Convert.ToInt32(linieBD["nr_produse"].ToString());
            Total = Convert.ToDecimal(linieBD["total"].ToString());
            Modalitate_plata = linieBD["modalitate_plata"].ToString();
        }
    }
}
