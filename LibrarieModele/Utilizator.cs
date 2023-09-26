using System;
using System.Data;

namespace LibrarieModele
{
    public class Utilizator
    {
        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string NumeUtilizator { get; set; }
        public string Parola { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public Utilizator()
        { }

        public Utilizator(string nume, string prenume, string numeUtilizator, string parola, string email, string telefon)
        {
            Nume = nume;
            Prenume = prenume;
            NumeUtilizator = numeUtilizator;
            Parola = parola;
            Email = email;
            Telefon = telefon;
        }

        public Utilizator(DataRow linieDB)
        {
            Nume = linieDB["nume"].ToString();
            Prenume = linieDB["prenume"].ToString();
            NumeUtilizator = linieDB["numeUtilizator"].ToString();
            Parola = linieDB["parola"].ToString();
            Email = linieDB["email"].ToString();
            Telefon =linieDB["telefon"].ToString();
        }
    }
}
