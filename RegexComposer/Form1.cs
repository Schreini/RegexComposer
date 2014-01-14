using System;
using System.Data;
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
            GrdMatches.AutoGenerateColumns = true;
            ClbRegexOptions.Items.AddRange(new []
                                               {
                                                   new RegexOptionListBoxItem(RegexOptions.CultureInvariant),
                                                   new RegexOptionListBoxItem(RegexOptions.Singleline),
                                                   new RegexOptionListBoxItem(RegexOptions.Multiline),
                                                   new RegexOptionListBoxItem(RegexOptions.IgnoreCase),
                                               });

        }

        private void ReEvaluateForm()
        {
            ReMatchRegex();
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
                bool isMatch = r.IsMatch(TxtInput.Text);

                FillMatchesGrid(r);

                var replaceWith = Regex.Unescape(TxtReplaceWith.Text);
                TxtReplaced.Text = r.Replace(TxtInput.Text, replaceWith);

                TxtInput.BackColor = isMatch ? Color.Green : Color.FromKnownColor(KnownColor.Window);
                TxtRegex.BackColor = Color.FromKnownColor(KnownColor.Window);
                TxtError.Text = string.Empty;
            }
            catch (Exception ex)
            {
                TxtRegex.BackColor = Color.PaleVioletRed;
                TxtError.Text = ex.Message;
            }
        }

        private void FillMatchesGrid(Regex r)
        {
            var dt = new DataTable();
            //Zeilen
            foreach (var groupName in r.GetGroupNames())
            {
                dt.Columns.Add(groupName);
            } 
            foreach (Match match in r.Matches(TxtInput.Text))
            {
                //Spalten
                var row = dt.NewRow();

                r.GetGroupNumbers();
                row.ItemArray = match.Groups.Cast<Group>().Select(g => g.Value).ToArray();

                //row.ItemArray =
                //    match.Groups.Cast<Group>().Select(
                //        g => String.Format("V:{0};S:{1};I:{2};L:{3};C{4};", g.Value, g.Success, g.Index, g.Length,
                //                           g.Captures.Cast<Capture>().Select(
                //                               c => String.Format("<CV:{0};CI:{1};CL:{2};>", c.Value, c.Index, c.Length))
                //                               .Aggregate((a, b) => a + b))).ToArray();

                dt.Rows.Add(row);
            }

            MatchesBindingSource.DataSource = dt;
        }

        private void ClbRegexOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //wird als letztes Event in die eventloop geängt. Dann ist die CheckedItems Collection korrekt gefüllt
            BeginInvoke((MethodInvoker)ReEvaluateForm);
        }

        private void TxtRegex_TextChanged(object sender, EventArgs e)
        {
            ReEvaluateForm();
        }

        private void TxtText_TextChanged(object sender, EventArgs e)
        {
            ReEvaluateForm();
        }

        private void TxtReplaceWith_TextChanged(object sender, EventArgs e)
        {
            ReEvaluateForm();
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
