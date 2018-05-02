using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PropertySysv2
{
    class Property
    {
        //instance variables
        private int prop_id;
        private int rentpermonth;
        private int bedrooms;
        private int bathrooms;
        private string housetype;
        private string street;
        private string town;
        private string county;
        private string activity;
        private int owner_id;

        public Property()
        {
            rentpermonth = 0;
            bedrooms = 0;
            bathrooms = 0;
            housetype = "";
            street = "";
            town = "";
            county = "";
            activity = "";
        }

        //Define setters
        public void setPropId(int Prop_ID)
        {
            this.prop_id = Prop_ID;
        }
        public void setRentPerMonth(int RentPerMonth)
        {
            this.rentpermonth = RentPerMonth;
        }
        public void setBedrooms(int Bedrooms)
        {
            this.bedrooms = Bedrooms;
        }
        public void setBathrooms(int Bathrooms)
        {
            this.bathrooms = Bathrooms;
        }
        public void setHouseType(String HouseType)
        {
            this.housetype = HouseType;
        }
        public void setStreet(String Street)
        {
            this.street = Street;
        }
        public void setTown(String Town)
        {
            this.town = Town;
        }
        public void setCounty(String County)
        {
            this.county = County;
        }

        public void setActivity(String Activity)
        {
            this.activity = Activity;
        }

        internal void getSpecificProps(int v)
        {
            throw new NotImplementedException();
        }

        public void setOwnerId(int Owner_ID)
        {
            this.owner_id = Owner_ID;
        }

        //Define getters
        public int getPropId()
        {
            return prop_id;
        }
        public int getRentPerMonth()
        {
            return rentpermonth;
        }
        public int getBedrooms()
        {
            return bedrooms;
        }
        public int getBathrooms()
        {
            return bathrooms;
        }
        public String getHouseType()
        {
            return housetype;
        }
        public String getStreet()
        {
            return street;
        }
        public String getTown()
        {
            return town;
        }
        public String getCounty()
        {
            return county;
        }
        public String getActivity()
        {
            return activity;
        }
        public int getOwnerId()
        {
            return owner_id;
        }

        public void getProperty(int Pid)
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX prop_id used
            String strSQL = "SELECT * FROM Properties WHERE Prop_ID = " + Pid;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL Query
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                setPropId(dr.GetInt32(0));
                setRentPerMonth(dr.GetInt32(1));
                setBedrooms(dr.GetInt32(2));
                setBathrooms(dr.GetInt32(3));
                setHouseType(dr.GetString(4));
                setStreet(dr.GetString(5));
                setTown(dr.GetString(6));
                setCounty(dr.GetString(7));
                setOwnerId(dr.GetInt32(8));
            }

            //close DB connection
            myConn.Close();
        }
        public static DataSet getProp(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT Prop_ID FROM Properties ORDER BY Prop_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }
        public static DataSet getTown(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT DISTINCT Town FROM Properties ORDER BY Town";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }
        public static DataSet getCounty(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT DISTINCT County FROM Properties ORDER BY County";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }
        public static DataSet getSpecificProps(DataSet DS, String Town, int Beds)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Properties WHERE Town = '" + Town + "' AND Bedrooms = " + Beds + " AND Activity = 'A'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");
            conn.Close();
            return DS;
        }
        public static DataSet getSpecificProps(DataSet DS, String Town)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Properties WHERE Town = '" + Town + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");
            conn.Close();
            return DS;
        }
        public static int getNextPropId()
        {
            int intNextPropId;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Prop_ID) FROM Properties";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                intNextPropId = 1;
            else
                intNextPropId = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return intNextPropId;
        }
        //define a static method to get data
        public static DataSet getAllProperties(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String strSQL = "SELECT * FROM Properties";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");
            conn.Close();
            return DS;
        }
       
        public void regProp()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "INSERT INTO Properties VALUES(" + this.prop_id.ToString() +
                "," + this.rentpermonth.ToString() + "," + this.bedrooms.ToString() +
                "," + this.bathrooms.ToString() + ",'" + this.housetype.ToUpper() +
                "','" + this.street.ToUpper().ToString() + "','" + this.town.ToUpper() + "','" +
                this.county.ToUpper() + "','" + this.activity.ToUpper() + "'," + this.owner_id.ToString() + ")"; 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();

        }

        public void updProp()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Properties SET RentPerMonth = " + this.rentpermonth.ToString() + ", Bedrooms = " +
                this.bedrooms.ToString() + ", Bathrooms = " + this.bathrooms.ToString() + ", HouseType = '" + this.housetype.ToUpper() +
                "', Street = '" + this.street.ToUpper() + "', Town = '" + this.town.ToUpper() + "', County = '" +
                this.county.ToUpper() + "', Activity = '" + this.activity.ToUpper() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        public void updProp(int Pid)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Properties SET VALUES(" + this.prop_id.ToString() +
                "," + this.rentpermonth.ToString() + "," + this.bedrooms.ToString() +
                "," + this.bathrooms.ToString() + ",'" + this.housetype.ToUpper() +
                "','" + this.street.ToUpper() + "','" + this.town.ToUpper() + "','" +
                this.county.ToUpper() + "') WHERE Prop_ID = " + Pid;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }
        public void rmvProperty()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to DELETE stock record
            String strSQL = "DELETE FROM Properties WHERE Prop_ID = " + this.prop_id.ToString();

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public void rmvProperty(int Pid)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to DELETE stock record
            String strSQL = "DELETE FROM Properties WHERE Prop_ID = " + Pid;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
    }
}
