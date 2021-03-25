
namespace Hitman3Reworked
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonTeleport = new System.Windows.Forms.Button();
            this.ButtonMainPage = new System.Windows.Forms.Button();
            this.userControlMainPage1 = new Hitman3Reworked.UserControlMainPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControlTeleport1 = new Hitman3Reworked.UserControlTeleport();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ButtonTeleport);
            this.panel1.Controls.Add(this.ButtonMainPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 313);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Creator : Monday";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version : 1.0 Alpha";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Location = new System.Drawing.Point(192, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 311);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(281, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 167);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(281, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 133);
            this.panel2.TabIndex = 2;
            // 
            // ButtonTeleport
            // 
            this.ButtonTeleport.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonTeleport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTeleport.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonTeleport.ForeColor = System.Drawing.Color.White;
            this.ButtonTeleport.Location = new System.Drawing.Point(0, 80);
            this.ButtonTeleport.Name = "ButtonTeleport";
            this.ButtonTeleport.Size = new System.Drawing.Size(186, 69);
            this.ButtonTeleport.TabIndex = 1;
            this.ButtonTeleport.Text = "Teleport";
            this.ButtonTeleport.UseVisualStyleBackColor = false;
            this.ButtonTeleport.Click += new System.EventHandler(this.ClickTeleportButton);
            // 
            // ButtonMainPage
            // 
            this.ButtonMainPage.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMainPage.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonMainPage.ForeColor = System.Drawing.Color.White;
            this.ButtonMainPage.Location = new System.Drawing.Point(0, 12);
            this.ButtonMainPage.Name = "ButtonMainPage";
            this.ButtonMainPage.Size = new System.Drawing.Size(186, 62);
            this.ButtonMainPage.TabIndex = 0;
            this.ButtonMainPage.Text = "Main";
            this.ButtonMainPage.UseVisualStyleBackColor = false;
            this.ButtonMainPage.Click += new System.EventHandler(this.ClickMainButton);
            // 
            // userControlMainPage1
            // 
            this.userControlMainPage1.BackColor = System.Drawing.Color.Transparent;
            this.userControlMainPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlMainPage1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userControlMainPage1.Location = new System.Drawing.Point(202, 0);
            this.userControlMainPage1.Name = "userControlMainPage1";
            this.userControlMainPage1.Size = new System.Drawing.Size(676, 313);
            this.userControlMainPage1.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // userControlTeleport1
            // 
            this.userControlTeleport1.BackColor = System.Drawing.Color.Transparent;
            this.userControlTeleport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTeleport1.Location = new System.Drawing.Point(202, 0);
            this.userControlTeleport1.Name = "userControlTeleport1";
            this.userControlTeleport1.Size = new System.Drawing.Size(676, 313);
            this.userControlTeleport1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(714, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Discord :  monday#9895";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(878, 313);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userControlTeleport1);
            this.Controls.Add(this.userControlMainPage1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hitman 3 Fly / Teleport Mod By Monday";
            this.TransparencyKey = System.Drawing.Color.Violet;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonTeleport;
        private System.Windows.Forms.Button ButtonMainPage;
        private UserControlMainPage userControlMainPage1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControlTeleport userControlTeleport1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHowTo;
    }
}

