using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareElectronice : IStocareElectronice
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Electronic> GetElectronice()
        {
            var result = new List<Electronic>();
            var dsElectronice = SqlDBHelper.ExecuteDataSet("select * from Electronice_PCG", CommandType.Text);

            foreach (DataRow linieDB in dsElectronice.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Electronic(linieDB));
            }
            return result;
        }

        public Electronic GetElectronic(int idelectronic)
        {
            Electronic result = null;
            var dsElectronice = SqlDBHelper.ExecuteDataSet("select * from Electronice_PCG where IdElectronic = :IdElectronic", CommandType.Text,
                new OracleParameter(":IdElectronic", OracleDbType.Int32, idelectronic, ParameterDirection.Input));

            if (dsElectronice.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsElectronice.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Electronic(linieDB);
            }
            return result;
        }

        public bool AddElectronic(Electronic electronic)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO Electronice_PCG VALUES ( :IdElectronic, :Nume_produs, :Firma, :Model, :Specificatii, :Culoare, :Nr_Produse, :Pret )", CommandType.Text,
                new OracleParameter(":IdElectronic", OracleDbType.Int32, electronic.IdElectronic, ParameterDirection.Input),
                new OracleParameter(":Nume_produs", OracleDbType.NVarchar2, electronic.Nume_produs, ParameterDirection.Input),
                new OracleParameter(":Firma", OracleDbType.NVarchar2, electronic.Firma, ParameterDirection.Input),
                new OracleParameter(":Model", OracleDbType.NVarchar2, electronic.Model, ParameterDirection.Input),
                new OracleParameter(":Specificatii", OracleDbType.NVarchar2, electronic.Specificatii, ParameterDirection.Input),
                new OracleParameter(":Culoare", OracleDbType.NVarchar2, electronic.Culoare, ParameterDirection.Input),
                new OracleParameter(":Nr_Produse", OracleDbType.Int32, electronic.Nr_Produse, ParameterDirection.Input),
                new OracleParameter(":Pret", OracleDbType.Int32, electronic.Pret, ParameterDirection.Input)
           );
        }

        public bool UpdateElectronic(Electronic electronic)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Electronice_PCG set IdElectronic = :IdElectronic, Nume_produs = :Nume_produs, Firma = :Firma, Model = :Model, Specificatii = :Specificatii, Culoare = :Culoare, Nr_Produse = :Nr_Produse, Pret =:Pret  where IdElectronic = :IdElectronic", CommandType.Text,
                new OracleParameter(":IdElectronic", OracleDbType.Int32, electronic.IdElectronic, ParameterDirection.Input),
                new OracleParameter(":Nume_produs", OracleDbType.NVarchar2, electronic.Nume_produs, ParameterDirection.Input),
                new OracleParameter(":Firma", OracleDbType.NVarchar2, electronic.Firma, ParameterDirection.Input),
                new OracleParameter(":Model", OracleDbType.NVarchar2, electronic.Model, ParameterDirection.Input),
                new OracleParameter(":Specificatii", OracleDbType.NVarchar2, electronic.Specificatii, ParameterDirection.Input),
                new OracleParameter(":Culoare", OracleDbType.NVarchar2, electronic.Culoare, ParameterDirection.Input),
                new OracleParameter(":Nr_Produse", OracleDbType.Int32, electronic.Nr_Produse, ParameterDirection.Input),
                new OracleParameter(":Pret", OracleDbType.Int32, electronic.Pret, ParameterDirection.Input)
           );
        }
        public bool DeleteElectronic(Electronic electronic)
        {
            return SqlDBHelper.ExecuteNonQuery("DELETE FROM Electronice_PCG WHERE IdElectronic = :IdElectronic", CommandType.Text,
                new OracleParameter(":IdElectronic", OracleDbType.Int32, electronic.IdElectronic, ParameterDirection.Input));
        }
        public bool UpdateElectronicLaCumparare(Electronic electronic)
        {
            return SqlDBHelper.ExecuteNonQuery("UPDATE Electronice_PCG set Nr_Produse=:Nr_Produse WHERE IdElectronic=:IdElectronic",
                CommandType.Text,
                new OracleParameter(":Nr_Produse", OracleDbType.Int32, electronic.Nr_Produse, ParameterDirection.Input),
                new OracleParameter(":Idelectronic", OracleDbType.Int32, electronic.IdElectronic, ParameterDirection.Input)
                );
        }
    }
}
