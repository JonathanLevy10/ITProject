using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.BL
{
    public class Category
    {
        private string m_Name;
        private int m_id; //Items individual and unique id used for identifying categories

        public string Name { get => m_Name; set => m_Name = value; } //change this variable name to anything no errors
        public int Id { get => m_id; set => m_id = value; }

    }
}
