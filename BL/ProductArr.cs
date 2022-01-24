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
    public class ProductArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = Product_Dal.GetDataTable();

            DataRow dataRow;
            Product curProduct; 

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curProduct = new Product(dataRow);
                this.Add(curProduct);
            }
        }

        
        public bool IsContains(string Product_Name)
        {
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Name == Product_Name)
                    return true;

            return false;
        }

        public Product GetProductWithMaxId()
        {
            Product maxProduct = new Product();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Id > maxProduct.Id)
                    maxProduct = this[i] as Product;

            return maxProduct;
        }

        public ProductArr Filter(string name, Level level, Category category)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Product product = (this[i] as Product);
                if (

                //סינון לפי שם המוצר

                product.Name.StartsWith(name)

                //סינון לפי החברה
                && (level == null || level.Id == -1 || product.Level.Id == level.Id)
                //סינון לפי קטגוריה
                && (category == null || category.Id == -1 || product.Category.Id == category.Id)
                )

                    //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    productArr.Add(product);
            }
            return productArr;
        }

        public bool DoesExist(Category curCategory)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Category.Id == curCategory.Id)
                    return true;

            return false;
        }

        public bool DoesExist(Level curLevel)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Level.Id == curLevel.Id)
                    return true;

            return false;
        }

    }
}
