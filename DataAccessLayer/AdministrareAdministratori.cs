using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareAdministratori : IStocareAdministratori
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddAdministrator(Administrator a)
        {
            throw new System.NotImplementedException();
        }

        public List<Administrator> GetAdministratori()
        {
            var result = new List<Administrator>();
            var dsAdministratori = SqlDBHelper.ExecuteDataSet("select * from Administratori_PCG", CommandType.Text);

            foreach (DataRow linieDB in dsAdministratori.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Administrator(linieDB));
            }
            return result;
        }

        public Administrator GetAdministratori(string numeutilizator)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateAdministrator(Administrator a)
        {
            throw new System.NotImplementedException();
        }
    }
}
