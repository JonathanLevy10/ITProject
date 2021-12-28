using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.BL
{
    class Level
    {

        private int m_id;
        private string m_Name;


        public int Id { get => m_id; set => m_id = value; }
        public string LevelName { get => m_Name; set => m_Name = value; }
       
    }
}
