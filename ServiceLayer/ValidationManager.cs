using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class ValidationManager
    {
        public static bool IsValidString(string str)
        {
            if (str == null || str == String.Empty || str.Trim().Length == 0) 
            {
                return false;
            }
            return true;
        }
    }
}
