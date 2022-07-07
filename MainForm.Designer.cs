namespace Wordlin
{
    partial class MainForm
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
            this.grpGuesses = new System.Windows.Forms.GroupBox();
            this.btnSetRules = new System.Windows.Forms.Button();
            this.btnLetter5 = new System.Windows.Forms.Button();
            this.btnLetter4 = new System.Windows.Forms.Button();
            this.btnLetter3 = new System.Windows.Forms.Button();
            this.btnLetter2 = new System.Windows.Forms.Button();
            this.btnLetter1 = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.MaskedTextBox();
            this.grpRules = new System.Windows.Forms.GroupBox();
            this.lstRules = new System.Windows.Forms.ListView();
            this.btnClearRules = new System.Windows.Forms.Button();
            this.grpSuggestions = new System.Windows.Forms.GroupBox();
            this.lstSuggestions = new System.Windows.Forms.ListView();
            this.grpGuesses.SuspendLayout();
            this.grpRules.SuspendLayout();
            this.grpSuggestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGuesses
            // 
            this.grpGuesses.Controls.Add(this.btnSetRules);
            this.grpGuesses.Controls.Add(this.btnLetter5);
            this.grpGuesses.Controls.Add(this.btnLetter4);
            this.grpGuesses.Controls.Add(this.btnLetter3);
            this.grpGuesses.Controls.Add(this.btnLetter2);
            this.grpGuesses.Controls.Add(this.btnLetter1);
            this.grpGuesses.Controls.Add(this.txtGuess);
            this.grpGuesses.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGuesses.Location = new System.Drawing.Point(0, 0);
            this.grpGuesses.Name = "grpGuesses";
            this.grpGuesses.Size = new System.Drawing.Size(464, 67);
            this.grpGuesses.TabIndex = 0;
            this.grpGuesses.TabStop = false;
            this.grpGuesses.Text = "Guesses";
            // 
            // btnSetRules
            // 
            this.btnSetRules.Location = new System.Drawing.Point(283, 30);
            this.btnSetRules.Name = "btnSetRules";
            this.btnSetRules.Size = new System.Drawing.Size(120, 31);
            this.btnSetRules.TabIndex = 6;
            this.btnSetRules.Text = "Set Rules";
            this.btnSetRules.UseVisualStyleBackColor = true;
            this.btnSetRules.Click += new System.EventHandler(this.btnSetRules_Click);
            // 
            // btnLetter5
            // 
            this.btnLetter5.BackColor = System.Drawing.Color.White;
            this.btnLetter5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter5.Location = new System.Drawing.Point(246, 30);
            this.btnLetter5.Name = "btnLetter5";
            this.btnLetter5.Size = new System.Drawing.Size(31, 31);
            this.btnLetter5.TabIndex = 5;
            this.btnLetter5.UseVisualStyleBackColor = false;
            this.btnLetter5.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnLetter4
            // 
            this.btnLetter4.BackColor = System.Drawing.Color.White;
            this.btnLetter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter4.Location = new System.Drawing.Point(209, 30);
            this.btnLetter4.Name = "btnLetter4";
            this.btnLetter4.Size = new System.Drawing.Size(31, 31);
            this.btnLetter4.TabIndex = 4;
            this.btnLetter4.UseVisualStyleBackColor = false;
            this.btnLetter4.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnLetter3
            // 
            this.btnLetter3.BackColor = System.Drawing.Color.White;
            this.btnLetter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter3.Location = new System.Drawing.Point(172, 30);
            this.btnLetter3.Name = "btnLetter3";
            this.btnLetter3.Size = new System.Drawing.Size(31, 31);
            this.btnLetter3.TabIndex = 3;
            this.btnLetter3.UseVisualStyleBackColor = false;
            this.btnLetter3.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnLetter2
            // 
            this.btnLetter2.BackColor = System.Drawing.Color.White;
            this.btnLetter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter2.Location = new System.Drawing.Point(135, 30);
            this.btnLetter2.Name = "btnLetter2";
            this.btnLetter2.Size = new System.Drawing.Size(31, 31);
            this.btnLetter2.TabIndex = 2;
            this.btnLetter2.UseVisualStyleBackColor = false;
            this.btnLetter2.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnLetter1
            // 
            this.btnLetter1.BackColor = System.Drawing.Color.White;
            this.btnLetter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter1.Location = new System.Drawing.Point(98, 30);
            this.btnLetter1.Name = "btnLetter1";
            this.btnLetter1.Size = new System.Drawing.Size(31, 31);
            this.btnLetter1.TabIndex = 1;
            this.btnLetter1.UseVisualStyleBackColor = false;
            this.btnLetter1.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.AsciiOnly = true;
            this.txtGuess.Location = new System.Drawing.Point(12, 30);
            this.txtGuess.Mask = "?????";
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(80, 31);
            this.txtGuess.TabIndex = 0;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // grpRules
            // 
            this.grpRules.Controls.Add(this.lstRules);
            this.grpRules.Controls.Add(this.btnClearRules);
            this.grpRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRules.Location = new System.Drawing.Point(0, 67);
            this.grpRules.Name = "grpRules";
            this.grpRules.Size = new System.Drawing.Size(464, 188);
            this.grpRules.TabIndex = 1;
            this.grpRules.TabStop = false;
            this.grpRules.Text = "Rules";
            // 
            // lstRules
            // 
            this.lstRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRules.HideSelection = false;
            this.lstRules.LabelWrap = false;
            this.lstRules.Location = new System.Drawing.Point(12, 30);
            this.lstRules.Name = "lstRules";
            this.lstRules.Size = new System.Drawing.Size(403, 152);
            this.lstRules.TabIndex = 1;
            this.lstRules.UseCompatibleStateImageBehavior = false;
            // 
            // btnClearRules
            // 
            this.btnClearRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearRules.Location = new System.Drawing.Point(421, 30);
            this.btnClearRules.Name = "btnClearRules";
            this.btnClearRules.Size = new System.Drawing.Size(31, 152);
            this.btnClearRules.TabIndex = 0;
            this.btnClearRules.Text = "X";
            this.btnClearRules.UseVisualStyleBackColor = true;
            this.btnClearRules.Click += new System.EventHandler(this.btnClearRules_Click);
            // 
            // grpSuggestions
            // 
            this.grpSuggestions.Controls.Add(this.lstSuggestions);
            this.grpSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSuggestions.Location = new System.Drawing.Point(0, 255);
            this.grpSuggestions.Name = "grpSuggestions";
            this.grpSuggestions.Size = new System.Drawing.Size(464, 506);
            this.grpSuggestions.TabIndex = 2;
            this.grpSuggestions.TabStop = false;
            this.grpSuggestions.Text = "Suggestions";
            // 
            // lstSuggestions
            // 
            this.lstSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSuggestions.HideSelection = false;
            this.lstSuggestions.LabelWrap = false;
            this.lstSuggestions.Location = new System.Drawing.Point(3, 27);
            this.lstSuggestions.MultiSelect = false;
            this.lstSuggestions.Name = "lstSuggestions";
            this.lstSuggestions.Size = new System.Drawing.Size(458, 476);
            this.lstSuggestions.TabIndex = 2;
            this.lstSuggestions.UseCompatibleStateImageBehavior = false;
            this.lstSuggestions.View = System.Windows.Forms.View.SmallIcon;
            this.lstSuggestions.SelectedIndexChanged += new System.EventHandler(this.lstSuggestions_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSetRules;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClearRules;
            this.ClientSize = new System.Drawing.Size(464, 761);
            this.Controls.Add(this.grpSuggestions);
            this.Controls.Add(this.grpRules);
            this.Controls.Add(this.grpGuesses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wordlin";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpGuesses.ResumeLayout(false);
            this.grpGuesses.PerformLayout();
            this.grpRules.ResumeLayout(false);
            this.grpSuggestions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpGuesses;
        private System.Windows.Forms.Button btnSetRules;
        private System.Windows.Forms.Button btnLetter5;
        private System.Windows.Forms.Button btnLetter4;
        private System.Windows.Forms.Button btnLetter3;
        private System.Windows.Forms.Button btnLetter2;
        private System.Windows.Forms.Button btnLetter1;
        private System.Windows.Forms.MaskedTextBox txtGuess;
        private System.Windows.Forms.GroupBox grpRules;
        private System.Windows.Forms.ListView lstRules;
        private System.Windows.Forms.Button btnClearRules;
        private System.Windows.Forms.GroupBox grpSuggestions;
        private System.Windows.Forms.ListView lstSuggestions;
    }
}