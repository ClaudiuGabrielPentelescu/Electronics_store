using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareUtilizatori : IStocareUtilizatori
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Utilizator> GetUtilizatori()
        {
            var result = new List<Utilizator>();
            var dsUtilizatori = SqlDBHelper.ExecuteDataSet("select * from Utilizatori_PCG", CommandType.Text);

            foreach (DataRow linieDB in dsUtilizatori.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Utilizator(linieDB));
            }
            return result;
        }

        public Utilizator GetUtilizator(string numeutilizator)
        {
            Utilizator result = null;
            var dsUtilizatori = SqlDBHelper.ExecuteDataSet("select * from Utilizatori_PCG where NumeUtilizator = :NumeUtilizator", CommandType.Text,
                new OracleParameter(":NumeUtilizator", OracleDbType.NVarchar2, numeutilizator, ParameterDirection.Input));

            if (dsUtilizatori.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsUtilizatori.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Utilizator(linieDB);
            }
            return result;
        }

        public bool AddUtilizator(Utilizator utilizator)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO Utilizatori_PCG VALUES ( :Nume, :Prenume, :NumeUtilizator, :Parola, :Email, :Telefon)", CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.NVarchar2, utilizator.Nume, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.NVarchar2, utilizator.Prenume, ParameterDirection.Input),
                new OracleParameter(":NumeUtilizator", OracleDbType.NVarchar2, utilizator.NumeUtilizator, ParameterDirection.Input),
                new OracleParameter(":Parola", OracleDbType.NVarchar2, utilizator.Parola, ParameterDirection.Input),
                new OracleParameter(":Email", OracleDbType.NVarchar2, utilizator.Email, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.NVarchar2, utilizator.Telefon, ParameterDirection.Input)
           );
        }

        public bool UpdateUtilizator(Utilizator utilizator)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Electronice_PCG set Nume = :Nume, Prenume = :Prenume, NumeUtilizator = :NumeUtilizator, Parola = :Parola, Email = :Email, Telefon = :Telefon  where NumeUtilizator = :NumeUtilizator", CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.Varchar2, utilizator.Nume, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.NVarchar2, utilizator.Prenume, ParameterDirection.Input),
                new OracleParameter(":NumeUtilizator", OracleDbType.NVarchar2, utilizator.NumeUtilizator, ParameterDirection.Input),
                new OracleParameter(":Parola", OracleDbType.NVarchar2, utilizator.Parola, ParameterDirection.Input),
                new OracleParameter(":Email", OracleDbType.NVarchar2, utilizator.Email, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.NVarchar2, utilizator.Telefon, ParameterDirection.Input)
           );
        }
    }
}
