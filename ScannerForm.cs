using AForge.Video;
using AForge.Video.DirectShow;
using Amazon;
using Amazon.Textract;
using Amazon.Textract.Model;
using TechSivaram.DocScan.Registration;
using TechSivaram.DocScan.Textract.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace TechSivaram.DocScan
{
    public partial class ScannerForm : System.Windows.Forms.Form
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        private ScanDevice device = null;

        public static TextractDocument formFieldData;
        public static string Symptoms = "";

        public static string ScannedDocBase64 { get; private set; }

        public ScannerForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (lstScanners.SelectedIndex < 0)
            {
                MessageBox.Show("You need to select first an scanner device from the list",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pb_ScannedDoc.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void TriggerScan()
        {
            MessageBox.Show("Image succesfully scanned");
        }

        private void ListScanners()
        {
            // Clear the ListBox.
            lstScanners.Items.Clear();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (AForge.Video.DirectShow.FilterInfo Device in filterInfoCollection)
            {
                lstScanners.Items.Add(Device.Name);
            }

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox (the entire DeviceInfos object)
                // Important: we store an object of type scanner (which ToString method returns the name of the scanner)
                lstScanners.Items.Add(
                    new ScanDevice(deviceManager.DeviceInfos[i])
                );
            }
        }

        private void ScannerForm_Load(object sender, EventArgs e)
        {
            ListScanners();
            if (lstScanners.Items.Count > 0)
                lstScanners.SelectedIndex = 0;
        }

        public void StartScanning()
        {
            ScanDevice device = null;

            this.Invoke(new MethodInvoker(delegate ()
            {
                if (lstScanners.SelectedItem is ScanDevice)
                    device = lstScanners.SelectedItem as ScanDevice;

                if (lstScanners.SelectedItem is string)
                {
                    if (filterInfoCollection[lstScanners.SelectedIndex] != null)
                    {
                        if (filterInfoCollection[lstScanners.SelectedIndex] is AForge.Video.DirectShow.FilterInfo)
                        {
                            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[lstScanners.SelectedIndex].MonikerString);
                            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
                            videoCaptureDevice.Start();
                            return;
                        }
                    }
                }
            }));


            if (device != null)
            {
                ImageFile image = new ImageFile();
                string imageExtension = "";

                this.Invoke(new MethodInvoker(delegate ()
                {
                    image = device.ScanPNG();
                    imageExtension = ".png";
                }));

                byte[] buffer = (byte[])image.FileData.get_BinaryData();
                MemoryStream ms = new MemoryStream(buffer);
                var img = Image.FromStream(ms);
                pb_ScannedDoc.Image = new Bitmap(img);
            }

            //var img = Image.FromFile(@"C:\Users\sivaram\Downloads\Brookwood.png");
            ////var img = Image.FromStream(ms);
            //pb_ScannedDoc.Image = new Bitmap(img);
        }

        private void ScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (pb_ScannedDoc.Image == null)
            {
                MessageBox.Show("Please scan");
                return;
            }

            AmazonTextractClient client = new AmazonTextractClient("xxx", "xxx", RegionEndpoint.APSouth1);
            MemoryStream stream = new MemoryStream();
            pb_ScannedDoc.Image.Save(stream, ImageFormat.Png);
            AnalyzeDocumentRequest analyzeDocumentRequest = new AnalyzeDocumentRequest
            {
                Document = new Document
                {
                    Bytes = stream

                },
                FeatureTypes = new List<string>
                {
                    FeatureType.TABLES,
                    FeatureType.FORMS
                }
            };

            DetectDocumentTextRequest detectDocumentTextRequest = new DetectDocumentTextRequest
            {
                Document = new Document
                {
                    Bytes = stream
                }
            };

            ScannedDocBase64 = Convert.ToBase64String(stream.ToArray());

            var analyzeDocumentResponse = client.AnalyzeDocument(analyzeDocumentRequest);
            var detextTextResponse = client.DetectDocumentText(detectDocumentTextRequest);

            List<Block> blocks = analyzeDocumentResponse.Blocks;
            List<Block> textBlocks = detextTextResponse.Blocks;

            //get key and value maps
            List<Block> key_map = new List<Block>();
            List<Block> value_map = new List<Block>();
            List<Block> block_map = new List<Block>();
            List<Block> table_blocks = new List<Block>();

            var document = new TextractDocument(analyzeDocumentResponse);
            formFieldData = document;
            document.Pages.ForEach(page =>
            {
                page.Tables.ForEach(table =>
                {
                    var r = 0;
                    table.Rows.ForEach(row =>
                    {
                        r++;
                        var c = 0;
                        row.Cells.ForEach(cell =>
                        {
                            c++;
                            Console.WriteLine("Table [{0}][{1}] = {2}", r, c, cell.Text);
                        });
                    });
                });
            });

            string[] codes = {"Z11.59", "Z03.818", "Z20.828", "B97.29", "J12.89", "J20.8", "J40.0", "J22.0", "J98.8", "J80.0", "R05.0", "R06.02", "R50.9","R68.83","R53.83",
                "M79.1","R51.0","R43.9","R07.0","R09.89","R11.2","R11.0","R19.7","U07.1","U07.2" };
            string[] symptoms = { };

            foreach (Block block in textBlocks)
            {
                if (!string.IsNullOrEmpty(block.Text))
                {
                    codes.Where(i => block.Text.Contains(i)).Select(i => i).ToList().ForEach(i =>
                    {
                        if (!symptoms.Any(s => s == i))
                        {
                            symptoms = symptoms.Append(i).ToArray();
                        }
                    });
                }
            }

            Symptoms = string.Join(",", symptoms);

            //foreach (Block block in blocks)
            //{
            //    var block_id = block.Id;
            //    block_map.Add(block);
            //    if (block.BlockType == BlockType.KEY_VALUE_SET)
            //    {
            //        if (block.EntityTypes.Contains("KEY"))
            //        {
            //            key_map.Add(block);
            //        }
            //        else
            //        {
            //            value_map.Add(block);
            //        }
            //    }

            //    if (block.BlockType == BlockType.TABLE)
            //    {
            //        var t = new Table(block, table_blocks);
            //        Console.WriteLine(t.ToString());
            //    }
            //}

            //var getKeyValueRelationship = Get_kv_relationship(key_map, value_map, block_map);

            //foreach (KeyValuePair<string, string> kvp in getKeyValueRelationship)
            //{
            //    Console.WriteLine(" {0} : {1}", kvp.Key, kvp.Value);
            //}

            RegistrationForm rf = new RegistrationForm();
            rf.FormClosed += Rf_FormClosed;
            DialogResult dres = rf.ShowDialog();
        }

        private void Rf_FormClosed(object sender, FormClosedEventArgs e)
        {
            pb_ScannedDoc.Image.Dispose();
            pb_ScannedDoc.Image = null;
        }

        public static Dictionary<string, string> Get_kv_relationship(List<Block> key_map, List<Block> value_map, List<Block> block_map)
        {
            List<string> kvs1 = new List<string>();
            Dictionary<string, string> kvs = new Dictionary<string, string>();
            Block value_block = new Block();
            string key, val = string.Empty;

            foreach (var block in key_map)
            {
                value_block = Find_value_block(block, value_map);
                key = Get_text(block, block_map);
                val = Get_text(value_block, block_map);
                kvs.Add(key, val);
            }

            return kvs;
        }

        public static Block Find_value_block(Block block, List<Block> value_map)
        {
            Block value_block = new Block();
            foreach (var relationship in block.Relationships)
            {
                if (relationship.Type == "VALUE")
                {
                    foreach (var value_id in relationship.Ids)
                    {
                        value_block = value_map.First(x => x.Id == value_id);
                    }

                }

            }
            return value_block;

        }

        public static string Get_text(Block result, List<Block> block_map)
        {
            string text = string.Empty;
            Block word = new Block();

            if (result.Relationships.Count > 0)
            {
                foreach (var relationship in result.Relationships)
                {
                    if (relationship.Type == "CHILD")
                    {
                        foreach (var child_id in relationship.Ids)
                        {
                            word = block_map.First(x => x.Id == child_id);
                            if (word.BlockType == "WORD")
                            {
                                text += word.Text + " ";
                            }
                            if (word.BlockType == "SELECTION_ELEMENT")
                            {
                                if (word.SelectionStatus == "SELECTED")
                                {
                                    text += "X ";
                                }

                            }
                        }
                    }
                }
            }
            return text;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }
    }
}
