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
        public CompArr Filter(int id, string name)
        {
            CompArr compArr = new CompArr(); //checks if comp exists, then moves the ones that exist into new array
            Comp comp;
            for (int i = 0; i < this.Count; i++)
            {
                comp = (this[i] as Comp);
                if (
                    (id == 0 || comp.Id == id) && comp.Name.ToLower().StartsWith(name.ToLower()))
                    compArr.Add(compArr);
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
