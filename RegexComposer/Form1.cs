using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexComposer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClbRegexOptions.Items.AddRange(new []
                                               {
                                                   new RegexOptionListBoxItem(RegexOptions.CultureInvariant),
                                                   new RegexOptionListBoxItem(RegexOptions.Singleline),
                                                   new RegexOptionListBoxItem(RegexOptions.Multiline),
                                                   new RegexOptionListBoxItem(RegexOptions.IgnoreCase),
                                               });

        }

        private void ReMatchRegex()
        {
            try
            {
                
                var selectedOptions = ClbRegexOptions.CheckedItems.Cast<RegexOptionListBoxItem>().Select(i => i.Option);
                RegexOptions options = RegexOptions.None;
                
                if (selectedOptions.Count() >= 1)
                    options = selectedOptions.First();
                
                if(selectedOptions.Count()> 1)
                {
                    foreach (var selectedOption in selectedOptions)
                    {
                        options = options | selectedOption;
                    }
                }

                var r = new Regex(TxtRegex.Text, options );
                bool isMatch = r.IsMatch(TxtText.Text);
                TxtText.BackColor = isMatch ? Color.Green : Color.FromKnownColor(KnownColor.Window);
                TxtRegex.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
            catch (Exception ex)
            {
                TxtRegex.BackColor = Color.PaleVioletRed;
                TxtError.Text = ex.Message;
            }
        }

        private void ClbRegexOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //wird als letztes Event in die eventloop geängt. Dann ist die CheckedItems Collection korrekt gefüllt
            BeginInvoke((MethodInvoker)ReMatchRegex);
        }

        private void TxtRegex_TextChanged(object sender, EventArgs e)
        {
            ReMatchRegex();
        }

        private void TxtText_TextChanged(object sender, EventArgs e)
        {
            ReMatchRegex();
        }
    }

    public class RegexOptionListBoxItem
    {
        public RegexOptions Option { get; set; }
        public string Name { get; set; }

        public RegexOptionListBoxItem(RegexOptions option)
        {
            Option = option;
            Name = Option.ToString();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
