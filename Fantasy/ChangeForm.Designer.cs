namespace Fantasy
{
    partial class ChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeForm));
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.textPower = new System.Windows.Forms.NumericUpDown();
            this.labelManaUsage = new System.Windows.Forms.Label();
            this.textManaUsage = new System.Windows.Forms.NumericUpDown();
            this.labelResistance = new System.Windows.Forms.Label();
            this.textResistance = new System.Windows.Forms.NumericUpDown();
            this.labelMagicResistance = new System.Windows.Forms.Label();
            this.textMagicResistance = new System.Windows.Forms.NumericUpDown();
            this.labelHP = new System.Windows.Forms.Label();
            this.textHP = new System.Windows.Forms.NumericUpDown();
            this.labelMana = new System.Windows.Forms.Label();
            this.textMana = new System.Windows.Forms.NumericUpDown();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.classChoose = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textManaUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textResistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMagicResistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMana)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(204, 21);
            this.textName.MaxLength = 25;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(118, 22);
            this.textName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 52);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(69, 16);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "LastName";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(204, 46);
            this.textLastName.MaxLength = 25;
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(118, 22);
            this.textLastName.TabIndex = 1;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(12, 135);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(45, 16);
            this.labelPower.TabIndex = 0;
            this.labelPower.Text = "Power";
            // 
            // textPower
            // 
            this.textPower.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textPower.Location = new System.Drawing.Point(204, 133);
            this.textPower.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.textPower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textPower.Name = "textPower";
            this.textPower.Size = new System.Drawing.Size(118, 22);
            this.textPower.TabIndex = 2;
            this.textPower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelManaUsage
            // 
            this.labelManaUsage.AutoSize = true;
            this.labelManaUsage.Location = new System.Drawing.Point(12, 163);
            this.labelManaUsage.Name = "labelManaUsage";
            this.labelManaUsage.Size = new System.Drawing.Size(82, 16);
            this.labelManaUsage.TabIndex = 0;
            this.labelManaUsage.Text = "ManaUsage";
            // 
            // textManaUsage
            // 
            this.textManaUsage.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textManaUsage.Location = new System.Drawing.Point(204, 161);
            this.textManaUsage.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.textManaUsage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textManaUsage.Name = "textManaUsage";
            this.textManaUsage.Size = new System.Drawing.Size(118, 22);
            this.textManaUsage.TabIndex = 2;
            this.textManaUsage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelResistance
            // 
            this.labelResistance.AutoSize = true;
            this.labelResistance.Location = new System.Drawing.Point(12, 191);
            this.labelResistance.Name = "labelResistance";
            this.labelResistance.Size = new System.Drawing.Size(75, 16);
            this.labelResistance.TabIndex = 0;
            this.labelResistance.Text = "Resistance";
            // 
            // textResistance
            // 
            this.textResistance.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textResistance.Location = new System.Drawing.Point(204, 189);
            this.textResistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textResistance.Name = "textResistance";
            this.textResistance.Size = new System.Drawing.Size(118, 22);
            this.textResistance.TabIndex = 2;
            this.textResistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMagicResistance
            // 
            this.labelMagicResistance.AutoSize = true;
            this.labelMagicResistance.Location = new System.Drawing.Point(12, 219);
            this.labelMagicResistance.Name = "labelMagicResistance";
            this.labelMagicResistance.Size = new System.Drawing.Size(112, 16);
            this.labelMagicResistance.TabIndex = 0;
            this.labelMagicResistance.Text = "MagicResistance";
            // 
            // textMagicResistance
            // 
            this.textMagicResistance.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textMagicResistance.Location = new System.Drawing.Point(204, 217);
            this.textMagicResistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textMagicResistance.Name = "textMagicResistance";
            this.textMagicResistance.Size = new System.Drawing.Size(118, 22);
            this.textMagicResistance.TabIndex = 2;
            this.textMagicResistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(12, 79);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(26, 16);
            this.labelHP.TabIndex = 0;
            this.labelHP.Text = "HP";
            // 
            // textHP
            // 
            this.textHP.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textHP.Location = new System.Drawing.Point(204, 77);
            this.textHP.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.textHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textHP.Name = "textHP";
            this.textHP.Size = new System.Drawing.Size(118, 22);
            this.textHP.TabIndex = 2;
            this.textHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMana
            // 
            this.labelMana.AutoSize = true;
            this.labelMana.Location = new System.Drawing.Point(12, 107);
            this.labelMana.Name = "labelMana";
            this.labelMana.Size = new System.Drawing.Size(41, 16);
            this.labelMana.TabIndex = 0;
            this.labelMana.Text = "Mana";
            // 
            // textMana
            // 
            this.textMana.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textMana.Location = new System.Drawing.Point(204, 105);
            this.textMana.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.textMana.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textMana.Name = "textMana";
            this.textMana.Size = new System.Drawing.Size(118, 22);
            this.textMana.TabIndex = 2;
            this.textMana.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(15, 299);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.Update_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(247, 299);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.Delete_Click);
            // 
            // classChoose
            // 
            this.classChoose.AutoCompleteCustomSource.AddRange(new string[] {
            "Dragon",
            "Hydra"});
            this.classChoose.Location = new System.Drawing.Point(110, 258);
            this.classChoose.Name = "classChoose";
            this.classChoose.Size = new System.Drawing.Size(121, 24);
            this.classChoose.TabIndex = 4;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(134, 299);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.Add_Click);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 345);
            this.Controls.Add(this.classChoose);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.textMagicResistance);
            this.Controls.Add(this.labelMagicResistance);
            this.Controls.Add(this.textResistance);
            this.Controls.Add(this.labelResistance);
            this.Controls.Add(this.textMana);
            this.Controls.Add(this.textManaUsage);
            this.Controls.Add(this.labelMana);
            this.Controls.Add(this.labelManaUsage);
            this.Controls.Add(this.textHP);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.textPower);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(352, 392);
            this.MinimumSize = new System.Drawing.Size(352, 392);
            this.Name = "ChangeForm";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textManaUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textResistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMagicResistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelManaUsage;
        private System.Windows.Forms.Label labelResistance;
        private System.Windows.Forms.Label labelMagicResistance;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelMana;
        public System.Windows.Forms.TextBox textName;
        public System.Windows.Forms.TextBox textLastName;
        public System.Windows.Forms.NumericUpDown textPower;
        public System.Windows.Forms.NumericUpDown textManaUsage;
        public System.Windows.Forms.NumericUpDown textResistance;
        public System.Windows.Forms.NumericUpDown textMagicResistance;
        public System.Windows.Forms.NumericUpDown textHP;
        public System.Windows.Forms.NumericUpDown textMana;
        public System.Windows.Forms.Button UpdateBtn;
        public System.Windows.Forms.Button DeleteBtn;
        public System.Windows.Forms.ComboBox classChoose;
        public System.Windows.Forms.Button AddBtn;
    }
}