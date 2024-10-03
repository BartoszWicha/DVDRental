using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DVDRental
{
    class Category
    {
        private String CatCode;
        private String Description;
        private decimal Rate;

        public Category()
        {
            this.CatCode = "";
            this.Description = "";
            this.Rate = 0;
        }
        public Category(string catCode, string description, decimal rate)
        {
            this.CatCode = catCode;
            this.Description = description;
            this.Rate = rate;
        }

        public String getCatCode() { return this.CatCode; }
        public String getDescription() { return this.Description; }
        public decimal getRate() { return this.Rate; }

        public void setCatCode(String catCode){this.CatCode = catCode; }
        public void setDescription(String description){this.Description = description; }
        public void setRate(Decimal rate) {this.Rate = rate;}

        public void createCategory() {
            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "INSERT INTO Categories Values ('" +
                this.CatCode + "','" +
                this.Description + "'," +
                this.Rate + ")";
            
            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public void modifyCategory()
        {
            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "UPDATE Categories SET " +
                "description = '" + this.Description + "' ," +
                "rates = " + this.Rate +
                "WHERE catCode = '" + this.CatCode + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public static DataSet getCategories()
        {
            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "SELECT * FROM Categories";
            DataSet dataSet = Utility.getDataSet(sqlQuery);

            return dataSet;
        }
        public void getCategory() {
            String sqlQuery = "SELECT * FROM Categories " +
                            "WHERE catCode LIKE '" + this.CatCode + "'";
            DataSet dataSet = Utility.getDataSet(sqlQuery);

            setDescription(Convert.ToString(dataSet.Tables[0].Rows[0][1]));
            setRate(Convert.ToDecimal(dataSet.Tables[0].Rows[0][2]));
        }
        public static Boolean catCodeIsUnique(String catCode) {

            String sqlQuery = "SELECT * FROM Categories" +
                             " WHERE catCode = '" + catCode + "'";
            DataSet dataSet = Utility.getDataSet(sqlQuery);

            Boolean exists = !Utility.checkIfDataSetEmpty(dataSet);

            return exists;

        }
    }
}
