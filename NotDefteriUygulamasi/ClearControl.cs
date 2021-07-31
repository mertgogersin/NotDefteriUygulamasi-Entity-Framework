using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteriUygulamasi
{
    class ClearControl
    {
        public static void Clear(Form form)
        {

            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }

        }
    }
}
