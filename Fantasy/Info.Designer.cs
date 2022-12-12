namespace Fantasy
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.OK = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.linkGit = new System.Windows.Forms.LinkLabel();
            this.GiTHub = new System.Windows.Forms.Label();
            this.labelCreator = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.GroupAndName = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.Location = new System.Drawing.Point(160, 400);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 33);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(253, 325);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(103, 16);
            this.Copyright.TabIndex = 1;
            this.Copyright.Text = "Copyright ©2022";
            // 
            // linkGit
            // 
            this.linkGit.AutoSize = true;
            this.linkGit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkGit.Location = new System.Drawing.Point(157, 160);
            this.linkGit.Name = "linkGit";
            this.linkGit.Size = new System.Drawing.Size(148, 16);
            this.linkGit.TabIndex = 2;
            this.linkGit.TabStop = true;
            this.linkGit.Text = "https://github.com/T0riU";
            this.linkGit.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGit_LinkClicked);
            // 
            // GiTHub
            // 
            this.GiTHub.AutoSize = true;
            this.GiTHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiTHub.Location = new System.Drawing.Point(26, 157);
            this.GiTHub.Name = "GiTHub";
            this.GiTHub.Size = new System.Drawing.Size(67, 20);
            this.GiTHub.TabIndex = 1;
            this.GiTHub.Text = "Git Hub";
            // 
            // labelCreator
            // 
            this.labelCreator.AutoSize = true;
            this.labelCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreator.Location = new System.Drawing.Point(26, 120);
            this.labelCreator.Name = "labelCreator";
            this.labelCreator.Size = new System.Drawing.Size(121, 20);
            this.labelCreator.TabIndex = 1;
            this.labelCreator.Text = "Creator Social:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(21, 37);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 50);
            this.name.TabIndex = 3;
            this.name.Text = "T0riU";
            // 
            // GroupAndName
            // 
            this.GroupAndName.AutoSize = true;
            this.GroupAndName.Location = new System.Drawing.Point(241, 52);
            this.GroupAndName.Name = "GroupAndName";
            this.GroupAndName.Size = new System.Drawing.Size(115, 16);
            this.GroupAndName.TabIndex = 4;
            this.GroupAndName.Text = "Oleh Riepin 137 g.";
            this.GroupAndName.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel2.Location = new System.Drawing.Point(27, 325);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(113, 16);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "How use program";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Info
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.GroupAndName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkGit);
            this.Controls.Add(this.labelCreator);
            this.Controls.Add(this.GiTHub);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.LinkLabel linkGit;
        private System.Windows.Forms.Label GiTHub;
        private System.Windows.Forms.Label labelCreator;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label GroupAndName;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}