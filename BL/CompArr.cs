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
    class CompArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = Comp_Dal.GetDataTable();

            DataRow dataRow;
            Comp curComp;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curComp = new Comp(dataRow);
                this.Add(curComp);
            }
        }
        public CompArr Filter(string name, Category category)
        {
            CompArr compArr = new CompArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Comp comp = (this[i] as Comp);
                if (

                //סינון לפי שם המוצר

                comp.Name.StartsWith(name)

                //סינון לפי החברה
               
                //סינון לפי קטגוריה
                && (category == null || category.Id == -1 || comp.Category.Id == category.Id)
                )

                    //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    compArr.Add(comp);
            }
            return compArr;
        }
        public bool IsContains(string name)
        {
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Comp).Name == name)
                    return true;

            return false;
        }
        public Comp GetCompWithMaxId()
        {
            Comp maxComp = new Comp();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Comp).Id > maxComp.Id)
                    maxComp = this[i] as Comp;

            return maxComp;
        }

    }
}
