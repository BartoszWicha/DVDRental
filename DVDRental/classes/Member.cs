using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace DVDRental
{
    class Member
    {

        private int memberID;
        private String firstName;
        private String surName;
        private String phoneNum;
        private Char status;

        public int getMemberID() { return memberID; }
        public String getFirstName() { return firstName; }
        public String getSurName() { return surName; }
        public String getPhoneNum() { return phoneNum; }

        private void setStatus(Char Status) { status = Status; }
        public void setFirstName(String FirstName) { firstName = FirstName; }
        public void setPhoneNum(String PhoneNum) { phoneNum = PhoneNum; }
        public void setSurName(String SurName) { surName = SurName; }
        private void setMemberID(int MemberID) { memberID = MemberID; }

        public Member() {
            setMemberID(0);
            setFirstName("");
            setPhoneNum("");
            setStatus(Convert.ToChar("A"));
            setSurName("");
        }
        public Member (int MemberID, String FirstName, String SurName, String PhoneNum) {
            setSurName(SurName);
            setPhoneNum(PhoneNum);
            setMemberID(MemberID);
            setFirstName(FirstName);
            setStatus(Convert.ToChar("A")); 
        }
        
        public static int generateNextID() { 
            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "SELECT MAX(memberID) FROM Members";

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
        public void addMember()
        {
            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "INSERT INTO Members Values (" +
                this.memberID + ",'" +
                this.firstName + "','" +
                this.surName + "','" +
                this.phoneNum + "','" +
                this.status + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public void modifyMember() {
            OracleConnection connection = Utility.GetConnection();
          
            String sqlQuery = "UPDATE Members SET " +
                "MemberID = " + this.memberID + "," +
                "firstName = '" + this.firstName + "' ," +
                "surName = '" + this.surName + "' ," +
                "status = '" + this.status + "' ," +
                "phoneNum = '" + this.phoneNum + "'" +
                "WHERE MemberID = " + this.memberID;

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public static DataSet getMatchingMembers(String surName) {

            OracleConnection connection = Utility.GetConnection();

            String sqlQuery = "SELECT MemberID, FirstName, SurName, PhoneNum, Status FROM Members " +
                                "WHERE LOWER(surName) LIKE '%" + surName.ToString().ToLower() + "%'";
            DataSet dataSet = Utility.getDataSet(sqlQuery);

            return dataSet;
        }
        public void getSelectedMember(int id)
        {
            String sqlQuery = "SELECT * FROM Members WHERE memberID = " + id;
            DataSet dataSet = Utility.getDataSet(sqlQuery);

            setMemberID(Convert.ToInt32(dataSet.Tables[0].Rows[0][0]));
            setFirstName(Convert.ToString(dataSet.Tables[0].Rows[0][1]));
            setSurName(Convert.ToString(dataSet.Tables[0].Rows[0][2]));
            setPhoneNum(Convert.ToString(dataSet.Tables[0].Rows[0][3]));
            setStatus(Convert.ToChar(dataSet.Tables[0].Rows[0][4]));
        }
        public void cancelMember() {

            OracleConnection conn = Utility.GetConnection();
            String sqlQuery = "UPDATE Members SET Status = 'C' WHERE MemberID = " + this.memberID;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();
                
        }
        public Boolean memberHasUnreturnedRentals() {
            String sqlQuery = "SELECT * FROM Rentals WHERE memberid = " + this.memberID + " AND status = 'U'";
            DataSet dataSet = Utility.getDataSet(sqlQuery);

            return !(Utility.checkIfDataSetEmpty(dataSet));
        }
    }
}
