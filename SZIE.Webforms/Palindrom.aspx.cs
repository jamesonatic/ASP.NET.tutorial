using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Palidrom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            var isPalindrom = true;
            var text = txtSentence.Text.Replace(" ", "").ToLower();
            for (int i = 0; i<text.Length;i++)
            {
                if (text[i] != text[text.Length-1-i])
                {
                    isPalindrom = false;
                    break;
                }
            }
            if (isPalindrom)
            {
                lblResult.Text = "Igen, ez palindrom!";
                lblResult.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                lblResult.Text = "Nem, ez nem palindrom!";
                lblResult.BackColor = System.Drawing.Color.OrangeRed;
            }
        }
    }
}