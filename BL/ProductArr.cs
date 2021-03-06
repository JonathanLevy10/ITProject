using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFP_GOS.DAL;

namespace WFP_GOS.BL
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
        public ProductArr Filter(string name, Category category, Level level)
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
        public ProductArr Filter(string name, Category category, Level level, int countFrom, int countTo)
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
                && (product.Count > countFrom && product.Count < countTo)
                )

                    //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    productArr.Add(product);
            }
            return productArr;
        }
        public ProductArr Filter2(int id, Category category, Level level)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Product product = (this[i] as Product);
                if (

                //סינון לפי שם המוצר

                product.Name.StartsWith(product.Name)

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
        public ProductArr GetProductArr()
        {
            ProductArr productArr = new ProductArr();
            for (int i = 0; i < this.Count; i++)
                productArr.Add((this[i] as OrderProduct).Product);

            return productArr;
        }
        public void Remove(ProductArr productArr)
        {
            for (int i = 0; i < productArr.Count; i++)
                this.Remove(productArr[i] as Product);
        }
        public void Remove(Product product)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).Id == product.Id)
                {
                    this.RemoveAt(i); return;
                }
            }
        }
        public void UpdateCount()
        {

            //מעדכנת את אוסף המוצרים

            for (int i = 0; i < this.Count; i++)
                (this[i] as Product).UpdateCount();
        }

    }
}
