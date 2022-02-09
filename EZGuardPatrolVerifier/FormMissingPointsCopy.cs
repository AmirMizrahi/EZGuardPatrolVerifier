using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZGuardPatrolVerifier
{
    public partial class FormMissingPointsCopy : Form
    {
        private List<String> m_MissingPoints;

        public FormMissingPointsCopy(List<String> i_MissingPoints)
        {
            InitializeComponent();
            m_MissingPoints = i_MissingPoints;
            //this.Text = "Patrol start time: " + i_StartTime;
            ShowMissingPoints();
        }

        public void ShowMissingPoints()
        {
            foreach (String s2 in m_MissingPoints)
            {
                listBoxMissingPoints.Items.Add(s2);
            }
        }

        private void buttonCopyMissingPointsList_Click(object sender, EventArgs e)
        {
            string s1 = "";
            foreach (object item in listBoxMissingPoints.Items) s1 += item.ToString() + "\r\n";
            Clipboard.SetText(s1);
            MessageBox.Show("Copied");
        }
    }
}
