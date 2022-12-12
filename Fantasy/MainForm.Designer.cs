namespace Fantasy
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxP = new System.Windows.Forms.ComboBox();
            this.buttonPAB = new System.Windows.Forms.Button();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.buttonMAB = new System.Windows.Forms.Button();
            this.buttonPlayerChange = new System.Windows.Forms.Button();
            this.buttonMobChange = new System.Windows.Forms.Button();
            this.textHP = new System.Windows.Forms.Label();
            this.textMana = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelMana = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menu = new System.Windows.Forms.ToolStrip();
            this.CFBtn = new System.Windows.Forms.ToolStripButton();
            this.DNBtn = new System.Windows.Forms.ToolStripButton();
            this.InfoBtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // richText
            // 
            this.richText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richText.Location = new System.Drawing.Point(543, 40);
            this.richText.Name = "richText";
            this.richText.ReadOnly = true;
            this.richText.Size = new System.Drawing.Size(247, 246);
            this.richText.TabIndex = 1;
            this.richText.Text = "";
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(543, 289);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(102, 42);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type";
            this.labelType.MouseHover += new System.EventHandler(this.labelType_MouseHover);
            // 
            // comboBoxP
            // 
            this.comboBoxP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxP.FormattingEnabled = true;
            this.comboBoxP.Location = new System.Drawing.Point(12, 353);
            this.comboBoxP.Name = "comboBoxP";
            this.comboBoxP.Size = new System.Drawing.Size(121, 24);
            this.comboBoxP.TabIndex = 3;
            // 
            // buttonPAB
            // 
            this.buttonPAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPAB.Location = new System.Drawing.Point(139, 353);
            this.buttonPAB.Name = "buttonPAB";
            this.buttonPAB.Size = new System.Drawing.Size(120, 24);
            this.buttonPAB.TabIndex = 4;
            this.buttonPAB.Text = "Player\'s ability";
            this.buttonPAB.UseVisualStyleBackColor = false;
            this.buttonPAB.Click += new System.EventHandler(this.buttonPAB_Click);
            this.buttonPAB.MouseHover += new System.EventHandler(this.buttonPAB_MouseHover);
            // 
            // comboBoxM
            // 
            this.comboBoxM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Location = new System.Drawing.Point(288, 353);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(121, 24);
            this.comboBoxM.TabIndex = 3;
            // 
            // buttonMAB
            // 
            this.buttonMAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMAB.FlatAppearance.BorderSize = 0;
            this.buttonMAB.Location = new System.Drawing.Point(415, 353);
            this.buttonMAB.Name = "buttonMAB";
            this.buttonMAB.Size = new System.Drawing.Size(120, 24);
            this.buttonMAB.TabIndex = 4;
            this.buttonMAB.Text = "Mob\'s ability";
            this.buttonMAB.UseVisualStyleBackColor = false;
            this.buttonMAB.Click += new System.EventHandler(this.buttonMAB_Click);
            this.buttonMAB.MouseHover += new System.EventHandler(this.buttonMAB_MouseHover);
            // 
            // buttonPlayerChange
            // 
            this.buttonPlayerChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlayerChange.FlatAppearance.BorderSize = 0;
            this.buttonPlayerChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlayerChange.Location = new System.Drawing.Point(694, 412);
            this.buttonPlayerChange.Name = "buttonPlayerChange";
            this.buttonPlayerChange.Size = new System.Drawing.Size(45, 45);
            this.buttonPlayerChange.TabIndex = 5;
            this.buttonPlayerChange.Text = "P";
            this.buttonPlayerChange.UseVisualStyleBackColor = false;
            this.buttonPlayerChange.Click += new System.EventHandler(this.buttonPlayerChange_Click);
            this.buttonPlayerChange.MouseHover += new System.EventHandler(this.buttonPlayerChange_MouseHover);
            // 
            // buttonMobChange
            // 
            this.buttonMobChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMobChange.FlatAppearance.BorderSize = 0;
            this.buttonMobChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMobChange.Location = new System.Drawing.Point(745, 412);
            this.buttonMobChange.Name = "buttonMobChange";
            this.buttonMobChange.Size = new System.Drawing.Size(45, 45);
            this.buttonMobChange.TabIndex = 5;
            this.buttonMobChange.Text = "M";
            this.buttonMobChange.UseVisualStyleBackColor = false;
            this.buttonMobChange.Click += new System.EventHandler(this.buttonMobChange_Click);
            this.buttonMobChange.MouseHover += new System.EventHandler(this.buttonMobChange_MouseHover);
            // 
            // textHP
            // 
            this.textHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textHP.AutoSize = true;
            this.textHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHP.Location = new System.Drawing.Point(13, 432);
            this.textHP.Name = "textHP";
            this.textHP.Size = new System.Drawing.Size(45, 25);
            this.textHP.TabIndex = 6;
            this.textHP.Text = "HP:";
            // 
            // textMana
            // 
            this.textMana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textMana.AutoSize = true;
            this.textMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMana.Location = new System.Drawing.Point(168, 432);
            this.textMana.Name = "textMana";
            this.textMana.Size = new System.Drawing.Size(68, 25);
            this.textMana.TabIndex = 6;
            this.textMana.Text = "Mana:";
            // 
            // labelHP
            // 
            this.labelHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHP.AutoSize = true;
            this.labelHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHP.Location = new System.Drawing.Point(54, 426);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(30, 32);
            this.labelHP.TabIndex = 7;
            this.labelHP.Text = "0";
            this.labelHP.MouseHover += new System.EventHandler(this.labelHP_MouseHover);
            // 
            // labelMana
            // 
            this.labelMana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMana.AutoSize = true;
            this.labelMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMana.Location = new System.Drawing.Point(230, 425);
            this.labelMana.Name = "labelMana";
            this.labelMana.Size = new System.Drawing.Size(30, 32);
            this.labelMana.TabIndex = 7;
            this.labelMana.Text = "0";
            this.labelMana.MouseHover += new System.EventHandler(this.labelMana_MouseHover);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CFBtn,
            this.DNBtn,
            this.InfoBtn});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(802, 27);
            this.menu.TabIndex = 9;
            this.menu.Text = "Menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // CFBtn
            // 
            this.CFBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CFBtn.Image = ((System.Drawing.Image)(resources.GetObject("CFBtn.Image")));
            this.CFBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CFBtn.Name = "CFBtn";
            this.CFBtn.Size = new System.Drawing.Size(29, 24);
            this.CFBtn.Text = "Choose File";
            this.CFBtn.Click += new System.EventHandler(this.CFBtn_Click);
            // 
            // DNBtn
            // 
            this.DNBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DNBtn.Image = ((System.Drawing.Image)(resources.GetObject("DNBtn.Image")));
            this.DNBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DNBtn.Name = "DNBtn";
            this.DNBtn.Size = new System.Drawing.Size(29, 28);
            this.DNBtn.Text = "toolStripButton1";
            this.DNBtn.ToolTipText = "Change Theme";
            this.DNBtn.Click += new System.EventHandler(this.DNBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InfoBtn.Image = ((System.Drawing.Image)(resources.GetObject("InfoBtn.Image")));
            this.InfoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(29, 28);
            this.InfoBtn.Text = "Info";
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 463);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.labelMana);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.textMana);
            this.Controls.Add(this.textHP);
            this.Controls.Add(this.buttonMobChange);
            this.Controls.Add(this.buttonPlayerChange);
            this.Controls.Add(this.buttonMAB);
            this.Controls.Add(this.buttonPAB);
            this.Controls.Add(this.comboBoxM);
            this.Controls.Add(this.comboBoxP);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 470);
            this.Name = "MainForm";
            this.Text = "Fantasy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxP;
        private System.Windows.Forms.Button buttonPAB;
        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.Button buttonMAB;
        private System.Windows.Forms.Button buttonPlayerChange;
        private System.Windows.Forms.Button buttonMobChange;
        private System.Windows.Forms.Label textHP;
        private System.Windows.Forms.Label textMana;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelMana;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripButton DNBtn;
        private System.Windows.Forms.ToolStripButton InfoBtn;
        private System.Windows.Forms.ToolStripButton CFBtn;
    }
}

