using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDRental
{
    class Utility
    {
        public static void fillComboBox(ComboBox cmbBox, DataSet ds, int padding) {

            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {
                    cmbBox.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(padding, '0') + " - " + ds.Tables[0].Rows[i][1]);
                }
                return;
            }
            return;
        }

        public static Boolean checkIfDataSetEmpty(DataSet ds) {
            //if has 1 records return false
            //if has 0 records return true
            return !(ds.Tables[0].Rows.Count > 0);
        }

        public static OracleConnection GetConnection() {
            OracleConnection connection = new OracleConnection(DBConnect.oradb);
            connection.Open();
            return connection;
        }

        public static DataSet getDataSet(String sqlQuery) {

            OracleConnection connection = GetConnection();
            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            connection.Close();

            return dataSet;
        }
    }
}
