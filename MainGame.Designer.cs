namespace Rouelette
{
    partial class russian
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
            this.shot_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Shoot_picbox = new System.Windows.Forms.PictureBox();
            this.btnagain = new System.Windows.Forms.Button();
            this.btnspin = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Shoot_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // shot_btn
            // 
            this.shot_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shot_btn.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shot_btn.ForeColor = System.Drawing.Color.White;
            this.shot_btn.Location = new System.Drawing.Point(58, 238);
            this.shot_btn.Name = "shot_btn";
            this.shot_btn.Size = new System.Drawing.Size(125, 55);
            this.shot_btn.TabIndex = 3;
            this.shot_btn.Text = "SHOT";
            this.shot_btn.UseVisualStyleBackColor = false;
            this.shot_btn.Click += new System.EventHandler(this.shot_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(58, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Shoot_picbox
            // 
            this.Shoot_picbox.Location = new System.Drawing.Point(403, 238);
            this.Shoot_picbox.Name = "Shoot_picbox";
            this.Shoot_picbox.Size = new System.Drawing.Size(350, 175);
            this.Shoot_picbox.TabIndex = 4;
            this.Shoot_picbox.TabStop = false;
            this.Shoot_picbox.Click += new System.EventHandler(this.picbox_Click);
            // 
            // btnagain
            // 
            this.btnagain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnagain.Font = new System.Drawing.Font("Lucida Handwriting", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnagain.Location = new System.Drawing.Point(559, 57);
            this.btnagain.Name = "btnagain";
            this.btnagain.Size = new System.Drawing.Size(166, 84);
            this.btnagain.TabIndex = 2;
            this.btnagain.Text = "Shoot Away";
            this.btnagain.UseVisualStyleBackColor = false;
            this.btnagain.Click += new System.EventHandler(this.shootaway_btn_Click);
            // 
            // btnspin
            // 
            this.btnspin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnspin.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnspin.Image = global::Rouelette.Properties.Resources.spinn;
            this.btnspin.Location = new System.Drawing.Point(315, 53);
            this.btnspin.Name = "btnspin";
            this.btnspin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnspin.Size = new System.Drawing.Size(166, 84);
            this.btnspin.TabIndex = 1;
            this.btnspin.Text = "SPIN";
            this.btnspin.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnspin.UseVisualStyleBackColor = false;
            this.btnspin.Click += new System.EventHandler(this.btnspin_Click);
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.Black;
            this.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnload.Font = new System.Drawing.Font("Lucida Handwriting", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnload.Image = global::Rouelette.Properties.Resources.loding_gun;
            this.btnload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnload.Location = new System.Drawing.Point(44, 53);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(166, 84);
            this.btnload.TabIndex = 0;
            this.btnload.Text = "LOAD";
            this.btnload.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(13, 13);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(52, 13);
            this.Welcome.TabIndex = 8;
            this.Welcome.Text = "Welcome";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(72, 12);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(10, 13);
            this.Name_lbl.TabIndex = 9;
            this.Name_lbl.Text = ":";
            // 
            // russian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Shoot_picbox);
            this.Controls.Add(this.shot_btn);
            this.Controls.Add(this.btnagain);
            this.Controls.Add(this.btnspin);
            this.Controls.Add(this.btnload);
            this.Name = "russian";
            this.Text = "Russian";
            this.Load += new System.EventHandler(this.russian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Shoot_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnspin;
        private System.Windows.Forms.Button btnagain;
        private System.Windows.Forms.Button shot_btn;
        private System.Windows.Forms.PictureBox Shoot_picbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label Name_lbl;
    }
}