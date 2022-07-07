namespace Wordlin
{
    partial class MainForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("A");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("B");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("C");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("D");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("E");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("F");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("G");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("H");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("I");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("J");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("K");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("L");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("M");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("N");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("O");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("P");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Q");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("R");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("S");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("T");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("U");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("V");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("W");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("X");
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("Y");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("Z");
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("<-- SELECT A LETTER, THEN EDIT ITS RULE ABOVE ^");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("\'X\' BUTTON (OR ESC) CLEARS RULES");
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("LOAD A DIFERENT DICTIONARY WITH F1");
            this.pnlRule = new System.Windows.Forms.Panel();
            this.lblLetter = new System.Windows.Forms.Label();
            this.cmbSecondPosition = new System.Windows.Forms.ComboBox();
            this.cmbIsSecondPosition = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkIsSecondOccurence = new System.Windows.Forms.CheckBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.cmbIsPosition = new System.Windows.Forms.ComboBox();
            this.cmbInclude = new System.Windows.Forms.ComboBox();
            this.lstLetters = new System.Windows.Forms.ListView();
            this.lstWords = new System.Windows.Forms.ListView();
            this.ofdDictionary = new System.Windows.Forms.OpenFileDialog();
            this.pnlRule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRule
            // 
            this.pnlRule.Controls.Add(this.lblLetter);
            this.pnlRule.Controls.Add(this.cmbSecondPosition);
            this.pnlRule.Controls.Add(this.cmbIsSecondPosition);
            this.pnlRule.Controls.Add(this.btnClear);
            this.pnlRule.Controls.Add(this.chkIsSecondOccurence);
            this.pnlRule.Controls.Add(this.cmbPosition);
            this.pnlRule.Controls.Add(this.cmbIsPosition);
            this.pnlRule.Controls.Add(this.cmbInclude);
            this.pnlRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRule.Location = new System.Drawing.Point(0, 0);
            this.pnlRule.Margin = new System.Windows.Forms.Padding(6);
            this.pnlRule.Name = "pnlRule";
            this.pnlRule.Size = new System.Drawing.Size(863, 60);
            this.pnlRule.TabIndex = 1;
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(176, 18);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(0, 25);
            this.lblLetter.TabIndex = 1;
            // 
            // cmbSecondPosition
            // 
            this.cmbSecondPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondPosition.Enabled = false;
            this.cmbSecondPosition.FormattingEnabled = true;
            this.cmbSecondPosition.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbSecondPosition.Location = new System.Drawing.Point(757, 15);
            this.cmbSecondPosition.Margin = new System.Windows.Forms.Padding(6);
            this.cmbSecondPosition.Name = "cmbSecondPosition";
            this.cmbSecondPosition.Size = new System.Drawing.Size(96, 33);
            this.cmbSecondPosition.TabIndex = 5;
            this.cmbSecondPosition.SelectedIndexChanged += new System.EventHandler(this.cmbSecondPosition_SelectedIndexChanged);
            // 
            // cmbIsSecondPosition
            // 
            this.cmbIsSecondPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsSecondPosition.Enabled = false;
            this.cmbIsSecondPosition.FormattingEnabled = true;
            this.cmbIsSecondPosition.Items.AddRange(new object[] {
            "anywhere",
            "at position",
            "NOT at position"});
            this.cmbIsSecondPosition.Location = new System.Drawing.Point(549, 15);
            this.cmbIsSecondPosition.Margin = new System.Windows.Forms.Padding(6);
            this.cmbIsSecondPosition.Name = "cmbIsSecondPosition";
            this.cmbIsSecondPosition.Size = new System.Drawing.Size(196, 33);
            this.cmbIsSecondPosition.TabIndex = 4;
            this.cmbIsSecondPosition.SelectedIndexChanged += new System.EventHandler(this.cmbIsSecondPosition_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(38, 60);
            this.btnClear.TabIndex = 6;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkIsSecondOccurence
            // 
            this.chkIsSecondOccurence.AutoSize = true;
            this.chkIsSecondOccurence.Enabled = false;
            this.chkIsSecondOccurence.Location = new System.Drawing.Point(457, 17);
            this.chkIsSecondOccurence.Margin = new System.Windows.Forms.Padding(6);
            this.chkIsSecondOccurence.Name = "chkIsSecondOccurence";
            this.chkIsSecondOccurence.Size = new System.Drawing.Size(80, 29);
            this.chkIsSecondOccurence.TabIndex = 3;
            this.chkIsSecondOccurence.Text = "twice";
            this.chkIsSecondOccurence.UseVisualStyleBackColor = true;
            this.chkIsSecondOccurence.CheckedChanged += new System.EventHandler(this.chkIsSecondOccurence_CheckedChanged);
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Enabled = false;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbPosition.Location = new System.Drawing.Point(405, 15);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(6);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(40, 33);
            this.cmbPosition.TabIndex = 2;
            this.cmbPosition.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            // 
            // cmbIsPosition
            // 
            this.cmbIsPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsPosition.Enabled = false;
            this.cmbIsPosition.FormattingEnabled = true;
            this.cmbIsPosition.Items.AddRange(new object[] {
            "anywhere",
            "at position",
            "NOT at position"});
            this.cmbIsPosition.Location = new System.Drawing.Point(213, 15);
            this.cmbIsPosition.Margin = new System.Windows.Forms.Padding(6);
            this.cmbIsPosition.Name = "cmbIsPosition";
            this.cmbIsPosition.Size = new System.Drawing.Size(180, 33);
            this.cmbIsPosition.TabIndex = 2;
            this.cmbIsPosition.SelectedIndexChanged += new System.EventHandler(this.cmbIsPosition_SelectedIndexChanged);
            // 
            // cmbInclude
            // 
            this.cmbInclude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInclude.Enabled = false;
            this.cmbInclude.FormattingEnabled = true;
            this.cmbInclude.Items.AddRange(new object[] {
            "Ignore",
            "Include",
            "Exclude"});
            this.cmbInclude.Location = new System.Drawing.Point(47, 15);
            this.cmbInclude.Margin = new System.Windows.Forms.Padding(6);
            this.cmbInclude.Name = "cmbInclude";
            this.cmbInclude.Size = new System.Drawing.Size(120, 33);
            this.cmbInclude.TabIndex = 0;
            this.cmbInclude.SelectedIndexChanged += new System.EventHandler(this.cmbInclude_SelectedIndexChanged);
            // 
            // lstLetters
            // 
            this.lstLetters.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstLetters.FullRowSelect = true;
            this.lstLetters.HideSelection = false;
            this.lstLetters.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26});
            this.lstLetters.Location = new System.Drawing.Point(0, 60);
            this.lstLetters.Margin = new System.Windows.Forms.Padding(6);
            this.lstLetters.MultiSelect = false;
            this.lstLetters.Name = "lstLetters";
            this.lstLetters.ShowGroups = false;
            this.lstLetters.Size = new System.Drawing.Size(36, 701);
            this.lstLetters.TabIndex = 0;
            this.lstLetters.UseCompatibleStateImageBehavior = false;
            this.lstLetters.View = System.Windows.Forms.View.List;
            this.lstLetters.SelectedIndexChanged += new System.EventHandler(this.lstLetters_SelectedIndexChanged);
            this.lstLetters.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // lstWords
            // 
            this.lstWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWords.FullRowSelect = true;
            this.lstWords.HideSelection = false;
            this.lstWords.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem27,
            listViewItem28,
            listViewItem29});
            this.lstWords.LabelWrap = false;
            this.lstWords.Location = new System.Drawing.Point(36, 60);
            this.lstWords.Margin = new System.Windows.Forms.Padding(6);
            this.lstWords.MultiSelect = false;
            this.lstWords.Name = "lstWords";
            this.lstWords.ShowGroups = false;
            this.lstWords.Size = new System.Drawing.Size(827, 701);
            this.lstWords.TabIndex = 2;
            this.lstWords.TabStop = false;
            this.lstWords.UseCompatibleStateImageBehavior = false;
            this.lstWords.View = System.Windows.Forms.View.SmallIcon;
            this.lstWords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // ofdDictionary
            // 
            this.ofdDictionary.Filter = "Text|*.txt|All files|*.*";
            this.ofdDictionary.Title = "Load Dictionary";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(863, 761);
            this.Controls.Add(this.lstWords);
            this.Controls.Add(this.lstLetters);
            this.Controls.Add(this.pnlRule);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wordlin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.pnlRule.ResumeLayout(false);
            this.pnlRule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRule;
        private System.Windows.Forms.ComboBox cmbSecondPosition;
        private System.Windows.Forms.ComboBox cmbIsSecondPosition;
        private System.Windows.Forms.CheckBox chkIsSecondOccurence;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.ComboBox cmbIsPosition;
        private System.Windows.Forms.ComboBox cmbInclude;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lstLetters;
        private System.Windows.Forms.ListView lstWords;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.OpenFileDialog ofdDictionary;
    }
}