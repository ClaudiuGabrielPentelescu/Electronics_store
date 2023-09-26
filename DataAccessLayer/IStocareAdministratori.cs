using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareAdministratori : IStocareFactory
    {
        List<Administrator> GetAdministratori();
        Administrator GetAdministratori(string numeutilizator);
        bool AddAdministrator(Administrator a);

        bool UpdateAdministrator(Administrator a);
    }
}