using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareCumparaturi : IStocareFactory
    {
        List<Cumparatura> GetCumparaturi();
        Cumparatura GetCumparatura(int idelectronic);
        bool AddCumparatura(Cumparatura c);

        bool UpdateCumparatura(Cumparatura c);
    }
}