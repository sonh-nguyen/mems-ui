using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Electrochemical_Potentiostat
{
    public partial class Form1 : Form
    {
        NumberFormatInfo provider = new NumberFormatInfo();
        LineItem curve1, curve2, curve3, curve4, curve5, curve6;

        int intlen = 0, status = 0, receiverCount = 0;
        int S_Vol, E_Vol, Step, RepeatTimes, numStep = 0, numSample = 1;
        double time, mag, phase;

        string[] buffSerial = new string[25000];

        double[] bufferV = new double[25000];
        double[] bufferC = new double[25000];
        double[] tempC = new double[25000];

        double[] buffFreq = new double[25000];
        double[] buffMag = new double[25000];
        double[] buffPhase = new double[25000];

        //sonnh
        const int ExtraSub = 1;
        const int Sub = 2;
        const int Add = 3;
        const int ExtraAdd = 4;

        private void sendControlVoltageCmd(int Cmd)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Please connect to the port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int VoltageIdx = -1;
                if (cbVoltage1.Checked)
                    VoltageIdx = 1;
                else if (cbVoltage2.Checked)
                    VoltageIdx = 2;


                //string str = "1#" + CVnumericStartVolt.Text + '?' + CVnumericEndVolt.Text + '/' + numStep.ToString() + '|' + CVnumericRepeatTimes.Text + "$0!";
                string str = "3#" + VoltageIdx.ToString() + '?' + Cmd.ToString() + "/" + "!";
                serialPort1.Write(str);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            provider.NumberDecimalSeparator = ".";
            CV_ClearGraph();
            EIS_ClearGraph();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            //sonnh display Voltage




            //sonnh end
            if (true)
            {
                Console.WriteLine("Got Data");

                string[] arrList = serialPort1.ReadExisting().Split(';');

                Console.WriteLine(arrList[0] + " " + arrList[1]);
                if (arrList.Length > 1)
                {
                    if (tbVoltage1.InvokeRequired)
                    {
                        tbVoltage1.Invoke(new MethodInvoker(delegate () {
                            tbVoltage1.Text = arrList[0];
                        }));
                    }
                    else
                    {
                        tbVoltage1.Text = arrList[0];
                    }

                    if (tbVoltage2.InvokeRequired)
                    {
                        tbVoltage2.Invoke(new MethodInvoker(delegate () {
                            tbVoltage2.Text = arrList[1];
                        }));
                    }
                    else
                    {
                        tbVoltage2.Text = arrList[1];
                    }

                }

            }
            //else if (CVbtnMeasure.Enabled == false)
            //{
            //    /*string[] arrList = serialPort1.ReadExisting().Split('\n');
            //    int i = 0;
            //    while (i < arrList.Length)
            //    {
            //        Console.WriteLine(receiverCount);
            //        if (buffSerial[receiverCount] == null)
            //        {
            //            buffSerial[receiverCount] = arrList[i];
            //        }
            //        else
            //        {
            //            buffSerial[receiverCount] += arrList[i];
            //        }
            //        if (arrList[i].Contains("\r"))
            //        {
            //            receiverCount++;
            //        }
            //        i++;
            //    }*/
            //    string str = serialPort1.ReadLine();
            //    if (str[0] >= '0' && str[0] <= '9')
            //    {
            //        buffSerial[receiverCount] = str;
            //        receiverCount++;
            //        Console.WriteLine(receiverCount);
            //    }
            //}
            //else if (EISbtnMeasure.Enabled == false || EISbtnMeasure.Text == "Stop")
            //{
            //    string[] arrList = serialPort1.ReadLine().Split(';');
            //    if (arrList.Length > 1)
            //    {
            //        buffFreq[receiverCount] = Convert.ToDouble(arrList[0], provider);
            //        if (arrList[1] == "inf")
            //        {
            //            buffMag[receiverCount] = 60000000;
            //        }
            //        else
            //        {
            //            buffMag[receiverCount] = Convert.ToDouble(arrList[1], provider);
            //        }
            //        buffPhase[receiverCount] = Convert.ToDouble(arrList[2], provider);

            //        time = buffFreq[receiverCount] / 1000;
            //        mag = buffMag[receiverCount];
            //        phase = buffPhase[receiverCount];

            //        Console.WriteLine(receiverCount);
            //        receiverCount++;
            //        status = 1;
            //    }
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); // Get list COM ports
            if (intlen != ports.Length)
            {
                if (ports.Length == 0)
                {
                    serialPort1.Close();

                    CVselectPort.ResetText();
                    CVstatusCOM.Value = 0;
                    CVbtnConnect.Enabled = true;
                    CVbtnDisconnect.Enabled = false;
                    CVbtnMeasure.Enabled = true;
                    CVbtnImport.Enabled = true;
                    CVbtnExport.Enabled = true;

                    EISselectPort.ResetText();
                    EISstatusCOM.Value = 0;
                    EISbtnConnect.Enabled = true;
                    EISbtnDisconnect.Enabled = false;
                    EISbtnMeasure.Enabled = true;
                    EISbtnImport.Enabled = true;
                    EISbtnExport.Enabled = true;
                }
                else
                {
                    intlen = ports.Length;

                    CVselectPort.Items.Clear();
                    CVselectPort.Items.AddRange(ports);

                    EISselectPort.Items.Clear();
                    EISselectPort.Items.AddRange(ports);

                     //sonnh
                    selectPort.Items.Clear();
                    selectPort.Items.AddRange(ports);
                    //sonnh end
                }
            }

            if (CVbtnMeasure.Enabled == false)
            {
                CVprogressBar.Value = receiverCount * 100 / numSample;
                if (CVprogressBar.Value == 100)
                {
                    CV_DataProcess();
                    CV_DataListview();
                    CV_DrawGraph();
                    receiverCount = 0;
                    CVbtnMeasure.Enabled = true;
                    CVbtnClearAll.Enabled = true;
                    CVbtnImport.Enabled = true;
                    CVbtnExport.Enabled = true;
                }
            }
            else if (EISbtnMeasure.Enabled == false)
            {
                EISprogressBar.Value = receiverCount * 100 / numSample;
                EIS_DataListview();
                status = 0;
                if (receiverCount == numSample)
                {
                    EIS_DrawGraph();
                    receiverCount = 0;

                    EISbtnMeasure.Enabled = true;
                    EISbtnClearAll.Enabled = true;
                    EISbtnImport.Enabled = true;
                    EISbtnExport.Enabled = true;
                    EIScheckBoxSweepEn.Enabled = true;
                    EIScheckBoxLog.Enabled = true;
                    EISnumericStartFreq.Enabled = true;
                    EISnumericStopFreq.Enabled = true;
                    EISnumericSweepPoints.Enabled = true;
                    EISnumericRepeatTimes.Enabled = true;
                }
            }
            else if (EISbtnMeasure.Text == "Stop")
            {
                if (status == 1)
                {
                    EIS_DataListview();
                    EIS_DrawGraphRealtime();
                    status = 0;
                }
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (CVbtnMeasure.Enabled == false)
            {
                tabControl1.SelectedIndex = 0;
                MessageBox.Show("Please wait for Cyclic Voltammetry Measurement done!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (EISbtnMeasure.Text == "Stop")
            {
                tabControl1.SelectedIndex = 1;
                MessageBox.Show("Please Stop Electrochemical Impedance Spectroscopy Measurement before taking another measurement!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (EISbtnMeasure.Enabled == false)
            {
                tabControl1.SelectedIndex = 1;
                MessageBox.Show("Please wait for Electrochemical Impedance Spectroscopy Measurement done!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CV_ClearGraph();
                CVlistView.Items.Clear();

                EIS_ClearGraph();
                EISlistView.Items.Clear();

                ClearData();
            }
        }

        private void CVbtnConnect_Click(object sender, EventArgs e)
        {
            if (CVselectPort.Text == "")
            {
                MessageBox.Show("Please select the port COM!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                serialPort1.PortName = CVselectPort.Text;
                EISselectPort.Text = CVselectPort.Text;
                try
                {
                    serialPort1.Open();

                    CVbtnConnect.Enabled = false;
                    CVbtnDisconnect.Enabled = true;
                    CVstatusCOM.Value = 100;

                    EISbtnConnect.Enabled = false;
                    EISbtnDisconnect.Enabled = true;
                    EISstatusCOM.Value = 100;
                }
                catch
                {
                    MessageBox.Show("Connect to the port " + serialPort1.PortName + " is denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CVbtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();

                CVstatusCOM.Value = 0;
                CVbtnConnect.Enabled = true;
                CVbtnDisconnect.Enabled = false;
                CVbtnMeasure.Enabled = true;
                CVbtnClearAll.Enabled = true;
                CVbtnImport.Enabled = true;
                CVbtnExport.Enabled = true;

                EISstatusCOM.Value = 0;
                EISbtnConnect.Enabled = true;
                EISbtnDisconnect.Enabled = false;
                EISbtnMeasure.Enabled = true;
                EISbtnClearAll.Enabled = true;
                EISbtnImport.Enabled = true;
                EISbtnExport.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Disconnect to the port " + serialPort1.PortName + " is denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EISbtnConnect_Click(object sender, EventArgs e)
        {
            if (EISselectPort.Text == "")
            {
                MessageBox.Show("Please select the port COM!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                serialPort1.PortName = EISselectPort.Text;
                CVselectPort.Text = CVselectPort.Text;
                try
                {
                    serialPort1.Open();

                    CVbtnConnect.Enabled = false;
                    CVbtnDisconnect.Enabled = true;
                    CVstatusCOM.Value = 100;

                    EISbtnConnect.Enabled = false;
                    EISbtnDisconnect.Enabled = true;
                    EISstatusCOM.Value = 100;
                }
                catch
                {
                    MessageBox.Show("Connect to the port " + serialPort1.PortName + " is denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EISbtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();

                CVstatusCOM.Value = 0;
                CVbtnConnect.Enabled = true;
                CVbtnDisconnect.Enabled = false;
                CVbtnMeasure.Enabled = true;
                CVbtnClearAll.Enabled = true;
                CVbtnImport.Enabled = true;
                CVbtnExport.Enabled = true;

                EISstatusCOM.Value = 0;
                EISbtnConnect.Enabled = true;
                EISbtnDisconnect.Enabled = false;
                EISbtnMeasure.Enabled = true;
                EISbtnClearAll.Enabled = true;
                EISbtnImport.Enabled = true;
                EISbtnExport.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Disconnect to the port " + serialPort1.PortName + " is denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CVbtnMeasure_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Please connect to the port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((CVnumericStartVolt.Text == "") || (CVnumericEndVolt.Text == "") || (CVnumericStep.Text == "") || (CVnumericRepeatTimes.Text == ""))
            {
                MessageBox.Show("Please complete all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                buffSerial = new string[25000];

                bufferC = new double[25000];
                bufferV = new double[25000];
                tempC = new double[25000];

                S_Vol = Convert.ToInt32(CVnumericStartVolt.Text);
                E_Vol = Convert.ToInt32(CVnumericEndVolt.Text);
                Step = Convert.ToInt32(CVnumericStep.Text);
                RepeatTimes = Convert.ToInt32(CVnumericRepeatTimes.Text);

                numStep = ((E_Vol - S_Vol) / Step + 1) * 2;
                numSample = numStep * RepeatTimes;

                CV_ClearGraph();
                CVlistView.Items.Clear();

                CVbtnMeasure.Enabled = false;
                CVbtnClearAll.Enabled = false;
                CVbtnImport.Enabled = false;
                CVbtnExport.Enabled = false;
                CVprogressBar.Value = 0;

                receiverCount = 0;

                //string str = "1#" + CVnumericStartVolt.Text + '?' + CVnumericEndVolt.Text + '/' + numStep.ToString() + '|' + CVnumericRepeatTimes.Text + "$0!";
                string str = "1#" + (-E_Vol).ToString() + '?' + (-S_Vol).ToString() + '/' + numStep.ToString() + '|' + CVnumericRepeatTimes.Text + "$0!";
                serialPort1.Write(str);
            }
        }

        private void EISbtnMeasure_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Please connect to the port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((EISnumericStartFreq.Text == "") || (EISnumericStopFreq.Text == "") || (EISnumericSweepPoints.Text == "") || (EISnumericRepeatTimes.Text == ""))
            {
                MessageBox.Show("Please complete all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (EISbtnMeasure.Text == "Measure")
            {
                buffSerial = new string[25000];

                buffFreq = new double[25000];
                buffMag = new double[25000];
                buffPhase = new double[25000];

                receiverCount = 0;
                status = 0;
                EIS_ClearGraph();
                EISlistView.Items.Clear();

                if (EIScheckBoxSweepEn.Checked == true)
                {
                    EISbtnMeasure.Enabled = false;
                }
                else
                {
                    EISbtnMeasure.Text = "Stop";
                }

                EISbtnClearAll.Enabled = false;
                EISbtnImport.Enabled = false;
                EISbtnExport.Enabled = false;
                EIScheckBoxSweepEn.Enabled = false;
                EIScheckBoxLog.Enabled = false;
                EISnumericStartFreq.Enabled = false;
                EISnumericStopFreq.Enabled = false;
                EISnumericSweepPoints.Enabled = false;
                EISnumericRepeatTimes.Enabled = false;

                string str;
                var logEn = EIScheckBoxLog.Checked ? "1" : "0";

                S_Vol = Convert.ToInt32(EISnumericStartFreq.Text);
                E_Vol = Convert.ToInt32(EISnumericStopFreq.Text);
                numStep = Convert.ToInt32(EISnumericSweepPoints.Text);
                RepeatTimes = Convert.ToInt32(EISnumericRepeatTimes.Text);
                numSample = numStep * RepeatTimes;

                if (EIScheckBoxSweepEn.Checked == false)
                {
                    str = "2#" + EISnumericStartFreq.Text + '?' + EISnumericStartFreq.Text + '/' + EISnumericSweepPoints.Text + '|' + EISnumericRepeatTimes.Text + "$0!";
                }
                else
                {
                    numSample = Convert.ToInt32(EISnumericSweepPoints.Text) * Convert.ToInt32(EISnumericRepeatTimes.Text);
                    str = "2#" + EISnumericStartFreq.Text + '?' + EISnumericStopFreq.Text + '/' + EISnumericSweepPoints.Text + '|' + EISnumericRepeatTimes.Text + '$' + logEn + '!';
                }
                serialPort1.Write(str);
            }
            else
            {
                EISbtnMeasure.Text = "Measure";
                if (EIScheckBoxSweepEn.Checked == true)
                {
                    EISbtnClearAll.Enabled = true;
                    EISbtnImport.Enabled = true;
                    EISbtnExport.Enabled = true;
                    EIScheckBoxSweepEn.Enabled = true;
                    EIScheckBoxLog.Enabled = true;
                    EISnumericStartFreq.Enabled = true;
                    EISnumericStopFreq.Enabled = true;
                    EISnumericSweepPoints.Enabled = true;
                    EISnumericRepeatTimes.Enabled = true;
                }
                else
                {
                    EISbtnClearAll.Enabled = true;
                    EISbtnImport.Enabled = true;
                    EISbtnExport.Enabled = true;
                    EIScheckBoxSweepEn.Enabled = true;
                    EISnumericStartFreq.Enabled = true;
                }

                serialPort1.Write("s");
                numSample = receiverCount;
            }
        }

        private void CVbtnClearAll_Click(object sender, EventArgs e)
        {
            if (CVbtnMeasure.Enabled == false)
            {
                MessageBox.Show("Data is empty or measurement is in progress!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Are you sure you want to clear all data?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    CV_ClearGraph();
                    ClearData();
                }
            }
        }

        private void CVbtnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xls;*.xlsx;*csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CV_ClearGraph();
                    CVlistView.Items.Clear();

                    bufferC = new double[25000];
                    bufferV = new double[25000];
                    tempC = new double[25000];

                    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                    Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
                    // Lấy Sheet 1
                    Worksheet xlWorksheet = (Worksheet)xlWorkbook.Sheets.get_Item(1);
                    // Lấy phạm vi dữ liệu
                    Range xlRange = xlWorksheet.UsedRange;
                    object[,] valueArray = (object[,])xlRange.get_Value(XlRangeValueDataType.xlRangeValueDefault);

                    // Hiển thị nọi dung
                    CVnumericStartVolt.Text = valueArray[1, 2].ToString();
                    CVnumericEndVolt.Text = valueArray[2, 2].ToString();
                    CVnumericStep.Text = valueArray[3, 2].ToString();
                    CVnumericRepeatTimes.Text = valueArray[4, 2].ToString();

                    S_Vol = Convert.ToInt32(CVnumericStartVolt.Text);
                    E_Vol = Convert.ToInt32(CVnumericEndVolt.Text);
                    Step = Convert.ToInt32(CVnumericStep.Text);
                    RepeatTimes = Convert.ToInt32(CVnumericRepeatTimes.Text);

                    numStep = ((E_Vol - S_Vol) / Step + 1) * 2;
                    numSample = numStep * RepeatTimes;

                    receiverCount = 0;
                    for (int row = 6; row <= xlWorksheet.UsedRange.Rows.Count; row++)//đọc row hiện có trong Excel
                    {
                        //Giá trị = valueArray[dòng, cột]; ToString() là để chuyển giá trị thành dạng String
                        bufferV[receiverCount] = Convert.ToDouble(valueArray[row, 1]);
                        tempC[receiverCount] = Convert.ToDouble(valueArray[row, 2]);
                        bufferC[receiverCount] = Convert.ToDouble(valueArray[row, 3]);
                        receiverCount++;
                        CVprogressBar.Value = receiverCount * 100 / numSample;
                    }
                    // Đóng Workbook.
                    xlWorkbook.Close(false);
                    CV_DataListview();
                    CV_DrawGraph();
                    receiverCount = 0;
                }
            }
        }

        private void CVbtnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;

            Range rg = ws.get_Range("A1", "B1");
            ws.Cells[1, 1] = "Start Voltage";
            ws.Cells[1, 2] = S_Vol.ToString();
            ws.Cells[1, 3] = "[mV]";

            ws.Cells[2, 1] = "End Voltage";
            ws.Cells[2, 2] = E_Vol.ToString();
            ws.Cells[2, 3] = "[mV]";

            ws.Cells[3, 1] = "Step";
            ws.Cells[3, 2] = Step.ToString();
            ws.Cells[3, 3] = "[mV]";

            ws.Cells[4, 1] = "Repeat Times";
            ws.Cells[4, 2] = RepeatTimes.ToString();
            ws.Cells[4, 3] = "[times]";

            ws.Cells[5, 1] = "Voltage";
            ws.Cells[5, 2] = "Current (Raw)";
            ws.Cells[5, 3] = "Current (Moving average filter)";

            int j = 0, n = numSample + 6;
            for (int i = 6; i < n; i++)
            {
                ws.Cells[i, 1] = bufferV[j];
                ws.Cells[i, 2] = tempC[j];
                ws.Cells[i, 3] = bufferC[j];
                j++;
                CVprogressBar.Value = j * 100 / numSample;
            }

            xla.Visible = true;
        }

        private void EISbtnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xls;*.xlsx;*csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    EIS_ClearGraph();
                    EISlistView.Items.Clear();

                    buffFreq = new double[25000];
                    buffMag = new double[25000];
                    buffPhase = new double[25000];

                    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                    Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
                    // Lấy Sheet 1
                    Worksheet xlWorksheet = (Worksheet)xlWorkbook.Sheets.get_Item(1);
                    // Lấy phạm vi dữ liệu
                    Range xlRange = xlWorksheet.UsedRange;
                    object[,] valueArray = (object[,])xlRange.get_Value(XlRangeValueDataType.xlRangeValueDefault);

                    // Hiển thị nọi dung
                    string strSweepEn = valueArray[1, 2].ToString();
                    EIScheckBoxSweepEn.Checked = (strSweepEn == "True") ? true : false;
                    EIScheckBoxLog.Checked = (valueArray[2, 2].ToString() == "True") ? true : false;
                    EISnumericStartFreq.Text = valueArray[3, 2].ToString();
                    EISnumericStopFreq.Text = valueArray[4, 2].ToString();
                    EISnumericSweepPoints.Text = valueArray[5, 2].ToString();
                    EISnumericRepeatTimes.Text = valueArray[6, 2].ToString();

                    S_Vol = Convert.ToInt32(EISnumericStartFreq.Text);
                    E_Vol = Convert.ToInt32(EISnumericStopFreq.Text);
                    numStep = Convert.ToInt32(EISnumericSweepPoints.Text);
                    RepeatTimes = Convert.ToInt32(EISnumericRepeatTimes.Text);

                    numSample = numStep * RepeatTimes;

                    receiverCount = 0;
                    for (int row = 8; row <= xlWorksheet.UsedRange.Rows.Count; row++)
                    {
                        //Giá trị = valueArray[dòng, cột]; ToString() là để chuyển giá trị thành dạng String
                        buffFreq[receiverCount] = Convert.ToDouble(valueArray[row, 1]);
                        buffMag[receiverCount] = Convert.ToDouble(valueArray[row, 2]);
                        buffPhase[receiverCount] = Convert.ToDouble(valueArray[row, 3]);

                        receiverCount++;
                        EISprogressBar.Value = receiverCount * 100 / numSample;
                        status = 1;
                        EIS_DataListview();
                        status = 0;
                    }
                    // Đóng Workbook.
                    xlWorkbook.Close(false);
                    EIS_DrawGraph();
                    receiverCount = 0;
                }
            }
        }

        private void EISbtnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;

            Range rg = ws.get_Range("A1", "B1");

            ws.Cells[1, 1] = "Sweep Enable";
            ws.Cells[1, 2] = EIScheckBoxSweepEn.Checked.ToString();

            ws.Cells[2, 1] = "Logarithmic";
            ws.Cells[2, 2] = EIScheckBoxLog.Checked.ToString();

            ws.Cells[3, 1] = "Start Frequency";
            ws.Cells[3, 2] = S_Vol.ToString();
            ws.Cells[3, 3] = "[Hz]";

            ws.Cells[4, 1] = "End Frequency";
            ws.Cells[4, 2] = E_Vol.ToString();
            ws.Cells[4, 3] = "[Hz]";

            ws.Cells[5, 1] = "Sweep Points";
            if (EIScheckBoxSweepEn.Checked)
                ws.Cells[5, 2] = numStep.ToString();
            else
                ws.Cells[5, 2] = numSample.ToString();
            ws.Cells[5, 3] = "[Times]";

            ws.Cells[6, 1] = "Repeat Times";
            if (EIScheckBoxSweepEn.Checked)
                ws.Cells[6, 2] = RepeatTimes.ToString();
            else
                ws.Cells[6, 2] = "1";
            ws.Cells[6, 3] = "[times]";

            ws.Cells[7, 1] = "Frequency (Hz)";
            ws.Cells[7, 2] = "Magnitude (Ohm)";
            ws.Cells[7, 3] = "Phase (Degree)";

            int j = 0, n = numSample + 8;
            for (int i = 8; i < n; i++)
            {
                ws.Cells[i, 1] = buffFreq[j];
                ws.Cells[i, 2] = buffMag[j];
                ws.Cells[i, 3] = buffPhase[j];
                j++;
                EISprogressBar.Value = j * 100 / numSample;
            }

            xla.Visible = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void selectPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EISselectPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (selectPort.Text == "")
            {
                MessageBox.Show("Please select the port COM!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                serialPort1.PortName = selectPort.Text;
                EISselectPort.Text = selectPort.Text;
                CVselectPort.Text = selectPort.Text;
                try
                {
                    serialPort1.Open();

                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    statusCOM.Value = 100;

                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    statusCOM.Value = 100;
                }
                catch
                {
                    MessageBox.Show("Connect to the port " + serialPort1.PortName + " is denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();

                CVstatusCOM.Value = 0;
                CVbtnConnect.Enabled = true;
                CVbtnDisconnect.Enabled = false;
                CVbtnMeasure.Enabled = true;
                CVbtnClearAll.Enabled = true;
                CVbtnImport.Enabled = true;
                CVbtnExport.Enabled = true;

                EISstatusCOM.Value = 0;
                EISbtnConnect.Enabled = true;
                EISbtnDisconnect.Enabled = false;
                EISbtnMeasure.Enabled = true;
                EISbtnClearAll.Enabled = true;
                EISbtnImport.Enabled = true;
                EISbtnExport.Enabled = true;

                //sonnh
                statusCOM.Value = 0;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                //btnClearAll.Enabled = true;
                //btnImport.Enabled = true;

                //sonnh end
            }
            catch
            {
                MessageBox.Show("Disconnect to the port " + serialPort1.PortName + " is denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void tabCVEIS_Click(object sender, EventArgs e)
        {

        }


        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbVoltage1_CheckedChanged(object sender, EventArgs e)
        {
            cbVoltage2.Checked = !cbVoltage1.Checked;
        }

        private void cbVoltage2_CheckedChanged(object sender, EventArgs e)
        {
            cbVoltage1.Checked = !cbVoltage2.Checked;
        }

        private void bntExtraSub_Click(object sender, EventArgs e)
        {
            sendControlVoltageCmd(ExtraSub);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            sendControlVoltageCmd(Sub);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sendControlVoltageCmd(Add);
        }

        private void btnExtraAdd_Click(object sender, EventArgs e)
        {
            sendControlVoltageCmd(ExtraAdd);
        }

        private void EISbtnClearAll_Click(object sender, EventArgs e)
        {
            if (CVbtnMeasure.Enabled == false)
            {
                MessageBox.Show("Data is empty or measurement is in progress!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Are you sure you want to clear all data?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    EIS_ClearGraph();
                    ClearData();
                }
            }
        }

        private void CVradioBtnShowAllSweeps_Click(object sender, EventArgs e)
        {
            CV_DrawGraph();
        }

        private void EISradioBtn1st_Click(object sender, EventArgs e)
        {
            EIS_DrawGraph();
        }

        private void EIScheckBoxSweepEn_CheckedChanged(object sender, EventArgs e)
        {
            GraphPane eisPane = EISzedGraphControl.GraphPane;
            if (EIScheckBoxSweepEn.Checked)
            {
                EIScheckBoxLog.Enabled = true;
                EISnumericStopFreq.Enabled = true;
                EISnumericSweepPoints.Enabled = true;
                EISnumericRepeatTimes.Enabled = true;

                groupBoxShowSweepTimes.Enabled = true;

                eisPane.XAxis.Title.Text = "Frequency (Hz)";
                EISlistView.Clear();
                EISlistView.Columns.Add("Frequency (Hz)");
                EISlistView.Columns.Add("Magtitude (Ω)");
                EISlistView.Columns.Add("Phase (°)");

            }
            else
            {
                EIScheckBoxLog.Enabled = false;
                EIScheckBoxLog.Checked = false;
                EISnumericStopFreq.Enabled = false;
                EISnumericSweepPoints.Enabled = false;
                EISnumericRepeatTimes.Enabled = false;

                groupBoxShowSweepTimes.Enabled = false;

                eisPane.XAxis.Title.Text = "Time (ms)";
                EISlistView.Clear();
                EISlistView.Columns.Add("Time (ms)");
                EISlistView.Columns.Add("Magtitude (Ω)");
                EISlistView.Columns.Add("Phase (°)");
            }

            EISzedGraphControl.AxisChange();
            EISzedGraphControl.Invalidate();
            EISzedGraphControl.Refresh();
        }

        private void CV_DataProcess()
        {
            for (int i = 0; i < 4; i++)
            {
                buffSerial[i] = buffSerial[4];
            }
            for (int i = 0; i < (RepeatTimes * 2); i++)
            {
                for (int j = 0; j < (numStep / 4); j++)
                {
                    string temp = buffSerial[i * numStep / 2 + j];
                    buffSerial[i * numStep / 2 + j] = buffSerial[i * numStep / 2 + numStep / 2 - j - 1];
                    buffSerial[i * numStep / 2 + numStep / 2 - j - 1] = temp;
                }
            }
            for (int i = 0; i < receiverCount; i++)
            {
                string[] arrList = buffSerial[i].Split(';');
                bufferC[i] = Convert.ToDouble(arrList[1], provider) * -25000;
                tempC[i] = bufferC[i];

                if (i % numStep == 0)
                    bufferV[i] = S_Vol;
                else if ((i / (numStep / 2)) % 2 == 0)
                    bufferV[i] = bufferV[i - 1] + Step;
                else if (i % (numStep / 2) == 0)
                    bufferV[i] = bufferV[i - 1];
                else
                    bufferV[i] = bufferV[i - 1] - Step;
            }
            
            SmoothingData(bufferC);
        }

        private void SmoothingData(double[] data)
        {
            /*
            int frame = 25;
            double sum = 0;

            for (int i = 0; i < receiverCount; i++)
            {
                sum = 0;
                if (i < frame / 2)
                {
                    for (int j = 0; j <= i + frame / 2; j++)
                    {
                        sum += tempC[j];
                    }
                    data[i] = Math.Round(sum / (i + frame / 2 + 1), 3);
                }

                if (i >= frame / 2 && i < receiverCount - frame / 2)
                {
                    for (int j = (i - (frame / 2)); j < (i - (frame / 2) + frame); j++)
                    {
                        sum += tempC[j];
                    }
                    data[i] = Math.Round(sum / frame, 3);
                }

                if (i >= receiverCount - (frame / 2))
                {
                    for (int j = i - frame / 2; j < receiverCount; j++)
                    {
                        sum += tempC[j];
                    }
                    data[i] = Math.Round(sum / ((receiverCount - 1 - i) + frame / 2 + 1), 3);
                }
            }
            */
            data[0] = bufferC[0];
            data[1] = Math.Round((bufferC[0] + bufferC[1]) / 2, 3);
            for (int i = 2; i < receiverCount; i++)
            {
                data[i] = Math.Round((bufferC[i] + bufferC[i-1] + bufferC[i-2]) / 3, 3);
            }
        }

        private void CV_DataListview()
        {
            for (int i = 0; i < receiverCount; i++)
            {
                ListViewItem item = new ListViewItem(bufferV[i].ToString());
                item.SubItems.Add(bufferC[i].ToString());
                CVlistView.Items.Add(item);

                CVlistView.Items[CVlistView.Items.Count - 1].EnsureVisible();
            }
        }

        private void EIS_DataListview()
        {
            if (status == 0)
                return;
            else
            {
                ListViewItem item = new ListViewItem(buffFreq[receiverCount - 1].ToString());

                item.SubItems.Add(buffMag[receiverCount - 1].ToString());
                item.SubItems.Add(buffPhase[receiverCount - 1].ToString());
                EISlistView.Items.Add(item);

                EISlistView.Items[EISlistView.Items.Count - 1].EnsureVisible();
            }
        }

        private void CV_DrawGraph()
        {
            CV_ClearGraph();
            GraphPane cvPane = CVzedGraphControl.GraphPane;

            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            PointPairList list3 = new PointPairList();
            PointPairList list4 = new PointPairList();
            PointPairList list5 = new PointPairList();
            PointPairList list6 = new PointPairList();

            if (CVradioBtn1st.Checked && RepeatTimes >= 1)
            {
                for (int i = numStep - 1; i >= 0; i--)
                {
                    list1.Add(bufferV[i], bufferC[i]);
                }

                Scale xScale = CVzedGraphControl.GraphPane.XAxis.Scale;
                Scale yScale = CVzedGraphControl.GraphPane.YAxis.Scale;

                xScale.Max = list1.Max(point => point.X) + 0.05;
                xScale.Min = list1.Min(point => point.X) - 0.05;
                yScale.Max = list1.Max(point => point.Y) + 0.05;
                yScale.Min = list1.Min(point => point.Y) - 0.05;

                curve1 = cvPane.AddCurve("1st", list1, Color.Red, SymbolType.None);

            }
            else if (CVradioBtn2nd.Checked && RepeatTimes >= 2)
            {
                for (int i = numStep - 1; i >= 0; i--)
                {
                    list2.Add(bufferV[i + numStep], bufferC[i + numStep]);
                }

                Scale xScale = CVzedGraphControl.GraphPane.XAxis.Scale;
                Scale yScale = CVzedGraphControl.GraphPane.YAxis.Scale;

                xScale.Max = list2.Max(point => point.X) + 0.05;
                xScale.Min = list2.Min(point => point.X) - 0.05;
                yScale.Max = list2.Max(point => point.Y) + 0.05;
                yScale.Min = list2.Min(point => point.Y) - 0.05;

                curve2 = cvPane.AddCurve("2nd", list2, Color.Orange, SymbolType.None);

            }
            else if (CVradioBtn3rd.Checked && RepeatTimes >= 3)
            {
                for (int i = numStep - 1; i >= 0; i--)
                {
                    list3.Add(bufferV[i + numStep * 2], bufferC[i + numStep * 2]);
                }

                Scale xScale = CVzedGraphControl.GraphPane.XAxis.Scale;
                Scale yScale = CVzedGraphControl.GraphPane.YAxis.Scale;

                xScale.Max = list3.Max(point => point.X) + 0.05;
                xScale.Min = list3.Min(point => point.X) - 0.05;
                yScale.Max = list3.Max(point => point.Y) + 0.05;
                yScale.Min = list3.Min(point => point.Y) - 0.05;

                curve3 = cvPane.AddCurve("3rd", list3, Color.Yellow, SymbolType.None);

            }
            else if (CVradioBtn4th.Checked && RepeatTimes >= 4)
            {
                for (int i = numStep - 1; i >= 0; i--)
                {
                    list4.Add(bufferV[i + numStep * 3], bufferC[i + numStep * 3]);
                }

                Scale xScale = CVzedGraphControl.GraphPane.XAxis.Scale;
                Scale yScale = CVzedGraphControl.GraphPane.YAxis.Scale;

                xScale.Max = list4.Max(point => point.X) + 0.05;
                xScale.Min = list4.Min(point => point.X) - 0.05;
                yScale.Max = list4.Max(point => point.Y) + 0.05;
                yScale.Min = list4.Min(point => point.Y) - 0.05;

                curve4 = cvPane.AddCurve("4th", list4, Color.Green, SymbolType.None);

            }
            else if (CVradioBtn5th.Checked && RepeatTimes >= 5)
            {
                for (int i = numStep - 1; i >= 0; i--)
                {
                    list5.Add(bufferV[i + numStep * 4], bufferC[i + numStep * 4]);
                }

                Scale xScale = CVzedGraphControl.GraphPane.XAxis.Scale;
                Scale yScale = CVzedGraphControl.GraphPane.YAxis.Scale;

                xScale.Max = list5.Max(point => point.X) + 0.05;
                xScale.Min = list5.Min(point => point.X) - 0.05;
                yScale.Max = list5.Max(point => point.Y) + 0.05;
                yScale.Min = list5.Min(point => point.Y) - 0.05;

                curve5 = cvPane.AddCurve("5th", list5, Color.Blue, SymbolType.None);

            }
            else if (CVradioBtn6th.Checked && RepeatTimes >= 6)
            {
                for (int i = numStep - 1; i >= 0; i--)
                {
                    list6.Add(bufferV[i + numStep * 5], bufferC[i + numStep * 5]);
                }

                Scale xScale = CVzedGraphControl.GraphPane.XAxis.Scale;
                Scale yScale = CVzedGraphControl.GraphPane.YAxis.Scale;

                xScale.Max = list6.Max(point => point.X) + 0.05;
                xScale.Min = list6.Min(point => point.X) - 0.05;
                yScale.Max = list6.Max(point => point.Y) + 0.05;
                yScale.Min = list6.Min(point => point.Y) - 0.05;

                curve6 = cvPane.AddCurve("6th", list6, Color.Purple, SymbolType.None);

            }
            else if (CVradioBtnShowAllSweeps.Checked)
            {
                for (int i = numStep - 1; i >= 0; i--)
                {
                    if (RepeatTimes >= 1)
                        list1.Add(bufferV[i], bufferC[i]);
                    if (RepeatTimes >= 2)
                        list2.Add(bufferV[i + numStep], bufferC[i + numStep]);
                    if (RepeatTimes >= 3)
                        list3.Add(bufferV[i + numStep * 2], bufferC[i + numStep * 2]);
                    if (RepeatTimes >= 4)
                        list4.Add(bufferV[i + numStep * 3], bufferC[i + numStep * 3]);
                    if (RepeatTimes >= 5)
                        list5.Add(bufferV[i + numStep * 4], bufferC[i + numStep * 4]);
                    if (RepeatTimes >= 6)
                        list6.Add(bufferV[i + numStep * 5], bufferC[i + numStep * 5]);
                }

                Scale xScale = CVzedGraphControl.GraphPane.XAxis.Scale;
                Scale yScale = CVzedGraphControl.GraphPane.YAxis.Scale;

                xScale.Max = bufferV.Max() + 0.05;
                xScale.Min = bufferV.Min() - 0.05;
                yScale.Max = bufferC.Max() + 0.05;
                yScale.Min = bufferC.Min() - 0.05;

                if (RepeatTimes >= 1)
                {
                    curve1 = cvPane.AddCurve("1st", list1, Color.Red, SymbolType.None);
                }
                if (RepeatTimes >= 2)
                {
                    curve2 = cvPane.AddCurve("2nd", list2, Color.Orange, SymbolType.None);
                }

                if (RepeatTimes >= 3)
                {
                    curve3 = cvPane.AddCurve("3rd", list3, Color.Yellow, SymbolType.None);
                }
                if (RepeatTimes >= 4)
                {
                    curve4 = cvPane.AddCurve("4th", list4, Color.Green, SymbolType.None);
                }
                if (RepeatTimes >= 5)
                {
                    curve5 = cvPane.AddCurve("5th", list5, Color.Blue, SymbolType.None);
                }
                if (RepeatTimes >= 6)
                {
                    curve6 = cvPane.AddCurve("6th", list6, Color.Purple, SymbolType.None);
                }
            }

            CVzedGraphControl.AxisChange();
            CVzedGraphControl.Invalidate();
            CVzedGraphControl.Refresh();
        }

        private void EIS_DrawGraph()
        {
            EIS_ClearGraph();
            GraphPane eisPane = EISzedGraphControl.GraphPane;

            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();

            Scale xScale = EISzedGraphControl.GraphPane.XAxis.Scale;
            Scale yScale = EISzedGraphControl.GraphPane.YAxis.Scale;
            Scale y2Scale = EISzedGraphControl.GraphPane.Y2Axis.Scale;

            for (int i = 0; i < numStep; i++)
            {
                if (EISradioBtn1st.Checked && RepeatTimes >= 1)
                {
                    list1.Add(new PointPair(buffFreq[i], buffMag[i]));
                    list2.Add(new PointPair(buffFreq[i], buffPhase[i]));

                    // Tự động Scale theo trục x
                    if (buffFreq[i] > xScale.Max - xScale.MajorStep)
                        xScale.Max = buffFreq[i] + xScale.MajorStep;
                    else if (buffFreq[i] < xScale.Min + xScale.MajorStep)
                        xScale.Min = buffFreq[i] - xScale.MajorStep;

                    // Tự động Scale theo trục y
                    if (buffMag[i] > yScale.Max - yScale.MajorStep)
                        yScale.Max = buffMag[i] + yScale.MajorStep;
                    else if (buffMag[i] < yScale.Min + yScale.MajorStep)
                        yScale.Min = buffMag[i] - yScale.MajorStep;

                    // Tự động Scale theo trục y2
                    if (buffPhase[i] > y2Scale.Max - y2Scale.MajorStep)
                        y2Scale.Max = buffPhase[i] + y2Scale.MajorStep;
                    else if (buffPhase[i] < y2Scale.Min + y2Scale.MajorStep)
                        y2Scale.Min = buffPhase[i] - y2Scale.MajorStep;
                }
                else if (EISradioBtn2nd.Checked && RepeatTimes >= 2)
                {
                    list1.Add(new PointPair(buffFreq[i + numStep], buffMag[i + numStep]));
                    list2.Add(new PointPair(buffFreq[i + numStep], buffPhase[i + numStep]));

                    // Tự động Scale theo trục x
                    if (buffFreq[i + numStep] > xScale.Max - xScale.MajorStep)
                        xScale.Max = buffFreq[i + numStep] + xScale.MajorStep;
                    else if (buffFreq[i + numStep] < xScale.Min + xScale.MajorStep)
                        xScale.Min = buffFreq[i + numStep] - xScale.MajorStep;

                    // Tự động Scale theo trục y
                    if (buffMag[i + numStep] > yScale.Max - yScale.MajorStep)
                        yScale.Max = buffMag[i + numStep] + yScale.MajorStep;
                    else if (buffMag[i + numStep] < yScale.Min + yScale.MajorStep)
                        yScale.Min = buffMag[i + numStep] - yScale.MajorStep;

                    // Tự động Scale theo trục y2
                    if (buffPhase[i + numStep] > y2Scale.Max - y2Scale.MajorStep)
                        y2Scale.Max = buffPhase[i + numStep] + y2Scale.MajorStep;
                    else if (buffPhase[i + numStep] < y2Scale.Min + y2Scale.MajorStep)
                        y2Scale.Min = buffPhase[i + numStep] - y2Scale.MajorStep;
                }
                else if (EISradioBtn3rd.Checked && RepeatTimes >= 3)
                {
                    list1.Add(new PointPair(buffFreq[i + numStep * 2], buffMag[i + numStep * 2]));
                    list2.Add(new PointPair(buffFreq[i + numStep * 2], buffPhase[i + numStep * 2]));

                    // Tự động Scale theo trục x
                    if (buffFreq[i + numStep * 2] > xScale.Max - xScale.MajorStep)
                        xScale.Max = buffFreq[i + numStep * 2] + xScale.MajorStep;
                    else if (buffFreq[i + numStep * 2] < xScale.Min + xScale.MajorStep)
                        xScale.Min = buffFreq[i + numStep * 2] - xScale.MajorStep;

                    // Tự động Scale theo trục y
                    if (buffMag[i + numStep * 2] > yScale.Max - yScale.MajorStep)
                        yScale.Max = buffMag[i + numStep * 2] + yScale.MajorStep;
                    else if (buffMag[i + numStep * 2] < yScale.Min + yScale.MajorStep)
                        yScale.Min = buffMag[i + numStep * 2] - yScale.MajorStep;

                    // Tự động Scale theo trục y2
                    if (buffPhase[i + numStep * 2] > y2Scale.Max - y2Scale.MajorStep)
                        y2Scale.Max = buffPhase[i + numStep * 2] + y2Scale.MajorStep;
                    else if (buffPhase[i + numStep * 2] < y2Scale.Min + y2Scale.MajorStep)
                        y2Scale.Min = buffPhase[i + numStep * 2] - y2Scale.MajorStep;
                }
                else if (EISradioBtn4th.Checked && RepeatTimes >= 4)
                {
                    list1.Add(new PointPair(buffFreq[i + numStep * 3], buffMag[i + numStep * 3]));
                    list2.Add(new PointPair(buffFreq[i + numStep * 3], buffPhase[i + numStep * 3]));

                    // Tự động Scale theo trục x
                    if (buffFreq[i + numStep * 3] > xScale.Max - xScale.MajorStep)
                        xScale.Max = buffFreq[i + numStep * 3] + xScale.MajorStep;
                    else if (buffFreq[i + numStep * 3] < xScale.Min + xScale.MajorStep)
                        xScale.Min = buffFreq[i + numStep * 3] - xScale.MajorStep;

                    // Tự động Scale theo trục y
                    if (buffMag[i + numStep * 3] > yScale.Max - yScale.MajorStep)
                        yScale.Max = buffMag[i + numStep * 3] + yScale.MajorStep;
                    else if (buffMag[i + numStep * 3] < yScale.Min + yScale.MajorStep)
                        yScale.Min = buffMag[i + numStep * 3] - yScale.MajorStep;

                    // Tự động Scale theo trục y2
                    if (buffPhase[i + numStep * 3] > y2Scale.Max - y2Scale.MajorStep)
                        y2Scale.Max = buffPhase[i + numStep * 3] + y2Scale.MajorStep;
                    else if (buffPhase[i + numStep * 3] < y2Scale.Min + y2Scale.MajorStep)
                        y2Scale.Min = buffPhase[i + numStep * 3] - y2Scale.MajorStep;
                }
                else if (EISradioBtn5th.Checked && RepeatTimes >= 5)
                {
                    list1.Add(new PointPair(buffFreq[i + numStep * 4], buffMag[i + numStep * 4]));
                    list2.Add(new PointPair(buffFreq[i + numStep * 4], buffPhase[i + numStep * 4]));

                    // Tự động Scale theo trục x
                    if (buffFreq[i + numStep * 4] > xScale.Max - xScale.MajorStep)
                        xScale.Max = buffFreq[i + numStep * 4] + xScale.MajorStep;
                    else if (buffFreq[i + numStep * 4] < xScale.Min + xScale.MajorStep)
                        xScale.Min = buffFreq[i + numStep * 4] - xScale.MajorStep;

                    // Tự động Scale theo trục y
                    if (buffMag[i + numStep * 4] > yScale.Max - yScale.MajorStep)
                        yScale.Max = buffMag[i + numStep * 4] + yScale.MajorStep;
                    else if (buffMag[i + numStep * 4] < yScale.Min + yScale.MajorStep)
                        yScale.Min = buffMag[i + numStep * 4] - yScale.MajorStep;

                    // Tự động Scale theo trục y2
                    if (buffPhase[i + numStep * 4] > y2Scale.Max - y2Scale.MajorStep)
                        y2Scale.Max = buffPhase[i + numStep * 4] + y2Scale.MajorStep;
                    else if (buffPhase[i + numStep * 4] < y2Scale.Min + y2Scale.MajorStep)
                        y2Scale.Min = buffPhase[i + numStep * 4] - y2Scale.MajorStep;
                }
                else if (EISradioBtn6th.Checked && RepeatTimes >= 6)
                {
                    list1.Add(new PointPair(buffFreq[i + numStep * 5], buffMag[i + numStep * 5]));
                    list2.Add(new PointPair(buffFreq[i + numStep * 5], buffPhase[i + numStep * 5]));

                    // Tự động Scale theo trục x
                    if (buffFreq[i + numStep * 5] > xScale.Max - xScale.MajorStep)
                        xScale.Max = buffFreq[i + numStep * 5] + xScale.MajorStep;
                    else if (buffFreq[i + numStep * 5] < xScale.Min + xScale.MajorStep)
                        xScale.Min = buffFreq[i + numStep * 5] - xScale.MajorStep;

                    // Tự động Scale theo trục y
                    if (buffMag[i + numStep * 5] > yScale.Max - yScale.MajorStep)
                        yScale.Max = buffMag[i + numStep * 5] + yScale.MajorStep;
                    else if (buffMag[i + numStep * 5] < yScale.Min + yScale.MajorStep)
                        yScale.Min = buffMag[i + numStep * 5] - yScale.MajorStep;

                    // Tự động Scale theo trục y2
                    if (buffPhase[i + numStep * 5] > y2Scale.Max - y2Scale.MajorStep)
                        y2Scale.Max = buffPhase[i + numStep * 5] + y2Scale.MajorStep;
                    else if (buffPhase[i + numStep * 5] < y2Scale.Min + y2Scale.MajorStep)
                        y2Scale.Min = buffPhase[i + numStep * 5] - y2Scale.MajorStep;
                }
            }

            eisPane.CurveList.Clear();
            // Generate a red curve with diamond symbols, and "Alpha" in the legend
            curve1 = eisPane.AddCurve("Magnitude", list1, Color.Red, SymbolType.Diamond);
            // Fill the symbols with white
            curve1.Symbol.Fill = new Fill(Color.White);

            // Generate a blue curve with circle symbols, and "Beta" in the legend
            curve2 = eisPane.AddCurve("Phase", list2, Color.Blue, SymbolType.Circle);
            // Fill the symbols with white
            curve2.Symbol.Fill = new Fill(Color.White);
            // Associate this curve with the Y2 axis
            curve2.IsY2Axis = true;

            EISzedGraphControl.AxisChange();
            EISzedGraphControl.Invalidate();
            EISzedGraphControl.Refresh();
        }

        private void EIS_DrawGraphRealtime()
        {
            if (EISzedGraphControl.GraphPane.CurveList.Count <= 0)
                return;

            curve1 = EISzedGraphControl.GraphPane.CurveList[0] as LineItem;
            curve2 = EISzedGraphControl.GraphPane.CurveList[1] as LineItem;

            if (curve1 == null)
                return;
            if (curve2 == null)
                return;

            IPointListEdit list1 = curve1.Points as IPointListEdit;
            IPointListEdit list2 = curve2.Points as IPointListEdit;

            if (list1 == null)
                return;
            if (list2 == null)
                return;

            list1.Add(time, mag);
            list2.Add(time, phase);

            Scale xScale = EISzedGraphControl.GraphPane.XAxis.Scale;
            Scale yScale = EISzedGraphControl.GraphPane.YAxis.Scale;
            Scale y2Scale = EISzedGraphControl.GraphPane.Y2Axis.Scale;

            // Tự động Scale theo trục x
            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
            }
            else if (time < xScale.Min + xScale.MajorStep)
            {
                xScale.Min = time - xScale.MajorStep;
            }

            // Tự động Scale theo trục y
            if (mag > yScale.Max - yScale.MajorStep)
            {
                yScale.Max = mag + yScale.MajorStep;
            }
            else if (mag < yScale.Min + yScale.MajorStep)
            {
                yScale.Min = mag - yScale.MajorStep;
            }
            // Tự động Scale theo trục y2
            if (phase > y2Scale.Max - y2Scale.MajorStep)
            {
                y2Scale.Max = phase + y2Scale.MajorStep;
            }
            else if (phase < y2Scale.Min + y2Scale.MajorStep)
            {
                y2Scale.Min = phase - y2Scale.MajorStep;
            }


            EISzedGraphControl.AxisChange();
            EISzedGraphControl.Invalidate();
            EISzedGraphControl.Refresh();
        }

        private void CV_ClearGraph()
        {
            CVzedGraphControl.GraphPane.CurveList.Clear(); // Xóa đường
            CVzedGraphControl.GraphPane.GraphObjList.Clear(); // Xóa đối tượng

            GraphPane cvPane = CVzedGraphControl.GraphPane;
            cvPane.Title.Text = "Cyclic Voltammetry";
            cvPane.XAxis.Title.Text = "Voltage (mV)";
            cvPane.YAxis.Title.Text = "Current (uA)";

            // Show the x axis grid
            cvPane.XAxis.MajorGrid.IsVisible = true;

            // Show the x axis grid
            cvPane.YAxis.MajorGrid.IsVisible = true;
            // Make the Y axis scale red
            cvPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            cvPane.YAxis.Title.FontSpec.FontColor = Color.Red;
            // turn off the opposite tics so the Y tics don't show up on the Y2 axis
            cvPane.YAxis.MajorTic.IsOpposite = false;
            cvPane.YAxis.MinorTic.IsOpposite = false;
            // Align the Y axis labels so they are flush to the axis
            cvPane.YAxis.Scale.Align = AlignP.Inside;

            // Fill the axis background with a gradient
            cvPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);

            CVzedGraphControl.RestoreScale(CVzedGraphControl.GraphPane);
            CVzedGraphControl.AxisChange();
        }

        private void EIS_ClearGraph()
        {
            EISzedGraphControl.GraphPane.CurveList.Clear(); // Xóa đường
            EISzedGraphControl.GraphPane.GraphObjList.Clear(); // Xóa đối tượng

            GraphPane eisPane = EISzedGraphControl.GraphPane;

            eisPane.Title.Text = "Electrochemical Impedance Spectroscopy";
            eisPane.YAxis.Title.Text = "Magnitude (Ohm)";
            eisPane.Y2Axis.Title.Text = "Phase (Degree)";
            if (EIScheckBoxSweepEn.Checked)
            {
                eisPane.XAxis.Title.Text = "Frequency (Hz)";
            }
            else
            {
                eisPane.XAxis.Title.Text = "Times (ms)";
            }

            RollingPointPairList list1 = new RollingPointPairList(60000);
            RollingPointPairList list2 = new RollingPointPairList(60000);

            // Show the x axis grid
            eisPane.XAxis.MajorGrid.IsVisible = true;

            // Make the Y axis scale red
            eisPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            eisPane.YAxis.Title.FontSpec.FontColor = Color.Red;
            // turn off the opposite tics so the Y tics don't show up on the Y2 axis
            eisPane.YAxis.MajorTic.IsOpposite = false;
            eisPane.YAxis.MinorTic.IsOpposite = false;
            // Don't display the Y zero line
            eisPane.YAxis.MajorGrid.IsZeroLine = false;
            // Align the Y axis labels so they are flush to the axis
            eisPane.YAxis.Scale.Align = AlignP.Inside;

            // Enable the Y2 axis display
            eisPane.Y2Axis.IsVisible = true;
            // Make the Y2 axis scale blue
            eisPane.Y2Axis.Scale.FontSpec.FontColor = Color.Blue;
            eisPane.Y2Axis.Title.FontSpec.FontColor = Color.Blue;
            // turn off the opposite tics so the Y2 tics don't show up on the Y axis
            eisPane.Y2Axis.MajorTic.IsOpposite = false;
            eisPane.Y2Axis.MinorTic.IsOpposite = false;
            // Don't display the Y2 zero line
            eisPane.Y2Axis.MajorGrid.IsZeroLine = false;
            // Display the Y2 axis grid lines
            eisPane.Y2Axis.MajorGrid.IsVisible = true;
            // Align the Y2 axis labels so they are flush to the axis
            eisPane.Y2Axis.Scale.Align = AlignP.Inside;

            // Fill the axis background with a gradient
            eisPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);

            // Generate a red curve with diamond symbols, and "Alpha" in the legend
            curve1 = eisPane.AddCurve("Magnitude", list1, Color.Red, SymbolType.Diamond);
            // Fill the symbols with white
            curve1.Symbol.Fill = new Fill(Color.White);

            // Generate a blue curve with circle symbols, and "Beta" in the legend
            curve2 = eisPane.AddCurve("Phase", list2, Color.Blue, SymbolType.Circle);
            // Fill the symbols with white
            curve2.Symbol.Fill = new Fill(Color.White);
            // Associate this curve with the Y2 axis
            curve2.IsY2Axis = true;

            EISzedGraphControl.RestoreScale(EISzedGraphControl.GraphPane);
            EISzedGraphControl.AxisChange();
            EISzedGraphControl.Refresh();
        }

        private void ClearData()
        {
            intlen = 0;

            CVnumericStartVolt.Value = -500;
            CVnumericEndVolt.Value = 500;
            CVnumericStep.Value = 10;
            CVnumericRepeatTimes.Value = 2;
            CV_ClearGraph();
            CVlistView.Items.Clear();

            EIScheckBoxLog.Checked = false;
            EIScheckBoxSweepEn.Checked = false;
            EISnumericStartFreq.Value = 100;
            EISnumericStopFreq.Value = 10000;
            EISnumericSweepPoints.Value = 100;
            EISnumericRepeatTimes.Value = 2;
            EIS_ClearGraph();
            EISlistView.Items.Clear();
        }
    }
}
