using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareCumparaturi : IStocareCumparaturi
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Cumparatura> GetCumparaturi()
        {
            var result = new List<Cumparatura>();
            var dsCumparaturi = SqlDBHelper.ExecuteDataSet("select * from Cumparaturi_PCG", CommandType.Text);

            foreach (DataRow linieDB in dsCumparaturi.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Cumparatura(linieDB));
            }
            return result;
        }

        public Cumparatura GetCumparatura(int idelectronic)
        {
            Cumparatura result = null;
            var dsCumparaturi = SqlDBHelper.ExecuteDataSet("select * from Cumparaturi_PCG where IdElectronic = :IdElectronic", CommandType.Text,
                new OracleParameter(":IdElectronic", OracleDbType.Int32, idelectronic, ParameterDirection.Input));

            if (dsCumparaturi.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsCumparaturi.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Cumparatura(linieDB);
            }
            return result;
        }

        public bool AddCumparatura(Cumparatura cumparatura)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO Cumparaturi_PCG VALUES ( :Nume_Utilizator, :IdElectronic, :Nume_produs, :Firma, :Model, :Specificatii, :Culoare, :Pret, :Nr_Produse, :Total, :Modalitate_plata  )", CommandType.Text,
                new OracleParameter(":Nume_Utilizator", OracleDbType.NVarchar2, cumparatura.Nume_Utilizator, ParameterDirection.Input),
                new OracleParameter(":IdElectronic", OracleDbType.Int32, cumparatura.IdElectronic, ParameterDirection.Input),
                new OracleParameter(":Nume_produs", OracleDbType.NVarchar2, cumparatura.Nume_produs, ParameterDirection.Input),
                new OracleParameter(":Firma", OracleDbType.NVarchar2, cumparatura.Firma, ParameterDirection.Input),
                new OracleParameter(":Model", OracleDbType.NVarchar2, cumparatura.Model, ParameterDirection.Input),
                new OracleParameter(":Specificatii", OracleDbType.NVarchar2, cumparatura.Specificatii, ParameterDirection.Input),
                new OracleParameter(":Culoare", OracleDbType.NVarchar2, cumparatura.Culoare, ParameterDirection.Input),
                new OracleParameter(":Pret", OracleDbType.Int32, cumparatura.Pret, ParameterDirection.Input),
                new OracleParameter(":Nr_Produse", OracleDbType.Int32, cumparatura.Nr_Produse, ParameterDirection.Input),
                new OracleParameter(":Total", OracleDbType.Int32, cumparatura.Total, ParameterDirection.Input),
                new OracleParameter(":Modalitate_plata", OracleDbType.NVarchar2, cumparatura.Modalitate_plata, ParameterDirection.Input)
           );
        }

        public bool UpdateCumparatura(Cumparatura cumparatura)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Cos_PCG set Nume_Utilizator = :Nume_Utilizator, IdElectronic = :IdElectronic, Nume_produs = :Nume_produs, Firma = :Firma, Model = :Model, Specificatii = :Specificatii, Culoare = :Culoare,Pret =:Pret, Nr_Produse = :Nr_Produse, Total=:Total,Modalitate_plata=:Modalitate_plata  where IdElectronic = :IdElectronic", CommandType.Text,
                new OracleParameter(":Nume_Utilizator", OracleDbType.NVarchar2, cumparatura.Nume_Utilizator, ParameterDirection.Input),
                new OracleParameter(":IdElectronic", OracleDbType.Int32, cumparatura.IdElectronic, ParameterDirection.Input),
                new OracleParameter(":Nume_produs", OracleDbType.NVarchar2, cumparatura.Nume_produs, ParameterDirection.Input),
                new OracleParameter(":Firma", OracleDbType.NVarchar2, cumparatura.Firma, ParameterDirection.Input),
                new OracleParameter(":Model", OracleDbType.NVarchar2, cumparatura.Model, ParameterDirection.Input),
                new OracleParameter(":Specificatii", OracleDbType.NVarchar2, cumparatura.Specificatii, ParameterDirection.Input),
                new OracleParameter(":Culoare", OracleDbType.NVarchar2, cumparatura.Culoare, ParameterDirection.Input),
                new OracleParameter(":Pret", OracleDbType.Int32, cumparatura.Pret, ParameterDirection.Input),
                new OracleParameter(":Nr_Produse", OracleDbType.Int32, cumparatura.Nr_Produse, ParameterDirection.Input),
                new OracleParameter(":Total", OracleDbType.Int32, cumparatura.Total, ParameterDirection.Input),
                new OracleParameter(":Modalitate_plata", OracleDbType.NVarchar2, cumparatura.Modalitate_plata, ParameterDirection.Input)
           );
        }
        public bool DeleteCumparatura(Cumparatura cumparatura)
        {
            return SqlDBHelper.ExecuteNonQuery("DELETE FROM Cumparaturi_PCG WHERE IdElectronic = :IdElectronic", CommandType.Text,
                new OracleParameter(":IdElectronic", OracleDbType.Int32, cumparatura.IdElectronic, ParameterDirection.Input));
        }

    }
}
