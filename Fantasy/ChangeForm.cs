using Fantasy.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fantasy
{
    public partial class ChangeForm : Form
    {
        MainForm obj = null;
        int ind = new int();
        public ChangeForm(MainForm _obj, int index=-2)
        {
            ind = index;
            obj = _obj;
            InitializeComponent();
        }

        private void ParseList(int funcNum)
        {
            var TypeChange2 = Activator.CreateInstance(ind == -1 ? obj.objs.Player[0].GetType() : obj.objs.GetAllWithOutPlayer()[ind].GetType(), new object[] { this.textName.Text, this.textLastName.Text, Int32.Parse(this.textHP.Text), Int32.Parse(this.textMana.Text), Int32.Parse(this.textPower.Text), Int32.Parse(this.textManaUsage.Text), Int32.Parse(this.textResistance.Text), Int32.Parse(this.textMagicResistance.Text) });
            MethodInfo[] methodInfos = Type.GetType(typeof(Creatures).ToString()).GetMethods(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance);
            List<MethodInfo> methodInfosAB = new List<MethodInfo>();
            foreach (var item in methodInfos)
            {
                if (item.ToString().Contains(ind == -1 ? obj.objs.Player[0].GetType().Name.ToString() : obj.objs.GetAllWithOutPlayer()[ind].GetType().Name.ToString()))
                {
                    if (item.ToString().Contains("get"))
                    {
                        methodInfosAB.Insert(0, item);
                    }
                }
            }
            IList Temp3 = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(ind == -1 ? obj.objs.Player[0].GetType() : obj.objs.GetAllWithOutPlayer()[ind].GetType()));
            Temp3 = (IList)methodInfosAB[0].Invoke(obj.objs, null);
            int subObjIndex = 0;
            foreach (var item in Temp3)
            {
                if (ind == -1 ? obj.objs.Player[0].Equals(item) : obj.objs.GetAllWithOutPlayer()[ind].Equals(item)) { break; }
                subObjIndex++;
            }
            if (funcNum == 1)
            {
                Temp3[subObjIndex] = TypeChange2;
            }
            else if(funcNum == 2)
            {
                Temp3.RemoveAt(subObjIndex);
            }

            obj.PlayerInfoUpdate();
            if (ind != -1) { obj.DataUpdate(); }

            Close();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            ParseList(funcNum:1);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ParseList(funcNum: 2);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (classChoose.SelectedIndex == -1)
            {
                MessageBox.Show("Choose class name".ToString(), "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }
            Type ClassType = Type.GetType(typeof(Creature).Namespace + "." + classChoose.Text);
            var TypeChange = Activator.CreateInstance(ClassType, new object[] { this.textName.Text, this.textLastName.Text, Int32.Parse(this.textHP.Text), Int32.Parse(this.textMana.Text), Int32.Parse(this.textPower.Text), Int32.Parse(this.textManaUsage.Text), Int32.Parse(this.textResistance.Text), Int32.Parse(this.textMagicResistance.Text) });
            MethodInfo[] methodInfos = Type.GetType(typeof(Creatures).ToString()).GetMethods(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance);
            List<MethodInfo> methodInfosAB = new List<MethodInfo>();
            foreach (var item in methodInfos)
            {
                if (item.ToString().Contains(classChoose.Text)&& item.ToString().Contains("get")) { methodInfosAB.Insert(0, item); }
            }
            IList Temp3 = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(ClassType));
            Temp3 = (IList)methodInfosAB[0].Invoke(obj.objs, null);
            Temp3.Add(TypeChange);
            if(obj.objs.GetAllWithOutPlayer().Count==1)
            {
                obj.MobInfoUpdate(new int());
            }
            obj.DataUpdate();
            Close();
        }
        private void ChangeTheme(Color primaryColor, Color secondaryColor, Color tertiaryColor, Color textColor)
        {
            classChoose.BackColor = primaryColor;
            textHP.BackColor = primaryColor;
            textMana.BackColor = primaryColor;
            textName.BackColor = primaryColor;
            textLastName.BackColor = primaryColor;
            textPower.BackColor = primaryColor;
            textManaUsage.BackColor = primaryColor;
            textResistance.BackColor = primaryColor;
            textMagicResistance.BackColor = primaryColor;
            UpdateBtn.BackColor = secondaryColor;
            AddBtn.BackColor = secondaryColor;
            DeleteBtn.BackColor = secondaryColor;
            this.BackColor = tertiaryColor;
            this.ForeColor = textColor;
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            if (ind >= -1)
            {
                if (ind == -1) { this.DeleteBtn.Visible = false; }
                this.AddBtn.Visible = false;
                this.classChoose.Visible = false;
            }
            else
            {
                this.UpdateBtn.Visible = false;
                this.DeleteBtn.Visible = false;
                classChoose.SelectedIndex = -1;
                classChoose.Items.Clear();
                MethodInfo[] methodInfos = Type.GetType(typeof(Creatures).ToString()).GetMethods(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance);
                foreach (var item in methodInfos)
                {
                    if (item.ToString().Contains("get"))
                    {
                        if (item.ToString().Contains("Player")) { continue; }
                        classChoose.Items.Add(item.Name.ToString().Replace("get_", ""));
                    }
                }
            }

            if (ind >= -1)
            {

                var item = ind == -1 ? obj.objs.Player[0] : (Creature)(obj.objs.GetAllWithOutPlayer()[ind]);
                this.textName.Text = item.Name;
                this.textLastName.Text = item.LastName;
                this.textHP.Text = item.HP.ToString();
                this.textMana.Text = item.Mana.ToString();
                this.textPower.Text = item.Power.ToString();
                this.textManaUsage.Text = item.ManaUsage.ToString();
                this.textResistance.Text = item.Resistance.ToString();
                this.textMagicResistance.Text = item.MagicResistance.ToString();

            }
            else
            {
                this.textName.Text = "Tori";
                this.textLastName.Text = "U";
                this.textHP.Text = "200";
                this.textMana.Text = "200";
                this.textPower.Text = "15";
                this.textManaUsage.Text = "20";
                this.textResistance.Text = "20";
                this.textMagicResistance.Text = "20";
            }
            ChangeTheme(Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Primary], Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Secondary], Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Tertiary], Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Text]);
        }
    }
}
