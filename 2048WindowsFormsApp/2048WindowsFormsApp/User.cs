using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048WindowsFormsApp

{
    class User
    {
        public int Result { set; get; }
        private string name;
        
        public User(string name)
        {
            if (name == null)
            {
                this.name = "Аноним";
            }
            else
            {
                this.name = name;
            }
        }
        public string GetName()
        {
            return name;
        }
    }
}
