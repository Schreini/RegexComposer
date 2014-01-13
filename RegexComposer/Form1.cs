﻿using System;
using System.Collections.Generic;
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

                var sb = new StringBuilder();
                foreach (Match match in r.Matches(TxtInput.Text))
                {
//                    var enumerable = match.Groups.Cast<Group>().Select(g=>g.Captures);
                    var groups = new StringBuilder();
                    foreach (var group in match.Groups.Cast<Group>())
                    {
                        groups.AppendFormat("[Group|Success:{0};Length:{1};Index:{2};Value:{3}\r\n", group.Success,
                                            group.Length, group.Index, group.Value);
                        foreach (Capture capture in group.Captures)
                        {
                            groups.AppendFormat("\tCapture|Length:{0};Index:{1};Value:{2}]\r\n", 
                                                capture.Length, capture.Index, capture.Value);
                        }
                        groups.Append("]\r\n");
                    }
                    sb.AppendFormat("Pos:{0}; Groups:{1};\r\n{2}\r\n----------------------------------------------\r\n",
                                    match.Index, groups, match.Value);
                }
                TxtMatches.Text = sb.ToString();

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
