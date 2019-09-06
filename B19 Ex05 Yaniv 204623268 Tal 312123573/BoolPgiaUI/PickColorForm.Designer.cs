namespace BoolPgiaUI
{
    partial class PickColorForm
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
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonSky = new System.Windows.Forms.Button();
            this.buttonPirple = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonPink = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRed.Location = new System.Drawing.Point(20, 12);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(63, 54);
            this.buttonRed.TabIndex = 0;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonSky
            // 
            this.buttonSky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSky.Location = new System.Drawing.Point(105, 12);
            this.buttonSky.Name = "buttonSky";
            this.buttonSky.Size = new System.Drawing.Size(63, 54);
            this.buttonSky.TabIndex = 1;
            this.buttonSky.UseVisualStyleBackColor = false;
            this.buttonSky.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonPirple
            // 
            this.buttonPirple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonPirple.Location = new System.Drawing.Point(190, 12);
            this.buttonPirple.Name = "buttonPirple";
            this.buttonPirple.Size = new System.Drawing.Size(63, 54);
            this.buttonPirple.TabIndex = 2;
            this.buttonPirple.UseVisualStyleBackColor = false;
            this.buttonPirple.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonOrange.Location = new System.Drawing.Point(275, 12);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(63, 54);
            this.buttonOrange.TabIndex = 3;
            this.buttonOrange.UseVisualStyleBackColor = false;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGreen.Location = new System.Drawing.Point(20, 81);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(63, 54);
            this.buttonGreen.TabIndex = 4;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(105, 81);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(63, 54);
            this.buttonBlue.TabIndex = 5;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonPink
            // 
            this.buttonPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonPink.Location = new System.Drawing.Point(190, 81);
            this.buttonPink.Name = "buttonPink";
            this.buttonPink.Size = new System.Drawing.Size(63, 54);
            this.buttonPink.TabIndex = 6;
            this.buttonPink.UseVisualStyleBackColor = false;
            this.buttonPink.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonYellow.Location = new System.Drawing.Point(275, 81);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(63, 54);
            this.buttonYellow.TabIndex = 7;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // PickColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 147);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonPink);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonOrange);
            this.Controls.Add(this.buttonPirple);
            this.Controls.Add(this.buttonSky);
            this.Controls.Add(this.buttonRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PickColorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick a color:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonSky;
        private System.Windows.Forms.Button buttonPirple;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonPink;
        private System.Windows.Forms.Button buttonYellow;
    }
}