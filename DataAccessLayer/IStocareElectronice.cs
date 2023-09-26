using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareElectronice : IStocareFactory
    {
        List<Electronic> GetElectronice();
        Electronic GetElectronic(int idelectronic);
        bool AddElectronic(Electronic e);
        bool UpdateElectronic(Electronic e);
        bool DeleteElectronic(Electronic e);
        bool UpdateElectronicLaCumparare(Electronic e);
    }
}