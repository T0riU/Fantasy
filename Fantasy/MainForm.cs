using Fantasy.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Fantasy
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ChangeTheme(Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Primary], Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Secondary], Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Tertiary]);
            ChangeTextColor(Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Text]);
            if (Debugger.IsAttached)
                Settings.Default.Reset();

        }
        private void ChangeTheme(Color primaryColor, Color secondaryColor, Color tertiaryColor)
        {
            richText.BackColor = primaryColor;
            dataGridView1.BackgroundColor = secondaryColor;
            menu.BackColor = primaryColor;
            comboBoxM.BackColor = primaryColor;
            comboBoxP.BackColor = primaryColor;
            buttonPAB.BackColor = secondaryColor;
            buttonMAB.BackColor = secondaryColor;
            buttonPlayerChange.BackColor = secondaryColor;
            buttonMobChange.BackColor = secondaryColor;
            this.BackColor = tertiaryColor;
        }
        private void ChangeTextColor(Color textColor)
        {
            labelHP.ForeColor = textColor;
            labelMana.ForeColor = textColor;
            textMana.ForeColor = textColor;
            textHP.ForeColor = textColor;
            labelType.ForeColor = textColor;
            richText.ForeColor = textColor;
            menu.ForeColor = textColor;
            comboBoxM.ForeColor = textColor;
            comboBoxP.ForeColor = textColor;
            buttonPAB.ForeColor = textColor;
            buttonMAB.ForeColor = textColor;
            buttonPlayerChange.ForeColor = textColor;
            buttonMobChange.ForeColor = textColor;
        }
        string FileName = Settings.Default.UserPath != String.Empty ? Settings.Default.UserPath + "\\" + Settings.Default.UserFileName : Settings.Default.UserFileName;
        string jData = String.Empty;
        public Creatures objs = new Creatures();
        public int NowCreatureIndex = 0;
        bool Error = false;
        public void MobInfoUpdate(int index, bool BoxUpdate = true)
        {
            //MessageBox.Show(objs.GetAllWithOutPlayer()[index].ToString(), "Kill me", MessageBoxButtons.OK, MessageBoxIcon.Error);
            try
            {
                richText.Text = objs.GetAllWithOutPlayer()[index].ToString();
                labelType.Text = objs.GetAllWithOutPlayer()[index].GetType().Name.ToString();
                if (BoxUpdate)
                {
                    ComboBoxUpdate(objs.GetAllWithOutPlayer()[index].GetType().FullName.ToString(), comboBoxM);
                }
            }
            catch (Exception)
            {
                richText.Text = "Add a Creature\nby pressing the\"M\" button ";
                labelType.Text = "NONE";
                comboBoxM.SelectedIndex = -1;
                comboBoxM.Items.Clear();
            }
        }
        private void ComboBoxUpdate(string type, System.Windows.Forms.ComboBox box)
        {
            box.SelectedIndex = -1;
            box.Items.Clear();
            MethodInfo[] methodInfos = Type.GetType(type).GetMethods(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance);
            foreach (var item in methodInfos) { if (item.ToString().Contains("AB_")) { box.Items.Add(item.Name.ToString().Replace("AB_", "")); } }
        }
        public void PlayerInfoUpdate()
        {
            labelHP.Text = objs.Player[0].NowHP.ToString();
            labelMana.Text = objs.Player[0].NowMana.ToString();
        }
        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                NowCreatureIndex = index;
                MobInfoUpdate(NowCreatureIndex);
            }

        }
        public void DataUpdate()
        {
            dataGridView1.DataSource = objs.GetAllWithOutPlayer();
            dataGridView1.ClearSelection();
            if (NowCreatureIndex != 0) {
                dataGridView1.Rows[0].Selected = true;
            }
         
            NowCreatureIndex = 0;
            MobInfoUpdate(NowCreatureIndex);
        }
        public void buttonMAB_Click(object sender, EventArgs e)
        {
            int index = comboBoxM.SelectedIndex;
            if (index >= 0 && objs.GetAllWithOutPlayer().Count > 0)
            {
                MethodInfo[] methodInfos = Type.GetType(objs.GetAllWithOutPlayer()[NowCreatureIndex].GetType().FullName.ToString()).GetMethods(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance);
                List<MethodInfo> methodInfosAB = new List<MethodInfo>();
                foreach (var item in methodInfos)
                {
                    if (item.ToString().Contains("AB_"))
                    {
                        methodInfosAB.Add(item);
                    }
                }
                if (methodInfosAB[index].GetParameters().Length != 0)
                {
                    methodInfosAB[index].Invoke(objs.GetAllWithOutPlayer()[NowCreatureIndex], new object[] { objs.Player[0] });
                }
                else
                {
                    methodInfosAB[index].Invoke(objs.GetAllWithOutPlayer()[NowCreatureIndex], null);
                }
                PlayerInfoUpdate();
                MobInfoUpdate(NowCreatureIndex, false);
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }

        public void buttonPAB_Click(object sender, EventArgs e)
        {
            int index = comboBoxP.SelectedIndex;
            if (index >= 0 && objs.GetAllWithOutPlayer().Count > 0)
            {
                MethodInfo[] methodInfos = Type.GetType(objs.Player[0].GetType().FullName.ToString()).GetMethods(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance);
                List<MethodInfo> methodInfosAB = new List<MethodInfo>();
                foreach (var item in methodInfos)
                {
                    if (item.ToString().Contains("AB_"))
                    {
                        methodInfosAB.Add(item);
                    }
                }
                if (methodInfosAB[index].GetParameters().Length != 0)
                {
                    methodInfosAB[index].Invoke(objs.Player[0], new object[] { objs.GetAllWithOutPlayer()[NowCreatureIndex] });
                }
                else
                {
                    methodInfosAB[index].Invoke(objs.Player[0], null);
                }
                PlayerInfoUpdate();
                MobInfoUpdate(NowCreatureIndex, false);
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                ChangeForm f2 = new ChangeForm(this, NowCreatureIndex);
                f2.ShowDialog();
            }
        }

        private void buttonPlayerChange_Click(object sender, EventArgs e)
        {
            ChangeForm f2 = new ChangeForm(this, -1);
            f2.ShowDialog();
        }

        private void buttonMobChange_Click(object sender, EventArgs e)
        {
            ChangeForm f2 = new ChangeForm(this, -100);
            f2.ShowDialog();
        }

        private void buttonMobChange_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Add New Creature", buttonMobChange);
        }

        private void buttonPlayerChange_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Change Player Parameters", buttonPlayerChange);
        }

        private void labelType_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Race of Creature", labelType);
        }

        private void buttonMAB_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Use Creature Ability", buttonMAB);
        }

        private void buttonPAB_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Use Player Ability", buttonPAB);
        }

        private void labelMana_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Player Mana", labelMana);
        }

        private void labelHP_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Player Hit Points", labelHP);
        }

        private void DNBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.UserTheme++;
            if (Settings.Default.UserTheme + 1 > Theme.Colors.Count)
            {
                Settings.Default.UserTheme = 0;
            }
            ChangeTheme(Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Primary], Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Secondary], Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Tertiary]);
            ChangeTextColor(Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Text]);
            Settings.Default.Save();
        }

        private void CFBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (Settings.Default.UserPath.ToString() == string.Empty)
            {
                Settings.Default.UserPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            }
            openFileDialog.InitialDirectory = Settings.Default.UserPath.ToString();
            openFileDialog.Filter = "Json file (*.json)|*.json";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.UserPath = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                Settings.Default.UserFileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                Settings.Default.Save();
                
                Application.Restart();
            }
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    try
                    {
                        if (File.Exists(FileName))
                        {
                            jData = File.ReadAllText(FileName);

                            objs = JsonConvert.DeserializeObject<Creatures>(jData);
                        }
                        else
                        {
                            throw new FileNotFoundException();
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        jData = "";
                        objs = null;
                        //File.Create(FileName);
                        //Error = true;
                        //Application.Restart();
                    }
                    catch (JsonReaderException)
                    {
                        var result = MessageBox.Show("The file is broken. Would you like to clear the file and open it?", "Error",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            System.IO.File.WriteAllText(FileName, string.Empty);
                            Error = true;
                            Application.Restart();
                        }
                        else if (result == DialogResult.No)
                        {
                            string output = JsonConvert.SerializeObject(objs);
                            Settings.Default.UserPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                            Settings.Default.UserFileName = System.IO.Path.GetFileName("creatures.json");
                            Settings.Default.Save();
                            Error = true;
                            Application.Exit();
                        }
                    }
                    if (objs == null)
                    {
                        if (jData == string.Empty)
                        {
                            MessageBox.Show("The file is empty, a template will be created.".ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("The file is broken, a template will be created. When saving, all information will be deleted.".ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        objs = new Creatures();
                        objs.Player.Add(new Player(name: "Player", LastName: "Empty", HP: 200, Mana: 200, Power: 20, ManaUsage: 30, Resistance: 15, MagicResistance: 15));
                    }
                    MobInfoUpdate(NowCreatureIndex);
                    PlayerInfoUpdate();
                    ComboBoxUpdate(typeof(Player).ToString(), comboBoxP);
                    dataGridView1.DataSource = objs.GetAllWithOutPlayer();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Error = true;
                    Application.Exit();
                }


            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Error)
            {
                var result = MessageBox.Show("Would you like to save?", "Closing",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.Yes)
                {
                    string output = JsonConvert.SerializeObject(objs);
                    //Console.WriteLine(output);
                    string temp = FileName;
                    File.WriteAllText(temp, output);
                }
            }
        }
    }
}
