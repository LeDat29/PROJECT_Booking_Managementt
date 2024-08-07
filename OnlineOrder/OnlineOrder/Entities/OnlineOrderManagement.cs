using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OnlineOrder.Entities
{
    public class OnlineOrderManagement
    {
        private static OnlineOrderManagement instance = null;

        private static readonly object instanceLock = new object();
        private OnlineOrderManagement() { }
        public static OnlineOrderManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OnlineOrderManagement();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Category> GetAllCategory()
        {
            List<Category> list;
            try
            {
                var db = new Prn212AssignmentBl5Context();
                list = db.Categories.ToList(); //linq
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        /*public void AddCategory(Category category) {
            try
            {
                if ()
                {
                    //check category ton tai
                    

                   
                        if ()
                        {
                            // da them oke
                        }
                        else
                        {
                            MessageBox.Show("Add category " +  + "Failed");
                        }
                    }
                    MessageBox.Show("Add category Successfully", "Add Category");

                }
                else
                {
                    MessageBox.Show("Category is existed !", "Alert");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
*/
    }
}
