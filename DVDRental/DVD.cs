using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DVDRental
{
    class DVD
    {
        private int dvdID;
        private String title;
        private char status;
        private String catCode;
        private int genreID;

        public DVD()
        {
            this.dvdID = 0;
            this.title = "";
            this.status = Convert.ToChar("A");
            this.genreID = 0;
            this.catCode = "";
        }

        public DVD(int dvdID, string dvdTitle, char status, string catCode, int genreID)
        {
            this.dvdID = dvdID;
            this.title = dvdTitle;
            this.status = status;
            this.catCode = catCode;
            this.genreID = genreID;
        }

        private void setDVDID(int DVDID) { dvdID = DVDID; }
        public void setDVDTitle(String Title) { title = Title; }
        public void setStatus(char Status) { status = Status; }
        public void setcatCode(String CatCode) { catCode = CatCode; }
        public void setGenreID(int GenreID) { genreID = GenreID; }

        public String getTitle() { return this.title; }
        public int getGenreID() { return this.genreID; }
        public String getCatCode() { return this.catCode; }
        public char getStatus() { return this.status; }
        public int getDVDID() { return this.dvdID; }

        public static int generateNextDVDID()
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT MAX(dvdID) FROM DVDs";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();

            int id;

            if (reader.IsDBNull(0))
            {
                id =  1;
            }

            else
            {
                id = reader.GetInt32(0) + 1;
            }

            conn.Close();
            return id;

        }

        public void addDVD()
        {
            //connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String sqlQuery = "INSERT INTO DVDs Values ('" +
                this.dvdID + "','" +
                this.title + "','" +
                this.status + "','" +
                this.catCode + "'," +
                this.genreID + ")";

            //run statement
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            //close connection to db
            conn.Close();

        }

        public static DataSet getMatchingDVDs(String DVDTitle) {

            //connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String sqlQuery = "SELECT DVDs.DVDID, DVDs.Title, DVDs.Status, Categories.description, Genres.GenreName " +
                                "FROM DVDs " +
                                "JOIN Categories ON DVDs.catCode = Categories.catCode " +
                                "JOIN Genres ON DVDs.genreID = Genres.genreID " +
                                "WHERE LOWER(DVDs.Title) LIKE '%" + DVDTitle.ToString().ToLower() + "%' AND status = 'A'" + 
                                "ORDER BY title DESC";

            //run statement
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            //close conneciton
            conn.Close();

            return ds;
        }

        public void getDVDByID(int dvdID) {

            //connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String sqlQuery = "SELECT * FROM DVDs WHERE DVDID = " + dvdID;

            //run statement
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            setDVDID(Convert.ToInt32(ds.Tables[0].Rows[0][0]));
            setDVDTitle(ds.Tables[0].Rows[0][1].ToString());
            setStatus(Convert.ToChar(ds.Tables[0].Rows[0][2].ToString()));
            setGenreID(Convert.ToInt32(ds.Tables[0].Rows[0][4]));
            setcatCode(ds.Tables[0].Rows[0][3].ToString());

            //close connection
            conn.Close();
        }

        public void updateDVD()
        {

            //connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String sqlQuery = "UPDATE DVDs SET " +
                "title = '" + this.title + "' ," +
                "catCode = '" + this.catCode + "' ," +
                "genreID = " + this.genreID +
                "WHERE dvdID = " + this.dvdID;

            //run statement
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            //close conneciton
            conn.Close();
        }

        public static void removeDVD(int dvdID) { 
        
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "UPDATE DVDs SET " + 
                "status = 'U'" +
                "WHERE dvdID = " + dvdID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }
}
