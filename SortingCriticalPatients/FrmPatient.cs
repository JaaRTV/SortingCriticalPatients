using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingCriticalPatients
{
    public partial class FrmPatient : Form
    {
        public FrmPatient()
        {
            InitializeComponent();
            StarInitalize();
        }

        List<Patient> PatienList;

        private void StarInitalize()
        {
            PatienList = new List<Patient>(5);
            Patient p1 = new("Alex", "Mitchel", 21, "critical");
            Patient p2 = new("Kate", "Pupsvel", 18, "critical");
            Patient p3 = new("Georg", "Robbinson", 42, "normal");
            Patient p4 = new("LG", "Company", 120, "normal");
            Patient p5 = new("Mikky", "Mouse", 30, "critical");
            PatienList.Add(p1);
            PatienList.Add(p2);
            PatienList.Add(p3);
            PatienList.Add(p4);
            PatienList.Add(p5);

            lVResult.GridLines = true;
            lVResult.View = View.Details;

            lVResult.GridLines = true;
            lVResult.View = View.Details;
            lVResult.Columns.Clear();
            lVResult.Columns.Add("Имя", 150, HorizontalAlignment.Center);
            lVResult.Columns.Add("Фамилия", 150, HorizontalAlignment.Center);
            lVResult.Columns.Add("Возрост", 150, HorizontalAlignment.Center);
            lVResult.Columns.Add("Статус", 150, HorizontalAlignment.Center);

            lVResult.FullRowSelect = true;
            lVResult.MultiSelect = true;

        }

        private void bLessThan_Click(object sender, EventArgs e)
        {
            var check = CheckingTextBoxIsEmpty(textBoxLessThan.Text);
            var textLength = textBoxLessThan.Text.Length;
            if (check == 1 && textLength <= 3)
            {
                SearchInPatientList(textBoxLessThan.Text,"LessThan");   
            }
            else
            {
                MessageBox.Show("Перепроверьте параметр поиска!");
            }

        }
        private void bFindByName_Click(object sender, EventArgs e)
        {
            var check = CheckingTextBoxIsEmpty(textBoxFindByName.Text);
            var textLength = textBoxFindByName.Text.Length;
            if (check == 1 && textLength >= 1)
            {
                SearchInPatientList(textBoxFindByName.Text, "FindByName");
            }
            else
            {
                MessageBox.Show("Перепроверьте параметр поиска!");
            }
        }

        private void bFindBySurname_Click(object sender, EventArgs e)
        {
            var check = CheckingTextBoxIsEmpty(textBoxFindBySurname.Text);
            var textLength = textBoxFindBySurname.Text.Length;
            if (check == 1 && textLength >= 1)
            {
                SearchInPatientList(textBoxFindBySurname.Text, "FindBySurname");
            }
            else
            {
                MessageBox.Show("Перепроверьте параметр поиска!");
            }
        }

        private void bCritical_Click(object sender, EventArgs e)
        {
            SearchInPatientList("critical", "critical");
        }

        private int CheckingTextBoxIsEmpty(string v)
        {
            if (v == String.Empty)
            {
                MessageBox.Show("Введите параметр поиска!");
                return 0;
            }
            else
            {
                return 1;
            }

        }
        private void SearchInPatientList(string text, string searchParam)
        {
            lVResult.Items.Clear();
            if (searchParam.Equals("LessThan"))
            {
                int search = Int32.Parse(text);
                var searchResult = PatienList.Where(i=> i.Age < search); 

                lVResult.BeginUpdate();
                foreach (var item in searchResult)
                {
                    lVResult.Items.Add(new ListViewItem(new string[] {item.Name, item.Surname, item.Age.ToString(), item.Status}));
                }
                lVResult.EndUpdate();
            }
            else if (searchParam.Equals("FindByName"))
            {
                var searchResult = PatienList.Where(i => i.Name == text);

                lVResult.BeginUpdate();
                foreach (var item in searchResult)
                {
                    lVResult.Items.Add(new ListViewItem(new string[] { item.Name, item.Surname, item.Age.ToString(), item.Status }));
                }
                lVResult.EndUpdate();
            }
            else if (searchParam.Equals("FindBySurname"))
            {
                var searchResult = PatienList.Where(i => i.Surname == text);

                lVResult.BeginUpdate();
                foreach (var item in searchResult)
                {
                    lVResult.Items.Add(new ListViewItem(new string[] { item.Name, item.Surname, item.Age.ToString(), item.Status }));
                }
                lVResult.EndUpdate();
            }
            else if (searchParam.Equals("critical"))
            {
                var searchResult = PatienList.Where(i => i.Status == text);

                lVResult.BeginUpdate();
                foreach (var item in searchResult)
                {
                    lVResult.Items.Add(new ListViewItem(new string[] { item.Name, item.Surname, item.Age.ToString(), item.Status }));
                }
                lVResult.EndUpdate();
            }

        }
    }
}
