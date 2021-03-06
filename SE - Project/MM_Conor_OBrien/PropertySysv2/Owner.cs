﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;

namespace PropertySysv2
{
    class Owner
    {
        // instance variables
        private int owner_id;
        private string surname;
        private string forename;
        private string street;
        private string town;
        private string county;
        private string phone;
        private string email;
        private string activity;


        // no argument constructor
        public Owner()
        {
            owner_id = 0;
            surname = "";
            forename = "";
            street = "";
            town = "";
            county = "";
            phone = "";
            email = "";
            activity = "";
        }


        //Define setters
        public void setOwnerId(int Owner_ID)
        {
            this.owner_id = Owner_ID;
        }
        public void setSurname(String Surname)
        {
            this.surname = Surname;
        }
        public void setForename(String Forename)
        {
            this.forename = Forename;
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
        public void setPhone(String Phone)
        {
            this.phone = Phone;
        }
        public void setEmail(String Email)
        {
            this.email = Email;
        }
        public void setActivity(String Activity)
        {
            this.activity = Activity;
        }


        //Define getters
        public int getOwnerId()
        {
            return owner_id;
        }

        public String getSurname()
        {
            return surname;
        }
        public String getForename()
        {
            return forename;
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
        public String getPhone()
        {
            return phone;
        }
        public String getEmail()
        {
            return email;
        }
        public String getActivity()
        {
            return activity;
        }
        public static bool validEmail(String inStr)
        {
            if (Regex.IsMatch(inStr, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool validText(String text)
        {
            if(Regex.IsMatch(text, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool validTextWithNumbers(String text)
        {
            if (Regex.IsMatch(text, @"^[a-zA-Z0-9 ]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validNumbers(String text)
        {
            if (Regex.IsMatch(text, @"^[0-9]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void getOwner(int Oid)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX owner_id used
            String strSQL = "SELECT * FROM Owners WHERE Owner_ID = " + Oid;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first OwnerId, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {
                setOwnerId(dr.GetInt32(0));
                setForename(dr.GetString(1));
                setSurname(dr.GetString(2));
                setStreet(dr.GetString(3));
                setTown(dr.GetString(4));
                setCounty(dr.GetString(5));
                setPhone(dr.GetString(6));
                setEmail(dr.GetString(7));            
            }
            //close DB connection
            myConn.Close();
        }

        public static int getNextOwnerId()
        {
            // variable to hold value to be returned
            int intNextOwnerId;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX Owner_ID used
            String strSQL = "SELECT MAX(Owner_ID) FROM Owners";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query         
            dr.Read();

           
            // If NULL, then there are no OwnerID's in the Owner File - start at 1
            //Otherwise add 1 to the value read

            if (dr.IsDBNull(0))
                intNextOwnerId = 1;
            else
                intNextOwnerId = Convert.ToInt16(dr.GetValue(0)) + 1;

            //close DB connection
            myConn.Close();

            //return next OwnerID
            return intNextOwnerId;
        }

        public void regOwner()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT Owner record
            String strSQL = "INSERT INTO Owners VALUES(" + this.owner_id.ToString() +
                ",'" + this.forename.ToUpper().ToString() + "','" +  this.surname.ToUpper() + "','" +
                  this.street.ToUpper() + "','" + this.town.ToUpper() + "','" + this.county.ToUpper() + "','"
                 + this.phone + "','" + this.email.ToUpper() + "','" + this.activity.ToUpper() + "')";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public static DataSet getSpecificOwners(DataSet DS, String Surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Owners WHERE Surname LIKE '%" + Surname + "%' AND Activity = 'A' ORDER BY Owner_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");
            conn.Close();
            return DS;
        }
        public static DataSet getSpecificAllOwners(DataSet DS, String Surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Owners WHERE Surname LIKE '%" + Surname + "%' ORDER BY Owner_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");
            conn.Close();
            return DS;
        }
        public void updOwner()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to UPDATE Owner record
            String strSQL = "UPDATE Owners SET Surname = '" + this.surname.ToUpper() + "', Forename = '" + this.forename.ToUpper() + "', Street = '" +
                  this.street.ToUpper() + "', Town = '" + this.town.ToUpper() + "', County = '" + this.county.ToUpper() + "', Phone = '"
                 + this.phone + "', Email = '" + this.email.ToUpper() + "', Activity = '" + this.activity.ToUpper().ToString() + "' WHERE Owner_ID = " + this.owner_id.ToString();

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public void rmvOwner()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to UPDATE Owner Activity to Inactive
            String strSQL = "UPDATE Owners SET Activity = 'I' WHERE Owner_ID = " + this.owner_id.ToString();

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
    }
}
