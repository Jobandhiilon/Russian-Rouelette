namespace Rouelette
{
    partial class roulette
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
            this.welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.btnrules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Silver;
            this.welcome.Location = new System.Drawing.Point(241, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(267, 63);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome";
            this.welcome.Click += new System.EventHandler(this.welcome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(38, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(672, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Russian Roulette Game";
            this.label2.Click += new System.EventHandler(this.game_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(340, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "To";
            this.label1.Click += new System.EventHandler(this.to_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(42, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please enter your name ";
            this.label4.Click += new System.EventHandler(this.entername_click);
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Black;
            this.btnstart.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnstart.Location = new System.Drawing.Point(617, 295);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(113, 34);
            this.btnstart.TabIndex = 5;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // textname
            // 
            this.textname.BackColor = System.Drawing.Color.Gainsboro;
            this.textname.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.ForeColor = System.Drawing.Color.Black;
            this.textname.Location = new System.Drawing.Point(569, 236);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(199, 34);
            this.textname.TabIndex = 6;
            this.textname.TextChanged += new System.EventHandler(this.textname_TextChanged);
            // 
            // btnrules
            // 
            this.btnrules.BackColor = System.Drawing.Color.Black;
            this.btnrules.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrules.ForeColor = System.Drawing.Color.White;
            this.btnrules.Location = new System.Drawing.Point(619, 335);
            this.btnrules.Name = "btnrules";
            this.btnrules.Size = new System.Drawing.Size(111, 33);
            this.btnrules.TabIndex = 7;
            this.btnrules.Text = "RULES";
            this.btnrules.UseVisualStyleBackColor = false;
            this.btnrules.Click += new System.EventHandler(this.btnrules_Click);
            // 
            // roulette
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrules);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcome);
            this.Name = "roulette";
            this.Load += new System.EventHandler(this.roulette_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Button btnrules;
    }
}

