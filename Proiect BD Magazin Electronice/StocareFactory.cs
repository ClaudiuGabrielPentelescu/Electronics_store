using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.Configuration;
using LibrarieModele;

namespace Proiect_BD_Magazin_Electronice
{
    /// <summary>
    /// Factory Design Pattern
    /// </summary>
    public class StocareFactory
    {
        public IStocareFactory GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":
                        if (tipEntitate == typeof(Administrator))
                        {
                            return new AdministrareAdministratori();
                        }
                        if (tipEntitate == typeof(Utilizator))
                        {
                            return new AdministrareUtilizatori();
                        }
                        if (tipEntitate == typeof(Electronic))
                        {
                            return new AdministrareElectronice();
                        }
                        if (tipEntitate == typeof(Cos))
                        {
                            return new AdministrareCosuri();
                        }
                        break;

                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
