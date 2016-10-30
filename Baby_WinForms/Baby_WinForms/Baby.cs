using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baby_WinForms
{
    class Baby
    {
        public string Name;
        public string Surname;
        public byte Age;

        // ListBox içinde nesneyi görüntülemek için
        public override string ToString()
        {
            return this.Name + "\t" + this.Surname + "\t" + this.Age;
        }
    }
}
