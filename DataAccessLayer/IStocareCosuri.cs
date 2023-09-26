using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareCosuri : IStocareFactory
    {
        List<Cos> GetCosuri();
        Cos GetCos(int idelectronic);
        bool AddCos(Cos c);

        bool UpdateCos(Cos c);
        bool DeleteCos(Cos c);

        bool DeleteAllCos(Cos c);
    }
}