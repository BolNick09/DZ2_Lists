using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DZ2_Lists
{
    public partial class FrmResume : Form
    {
        private class Resume
        {
            public string FirstName { get; set; }
            public string SureName { get; set; }
            public string EMail { get; set; }
            public string Phone { get; set; }

            public Resume(string firstName, string sureName, string eMail, string phone)
            {
                FirstName = firstName;
                SureName = sureName;
                EMail = eMail;
                Phone = phone;
            }
            public override string ToString()
            {
                return $"{FirstName} {SureName} {EMail} {Phone}";
            }

            public void change(string firstName, string sureName, string eMail, string phone)
            {
                FirstName = firstName;
                SureName = sureName;
                EMail = eMail;
                Phone = phone;
            }
        }

        Resume selectedResume = null;
        private BindingList<Resume> items;
        int selectedIndex;
        public FrmResume()
        {
            InitializeComponent();
            items = new BindingList<Resume>();
            lbMain.DataSource = items;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Resume resume = new Resume(tbFirstName.Text, tbSureName.Text,
                                        tbEmail.Text, tbPhone.Text);

            //lbMain.Items.Add(resume);
            items.Add(resume);
        }

        private void lbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = lbMain.SelectedIndex;
            selectedResume = (Resume)lbMain.Items[selectedIndex];
            if (selectedResume == null)
                return;
            tbFirstName.Text = selectedResume.FirstName;
            tbSureName.Text = selectedResume.SureName;
            tbEmail.Text = selectedResume.EMail;
            tbPhone.Text = selectedResume.Phone;


        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
                return;


            items[selectedIndex].change(tbFirstName.Text, tbSureName.Text,
                                        tbEmail.Text, tbPhone.Text);


            lbMain.Invalidate();
            //lbMain.Update();
            //lbMain.Refresh();



            //selectedResume.change(tbFirstName.Text, tbSureName.Text,
            //                            tbEmail.Text, tbPhone.Text);
            //lbMain.Items[selectedIndex] = selectedResume;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
                return;
            items.RemoveAt(selectedIndex);
            lbMain.Invalidate();
            ;

        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            using (var stream = new FileStream("resumes.xml", FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(List<Resume>));
                serializer.Serialize(stream, items.ToList());
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            string filePath = "resumes.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Resume>));
            List<Resume> resumes;
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                resumes = (List<Resume>)serializer.Deserialize(stream);
            }
            BindingList<Resume> items = new BindingList<Resume>(resumes);
        }
    }
}
