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
        public CategoryArr Filter(int id, string name)
        {
            CategoryArr levelArr = new CategoryArr(); //checks if level exists, then moves the ones that exist into new array
            Category level;
            for (int i = 0; i < this.Count; i++)
            {
                level = (this[i] as Category);
                if (
                    (id == 0 || level.Id == id) && level.Name.ToLower().StartsWith(name.ToLower()))
                    levelArr.Add(levelArr);
            }
            return levelArr;
        }
        public bool IsContains(string name)
        {
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Category).Name == name)
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


