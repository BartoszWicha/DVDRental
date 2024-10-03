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
        private int DvdID;
        private String Title;
        private char Status;
        private String CatCode;
        private int GenreID;

        public DVD()
        {
            this.DvdID = 0;
            this.Title = "";
            this.Status = Convert.ToChar("A");
            this.GenreID = 0;
            this.CatCode = "";
        }
        public DVD(int dvdID, string dvdTitle, char status, string catCode, int genreID)
        {
            this.DvdID = dvdID;
            this.Title = dvdTitle;
            this.Status = status;
            this.CatCode = catCode;
            this.GenreID = genreID;
        }

        public void setDVDID(int dvdID) { this.DvdID = dvdID; }
        public void setDVDTitle(String title) { this.Title = title; }
        public void setStatus(char status) { this.Status = status; }
        public void setcatCode(String catCode) { this.CatCode = catCode; }
        public void setGenreID(int genreID) { this.GenreID = genreID; }

        public String getTitle() { return this.Title; }
        public int getGenreID() { return this.GenreID; }
        public String getCatCode() { return this.CatCode; }
        public char getStatus() { return this.Status; }
        public int getDVDID() { return this.DvdID; }

        public static int generateNextDVDID()
        {
            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "SELECT MAX(dvdID) FROM DVDs";

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);

            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();

            int id;

            if (reader.IsDBNull(0))
            {
                id = 1;
            }

            else
            {
                id = reader.GetInt32(0) + 1;
            }

            connection.Close();

            return id;
        }
        public void addDVD()
        {
            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "INSERT INTO DVDs Values ('" +
                this.DvdID + "','" +
                this.Title + "','" +
                this.Status + "','" +
                this.CatCode + "'," +
                this.GenreID + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public void modifyDVD()
        {
            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "UPDATE DVDs SET " +
                "title = '" + this.Title + "' ," +
                "Status = '" + this.Status + "' ," +
                "catCode = '" + this.CatCode + "' ," +
                "genreID = " + this.GenreID +
                "WHERE dvdID = " + this.DvdID;

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public void removeDVD()
        {
            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "UPDATE DVDs SET " +
                "status = 'U'" +
                "WHERE dvdID = " + this.DvdID;

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public static DataSet getMatchingDVDs(String DVDTitle) {

            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "SELECT DVDs.DVDID, DVDs.Title, DVDs.Status, Categories.description, Genres.GenreName " +
                                "FROM DVDs " +
                                "JOIN Categories ON DVDs.catCode = Categories.catCode " +
                                "JOIN Genres ON DVDs.genreID = Genres.genreID " +
                                "WHERE LOWER(DVDs.Title) LIKE '%" + DVDTitle.ToString().ToLower() + "%' AND status = 'A'" + 
                                "ORDER BY title DESC";
            DataSet dataSet = Utility.getDataSet(sqlQuery);

            connection.Close();

            return dataSet;
        }
        public void getDVDByID() 
        {
            String sqlQuery = "SELECT * FROM DVDs WHERE DVDID = " + this.DvdID;
            DataSet dataSet = Utility.getDataSet(sqlQuery);

            setDVDTitle(dataSet.Tables[0].Rows[0][1].ToString());
            setStatus(Convert.ToChar(dataSet.Tables[0].Rows[0][2].ToString()));
            setGenreID(Convert.ToInt32(dataSet.Tables[0].Rows[0][4]));
            setcatCode(dataSet.Tables[0].Rows[0][3].ToString());
        }
    }
}
