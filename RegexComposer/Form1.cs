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

        private void SpcRegexReplace_Paint(object sender, PaintEventArgs e)
        {
            var control = sender as SplitContainer;
            //paint the three dots'
            Point[] points = new Point[3];
            var w = control.Width;
            var h = control.Height;
            var d = control.SplitterDistance;
            var sW = control.SplitterWidth;

            //calculate the position of the points'
            if (control.Orientation == Orientation.Horizontal)
            {
                points[0] = new Point((w / 2), d + (sW / 2));
                points[1] = new Point(points[0].X - 10, points[0].Y);
                points[2] = new Point(points[0].X + 10, points[0].Y);
            }
            else
            {
                points[0] = new Point(d + (sW / 2), (h / 2));
                points[1] = new Point(points[0].X, points[0].Y - 10);
                points[2] = new Point(points[0].X, points[0].Y + 10);
            }

            foreach (Point p in points)
            {
                p.Offset(-2, -2);
                e.Graphics.FillEllipse(SystemBrushes.ControlDark,
                    new Rectangle(p, new Size(3, 3)));

                p.Offset(1, 1);
                e.Graphics.FillEllipse(SystemBrushes.ControlLight,
                    new Rectangle(p, new Size(3, 3)));
            }
        }

        private void SpcRegexReplace_MouseDown(object sender, MouseEventArgs e)
        {
            var container = sender as SplitContainer;
            if (container == null)
                return;

            container.IsSplitterFixed = true;
        }

        private void SpcRegexReplace_MouseUp(object sender, MouseEventArgs e)
        {
            var container = sender as SplitContainer;
            if (container == null)
                return;

            container.IsSplitterFixed = false;
        }

        private void SpcRegexReplace_MouseMove(object sender, MouseEventArgs e)
        {
            var container = sender as SplitContainer;
            if (container == null)
                return;

            // Check to make sure the splitter won't be updated by the
            // normal move behavior also
            if (container.IsSplitterFixed)
            {
                // Make sure that the button used to move the splitter
                // is the left mouse button
                if (e.Button.Equals(MouseButtons.Left))
                {
                    // Checks to see if the splitter is aligned Vertically
                    if (container.Orientation.Equals(Orientation.Vertical))
                    {
                        // Only move the splitter if the mouse is within
                        // the appropriate bounds
                        if (e.X > 0 && e.X < container.Width)
                        {
                            // Move the splitter & force a visual refresh
                            container.SplitterDistance = e.X;
                            container.Refresh();
                        }
                    }
                    // If it isn't aligned vertically then it must be
                    // horizontal
                    else
                    {
                        // Only move the splitter if the mouse is within
                        // the appropriate bounds
                        if (e.Y > 0 && e.Y < container.Height)
                        {
                            // Move the splitter & force a visual refresh
                            container.SplitterDistance = e.Y;
                            container.Refresh();
                        }
                    }
                }
                // If a button other than left is pressed or no button
                // at all
                else
                {
                    // This allows the splitter to be moved normally again
                    container.IsSplitterFixed = false;
                }
            }
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
