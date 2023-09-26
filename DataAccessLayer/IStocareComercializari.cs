using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareComercializari : IStocareFactory
    {
        List<Comercializare> GetComercializari();
        Comercializare GetComercializare(int idelectronic);
        bool AddComercializari(Comercializare c);

        bool UpdateComercializare(Comercializare c);
    }
}