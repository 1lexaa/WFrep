namespace _1sept.Forms
{
    partial class MenuForm
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
            this.linkLabel1sept = new System.Windows.Forms.LinkLabel();
            this.linkLabel2sept = new System.Windows.Forms.LinkLabel();
            this.prac2sept = new System.Windows.Forms.LinkLabel();
            this.linkarr2 = new System.Windows.Forms.LinkLabel();
            this.linktimer = new System.Windows.Forms.LinkLabel();
            this.linkCH = new System.Windows.Forms.LinkLabel();
            this.linkLabel_IM = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel1sept
            // 
            this.linkLabel1sept.AutoSize = true;
            this.linkLabel1sept.Location = new System.Drawing.Point(73, 68);
            this.linkLabel1sept.Name = "linkLabel1sept";
            this.linkLabel1sept.Size = new System.Drawing.Size(79, 32);
            this.linkLabel1sept.TabIndex = 0;
            this.linkLabel1sept.TabStop = true;
            this.linkLabel1sept.Text = "1 sept";
            this.linkLabel1sept.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1sept_LinkClicked);
            // 
            // linkLabel2sept
            // 
            this.linkLabel2sept.AutoSize = true;
            this.linkLabel2sept.Location = new System.Drawing.Point(85, 172);
            this.linkLabel2sept.Name = "linkLabel2sept";
            this.linkLabel2sept.Size = new System.Drawing.Size(79, 32);
            this.linkLabel2sept.TabIndex = 1;
            this.linkLabel2sept.TabStop = true;
            this.linkLabel2sept.Text = "2 sept";
            this.linkLabel2sept.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2sept_LinkClicked);
            // 
            // prac2sept
            // 
            this.prac2sept.AutoSize = true;
            this.prac2sept.Location = new System.Drawing.Point(73, 260);
            this.prac2sept.Name = "prac2sept";
            this.prac2sept.Size = new System.Drawing.Size(151, 32);
            this.prac2sept.TabIndex = 2;
            this.prac2sept.TabStop = true;
            this.prac2sept.Text = "2 prac 2 sept";
            this.prac2sept.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.prac2sept_LinkClicked);
            // 
            // linkarr2
            // 
            this.linkarr2.AutoSize = true;
            this.linkarr2.Location = new System.Drawing.Point(113, 366);
            this.linkarr2.Name = "linkarr2";
            this.linkarr2.Size = new System.Drawing.Size(62, 32);
            this.linkarr2.TabIndex = 3;
            this.linkarr2.TabStop = true;
            this.linkarr2.Text = "arr 2";
            this.linkarr2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkarr2_LinkClicked);
            // 
            // linktimer
            // 
            this.linktimer.AutoSize = true;
            this.linktimer.Location = new System.Drawing.Point(85, 454);
            this.linktimer.Name = "linktimer";
            this.linktimer.Size = new System.Drawing.Size(99, 32);
            this.linktimer.TabIndex = 5;
            this.linktimer.TabStop = true;
            this.linktimer.Text = "w Timer";
            this.linktimer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linktimer_LinkClicked);
            // 
            // linkCH
            // 
            this.linkCH.AutoSize = true;
            this.linkCH.Location = new System.Drawing.Point(73, 538);
            this.linkCH.Name = "linkCH";
            this.linkCH.Size = new System.Drawing.Size(209, 32);
            this.linkCH.TabIndex = 6;
            this.linkCH.TabStop = true;
            this.linkCH.Text = "Change Wallpaper";
            this.linkCH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCH_LinkClicked);
            // 
            // linkLabel_IM
            // 
            this.linkLabel_IM.AutoSize = true;
            this.linkLabel_IM.Location = new System.Drawing.Point(123, 634);
            this.linkLabel_IM.Name = "linkLabel_IM";
            this.linkLabel_IM.Size = new System.Drawing.Size(157, 32);
            this.linkLabel_IM.TabIndex = 7;
            this.linkLabel_IM.TabStop = true;
            this.linkLabel_IM.Text = "Infinity menu";
            this.linkLabel_IM.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_IM_LinkClicked);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 864);
            this.Controls.Add(this.linkLabel_IM);
            this.Controls.Add(this.linkCH);
            this.Controls.Add(this.linktimer);
            this.Controls.Add(this.linkarr2);
            this.Controls.Add(this.prac2sept);
            this.Controls.Add(this.linkLabel2sept);
            this.Controls.Add(this.linkLabel1sept);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel1sept;
        private LinkLabel linkLabel2sept;
        private LinkLabel prac2sept;
        private LinkLabel linkarr2;
        private LinkLabel linktimer;
        private LinkLabel linkCH;
        private LinkLabel linkLabel_IM;
    }
}