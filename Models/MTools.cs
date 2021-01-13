using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.Models
{
    class MTools
    {
        public static bool verifyDataTable(DataTable dt)
        {
            if (dt != null)
                return true;
            else
                return false;


        }
    }
}
