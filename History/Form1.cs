using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History
{
    public partial class Form1 : Form
    {
        private List<Person> people = new List<Person>();

        readonly private Random r = new Random();

        readonly private int m = 8;

        readonly private DateTime un = new DateTime(2000, 1, 1);

        readonly private string[] FNames = { "James", "Robert", "John", "Elizabeth", "Karen", "Charles", "Susan", "Will" };
        readonly private string[] LNames = { "Smith", "Johnson", "Williams", "Brown", "Anderson", "Clark", "Miller", "Jones" };
        readonly private string[] Colours = { "000066", "cc0000", "ff3300", "1f9960", "ff9900", "009966", "730099", "cc005c" };

        public Form1()
        {
            InitializeComponent();

            PerformAutoScale();
            
            People_Start.CustomFormat = "MM-yyyy";
            People_End.CustomFormat = "MM-yyyy";

            People_Start.Value = un;
            People_End.Value = un;

            //Open.SetStyle(ControlStyles.Selectable, false);

            if (Program.arg != "")
            {
                Open_Click(Program.arg);
                
            }
        }

        private void UpdatePeopleList()
        {
            People_People.Items.Clear();
            foreach (Person person in people)
            {
                People_People.Items.Add(person.name);
            }
            People_People.Refresh();
        }
        private Color GetColour(int id)
        {
     
            int g = Math.Abs(id * 7859) % Colours.Length;
            return ColorTranslator.FromHtml('#' + Colours[g]);
        }
        private string GetName()
        {
            int f = r.Next(FNames.Length);
            int l = r.Next(LNames.Length);
            return FNames[f] + " " + LNames[l];
        }



        private void People_People_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (People_People.SelectedIndex > -1)
            {
                Person p = people[People_People.SelectedIndex];
                People_Name.Text = p.name;
                People_Start.Value = p.start;
                People_End.Value = p.end;
                People_Info.Text = p.desc;
                People_Image.Text = p.uri;
                People_ImageB.ImageLocation = Program.arg + p.uri;
                People_eb.Checked = p.eb;
                People_End.Enabled = p.eb;
                //People_Edit.Enabled = true;
            }
            else
            {
                //People_Edit.Enabled = false;
                People_Name.Text = "";
                People_Start.Value = un;
                People_End.Value = un;
                People_Info.Text = "";
                People_Image.Text = "";
                People_ImageB.ImageLocation = "";
                People_eb.Checked = false;
                People_End.Enabled = true;
            }

        }

        private void People_Add_Click(object sender, EventArgs e)
        {
            Person p = new Person(GetName(), un, un, "Blah Blah and other info", "", true);
            people.Add(p);
            UpdatePeopleList();
        }

        private void People_Remove_Click(object sender, EventArgs e)
        {
            if (People_People.SelectedIndex > -1)
            {

                People_Name.Text = "";
                People_Start.Value = un;
                People_End.Value = un;
                People_Info.Text = "";
                People_Image.Text = "";
                People_ImageB.ImageLocation = Program.arg + People_Image.Text;
                People_eb.Checked = false;


                people.RemoveAt(People_People.SelectedIndex); 
                UpdatePeopleList();
            }
        }

        private void People_Edit_Click(object sender, EventArgs e)
        {
            int i = People_People.SelectedIndex;
            if (i != -1)
            {
                people[People_People.SelectedIndex].name = People_Name.Text;
                people[People_People.SelectedIndex].start = People_Start.Value;
                people[People_People.SelectedIndex].end = People_End.Value;
                people[People_People.SelectedIndex].desc = People_Info.Text;
                people[People_People.SelectedIndex].uri = People_Image.Text;
                people[People_People.SelectedIndex].eb = People_eb.Checked;
                People_ImageB.ImageLocation = People_Image.Text;

            }

            UpdatePeopleList();
            
            People_People.SelectedIndex = i;
        }

        private void Save_Click(object sender, EventArgs e)
        {

            tabControl1.Focus();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string st = "";
                foreach (Person person in people)
                {
                    st += person.toString() + '`';
                }

                st += Person.GID;

                File.WriteAllText(saveFileDialog1.FileName, st);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            tabControl1.Focus();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Open_Click(openFileDialog1.FileName);
            }
        }

        private void Open_Click(string sender)
        {

            people.Clear();
            string c = File.ReadAllText(sender);

            string[] c1 = c.Split('`');

            foreach (string item in c1)
            {
                string[] c2 = item.Split('$');

                if (c2.Length > 1)
                {
                    Person p = new Person(Int32.Parse(c2[0]), c2[1], DateTime.Parse(c2[2]), DateTime.Parse(c2[3]), c2[4], c2[5], Boolean.Parse(c2[6]));
                    people.Add(p);
                }
                else
                {
                    Console.WriteLine(c2.Length);
                    Person.GID = Int32.Parse(c2[0]);
                }
            }
            RefMain_Click(1,null);

            string[] sp = sender.Split('\\');
            int si = sp[sp.Length - 1].Length;
            Program.arg = sender.Substring(0, sender.Length - si);

            UpdatePeopleList();
        }

        private void RefMain_Click(object sender, EventArgs e)
        {
            people.Sort((ps1, ps2) => DateTime.Compare(ps1.start, ps2.start));
            Main_Name.Text = "";
            Main_Date.Text = "";
            Main_Desc.Text = "";
            Main_Desc.Visible = false;
            Main_Image.ImageLocation = "";

            Main_Panel.Controls.Clear();
            
            if (people.Count > 0)
            {
                
                int ld = people[0].start.Year;

                foreach (var p in people)
                {
                    if (p.start.Year < ld)
                        ld = p.start.Year;
                }
                int i = 0;
                foreach (var p in people)
                {
                    
                    Label EventLabel = new Label
                    {
                        Location = new Point(((p.start.Year - ld) * 12 * m) + ((p.start.Month - 1) * m), (i*25) % 295),
                        BackColor = GetColour(p.ID),
                        Text = p.name
                    };
                    int dYear = p.end.Year - p.start.Year;
                    int dMonth = p.end.Month - p.start.Month;
                    if (p.eb)
                    {
                        EventLabel.Width = (dYear * 12 * m) + (dMonth * m);
                        if (EventLabel.Width == 0)
                            EventLabel.Width = 2;
                    }
                    else
                    {
                        EventLabel.Width = m * 23;
                    }
                    EventLabel.Height = 25;
                    EventLabel.Name = p.ID.ToString();
                    EventLabel.TextAlign = ContentAlignment.MiddleCenter;
                    EventLabel.Click += EventLabel_Click;
                    if (!p.eb)
                    {
                        EventLabel.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        EventLabel.ForeColor = Color.White;
                    }
                    EventLabel.BorderStyle = BorderStyle.FixedSingle;

                    Main_Panel.Controls.Add(EventLabel);
                    i++;
                }
            }
        }

        private void EventLabel_Click(object sender, EventArgs e)
        {
            UpdatePeopleList();
            int l = Int32.Parse(((Label)sender).Name);
            Person pe = people[0];
            foreach (var p in people)
            {
                if (p.ID == l)
                {
                    pe = p;
                }
            }

            Main_Name.Text = pe.name;
            if (pe.eb)
            {
                Main_Date.Text = "From " + pe.start.Month + "-" + pe.start.Year + " To " + pe.end.Month + "-" + pe.end.Year;
            }
            else
            {
                Main_Date.Text = "On " + pe.start.Month + "-" + pe.start.Year;

            }
            Main_Desc.Visible = true;
            Main_Desc.Text = pe.desc;
            Main_Image.ImageLocation = Program.arg + pe.uri;
        }

    }
}