using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFD.Logic
{
    public static class Helper
    {
        public static bool IsWomen(string Imię)
        {
            if (!string.IsNullOrEmpty(Imię))
            {
                Imię = Imię.Trim().ToLower();
                if (Imię.EndsWith("a") && Imię != "kuba" && (Imię.IndexOf(" ") == -1))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
