using Newtonsoft.Json;
using RestSharp;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TechSivaram.DocScan.Registration
{
    public partial class RegistrationForm : Form
    {
        PatientDTO request;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            request = new PatientDTO();
            request.Registration = new RegistrationDTO();
            PopulateUI();
        }

        private void PopulateUI()
        {
            txtSymtoms.Text = ScannerForm.Symptoms;
            request.Registration.PhotoFileId = ScannerForm.ScannedDocBase64;

            ScannerForm.formFieldData.Pages.ForEach(page =>
            {
                page.Tables.ForEach(table =>
                {
                    var r = 0;
                    var tab = table;
                    table.Rows.ForEach(row =>
                    {
                        r++;
                        var c = 0;
                        row.Cells.ForEach(cell =>
                        {
                            c++;
                            Console.WriteLine("Table [{0}][{1}] = {2}", r, c, cell.Text);

                            if (cell.Text.Trim() == "Patient Name")
                            {
                                string[] spearator = { ", " };
                                int count = 2;

                                var name = row.Cells[c].Text.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);

                                request.FirstName = name[1].Trim();
                                txtFirstName.Text = request.FirstName;
                                request.LastName = name[0].Trim();
                                txtLastName.Text = request.LastName;
                            }

                            if (cell.Text.Trim().Contains("Sex"))
                            {
                                request.GenderId = Convert.ToByte(row.Cells[c].Text.Split(' ')[0].Trim().ToLower() == "m" ? 1 : 2);
                                cbGender.Text = request.GenderId == 1 ? "Male" : "Female";

                                try
                                {
                                    request.DOB = DateTime.ParseExact(row.Cells[c].Text.Split(' ')[1], "MM/dd/yyyy", CultureInfo.InvariantCulture);
                                    dtDOB.Value = request.DOB;
                                }
                                catch
                                {
                                    Console.WriteLine("Not able to parse DOB");
                                }
                            }

                            if (cell.Text.Trim() == "Address")
                            {
                                request.Address1 = row.Cells[c].Text.Trim();
                                txtAddress1.Text = request.Address1;
                                request.ZipCode = request.Address1.Substring(request.Address1.Length - 5, 5);
                            }

                            if (cell.Text.Trim() == "Primary Insurance")
                            {
                                request.Registration.InsuranceName = row.Cells[c].Text.Trim();
                                string[] spearator = { " ID: " };
                                int count = 2;
                                txtInsuranceName.Text = request.Registration.InsuranceName.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries)[0];

                                string[] spearator1 = { " Group: " };
                                string[] spearator2 = { " Policy Holder: " };

                                if (request.Registration.InsuranceName.Contains(" Group: "))
                                {
                                    txtPolicyNo.Text = request.Registration.InsuranceName
                                                          .Split(spearator, count, StringSplitOptions.RemoveEmptyEntries)[1]
                                                          .Split(spearator1, count, StringSplitOptions.RemoveEmptyEntries)[0];
                                    request.Registration.InsurancePolicyId = txtPolicyNo.Text.Trim();
                                }
                                else
                                {
                                    txtPolicyNo.Text = request.Registration.InsuranceName
                                                          .Split(spearator, count, StringSplitOptions.RemoveEmptyEntries)[1]
                                                          .Split(spearator2, count, StringSplitOptions.RemoveEmptyEntries)[0];
                                    request.Registration.InsurancePolicyId = txtPolicyNo.Text.Trim();
                                }

                                if (request.Registration.InsuranceName.Contains(" Group: "))
                                {
                                    txtGroupNumber.Text = request.Registration.InsuranceName
                                                              .Split(spearator, count, StringSplitOptions.RemoveEmptyEntries)[1]
                                                              .Split(spearator1, count, StringSplitOptions.RemoveEmptyEntries)[1]
                                                              .Split(spearator2, count, StringSplitOptions.RemoveEmptyEntries)[0];
                                    request.Registration.InsuranceGroupId = txtGroupNumber.Text.Trim();
                                    txtInsured.Text = request.Registration.InsuranceName
                                                              .Split(spearator, count, StringSplitOptions.RemoveEmptyEntries)[1]
                                                              .Split(spearator1, count, StringSplitOptions.RemoveEmptyEntries)[1]
                                                              .Split(spearator2, count, StringSplitOptions.RemoveEmptyEntries)[1];
                                }
                                else
                                {
                                    txtInsured.Text = request.Registration.InsuranceName
                                                              .Split(spearator, count, StringSplitOptions.RemoveEmptyEntries)[1]
                                                              .Split(spearator2, count, StringSplitOptions.RemoveEmptyEntries)[1];
                                }

                                request.Registration.NameInsured = txtInsured.Text.Trim();
                                request.Registration.InsuranceName = txtInsuranceName.Text;
                            }

                            if (cell.Text.Trim() == "Phone")
                            {
                                string[] spearator1 = { "h: " };
                                string[] spearator2 = { " w:" };
                                txtPhone.Text = row.Cells[c].Text.Trim().ToLower().Split(spearator1, 2, StringSplitOptions.RemoveEmptyEntries)[0]
                                                                        .Split(spearator2, 2, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                                txtPhone.Text = txtPhone.Text.Replace("(", "").Replace(" ", "").Replace(")", "").Replace("-", "");
                            }

                            if (cell.Text.Trim() == "Ordering Provider")
                            {
                                var pro = tab.Rows[r].Cells[1].Text;

                                if (pro.ToUpper().Contains("HYD"))
                                {
                                    request.Registration.LocationCode = "HYD";
                                }

                                if (pro.ToUpper().Contains("BAN"))
                                {
                                    request.Registration.LocationCode = "NAN";
                                }

                                if (pro.ToUpper().Contains("DEL"))
                                {
                                    request.Registration.LocationCode = "DEL";
                                }

                                if (pro.ToUpper().Contains("MUM"))
                                {
                                    request.Registration.LocationCode = "MUM";
                                }

                                string[] numbers = Regex.Split(pro, @"\D+");

                                var prList = pro.Split(',')[0].Split(' ');
                                txtPFirstName.Text = prList[0];

                                if (prList.Length > 1)
                                {
                                    txtPLastName.Text = prList[1];
                                }

                                if (prList.Length > 2)
                                {
                                    txtPLastName.Text += prList[2];
                                }

                                foreach (var n in numbers)
                                {
                                    if (n.Length == 10)
                                    {
                                        txtNPI.Text = n;
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                txtPFirstName.Text = "firstname";
                                txtPLastName.Text = "lastname";
                                txtNPI.Text = "2555666";
                            }
                        });
                    });
                });
            });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            request.Symptoms = ScannerForm.Symptoms;
            request.SitePhone = "+1xxxxxxxx";
            request.Phone = txtPhone.Text;
            request.Address1 = txtAddress1.Text;
            request.FirstName = txtFirstName.Text;
            request.LastName = txtLastName.Text;
            request.ProviderFirstName = txtPFirstName.Text;
            request.ProviderLastName = txtPLastName.Text;
            request.ProviderNPI = txtNPI.Text;
            request.DOB = dtDOB.Value.Date;
            request.Address1 = txtAddress1.Text;
            request.GenderId = Convert.ToByte(cbGender.Text == "Male" ? 1 : 2);
            request.Registration.InsuranceName = txtInsuranceName.Text;
            request.Registration.InsurancePolicyId = txtPolicyNo.Text;
            request.Registration.InsuranceGroupId = txtGroupNumber.Text;
            request.Registration.NameInsured = txtInsured.Text;
            request.Symptoms = txtSymtoms.Text;
            string jsonString = JsonConvert.SerializeObject(request, Formatting.Indented,
                new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });

            RestClient client = new RestClient($"http://server/Registration/Public") { Timeout = -1 };
            var cdRequest = new RestRequest(Method.POST);
            cdRequest.AddHeader("Content-Type", "application/json");
            cdRequest.AddParameter("application/json", jsonString, ParameterType.RequestBody);

            IRestResponse response = client.Execute(cdRequest);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                string result = response.Content;
                MessageBox.Show("Toxicology Exception:" + result);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Order # " + response.Content, "Print Requisition", MessageBoxButtons.OK);

                if (dialogResult == DialogResult.OK)
                {
                    var pdfClient = new RestClient("http://server/PrintRequisition/" + response.Content);
                    pdfClient.Timeout = -1;
                    var request = new RestRequest(Method.GET);
                    request.AddHeader("Authorization", "Bearer xxxxxxxxx");
                    request.AddParameter("text/plain", "", ParameterType.RequestBody);
                    IRestResponse respPdf = pdfClient.Execute(request);
                    Console.WriteLine(respPdf.Content);
                    //System.Diagnostics.Process.Start(respPdf.Content.Replace('"', ' ').Trim());
                    Close();
                    RequisitionForm rf = new RequisitionForm(respPdf.Content.Replace('"', ' ').Trim());
                    rf.WindowState = FormWindowState.Maximized;
                    rf.ShowDialog(this);
                }
            }
        }
    }
}
