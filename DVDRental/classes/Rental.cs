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
    class Rental
    {

        private int RentID;
        private String DueDate;
        private char Status;
        private int MemberID;
        private List<int> DVDIDs;
        private String DateReturned;
        private List<decimal> Cost;
        private String DateRented;

        public Rental() { 
            this.RentID = 0;
            this.DateReturned = "Null";
            this.DueDate = "Null";
            this.Status = 'U';
            this.MemberID = 0;
            this.Cost = new List<decimal>();
            this.DVDIDs = new List<int>();
            this.DateRented = "Null";
        }
        public Rental(int rentID, String dateRented, String dueDate, char status, int memberID, List<int> dvds, List<decimal> cost)
        {
            this.RentID = rentID;
            this.DateRented = dateRented;
            this.DueDate = dueDate;
            this.Status = status;
            this.MemberID = memberID;
            this.DVDIDs = dvds;
            this.Cost = cost;
            this.DateReturned = DateTime.Today.ToString("dd-MMM-yy");
        }

        public void setRentID(int rentID) {
            this.RentID = rentID;
        }
        public void setDueDate(String dueDate) {  
            this.DueDate = dueDate; 
        }
        public void setStatus(char status) { 
            this.Status = status;
        }
        public void setDateRented(String dateRented) { 
            this.DateRented = dateRented;
        }
        public void setMemberID(int memberID) { 
            this.MemberID = memberID;
        }
        public void setDVDIDs(int[] dvdIDs) {
            for (int i = 0; i < dvdIDs.Length; i++) {
                this.DVDIDs.Add(dvdIDs[i]);
            }
        }
        public void setCost(decimal[] cost) {
            for (int i = 0; i < cost.Length; i++)
            {
                this.Cost.Add(cost[i]);
            } 
        }

        public int getRentID()
        {
            return this.RentID;
        }
        public String getDueDate() { 
            return this.DueDate;
        }
        public char getStatus() { 
            return (char) this.Status;
        }
        public int getMemberID()
        {
            return this.MemberID;
        }
        public String getDateRented()
        {
            return this.DateRented;
        }
        public List<int> getDVDIDs() {
            return this.DVDIDs;
        }
        public List<decimal> getCost() { 
            return this.Cost;
        }

        public static int generateNextRentID() 
        {
            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "SELECT MAX(RentID) FROM Rentals";

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
        public void saveRental() 
        {
            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "INSERT INTO Rentals Values (" +
                this.RentID + "," +
                "SYSDate ," +
                "SYSDate + 7 ,'" +
                this.Status + "'," +
                this.MemberID + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            connection.Close();

            saveRentalItems();
        }
        public void saveRentalItems()
        {
            OracleConnection connection = Utility.GetConnection();

            for (int i = 0; i < this.DVDIDs.Count; i++)
            {
                String sqlQuery = "INSERT INTO RentedItems Values (" +
                this.RentID + "," +
                this.DVDIDs[i] + ", " +
                "NULL ," +
                "NULL)";

                OracleCommand cmd = new OracleCommand(sqlQuery, connection);
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
        public void getMembersRental(int memberID) 
        {
            String sqlQuery = "SELECT * FROM Rentals WHERE memberID = " + memberID + " AND Status = 'U'";
            DataSet dataSet = Utility.getDataSet(sqlQuery);

            if (!Utility.checkIfDataSetEmpty(dataSet))
            {
                setMemberID(memberID);
                setDateRented(Convert.ToString(dataSet.Tables[0].Rows[0][1]));
                setDueDate(Convert.ToString(dataSet.Tables[0].Rows[0][2]));
                setRentID(Convert.ToInt32(dataSet.Tables[0].Rows[0][0]));
                setStatus(Convert.ToChar(dataSet.Tables[0].Rows[0][3]));
            }
            else {
                MessageBox.Show("Member has no pending rentals", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //select * from renteditems where rentid = this.rentid
            //for every row in dataset add dvdid to this.dvdids

            sqlQuery = "SELECT * FROM RentedItems WHERE rentID = " + this.RentID + " AND dateReturned IS NULL";
            dataSet = Utility.getDataSet(sqlQuery);

            this.DVDIDs.Clear();

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++) {
                this.DVDIDs.Add(Convert.ToInt32(dataSet.Tables[0].Rows[i][1]));
            }

            calculateCost();
        }
        private void calculateCost() 
        {
            decimal[] costOfDVDs = new decimal[this.DVDIDs.Count];

            for (int i = 0; i < costOfDVDs.Length; i++)
            {
                String sqlQuery = "SELECT C.Rates FROM DVDs D JOIN Categories C ON D.catcode = C.catcode WHERE DVDID = " + this.DVDIDs[i];
                DataSet ds = Utility.getDataSet(sqlQuery);

                int diffOfDays = (int)(DateTime.Today.Date - Convert.ToDateTime(this.DateRented).Date).Days; 

                costOfDVDs[i] = Convert.ToDecimal(ds.Tables[0].Rows[0][0]) * diffOfDays;

                MessageBox.Show(costOfDVDs[i].ToString() + " ");

                if (Convert.ToDateTime(this.DueDate) < DateTime.Today.Date)
                {
                        costOfDVDs[i] += 30;
                }
            }

            setCost(costOfDVDs);
        }
        public void updateRentalItems(int[] dvdIDsReturned) {
            //connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            for (int i = 0; i < dvdIDsReturned.Length; i++)
            {

                if (DVDIDs[i] == dvdIDsReturned[i])
                {
                    // update rentalitems set cost where dvdid = this and rentalid = this
                    String sqlQuery = "Update rentedItems " +
                        "SET cost = " + this.Cost[i] + ", " +
                        "dateReturned = '" + (DateTime.Today).ToString("dd-MMM-yy") + "' " +
                        "WHERE DVDID = " + this.DVDIDs[i] + " AND RentID = " + this.RentID;

                    //run statement
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    cmd.ExecuteNonQuery();
                }
            }

            conn.Close();
        }
        public void updateRentalStatus()
        {
            //connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            // update rentalitems set cost where dvdid = this and rentalid = this
            String sqlQuery = "Update rentals " +
                            "SET status = '" + this.Status + "' " +
                            "WHERE rentid = " + this.RentID;

            //run statement
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            //close conneciton
            conn.Close();
        }
        public static DataSet getRevenueGroupedByGenre() {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT genres.genreName, sum(this.cost) AS total " +
                "FROM genres " +
                "LEFT JOIN (SELECT g.genreName, ri.cost " +
                        "FROM DVDs d " +
                        "JOIN rentedItems ri ON d.dvdid = ri.dvdid " +
                        "JOIN genres g ON g.genreid = d.genreid " +
                        "WHERE ri.datereturned IS NOT NULL) " +
                "this ON this.genreName = genres.genreName " +
                "group by genres.genreName";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;
        }

        public static DataSet getRevenueOfYear(int year) {
            String sqlQuery = "SELECT TO_CHAR(DateReturned, 'mm'), SUM(cost)" +
                " FROM RentedItems" +
                " WHERE TO_CHAR(DateReturned, 'YYYY') = " + year.ToString() +
                " GROUP BY (TO_CHAR(DateReturned, 'mm'))";

            DataSet ds = Utility.getDataSet(sqlQuery);
            
            return ds;
        }

        public static ComboBox fillCmbYears(ComboBox cmbBox) {

            //select min and max years from rentedItems where date returned != null
            //
            String sqlQuery = "Select TO_CHAR(MIN(DateReturned), 'YYYY') as minDate, TO_CHAR(MAX(DateReturned), 'YYYY') as maxDate FROM RentedItems";
            DataSet ds = Utility.getDataSet(sqlQuery);

            int minDate = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            int maxDate = Int32.Parse(ds.Tables[0].Rows[0][1].ToString());

            for (int i = 0; i < (maxDate - minDate)+1; i++) {
                cmbBox.Items.Add(minDate + i);
            }

            return cmbBox;
        }
    }
}
