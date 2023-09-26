using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareUtilizatori : IStocareFactory
    {
        List<Utilizator> GetUtilizatori();
        Utilizator GetUtilizator(string numeutilizator);
        bool AddUtilizator(Utilizator u);

        bool UpdateUtilizator(Utilizator u);
    }
}
