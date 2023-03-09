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

namespace Farmacia
{
    public partial class Form1 : Form
    {
        private List<Medication> medicationList = new List<Medication>();
        private string MedicationListWay = "medicationList.txt";

        public Form1()
        {
            InitializeComponent();

            medicationList = MedicationListRead();

            dataGridView1.DataSource = medicationList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Medication medication = new Medication();
            medication.medicationName = txtMedicationName.Text;
            medication.medicationAmount = Convert.ToInt32(txtMedicationAmount.Text);
            medication.medicationPrice = Convert.ToDecimal(txtMedicationPrice.Text);

            medicationList.Add(medication);

            // Write updated medication list to file
            FileManagment.MedicationListFileWrite(medicationList);


            // Reflesh DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = medicationList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                medicationList.RemoveAt(selectedIndex);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = medicationList;
                // Write updated medication list to file
                FileManagment.MedicationListFileWrite(medicationList);
            }
        }

        // Medication list read
        private static List<Medication> MedicationListRead()
        {
            List<Medication> medicationList = new List<Medication>();
            StreamReader sr = new StreamReader("medicationList.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] lineParts = line.Split('|');
                Medication medication = new Medication();
                medication.medicationName = lineParts[0];
                medication.medicationAmount = Convert.ToInt32(lineParts[1]);
                medication.medicationPrice = Convert.ToDecimal(lineParts[2]);
                medicationList.Add(medication);
            }
            sr.Close();
            return medicationList;
        }

        // Medication List write
        public class FileManagment
        {
            public static void MedicationListFileWrite(List<Medication> medicationsList)
            {
                StreamWriter sw = new StreamWriter("medicationList.txt");
                foreach (Medication medication in medicationsList)
                {
                    sw.WriteLine(medication.medicationName + "|" + medication.medicationAmount + "|" + medication.medicationPrice);
                }
                sw.Close();
            }
        }


        public class Medication
        {
            public string medicationName { get; set; }
            public int medicationAmount { get; set; }
            public decimal medicationPrice { get; set; }

        }

        private void MedicationUpdate()
        {
            dataGridView1.Rows.Clear();
            string[] medicationList = File.ReadAllLines(MedicationListWay);
            //Add a row to the table for each Medication
            foreach (string medication in medicationList)
            {
                string[] medicationParts = medication.Split('|');
                dataGridView1.Rows.Add(medicationParts[0], medicationParts[1], medicationParts[2]);
            }
        }




        private void txtMedicationName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                Medication medication = medicationList[selectedIndex];
                medication.medicationName = txtMedicationName.Text;
                medication.medicationAmount = Convert.ToInt32(txtMedicationAmount.Text);
                medication.medicationPrice = Convert.ToDecimal(txtMedicationPrice.Text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = medicationList;
                // Write updated medication list to file
                FileManagment.MedicationListFileWrite(medicationList);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            var result = medicationList.Where(m=> m.medicationName.Contains(keyword)).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result;
        }
    }
}