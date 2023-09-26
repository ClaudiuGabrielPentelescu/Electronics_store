using System;
using System.Data;

namespace LibrarieModele
{
    public class Administrator
    {
        public string NumeUtilizator { get; set; }
        public string Parola { get; set; }

        public Administrator()
        { }

        public Administrator (string numeUtilizator, string parola)
        {
            NumeUtilizator = numeUtilizator;
            Parola = parola;
        }

        public Administrator (DataRow linieDB)
        {
            NumeUtilizator = linieDB["numeUtilizator"].ToString();
            Parola = linieDB["parola"].ToString();
        }
    }
}
