using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySysv2
{
    class Booking
    {
        private int booking_id;
        private String dateregistered;
        private String startoflease;
        private String endoflease;
        private int owner_id;
        private int prop_id;

        public Booking()
        {
            booking_id = 0;
            dateregistered = "";
            startoflease = "";
            endoflease = "";
            owner_id = 0;
            prop_id = 0;
        }

        //Define setters
        public void setBookingId(int Booking_ID)
        {
            this.booking_id = Booking_ID;
        }
        public void setDateRegistered(String DateRegistered)
        {
            this.dateregistered = DateRegistered;
        }
        public void setStartOfLease(String StartOfLease)
        {
            this.startoflease = StartOfLease;
        }
        public void setEndOfLease(String EndOfLease)
        {
            this.endoflease = EndOfLease;
        }
        public void setOwnerId(int Owner_ID)
        {
            this.owner_id = Owner_ID;
        }
        public void setPropId(int Prop_ID)
        {
            this.prop_id = Prop_ID;
        }

        //Define getters
        public int getBookingId()
        {
            return booking_id;
        }

        public String getDateRegistered()
        {
            return dateregistered;
        }

        public String getStartOfLease()
        {
            return startoflease;
        }
        public String getEndOfLease()
        {
            return endoflease;
        }
        public int getOwnerId()
        {
            return owner_id;
        }
        public int getPropId()
        {
            return prop_id;
        }

        public void makeBooking()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "INSERT INTO Bookings VALUES(" + this.booking_id.ToString() +
                ",'" + this.dateregistered.ToUpper() + "','" + this.startoflease.ToUpper() + "','" +
                this.endoflease.ToUpper() + "'," + this.prop_id.ToString() + ")";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static int getNextBookingId()
        {
            // variable to hold value to be returned
            int intNextBookingId;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT MAX(Booking_ID) FROM Bookings";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            //An aggregate function always returns 1 row, even if it contains a NULL value
            // If NULL, then there are no StockNo's in the Stock File - start at 1
            //Otherwise add 1 to the value read

            if (dr.IsDBNull(0))
                intNextBookingId = 1;
            else
                intNextBookingId = Convert.ToInt16(dr.GetValue(0)) + 1;

            //close DB connection
            myConn.Close();

            //return next StockNo
            return intNextBookingId;
        }
        public static int getMonthlyData(String County, String Town)
        {
            int total;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //connection name conn.Open();
            String strSQL = "SELECT SUM(RentPerMonth) FROM Properties WHERE Town = '" + Town + "' AND COUNTY = '" + County + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
                total = 0;
            else
                total = Convert.ToInt16(dr.GetValue(0));
            conn.Close();

            return total;
        }
        public static int getMonthlyData(String County)
        {
            int total;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //connection name conn.Open();
            String strSQL = "SELECT SUM(RentPerMonth) FROM Properties WHERE COUNTY = '" + County + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
                total = 0;
            else
                total = Convert.ToInt16(dr.GetValue(0));
            conn.Close();

            return total;
        }
    }
}
