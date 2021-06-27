using System;
using System.Windows.Forms;

namespace TechSivaram.DocScan.Registration
{
    public partial class RequisitionForm : Form
    {
        private readonly string URI = "";
        public RequisitionForm(string requistionUri)
        {
            URI = requistionUri;
            InitializeComponent();
        }

        private void RequisitionForm_Load(object sender, EventArgs e)
        {
            brRequisition.Navigate(URI);
        }
    }
}
