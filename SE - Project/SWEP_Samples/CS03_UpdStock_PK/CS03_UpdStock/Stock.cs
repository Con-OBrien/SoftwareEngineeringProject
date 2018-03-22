using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace CS03_UpdStock
{
    class Stock
    {
        // instance variables
        private int stock_No;
        private string description;
        private decimal cost_price;
        private decimal sale_price;
        private int qty;
        private char status;

        // no argument constructor
        public Stock()
        {
            stock_No = 0;
            description = "";
            cost_price = 0;
            sale_price = 0;
            qty = 0;

        }
        //Define setters
        public void setStockNo(int Stock_No)
        {
            this.stock_No = Stock_No;
        }
        public void setDescription(String Description)
        {
            this.description = Description;
        }

        public void setCostPrice(decimal Cost_Price)
        {
            this.cost_price = Cost_Price;
        }

        public void setSalePrice(decimal Sale_Price)
        {
            this.sale_price = Sale_Price;
        }

        public void setQty(int Qty)
        {
            this.qty = Qty;
        }

        public void setStatus(char Status)
        {
            this.status = Status;
        }

        //Define getters
        public int getStockNo()
        {
            return stock_No;
        }
        public string getDescription()
        {
            return description;
        }
        public decimal getCostPrice()
        {
            return cost_price;
        }
        public decimal getSalePrice()
        {
            return sale_price;
        }
        public int getQty()
        {
            return qty;
        }
        public char getStatus()
        {
            return status;
        }

        //define a static method to get data
        public static DataSet getStock(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT StockNo, Description,Qty FROM Stock ORDER BY StockNo";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
          
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();
     
            return DS;
        }

        public void getStock(int Sno)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT * FROM Stock WHERE StockNo = " + Sno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {

                setStockNo(dr.GetInt32(0));
                setDescription(dr.GetString(1));
                setCostPrice(dr.GetDecimal(2));
                setSalePrice(dr.GetDecimal(3));
                setQty(dr.GetInt32(4));
                //setStatus(dr.GetValue(5));

            }
            //close DB connection
            myConn.Close();
        }

        public void updStock()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Stock SET Description = '" + this.description.ToUpper() + "', CostPrice = " + this.cost_price + 
                ", SalePrice = " + this.sale_price + ", Qty = " + this.qty + " WHERE StockNo = " + this.stock_No;
            
            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public void updStock(int Sno)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Stock SET Description = '" + this.description.ToUpper() + "', Cost_Price = " + this.cost_price + ", Sale_Price = " +
                this.sale_price + ", Qty = " + this.qty + " WHERE Stock_No = " + Sno + "')";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

    }
}
