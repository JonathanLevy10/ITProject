using ClientSignup.DAL;
using System.Collections;
using System.Data;

namespace ClientSignup.BL
{
    public class LevelArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = Level_Dal.GetDataTable();

            DataRow dataRow;
            Level curLevel;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curLevel = new Level(dataRow);
                this.Add(curLevel);
            }
        }

        public LevelArr Filter(int id, string name) //checks if clients exists, then moves the ones that exist into new array
        {
            LevelArr levelArr = new LevelArr();
            Level level;
            for (int i = 0; i < this.Count; i++)
            {
                level = (this[i] as Level);
                if (
                    (id == 0 || level.Id == id) && level.Name.ToLower().StartsWith(name.ToLower()))
                    levelArr.Add(levelArr);
            }
            return levelArr;
        }

        public bool IsContains(string name)
        {
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Level).Name == name)
                    return true;

            return false;
        }

        public Level GetLevelWithMaxId()
        {
            Level maxLevel = new Level();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Level).Id > maxLevel.Id)
                    maxLevel = this[i] as Level;

            return maxLevel;
        }
    }
}
