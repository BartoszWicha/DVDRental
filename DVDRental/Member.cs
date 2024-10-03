using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    class Member
    {

        private int memberID;
        private String firstName;
        private String surName;
        private int phoneNum;
        private Char status;

        public int getMemberID() { return memberID; }
        public String getFirstName() { return firstName; }
        public String getSurName() { return surName; }
        public int getPhoneNum() { return phoneNum; }
        public Char getStatus() { return status; }

        public void setStatus(Char Status) { status = Status; }
        public void setFirstName(String FirstName) { firstName = FirstName; }
        public void setPhoneNum(int PhoneNum) { phoneNum = PhoneNum; }
        public void setSurName(String SurName) { surName = SurName; }
        private void setMemberID(int MemberID) { memberID = MemberID; }

        public Member() {
            setMemberID(0);
            setFirstName("");
            setPhoneNum(0);
            setStatus(Convert.ToChar("A"));
            setSurName("");
        }
        public Member (int MemberID, String FirstName, String SurName, int PhoneNum) {
            setSurName(SurName);
            setPhoneNum(PhoneNum);
            setMemberID(MemberID);
            setFirstName(FirstName);
            setStatus(Convert.ToChar("A")); 
        }

        public void RegisterMember() {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "INSERT INTO Members Values ('" +
                this.memberID + "','" +
                this.firstName + "','" +
                this.surName + "','" +
                this.phoneNum + "'," +
                this.status + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static int generateNextID() { 
            
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT MAX(memberID) FROM Members";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

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

            conn.Close();

            return id;
        }
        public void modifyMember() {

            //connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String sqlQuery = "UPDATE Members SET " +
                "MemberID = " + this.memberID + "," +
                "firstName = '" + this.firstName + "' ," +
                "surName = '" + this.surName + "' ," +
                "status = '" + this.status + "' ," +
                "phoneNum = " + this.phoneNum + "" +
                "WHERE MemberID = " + this.memberID;

            //run statement
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            //close conneciton
            conn.Close();

        }

    }
}
