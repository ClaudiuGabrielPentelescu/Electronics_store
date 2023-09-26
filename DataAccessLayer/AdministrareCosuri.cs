using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareCosuri : IStocareCosuri
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Cos> GetCosuri()
        {
            var result = new List<Cos>();
            var dsCosuri = SqlDBHelper.ExecuteDataSet("select * from Cos_PCG", CommandType.Text);

            foreach (DataRow linieDB in dsCosuri.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Cos(linieDB));
            }
            return result;
        }

        public Cos GetCos(int idelectronic)
        {
            Cos result = null;
            var dsCosuri = SqlDBHelper.ExecuteDataSet("select * from Cos_PCG where IdElectronic = :IdElectronic", CommandType.Text,
                new OracleParameter(":IdElectronic", OracleDbType.Int32, idelectronic, ParameterDirection.Input));

            if (dsCosuri.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsCosuri.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Cos(linieDB);
            }
            return result;
        }

        public bool AddCos(Cos cos)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO Cos_PCG VALUES ( :Nume_Utilizator, :IdElectronic, :Nume_produs, :Firma, :Model, :Specificatii, :Culoare, :Pret, :Nr_Produse, :Total, :Modalitate_plata  )", CommandType.Text,
                new OracleParameter(":Nume_Utilizator", OracleDbType.NVarchar2, cos.Nume_Utilizator, ParameterDirection.Input),
                new OracleParameter(":IdElectronic", OracleDbType.Int32, cos.IdElectronic, ParameterDirection.Input),
                new OracleParameter(":Nume_produs", OracleDbType.NVarchar2, cos.Nume_produs, ParameterDirection.Input),
                new OracleParameter(":Firma", OracleDbType.NVarchar2, cos.Firma, ParameterDirection.Input),
                new OracleParameter(":Model", OracleDbType.NVarchar2, cos.Model, ParameterDirection.Input),
                new OracleParameter(":Specificatii", OracleDbType.NVarchar2, cos.Specificatii, ParameterDirection.Input),
                new OracleParameter(":Culoare", OracleDbType.NVarchar2, cos.Culoare, ParameterDirection.Input),
                new OracleParameter(":Pret", OracleDbType.Int32, cos.Pret, ParameterDirection.Input),
                new OracleParameter(":Nr_Produse", OracleDbType.Int32, cos.Nr_Produse, ParameterDirection.Input),
                new OracleParameter(":Total", OracleDbType.Int32, cos.Total, ParameterDirection.Input),
                new OracleParameter(":Modalitate_plata", OracleDbType.NVarchar2, cos.Modalitate_plata, ParameterDirection.Input)
           );
        }

        public bool UpdateCos(Cos cos)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Cos_PCG set Nume_Utilizator = :Nume_Utilizator, IdElectronic = :IdElectronic, Nume_produs = :Nume_produs, Firma = :Firma, Model = :Model, Specificatii = :Specificatii, Culoare = :Culoare,Pret =:Pret, Nr_Produse = :Nr_Produse, Total=:Total,Modalitate_plata=:Modalitate_plata  where IdElectronic = :IdElectronic", CommandType.Text,
                new OracleParameter(":Nume_Utilizator", OracleDbType.NVarchar2, cos.Nume_Utilizator, ParameterDirection.Input),
                new OracleParameter(":IdElectronic", OracleDbType.Int32, cos.IdElectronic, ParameterDirection.Input),
                new OracleParameter(":Nume_produs", OracleDbType.NVarchar2, cos.Nume_produs, ParameterDirection.Input),
                new OracleParameter(":Firma", OracleDbType.NVarchar2, cos.Firma, ParameterDirection.Input),
                new OracleParameter(":Model", OracleDbType.NVarchar2, cos.Model, ParameterDirection.Input),
                new OracleParameter(":Specificatii", OracleDbType.NVarchar2, cos.Specificatii, ParameterDirection.Input),
                new OracleParameter(":Culoare", OracleDbType.NVarchar2, cos.Culoare, ParameterDirection.Input),
                new OracleParameter(":Pret", OracleDbType.Int32, cos.Pret, ParameterDirection.Input),
                new OracleParameter(":Nr_Produse", OracleDbType.Int32, cos.Nr_Produse, ParameterDirection.Input),
                new OracleParameter(":Total", OracleDbType.Int32, cos.Total, ParameterDirection.Input),
                new OracleParameter(":Modalitate_plata", OracleDbType.NVarchar2, cos.Modalitate_plata, ParameterDirection.Input)
           );
        }
        public bool DeleteCos(Cos cos)
        {
            return SqlDBHelper.ExecuteNonQuery("DELETE FROM Cos_PCG WHERE IdElectronic = :IdElectronic", CommandType.Text,
                new OracleParameter(":IdElectronic", OracleDbType.Int32, cos.IdElectronic, ParameterDirection.Input));
        }
        public bool DeleteAllCos(Cos cos)
        {
            return SqlDBHelper.ExecuteNonQuery("TRUNCATE TABLE Cos_PCG", CommandType.Text);
        }
    }
}
