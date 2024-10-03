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
        private String genreName;
        private int genreID;

        private void setGenreName(String GenreName) { genreName = GenreName; }
        private void setGenreID(int GenreID) { genreID = GenreID; }
        public String getGenreName() {  return genreName; }
        public int getGenreID() {  return genreID; }

        public static DataSet getGenres()
        {
            //connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String sqlQuery = "SELECT * FROM Genres ORDER BY genreID";

            //run statement
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            //close conneciton
            conn.Close();

            return ds;
        }

        public void getSelectedGenre(String GenreID)
        {

            //connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String sqlQuery = "SELECT * FROM GenreS WHERE genreID = " + GenreID;

            //run statement
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();

            setGenreID(reader.GetInt32(0));
            setGenreName(reader.GetString(1));

            //close connection
            conn.Close();
        }

    }
}
