using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    class Genre
    {
        private String GenreName;
        private int GenreID;

        public void setGenreName(String genreName) { this.GenreName = genreName; }
        public void setGenreID(int genreID) { this.GenreID = genreID; }
        public String getGenreName() {  return this.GenreName; }
        public int getGenreID() {  return this.GenreID; }

        public Genre() {
            setGenreID(0);
            setGenreName("");
        }
        public Genre(int gerneID, String genreName) { 
            setGenreID(gerneID);
            setGenreName(genreName);
        }

        public static DataSet getGenres()
        {
            String sqlQuery = "SELECT * FROM Genres ORDER BY genreID";
            DataSet dataSet = Utility.getDataSet(sqlQuery);

            return dataSet;
        }
        public void getGenreByID()
        {

            String sqlQuery = "SELECT * FROM GenreS WHERE genreID = " + this.GenreID;
            DataSet dataSet = Utility.getDataSet(sqlQuery);

            setGenreName(Convert.ToString(dataSet.Tables[0].Rows[0][1]));
        }

    }
}
