
namespace Assignment_1
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblMSG = new System.Windows.Forms.Label();
			this.tbxNumber = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Olive;
			this.button1.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(355, 343);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 49);
			this.button1.TabIndex = 3;
			this.button1.Text = "Guess";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(362, 413);
			this.progressBar1.Maximum = 10;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(282, 39);
			this.progressBar1.TabIndex = 4;
			this.progressBar1.Value = 10;
			// 
			// lblMSG
			// 
			this.lblMSG.BackColor = System.Drawing.Color.BurlyWood;
			this.lblMSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblMSG.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMSG.ForeColor = System.Drawing.SystemColors.Desktop;
			this.lblMSG.Location = new System.Drawing.Point(337, 504);
			this.lblMSG.Name = "lblMSG";
			this.lblMSG.Size = new System.Drawing.Size(328, 51);
			this.lblMSG.TabIndex = 1;
			this.lblMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMSG.Click += new System.EventHandler(this.lblMSG_Click);
			// 
			// tbxNumber
			// 
			this.tbxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxNumber.Location = new System.Drawing.Point(442, 281);
			this.tbxNumber.Name = "tbxNumber";
			this.tbxNumber.Size = new System.Drawing.Size(112, 45);
			this.tbxNumber.TabIndex = 5;
			this.tbxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumber_KeyPress);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1006, 31);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playAgainToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// playAgainToolStripMenuItem
			// 
			this.playAgainToolStripMenuItem.Name = "playAgainToolStripMenuItem";
			this.playAgainToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
			this.playAgainToolStripMenuItem.Text = "Play Again";
			this.playAgainToolStripMenuItem.Click += new System.EventHandler(this.playAgainToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Info;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(340, 117);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 49);
			this.label1.TabIndex = 7;
			this.label1.Text = "Type your Guess here !!!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Brown;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Yellow;
			this.label3.Location = new System.Drawing.Point(497, 343);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 49);
			this.label3.TabIndex = 9;
			this.label3.Text = "Turns left:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(324, 468);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 25);
			this.label4.TabIndex = 10;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.Goldenrod;
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(879, 147);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(55, 441);
			this.listView1.TabIndex = 11;
			this.listView1.Tag = "Guessed Number:";
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Goldenrod;
			this.label5.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(831, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(163, 24);
			this.label5.TabIndex = 12;
			this.label5.Text = "Gussed Numbers:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(279, 149);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 16);
			this.label6.TabIndex = 14;
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.Desktop;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.Info;
			this.label7.Location = new System.Drawing.Point(265, 51);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(460, 51);
			this.label7.TabIndex = 15;
			this.label7.Text = "GUESS THE NUMBER GAME";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(208, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(579, 65);
			this.label2.TabIndex = 16;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.GreenYellow;
			this.label8.Location = new System.Drawing.Point(965, 515);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "label8";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1006, 593);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxNumber);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblMSG);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximumSize = new System.Drawing.Size(1024, 640);
			this.MinimumSize = new System.Drawing.Size(1024, 640);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GUESS THE NUMBER GAME";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playAgainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}

