using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PropertySysv2
{
    class Tenant
    {
        // instance variables
        private int tenant_id;
        private string surname;
        private string forename;     
        private int phone;
        private string email;
        private string dob;
        private string activity;
        private int prop_id;


        // no argument constructor
        public Tenant()
        {
            tenant_id = 0;
            surname = "";
            forename = ""; 
            phone = 0;
            email = "";
            dob = "";
            activity = "";
            prop_id = 0;
        }


        //Define setters
        public void setTenantId(int Tenant_ID)
        {
            this.tenant_id = Tenant_ID;
        }
        public void setSurname(String Surname)
        {
            this.surname = Surname;
        }
        public void setForename(String Forename)
        {
            this.forename = Forename;
        }  
        public void setPhone(int Phone)
        {
            this.phone = Phone;
        }
        public void setEmail(String Email)
        {
            this.email = Email;
        }
        public void setDob(String DOB)
        {
            this.dob = DOB;
        }
        public void setActivity(String Activity)
        {
            this.activity = Activity;
        }
        public void setPropID(int Prop_ID)
        {
            this.prop_id = Prop_ID;
        }
       

        //Define getters
        public int getTenantId()
        {
            return tenant_id;
        }

        public String getSurname()
        {
            return surname;
        }
        public String getForename()
        {
            return forename;
        }
        public int getPhone()
        {
            return phone;
        }
        public String getEmail()
        {
            return email;
        }
        public String getDOB()
        {
            return dob;
        }
        public String getActivity()
        {
            return activity;
        }
        public int getPropID()
        {
            return prop_id;
        }
        public void getTenant(int Tid)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX owner_id used
            String strSQL = "SELECT * FROM Tenants WHERE Tenant_ID = " + Tid;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {
                setTenantId(dr.GetInt32(0));
                setForename(dr.GetString(1));
                setSurname(dr.GetString(2));    
                setPhone(Convert.ToInt32(dr.GetString(3)));
                setEmail(dr.GetString(4));
                setDob(dr.GetValue(5).ToString());
            }
            //close DB connection
            myConn.Close();
        }
        public static DataSet getTenant(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT Tenant_ID FROM Tenants ORDER BY Tenant_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }
        public static DataSet getSurnamesTenant(DataSet RS, String Surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String upper = Surname.ToUpper();
            String strSQL = "SELECT * FROM Tenants WHERE Surname LIKE '%" + upper + "%'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter ra = new OracleDataAdapter(cmd);

            ra.Fill(RS, "rs");

            conn.Close();

            return RS;
        }
        public static DataSet getSurnamesAllTenant(DataSet RS, String Surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String upper = Surname.ToUpper();
            String strSQL = "SELECT * FROM Tenants WHERE Surname LIKE '%" + upper + "%' AND Activity = 'A'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter ra = new OracleDataAdapter(cmd);

            ra.Fill(RS, "rs");

            conn.Close();

            return RS;
        }

        public static int getNextTenantId()
        {
            // variable to hold value to be returned
            int intNextTenantId;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT MAX(Tenant_ID) FROM Tenants";

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
                intNextTenantId = 1;
            else
                intNextTenantId = Convert.ToInt16(dr.GetValue(0)) + 1;

            //close DB connection
            myConn.Close();

            //return next StockNo
            return intNextTenantId;
        }
        public int getSumTenants(int PropID)
        {

            int total;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "SELECT COUNT(Prop_ID) FROM Bookings WHERE Prop_ID = " + PropID;
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.IsDBNull(0))
                total = 0;
            else
                total = Convert.ToInt16(dr.GetValue(0));

            myConn.Close();
            return total;
        }

        public void regTenant()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Tenants VALUES(" + this.tenant_id.ToString() +
                ",'" + this.forename.ToUpper() + "','" + this.surname.ToUpper() + 
                  "'," + this.phone.ToString() + ",'" + this.email.ToUpper() + "','" 
                  + this.dob.ToString() + "','" + this.activity.ToUpper() + "'," + this.prop_id.ToString() + ")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        

        public void updTenant()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Tenants SET Surname = '" + this.surname.ToUpper() + "', Forename ='"
                + this.forename.ToUpper() + "', Phone = " + this.phone.ToString() + ", Email ='"
                + this.email.ToUpper() + "', Activity = '" + this.activity.ToUpper() + "' WHERE Tenant_ID = " + this.tenant_id.ToString();

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public void rmvTenant()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to UPDATE Owner Activity to Inactive
            String strSQL = "UPDATE Tenants SET Activity = 'I' WHERE Tenant_ID = " + this.tenant_id.ToString();

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
    }
}
