using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUseOfDatabase
{
    public class clsCustomers
    {
        private string p_companyName;
        private string p_city;
        private string p_country;

    
        public string Company
        {
            get { return p_companyName; }
            set
            {
                if(value.Length < 1 || value.Length > 49)
                {
                    throw new Exception("Length of CompanyName must be between 1 and 40");
                }
                else
                {
                    try
                    {
                        p_companyName = value;
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        
        public string City
        {
            get { return p_city; }
            set
            {
                if(value.Length < 1 || value.Length > 15)
                {
                    throw new Exception("Length of City must be between 1 and 15");
                }
                try
                {
                    p_city = value;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
        public string Country
        {
            get { return p_country; }
            set
            {
                if(value.Length < 1 || value.Length > 15)
                {
                    throw new Exception("Length of Country must be between 1 and 15");
                }
                try
                {
                    p_country = value;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
