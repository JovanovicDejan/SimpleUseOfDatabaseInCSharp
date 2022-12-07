using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUseOfDatabase
{
    public class clsCategories
    {
        private string p_categoryName;
        private string p_description;

        public string CategoryName
        {
            get { return p_categoryName; }
            set
            {
                if(value.Length < 1 || value.Length > 15)
                {
                    throw new Exception("Length of Category name must be between 1 and 15");
                }
                else
                {
                    try
                    {
                        p_categoryName = value;
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        public string Description
        {
            get { return p_description; }
            set
            {
                if(value.Length < 1 || value.Length > 200)
                {
                    throw new Exception("Length of description must be between 1 and 200");
                }
            }
        }
    }
}
