﻿namespace RegexComposer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRegex = new System.Windows.Forms.TextBox();
            this.CmsRegex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.ClbRegexOptions = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtError = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtHelp = new System.Windows.Forms.TextBox();
            this.TxtReplaceWith = new System.Windows.Forms.TextBox();
            this.CmsReplaceWith = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.TxtReplaced = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GrdMatches = new System.Windows.Forms.DataGridView();
            this.MatchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpcRegexReplace = new System.Windows.Forms.SplitContainer();
            this.BtnRegexInsert = new System.Windows.Forms.Button();
            this.BtnReplaceInsert = new System.Windows.Forms.Button();
            this.SpcMainMatches = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpcRegexReplace)).BeginInit();
            this.SpcRegexReplace.Panel1.SuspendLayout();
            this.SpcRegexReplace.Panel2.SuspendLayout();
            this.SpcRegexReplace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcMainMatches)).BeginInit();
            this.SpcMainMatches.Panel1.SuspendLayout();
            this.SpcMainMatches.Panel2.SuspendLayout();
            this.SpcMainMatches.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regex";
            // 
            // TxtRegex
            // 
            this.TxtRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRegex.ContextMenuStrip = this.CmsRegex;
            this.TxtRegex.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegex.HideSelection = false;
            this.TxtRegex.Location = new System.Drawing.Point(245, 2);
            this.TxtRegex.Name = "TxtRegex";
            this.TxtRegex.Size = new System.Drawing.Size(778, 20);
            this.TxtRegex.TabIndex = 0;
            this.TxtRegex.TextChanged += new System.EventHandler(this.TxtRegex_TextChanged);
            // 
            // CmsRegex
            // 
            this.CmsRegex.Name = "CmsRegexInsert";
            this.CmsRegex.ShowImageMargin = false;
            this.CmsRegex.Size = new System.Drawing.Size(36, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input";
            // 
            // TxtInput
            // 
            this.TxtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.HideSelection = false;
            this.TxtInput.Location = new System.Drawing.Point(3, 25);
            this.TxtInput.MaxLength = 999999999;
            this.TxtInput.Multiline = true;
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtInput.Size = new System.Drawing.Size(434, 269);
            this.TxtInput.TabIndex = 1;
            this.TxtInput.WordWrap = false;
            this.TxtInput.TextChanged += new System.EventHandler(this.TxtText_TextChanged);
            this.TxtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_SuppressBing);
            this.TxtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_SelectAll);
            // 
            // ClbRegexOptions
            // 
            this.ClbRegexOptions.CheckOnClick = true;
            this.ClbRegexOptions.FormattingEnabled = true;
            this.ClbRegexOptions.Location = new System.Drawing.Point(0, 16);
            this.ClbRegexOptions.Name = "ClbRegexOptions";
            this.ClbRegexOptions.Size = new System.Drawing.Size(164, 124);
            this.ClbRegexOptions.Sorted = true;
            this.ClbRegexOptions.TabIndex = 4;
            this.ClbRegexOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbRegexOptions_ItemCheck);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Error";
            // 
            // TxtError
            // 
            this.TxtError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtError.HideSelection = false;
            this.TxtError.Location = new System.Drawing.Point(90, 542);
            this.TxtError.Name = "TxtError";
            this.TxtError.ReadOnly = true;
            this.TxtError.Size = new System.Drawing.Size(976, 20);
            this.TxtError.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RegexOptions";
            // 
            // TxtHelp
            // 
            this.TxtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtHelp.HideSelection = false;
            this.TxtHelp.Location = new System.Drawing.Point(0, 146);
            this.TxtHelp.Multiline = true;
            this.TxtHelp.Name = "TxtHelp";
            this.TxtHelp.ReadOnly = true;
            this.TxtHelp.Size = new System.Drawing.Size(164, 205);
            this.TxtHelp.TabIndex = 8;
            this.TxtHelp.Text = "Multiline: \r\n^ und $ matchen Zeilenanfang und Ende und nicht mehr Text Anfang und" +
    " Ende\r\n\r\nSingleline:\r\n. (Punkt) matcht auch \\n\r\n\r\nReplace With Text wird Unescap" +
    "ed -> \\r\\n ergibt ein Newline\r\n";
            // 
            // TxtReplaceWith
            // 
            this.TxtReplaceWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtReplaceWith.ContextMenuStrip = this.CmsReplaceWith;
            this.TxtReplaceWith.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReplaceWith.HideSelection = false;
            this.TxtReplaceWith.Location = new System.Drawing.Point(245, 28);
            this.TxtReplaceWith.Name = "TxtReplaceWith";
            this.TxtReplaceWith.Size = new System.Drawing.Size(778, 20);
            this.TxtReplaceWith.TabIndex = 0;
            this.TxtReplaceWith.TextChanged += new System.EventHandler(this.TxtReplaceWith_TextChanged);
            // 
            // CmsReplaceWith
            // 
            this.CmsReplaceWith.Name = "CmsReplaceWith";
            this.CmsReplaceWith.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Replace with";
            // 
            // TxtReplaced
            // 
            this.TxtReplaced.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtReplaced.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReplaced.HideSelection = false;
            this.TxtReplaced.Location = new System.Drawing.Point(3, 25);
            this.TxtReplaced.MaxLength = 999999999;
            this.TxtReplaced.Multiline = true;
            this.TxtReplaced.Name = "TxtReplaced";
            this.TxtReplaced.ReadOnly = true;
            this.TxtReplaced.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtReplaced.Size = new System.Drawing.Size(430, 269);
            this.TxtReplaced.TabIndex = 11;
            this.TxtReplaced.WordWrap = false;
            this.TxtReplaced.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_SuppressBing);
            this.TxtReplaced.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_SelectAll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Replaced";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Matches";
            // 
            // GrdMatches
            // 
            this.GrdMatches.AllowUserToAddRows = false;
            this.GrdMatches.AllowUserToDeleteRows = false;
            this.GrdMatches.AllowUserToOrderColumns = true;
            this.GrdMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdMatches.AutoGenerateColumns = false;
            this.GrdMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrdMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrdMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdMatches.DataSource = this.MatchesBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdMatches.DefaultCellStyle = dataGridViewCellStyle1;
            this.GrdMatches.Location = new System.Drawing.Point(78, 3);
            this.GrdMatches.Name = "GrdMatches";
            this.GrdMatches.ReadOnly = true;
            this.GrdMatches.Size = new System.Drawing.Size(969, 160);
            this.GrdMatches.TabIndex = 15;
            this.GrdMatches.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GrdMatches_Scroll);
            // 
            // SpcRegexReplace
            // 
            this.SpcRegexReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpcRegexReplace.Location = new System.Drawing.Point(170, 54);
            this.SpcRegexReplace.Name = "SpcRegexReplace";
            // 
            // SpcRegexReplace.Panel1
            // 
            this.SpcRegexReplace.Panel1.Controls.Add(this.TxtInput);
            this.SpcRegexReplace.Panel1.Controls.Add(this.label2);
            // 
            // SpcRegexReplace.Panel2
            // 
            this.SpcRegexReplace.Panel2.Controls.Add(this.TxtReplaced);
            this.SpcRegexReplace.Panel2.Controls.Add(this.label6);
            this.SpcRegexReplace.Size = new System.Drawing.Size(880, 297);
            this.SpcRegexReplace.SplitterDistance = 440;
            this.SpcRegexReplace.TabIndex = 16;
            this.SpcRegexReplace.Paint += new System.Windows.Forms.PaintEventHandler(this.SpcRegexReplace_Paint);
            this.SpcRegexReplace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpcRegexReplace_MouseDown);
            this.SpcRegexReplace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SpcRegexReplace_MouseMove);
            this.SpcRegexReplace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SpcRegexReplace_MouseUp);
            // 
            // BtnRegexInsert
            // 
            this.BtnRegexInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegexInsert.Location = new System.Drawing.Point(1029, 0);
            this.BtnRegexInsert.Name = "BtnRegexInsert";
            this.BtnRegexInsert.Size = new System.Drawing.Size(25, 22);
            this.BtnRegexInsert.TabIndex = 3;
            this.BtnRegexInsert.Text = "...";
            this.BtnRegexInsert.UseVisualStyleBackColor = true;
            this.BtnRegexInsert.Click += new System.EventHandler(this.BtnRegexInsert_Click);
            // 
            // BtnReplaceInsert
            // 
            this.BtnReplaceInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReplaceInsert.Location = new System.Drawing.Point(1029, 26);
            this.BtnReplaceInsert.Name = "BtnReplaceInsert";
            this.BtnReplaceInsert.Size = new System.Drawing.Size(25, 22);
            this.BtnReplaceInsert.TabIndex = 4;
            this.BtnReplaceInsert.Text = "...";
            this.BtnReplaceInsert.UseVisualStyleBackColor = true;
            this.BtnReplaceInsert.Click += new System.EventHandler(this.BtnReplaceInsert_Click);
            // 
            // SpcMainMatches
            // 
            this.SpcMainMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpcMainMatches.Location = new System.Drawing.Point(12, 12);
            this.SpcMainMatches.Name = "SpcMainMatches";
            this.SpcMainMatches.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpcMainMatches.Panel1
            // 
            this.SpcMainMatches.Panel1.Controls.Add(this.BtnReplaceInsert);
            this.SpcMainMatches.Panel1.Controls.Add(this.BtnRegexInsert);
            this.SpcMainMatches.Panel1.Controls.Add(this.TxtRegex);
            this.SpcMainMatches.Panel1.Controls.Add(this.TxtReplaceWith);
            this.SpcMainMatches.Panel1.Controls.Add(this.TxtHelp);
            this.SpcMainMatches.Panel1.Controls.Add(this.label5);
            this.SpcMainMatches.Panel1.Controls.Add(this.SpcRegexReplace);
            this.SpcMainMatches.Panel1.Controls.Add(this.label1);
            this.SpcMainMatches.Panel1.Controls.Add(this.ClbRegexOptions);
            this.SpcMainMatches.Panel1.Controls.Add(this.label4);
            // 
            // SpcMainMatches.Panel2
            // 
            this.SpcMainMatches.Panel2.Controls.Add(this.GrdMatches);
            this.SpcMainMatches.Panel2.Controls.Add(this.label7);
            this.SpcMainMatches.Size = new System.Drawing.Size(1054, 524);
            this.SpcMainMatches.SplitterDistance = 354;
            this.SpcMainMatches.TabIndex = 0;
            this.SpcMainMatches.Paint += new System.Windows.Forms.PaintEventHandler(this.SpcRegexReplace_Paint);
            this.SpcMainMatches.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpcRegexReplace_MouseDown);
            this.SpcMainMatches.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SpcRegexReplace_MouseMove);
            this.SpcMainMatches.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SpcRegexReplace_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 571);
            this.Controls.Add(this.SpcMainMatches);
            this.Controls.Add(this.TxtError);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Regex Composer";
            ((System.ComponentModel.ISupportInitialize)(this.GrdMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatchesBindingSource)).EndInit();
            this.SpcRegexReplace.Panel1.ResumeLayout(false);
            this.SpcRegexReplace.Panel1.PerformLayout();
            this.SpcRegexReplace.Panel2.ResumeLayout(false);
            this.SpcRegexReplace.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcRegexReplace)).EndInit();
            this.SpcRegexReplace.ResumeLayout(false);
            this.SpcMainMatches.Panel1.ResumeLayout(false);
            this.SpcMainMatches.Panel1.PerformLayout();
            this.SpcMainMatches.Panel2.ResumeLayout(false);
            this.SpcMainMatches.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcMainMatches)).EndInit();
            this.SpcMainMatches.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRegex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.CheckedListBox ClbRegexOptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtHelp;
        private System.Windows.Forms.TextBox TxtReplaceWith;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtReplaced;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GrdMatches;
        private System.Windows.Forms.BindingSource MatchesBindingSource;
        private System.Windows.Forms.SplitContainer SpcRegexReplace;
        private System.Windows.Forms.SplitContainer SpcMainMatches;
        private System.Windows.Forms.Button BtnRegexInsert;
        private System.Windows.Forms.Button BtnReplaceInsert;
        private System.Windows.Forms.ContextMenuStrip CmsRegex;
        private System.Windows.Forms.ContextMenuStrip CmsReplaceWith;
    }
}

