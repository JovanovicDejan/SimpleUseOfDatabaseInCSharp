using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;  
using System.Data.SqlClient;    

namespace SimpleUseOfDatabase
{
    public class clsProducts
    {
        private string p_productname;
        private double p_unitprice;
        public int SupplierID;
        public int CategoryID;
        public int Discontinued = 0;

        public string Productname
        {
            get { return p_productname; }
            set
            {
                if(value.Length < 1 || value.Length > 40)
                {
                    throw new Exception("Lenght of product name must be between 1 and 40!");
                }
                else
                {
                    try
                    {
                        p_productname = value;
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        public double UnitPrice
        {
            get { return p_unitprice; }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Unitprice can't be lower than 0");
                }
                else
                {
                    try
                    {
                        p_unitprice = value;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        public void DodajProizvod()
        {
            try
            {
            SqlConnection conn = new SqlConnection("Server=LAPTOP-ROMV3ETI; Integrated security=true; Database=TSQL");
            conn.Open();

            SqlCommand sm = new SqlCommand();
            sm.Connection = conn;
            sm.CommandType = CommandType.Text;

            string Sql = "INSERT INTO Production.Products VALUES (productname, supplierid, categoryid, unitprice,  -discontinued) VALUES ('" + p_productname + "', " + SupplierID.ToString() + ", " + CategoryID.ToString() + ", " + p_unitprice.ToString() + ", " + Discontinued.ToString() + ")";

            sm.CommandText = Sql;
            sm.ExecuteNonQuery();
            conn.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void PrikazSvihProizvoda()
        {
            try
            {
            SqlConnection conn = new SqlConnection("Server=LAPTOP-ROMV3ETI; Integrated security=true; Database=TSQL");
            conn.Open();

            SqlCommand sm = new SqlCommand();
            sm.Connection = conn;
            sm.CommandType = CommandType.Text;

            string Sql = "SELECT * FROM Production.Products";

            sm.CommandText = Sql;
            sm.ExecuteNonQuery();
            conn.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void IzmeniProizvod()
        {
            try
            {
            SqlConnection conn = new SqlConnection("Server=LAPTOP-ROMV3ETI; Integrated security=true; Database=TSQL");
            conn.Open();

            SqlCommand sm = new SqlCommand();
            sm.Connection = conn;
            sm.CommandType = CommandType.Text;

            string Sql = "UPDATE Production.Products SET productname =" + p_productname + ", supplierid =" + SupplierID +", categoryid =" + CategoryID + ", unitprice =" + p_unitprice + ", discontinued =" + Discontinued;


            sm.CommandText = Sql;
            sm.ExecuteNonQuery();
            conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ObrisiProizvod()
        {
            try
            {
            SqlConnection conn = new SqlConnection("Server=LAPTOP-ROMV3ETI; Integrated security=true; Database=TSQL");
            conn.Open();

            SqlCommand sm = new SqlCommand();
            sm.Connection = conn;
            sm.CommandType = CommandType.Text;

            string Sql = "DELETE FROM Production.Products WHERE productname = " + p_productname;

            sm.CommandText = Sql;
            sm.ExecuteNonQuery();
            conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
