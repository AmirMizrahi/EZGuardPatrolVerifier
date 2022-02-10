using ExcelDataReader;
using EZGuardPatrolVerifier.Engine;
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

namespace EZGuardPatrolVerifier
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxPatrol.SelectedIndex = 0;
            comboBoxPatrolType.SelectedIndex = 0;
        }

        private void textBoxFileLoad_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileList[0].Contains(".xlsx"))
            {
                textBoxFileLoad.Text = fileList[0];
            }
            else
            {
                MessageBox.Show(".xlsx files only!");
            }
        }

        private void textBoxFileLoad_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Workbook|*.xlsx";
            dialog.ValidateNames = true;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxFileLoad.Text = dialog.FileName;
            }
        }

        private void buttonGenerateScan_Click(object sender, EventArgs e)
        {
            int patrolType = comboBoxPatrol.SelectedIndex;
            int patrolHour = comboBoxPatrolType.SelectedIndex;
            ePatrolType patrolType1 = (ePatrolType)patrolType;
            ePatrolHour patrolHour1 = (ePatrolHour)patrolHour;
            SortedDictionary<String, bool> keyValuePairs = new SortedDictionary<string, bool>();
            int i = 1;
            FileStream fileStream;
            List<String> missingPoints = new List<string>();

            try
            {
                fileStream = File.Open(textBoxFileLoad.Text, FileMode.Open, FileAccess.Read);
                IExcelDataReader d = ExcelReaderFactory.CreateReader(fileStream);
                DataSet dd = d.AsDataSet(new ExcelDataSetConfiguration());
                string currentPoint = (string)dd.Tables[0].Rows[i].ItemArray[1];
                string site = (string)dd.Tables[0].Rows[i].ItemArray[0];

                switch (patrolType1)
                {
                    case ePatrolType.Rothchild:
                        {
                            keyValuePairs = TablesData.GetRothPoints(patrolHour1);
                            inputByReleventSiteAndType("Meta, TLV Rothchild", "Full Patrol Start", dd, keyValuePairs);
                            break;
                        }

                    case ePatrolType.Sarona:
                        {
                            keyValuePairs = TablesData.GetSarPoints(patrolHour1);
                            inputByReleventSiteAndType("Meta, TLV Sarona", "START", dd, keyValuePairs);
                            break;
                        }

                    case ePatrolType.JOH:
                        {
                            keyValuePairs = TablesData.GetJOHPoints(patrolHour1);
                            inputByReleventSiteAndType("Meta, JOH", "Recap START", dd, keyValuePairs);
                            break;
                        }

                    case ePatrolType.Novi:
                        {
                            keyValuePairs = TablesData.GetNoviPoints(patrolHour1);
                            inputByReleventSiteAndType("Meta, TLV Sarona", "START 31", dd, keyValuePairs);
                            break;
                        }

                    case ePatrolType.NewFloors:
                        {
                            keyValuePairs = TablesData.Get46To50Points(patrolHour1);
                            inputByReleventSiteAndType("Meta, TLV Sarona", "(START (46-50", dd, keyValuePairs);
                            break;
                        }
                    case ePatrolType.LowerFloorsT:
                        {
                            keyValuePairs = TablesData.GetT31Points();
                            inputByReleventSiteAndType("Meta, TLV Sarona", "START", dd, keyValuePairs);
                            break;
                        }
                    case ePatrolType.HigherFloorsT:
                        {
                            keyValuePairs = TablesData.GetT46Points();
                            inputByReleventSiteAndType("Meta, TLV Sarona", "(START (46-50", dd, keyValuePairs);
                            break;
                        }
                }
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            checkForMissingPoints(keyValuePairs, missingPoints);
            keyValuePairs.Clear();
        }

        private void inputByReleventSiteAndType(string reqSite, string start, DataSet dd, SortedDictionary<String, bool> keyValuePairs)
        {
            int i = 1;
            string currentPoint = (string)dd.Tables[0].Rows[i].ItemArray[1];
            string site = (string)dd.Tables[0].Rows[i].ItemArray[0];

            while (currentPoint != start)
            {
                currentPoint = (string)dd.Tables[0].Rows[i].ItemArray[1];
                site = (string)dd.Tables[0].Rows[i].ItemArray[0];
                if (site == reqSite)
                {
                    if (keyValuePairs.ContainsKey(currentPoint))
                    {
                        keyValuePairs[currentPoint] = true;
                    }
                }
                i++;
            }
        }

        private void checkForMissingPoints(SortedDictionary<String, bool> i_KeyValuePairs, List<String> i_MissingPoints)
        {
            bool areThereAnyMissingPointes = false;

            foreach (KeyValuePair<String, bool> t in i_KeyValuePairs)
            {
                if (!t.Value)
                {
                    i_MissingPoints.Add(t.Key);
                    areThereAnyMissingPointes = true;
                }
            }

            if (areThereAnyMissingPointes)
            {
                FormMissingPointsCopy missingPointsForm = new FormMissingPointsCopy(i_MissingPoints);
                missingPointsForm.ShowDialog();
            }
            else
            {
                Clipboard.SetText("יש הכל.");
                MessageBox.Show("No points missing!" + Environment.NewLine + "(Already copied to your clipboard (now in Hebrew :))");
            }
        }
    }
}