using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSignup.DAL;

namespace ClientSignup.BL
{
    public class CategoryArr : ArrayList
    {

        public void Fill()
        {
            DataTable dataTable = Category_Dal.GetDataTable();

            DataRow dataRow;
            Category curCategory;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCategory = new Category(dataRow);
                this.Add(curCategory);
            }
        }

        public CategoryArr Filter(int id, string Category) //checks if clients exists, then moves the ones that exist into new array
        {
            CategoryArr backgroundMAArr = new CategoryArr();
            Product product;
            for (int i = 0; i < this.Count; i++)
            {
                product = (this[i] as Product);
                if (

                    (id == 0 || product.Id == id) &&
                    product.Category.Name.ToLower().StartsWith(Category.ToLower())


                    )
                    backgroundMAArr.Add(backgroundMAArr);
            }
            return backgroundMAArr;
        }

        public bool IsContains(string Category_Name)
        {
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Category).Name == Category_Name)
                    return true;

            return false;
        }

        


        public Category GetCategoryWithMaxId()
        {
            Category maxCategory = new Category();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Category).Id > maxCategory.Id)
                    maxCategory = this[i] as Category;

            return maxCategory;


        }
    }
}


