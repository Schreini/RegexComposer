namespace RegexComposer
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRegex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.ClbRegexOptions = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtError = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtHelp = new System.Windows.Forms.TextBox();
            this.TxtReplaceWith = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtReplaced = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMatches = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regex";
            // 
            // TxtRegex
            // 
            this.TxtRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRegex.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegex.Location = new System.Drawing.Point(90, 5);
            this.TxtRegex.Name = "TxtRegex";
            this.TxtRegex.Size = new System.Drawing.Size(719, 20);
            this.TxtRegex.TabIndex = 1;
            this.TxtRegex.TextChanged += new System.EventHandler(this.TxtRegex_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input";
            // 
            // TxtInput
            // 
            this.TxtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.Location = new System.Drawing.Point(90, 32);
            this.TxtInput.Multiline = true;
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtInput.Size = new System.Drawing.Size(719, 116);
            this.TxtInput.TabIndex = 3;
            this.TxtInput.TextChanged += new System.EventHandler(this.TxtText_TextChanged);
            // 
            // ClbRegexOptions
            // 
            this.ClbRegexOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClbRegexOptions.CheckOnClick = true;
            this.ClbRegexOptions.FormattingEnabled = true;
            this.ClbRegexOptions.Location = new System.Drawing.Point(815, 24);
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
            this.label3.Location = new System.Drawing.Point(13, 534);
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
            this.TxtError.Location = new System.Drawing.Point(90, 527);
            this.TxtError.Name = "TxtError";
            this.TxtError.ReadOnly = true;
            this.TxtError.Size = new System.Drawing.Size(889, 20);
            this.TxtError.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(815, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RegexOptions";
            // 
            // TxtHelp
            // 
            this.TxtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHelp.HideSelection = false;
            this.TxtHelp.Location = new System.Drawing.Point(815, 155);
            this.TxtHelp.Multiline = true;
            this.TxtHelp.Name = "TxtHelp";
            this.TxtHelp.ReadOnly = true;
            this.TxtHelp.Size = new System.Drawing.Size(164, 366);
            this.TxtHelp.TabIndex = 8;
            this.TxtHelp.Text = "Multiline: \r\n^ und $ matchen Zeilenanfang und Ende und nicht mehr Text Anfang und" +
    " Ende\r\n\r\nSingleline:\r\n. (Punkt) matcht auch \\n\r\n\r\nReplace With Text wird Unescap" +
    "ed -> \\r\\n ergibt ein Newline\r\n";
            // 
            // TxtReplaceWith
            // 
            this.TxtReplaceWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtReplaceWith.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReplaceWith.Location = new System.Drawing.Point(90, 281);
            this.TxtReplaceWith.Name = "TxtReplaceWith";
            this.TxtReplaceWith.Size = new System.Drawing.Size(719, 20);
            this.TxtReplaceWith.TabIndex = 9;
            this.TxtReplaceWith.TextChanged += new System.EventHandler(this.TxtReplaceWith_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Replace with";
            // 
            // TxtReplaced
            // 
            this.TxtReplaced.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtReplaced.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReplaced.HideSelection = false;
            this.TxtReplaced.Location = new System.Drawing.Point(90, 307);
            this.TxtReplaced.Multiline = true;
            this.TxtReplaced.Name = "TxtReplaced";
            this.TxtReplaced.ReadOnly = true;
            this.TxtReplaced.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtReplaced.Size = new System.Drawing.Size(719, 115);
            this.TxtReplaced.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Replaced";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Matches";
            // 
            // TxtMatches
            // 
            this.TxtMatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMatches.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatches.HideSelection = false;
            this.TxtMatches.Location = new System.Drawing.Point(90, 158);
            this.TxtMatches.Multiline = true;
            this.TxtMatches.Name = "TxtMatches";
            this.TxtMatches.ReadOnly = true;
            this.TxtMatches.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtMatches.Size = new System.Drawing.Size(719, 116);
            this.TxtMatches.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 556);
            this.Controls.Add(this.TxtMatches);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtReplaced);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtReplaceWith);
            this.Controls.Add(this.TxtHelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClbRegexOptions);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRegex);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox TxtMatches;
    }
}

