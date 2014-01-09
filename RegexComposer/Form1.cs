using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexComposer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtRegex_TextChanged(object sender, EventArgs e)
        {
            MatchRegex();
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            MatchRegex();
        }



        private void MatchRegex()
        {
            try
            {
                var r = new Regex(txtRegex.Text);
                bool isMatch = r.IsMatch(txtText.Text);
                txtText.BackColor = isMatch ? Color.Green : Color.FromKnownColor(KnownColor.Window);
                txtRegex.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
            catch (Exception ex)
            {
                txtRegex.BackColor = Color.PaleVioletRed;
            }
        }




    }
}
