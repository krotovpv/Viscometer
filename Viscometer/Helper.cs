using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viscometer
{
    public static class Helper
    {
        public static void InvokeEx(this Control ctl, Action act)
        {
            if (ctl == null) return;
            if (ctl.InvokeRequired == true)
                ctl.Invoke(act);
            else
                act();
        }
    }
}