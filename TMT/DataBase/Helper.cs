using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMT.DataBase
{
    public class Helper
    {
        public static string CnnVal(string name)
        {
            var Enum = ConfigurationManager.ConnectionStrings.GetEnumerator();
            while (Enum.MoveNext())
            {
                var what = Enum.Current;
            }
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
