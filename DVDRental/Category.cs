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
        private String catCode;
        private String description;
        private decimal rate;

        public Category()
        {
            this.catCode = "";
            this.description = "";
            this.rate = 0;
        }

        public Category(string catCode, string description, decimal rate)
        {
            this.catCode = catCode;
            this.description = description;
            this.rate = rate;
        }

        public String getCatCode() { return this.catCode; }
        public String getDescription() { return this.description; }
        public decimal getRate() { return this.rate; }

        public void setCatCode(String CatCode){catCode = CatCode; }
        public void setDescription(String Description){ description = Description; }
        public void setRate(Decimal Rate) { rate = Rate;}

        public void createCategory() {
            //connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String sqlQuery = "INSERT INTO Categories Values ('" +
                this.catCode + "','" +
                this.description + "'," +
                this.rate + ")";
            
            //run statement
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            //close connection to db
            conn.Close();
        }

        public void getSelectedCategory(String catCode) {

            //connect to db
            OracleConnection conn = new OracleConnection (DBConnect.oradb);
            conn.Open();

            //define sql query
            String sqlQuery = "SELECT * FROM Categories WHERE catCode LIKE '" + catCode + "'";

            //run statement
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();

            setCatCode(reader.GetString(0));
            setDescription(reader.GetString(1));
            setRate(reader.GetDecimal(2));

            //close connection
            conn.Close();
        }

        public void modifyCategory() {

            //connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            
            //define sql query
            String sqlQuery = "UPDATE Categories SET " + 
                "catCode = '" + this.catCode + "' ," +
                "description = '" + this.description + "' ," +
                "rates = " + this.rate + 
                "WHERE catCode = '" + this.catCode + "'";

            //run statement
            OracleCommand cmd = new OracleCommand (sqlQuery, conn);
            cmd.ExecuteNonQuery();

            //close conneciton
            conn.Close();
        }

    }
}
