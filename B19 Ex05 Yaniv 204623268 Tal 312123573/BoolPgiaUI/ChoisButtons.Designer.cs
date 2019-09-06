namespace BoolPgiaUI
{
    partial class ChoisButtons
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChoiseButton4 = new System.Windows.Forms.Button();
            this.ChoiseButton3 = new System.Windows.Forms.Button();
            this.ChoiseButton2 = new System.Windows.Forms.Button();
            this.ChoiseButton1 = new System.Windows.Forms.Button();
            this.CheckResButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChoiseButton4
            // 
            this.ChoiseButton4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ChoiseButton4.Enabled = false;
            this.ChoiseButton4.Location = new System.Drawing.Point(186, 3);
            this.ChoiseButton4.Name = "ChoiseButton4";
            this.ChoiseButton4.Size = new System.Drawing.Size(55, 51);
            this.ChoiseButton4.TabIndex = 30;
            this.ChoiseButton4.UseVisualStyleBackColor = false;
            this.ChoiseButton4.Click += new System.EventHandler(this.choiseButtonOnClick);
            // 
            // ChoiseButton3
            // 
            this.ChoiseButton3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ChoiseButton3.Enabled = false;
            this.ChoiseButton3.Location = new System.Drawing.Point(125, 3);
            this.ChoiseButton3.Name = "ChoiseButton3";
            this.ChoiseButton3.Size = new System.Drawing.Size(55, 51);
            this.ChoiseButton3.TabIndex = 29;
            this.ChoiseButton3.UseVisualStyleBackColor = false;
            this.ChoiseButton3.Click += new System.EventHandler(this.choiseButtonOnClick);
            // 
            // ChoiseButton2
            // 
            this.ChoiseButton2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ChoiseButton2.Enabled = false;
            this.ChoiseButton2.Location = new System.Drawing.Point(64, 3);
            this.ChoiseButton2.Name = "ChoiseButton2";
            this.ChoiseButton2.Size = new System.Drawing.Size(55, 51);
            this.ChoiseButton2.TabIndex = 28;
            this.ChoiseButton2.UseVisualStyleBackColor = false;
            this.ChoiseButton2.Click += new System.EventHandler(this.choiseButtonOnClick);
            // 
            // ChoiseButton1
            // 
            this.ChoiseButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ChoiseButton1.Enabled = false;
            this.ChoiseButton1.Location = new System.Drawing.Point(3, 3);
            this.ChoiseButton1.Name = "ChoiseButton1";
            this.ChoiseButton1.Size = new System.Drawing.Size(55, 51);
            this.ChoiseButton1.TabIndex = 27;
            this.ChoiseButton1.UseVisualStyleBackColor = false;
            this.ChoiseButton1.Click += new System.EventHandler(this.choiseButtonOnClick);
            // 
            // CheckResButton
            // 
            this.CheckResButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CheckResButton.Enabled = false;
            this.CheckResButton.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckResButton.Location = new System.Drawing.Point(253, 12);
            this.CheckResButton.Name = "CheckResButton";
            this.CheckResButton.Size = new System.Drawing.Size(43, 32);
            this.CheckResButton.TabIndex = 26;
            this.CheckResButton.Text = ">>";
            this.CheckResButton.UseVisualStyleBackColor = false;
            this.CheckResButton.Click += new System.EventHandler(this.checkResButtonOnClick);
            // 
            // ChoisButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChoiseButton4);
            this.Controls.Add(this.ChoiseButton3);
            this.Controls.Add(this.ChoiseButton2);
            this.Controls.Add(this.ChoiseButton1);
            this.Controls.Add(this.CheckResButton);
            this.Name = "ChoisButtons";
            this.Size = new System.Drawing.Size(301, 58);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CheckResButton;
        internal System.Windows.Forms.Button ChoiseButton4;
        internal System.Windows.Forms.Button ChoiseButton3;
        internal System.Windows.Forms.Button ChoiseButton2;
        internal System.Windows.Forms.Button ChoiseButton1;
    }
}
