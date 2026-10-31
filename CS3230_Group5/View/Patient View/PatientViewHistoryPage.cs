using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3230_Group5.View.Patient_View
{
    public partial class PatientViewHistoryPage : Form
    {
        private readonly int _patientId;

        public PatientViewHistoryPage(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
        }

        private void patientHeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void PatientViewHistoryPage_Load(object sender, EventArgs e)
        {

        }
    }
}
