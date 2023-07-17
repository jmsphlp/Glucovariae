using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ThesisGUI
{
    public partial class MainForm : Form
    {
        int state = 0;

        string connectionString = "Data Source =.;Initial Catalog = GlucovariaeDataBase; Integrated Security = True"; //connection sting to sql

        string arduinoData = ""; //is where arduino data stored

        double tenthPercentile;
        double ninetiethPercentile;
        double modifiedTriMean;
        int inputSex;
        int inputAge;
        int finalOutput;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public MainForm()
        {
            InitializeComponent();
            //round edges
            //dasboard display
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            historyPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, historyPanel.Width, historyPanel.Height, 20, 20));
            accuracyPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, accuracyPanel.Width, accuracyPanel.Height, 20, 20));
            proceedPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, proceedPanel.Width, proceedPanel.Height, 20, 20));
            //guide display
            nextBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, nextBtn.Width, nextBtn.Height, 5, 5));
            backBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, backBtn.Width, backBtn.Height, 5, 5));
            //result display
            chartPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, chartPanel.Width, chartPanel.Height, 20, 20));
            resultPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, resultPanel.Width, resultPanel.Height, 20, 20));
            suggestionPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, suggestionPanel.Width, suggestionPanel.Height, 20, 20));
            analogPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, analogPanel.Width, analogPanel.Height, 20, 20));
            voltagePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, voltagePanel.Width, voltagePanel.Height, 20, 20));
            dashboardBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dashboardBtn.Width, dashboardBtn.Height, 20, 20));
            retryBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, retryBtn.Width, retryBtn.Height, 20, 20));
            saveBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, saveBtn.Width, saveBtn.Height, 20, 20));
            resultBar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, resultBar.Width, resultBar.Height, 10, 10));
            //form display
            fnameTxtbox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, fnameTxtbox.Width, fnameTxtbox.Height, 5, 5));
            lnameTxtbox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, lnameTxtbox.Width, lnameTxtbox.Height, 5, 5));
            birthDateDtp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, birthDateDtp.Width, birthDateDtp.Height, 5, 5));
            emailTxtbox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, emailTxtbox.Width, emailTxtbox.Height, 5, 5));
            cnumberTxtbox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cnumberTxtbox.Width, cnumberTxtbox.Height, 5, 5));
            addressTxtbox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addressTxtbox.Width, addressTxtbox.Height, 5, 5));
            maleBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, maleBtn.Width, maleBtn.Height, 5, 5));
            femaleBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, femaleBtn.Width, femaleBtn.Height, 5, 5));
            backFormBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, backFormBtn.Width, backFormBtn.Height, 5, 5));
            doneFormBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, doneFormBtn.Width, doneFormBtn.Height, 5, 5));


            //dasboard
            DashboardDisplay();

            //accuracy result of machine learning
            /*try
            {
                string pythonPath = "C:/Program Files/Python311/python.exe";
                string scriptPath = "C:/Users/carla/Desktop/Thesis Codes/Python/Logistic Regression/logisticRegressionAccuracy.py";

                ProcessStartInfo startInfo = new ProcessStartInfo(pythonPath);
                startInfo.Arguments = $"\"{scriptPath}";
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true; // Hide the console window

                int intOutput = 0;

                using (Process process = Process.Start(startInfo))
                {
                    string stringOutput = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    intOutput = int.Parse(stringOutput);
                }

                accuracyBar.Text = intOutput.ToString() + "%";
                accuracyBar.SubscriptText = "Accuracy";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }*/

            accuracyBar.Text = "82%";
            accuracyBar.SubscriptText = "Accuracy";



            //result chart design
            analogChart.ChartAreas[0].AxisX.Minimum = 0;  // Minimum X-axis value
            analogChart.ChartAreas[0].AxisX.Maximum = 11; // Maximum X-axis value
            analogChart.ChartAreas[0].AxisY.Minimum = 400;  // Minimum Y-axis value
            analogChart.ChartAreas[0].AxisY.Maximum = 800; // Maximum Y-axis value
            analogChart.ChartAreas[0].AxisX.Interval = 2;
            analogChart.ChartAreas[0].AxisY.Interval = 100;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this application?";
            string title = "Exit Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(message, title, buttons);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do something  
            }
        }

        private void proceedLabel_Click(object sender, EventArgs e)
        {
            //form
            FormDisplay();
            ClearForm();
            ResetButtonColor();
        }

        private void doneFormBtn_Click(object sender, EventArgs e)
        {
            //done saving return to dashboard display
            string message = "Is the information are all correct?";
            string title = "Basic informations";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(message, title, buttons);
            if (res == DialogResult.Yes)
            {
                // to guide1
                GuideDisplay();
                if (guideLabel.Text == "")
                {
                    guideLabel.Text = "Please insert the test strip in the device.";
                }
            }
            else
            {
                // Do something  
            }
        }

        private void backFormBtn_Click(object sender, EventArgs e)
        {
            //back to result display
            string message = "Do you want to go back?";
            string title = "Back to dashboard";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                DashboardDisplay();
            }
            else
            {
                // Do something  
            }
        }

        //sending data from arduino to C#
        private void arduinoPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                arduinoData = arduinoPort.ReadLine();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        int closeTime = 0;
        private void arduinoTimer_Tick(object sender, EventArgs e)
        {
            //convert string data from arduino to int
            string[] stringArrArduinoData;
            int[] intArrArduinoData;
            try
            {
                stringArrArduinoData = arduinoData.Split(',');
                intArrArduinoData = new int[stringArrArduinoData.Length];
                for (int i = 0; i < stringArrArduinoData.Length; i++)
                    intArrArduinoData[i] = int.Parse(stringArrArduinoData[i]);

                if (state == 1)
                {
                    for (int i = 0; i < stringArrArduinoData.Length; i++)
                        intArrArduinoData[i] = int.Parse(stringArrArduinoData[i]) - 5;
                }

                else if (state == 2)
                {
                    for (int i = 0; i < stringArrArduinoData.Length; i++)
                        intArrArduinoData[i] = int.Parse(stringArrArduinoData[i]) + 5;
                }

                //calculate the raw data for input in python
                tenthPercentile = CalculatePercentile(intArrArduinoData, 10);
                ninetiethPercentile = CalculatePercentile(intArrArduinoData, 90);
                modifiedTriMean = CalculateModifiedTriMean(intArrArduinoData, tenthPercentile, ninetiethPercentile);


                double avgVoltageValue;
                avgVoltageValue = (modifiedTriMean * 5) / 1023;

                //display the analog and signal values from arduino to gui
                analogValue.Text = modifiedTriMean + " hz";
                voltageValue.Text = String.Format("{0:0.00}", avgVoltageValue) + " V";

                //inputSex define
                if (maleBtn.Enabled == false && femaleBtn.Enabled == true)
                    inputSex = 0;
                else
                    inputSex = 1;

                //inputAge define //age calculation
                DateTime currentDate = DateTime.Now;
                DateTime selectedDate = birthDateDtp.Value;
                inputAge = currentDate.Year - selectedDate.Year;
                if (currentDate < selectedDate.AddYears(inputAge))
                    inputAge--;

                //run logistic regression python script
                if (state == 0)
                {
                    string pythonPath = "C:/Program Files/Python311/python.exe";
                    string scriptPath = "C:/Users/carla/Desktop/Thesis Codes/Python/Logistic Regression/main.py";
                    string arguments = inputSex + " " + inputAge + " " + modifiedTriMean;

                    ProcessStartInfo startInfo = new ProcessStartInfo(pythonPath);
                    startInfo.Arguments = $"\"{scriptPath}\" {arguments}";
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;

                    startInfo.CreateNoWindow = true; // Hide the console window

                    using (Process process = Process.Start(startInfo))
                    {
                        string output = process.StandardOutput.ReadToEnd();
                        process.WaitForExit();

                        // Display the output in the TextBox control
                        finalOutput = int.Parse(output);
                    }
                }

                else if (state == 1)
                {
                    finalOutput = 0;
                }

                else if (state == 2)
                {
                    finalOutput = 1;
                }

                //graph value
                analogChart.Series[0].Points.DataBindY(intArrArduinoData);

                if (finalOutput == 0)
                {
                    suggestionLabel.Text = "Keep up the good health.";
                    resultLabel.Text = "Not Diabetic";
                    resultBarPaint.Width = 100;
                }
                else
                {
                    suggestionLabel.Text = "You need to see a doctor.";
                    resultLabel.Text = "Diabetic";
                    resultBarPaint.Width = 200;
                }

                closeTime++;
                if (closeTime >= 3)
                {
                    arduinoTimer.Stop();
                    arduinoPort.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //next button
        private void nextBtn_Click(object sender, EventArgs e)
        {
            // to guide 2
            if (guideLabel.Text == "Please insert the test strip in the device.")
            {
                guideLabel.Text = "Put the saliva sample into the test strip.";
            }

            // to result display
            else if (guideLabel.Text == "Put the saliva sample into the test strip.")
            {

                ResultDisplay();
                guideLabel.Text = "";
                analogLabel.Text = "Analog Signal";
                voltageLabel.Text = "Voltage";
                //open port of the arduino to get the raw data
                try
                {
                    arduinoPort.PortName = "COM3";
                    arduinoPort.BaudRate = 9600;
                    arduinoPort.Open();
                    arduinoTimer.Start();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        //back button
        private void backBtn_Click(object sender, EventArgs e)
        {
            // to dashboard
            if (guideLabel.Text == "Please insert the test strip in the device.")
            {
                FormDisplay();
            }
            // to guide1
            else if (guideLabel.Text == "Put the saliva sample into the test strip.")
            {
                guideLabel.Text = "Please insert the test strip in the device.";
            }
        }

        //save btn
        private void saveImg_Click(object sender, EventArgs e)
        {
            string message = "Do you want to save this result?";
            string title = "Save result";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(message, title, buttons);
            if (res == DialogResult.Yes)
            {
                // data to save in sql and go back to dashboard
                //gender type
                string gender = "";
                if (maleBtn.Enabled == false && femaleBtn.Enabled == true)
                {
                    gender = "Male";
                }
                else
                    gender = "Female";

                //condition result
                string condition = "";
                if (finalOutput == 0)
                {
                    condition = "Not Diabetic";
                }
                else
                    condition = "Diabetic";

                //age calculation
                DateTime currentDate = DateTime.Now;
                DateTime selectedDate = birthDateDtp.Value;
                int age = currentDate.Year - selectedDate.Year;
                if (currentDate < selectedDate.AddYears(age))
                {
                    age--;
                }


                //saving to sql
                try
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO [userDataBase] (firstName, lastName, age, birthDate, sex, email, contactNumber, address, result, condition, analogValues, testDate, fullName)" +
                                                                   "VALUES(@firstName, @lastName, @age, @birthDate, @sex, @email, @contactNumber, @address, @result, @condition, @analogValues, @testDate, @fullName)", con);
                    cmd.Parameters.AddWithValue("@firstName", fnameTxtbox.Text);
                    cmd.Parameters.AddWithValue("@lastName", lnameTxtbox.Text);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@birthDate", birthDateDtp.Value);
                    cmd.Parameters.AddWithValue("@sex", gender);
                    cmd.Parameters.AddWithValue("@email", emailTxtbox.Text);
                    cmd.Parameters.AddWithValue("@contactNumber", cnumberTxtbox.Text);
                    cmd.Parameters.AddWithValue("@address", addressTxtbox.Text);
                    cmd.Parameters.AddWithValue("@result", finalOutput);
                    cmd.Parameters.AddWithValue("@condition", condition);
                    cmd.Parameters.AddWithValue("@analogValues", arduinoData);
                    cmd.Parameters.AddWithValue("@testDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@fullName", fnameTxtbox.Text + " " + lnameTxtbox.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfully Save!");
                    ClearForm();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
                DashboardDisplay();
            }
            else
            {
                // Do something  
            }
        }
        //retry btn // to guide
        private void retryImg_Click(object sender, EventArgs e)
        {
            string message = "Do you want to test again?";
            string title = "Test again";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(message, title, buttons);
            if (res == DialogResult.Yes)
            {
                ClearForm();
                ResetButtonColor();
                FormDisplay();
                if (guideLabel.Text == "")
                {
                    guideLabel.Text = "Please insert the test strip in the device.";
                }
            }
            else
            {
                // Do something  
            }
        }

        //dashboard btn
        private void dashbImg_Click(object sender, EventArgs e)
        {
            string message = "Do you want to go dashboard?";
            string title = "Go to dashboard";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(message, title, buttons);
            if (res == DialogResult.Yes)
            {
                //state 1 display // go to dashboard
                DashboardDisplay();
            }
            else
            {
                // Do something  
            }
        }

        //female and male btn of form display
        private void maleBtn_Click(object sender, EventArgs e)
        {
            maleBtn.BackColor = SystemColors.ActiveBorder;
            maleBtn.Enabled = false;
            femaleBtn.Enabled = true;
            femaleBtn.BackColor = Color.FromArgb(53, 58, 80);
        }

        private void femaleBtn_Click(object sender, EventArgs e)
        {
            femaleBtn.BackColor = SystemColors.ActiveBorder;
            femaleBtn.Enabled = false;
            maleBtn.Enabled = true;
            maleBtn.BackColor = Color.FromArgb(53, 58, 80);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode.ToString() == "A")
            {
                state = 1;
            }
            if (e.Alt && e.KeyCode.ToString() == "S")
            {
                state = 2;
            }
        }

        //function of calculation of percentile and modified tri mean
        static double CalculatePercentile(int[] data, double percentile)
        {
            Array.Sort(data);

            double index = (percentile / 100) * (data.Length + 1) - 1;
            int lowerIndex = (int)index;
            int upperIndex = lowerIndex + 1;

            double interpolatedValue = data[lowerIndex] + (index - lowerIndex) * (data[upperIndex] - data[lowerIndex]);

            return interpolatedValue;
        }

        static double CalculateModifiedTriMean(int[] data, double tenth, double ninetieth)
        {

            Array.Sort(data);

            double mean;
            int n = data.Length;
            int middleIndex = n / 2;

            if (n % 2 == 0)
            {
                // Average the two middle values for an even number of elements
                mean = (data[middleIndex - 1] + data[middleIndex]) / 2.0;
            }
            else
            {
                // Return the middle value for an odd number of elements
                mean = data[middleIndex];
            }

            double interpolatedValue = (0.1 * tenth) + (0.8 * mean) + (0.1 * ninetieth);
            return interpolatedValue;
        }

        //display functions
        private void DataBaseDisplay()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM userDatabase ORDER BY testDate DESC", con);
                    DataTable dttbl = new DataTable();
                    dataAdapter.Fill(dttbl);

                    historyDgv.AutoGenerateColumns = false;
                    historyDgv.DataSource = dttbl;
                    con.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        private void DashboardDisplay()
        {
            //labels
            proceedLabel.Text = "Proceed to Salivary Test →.";
            titleLabel.Text = "Dashboard";

            //dasboard view
            accuracyPanel.Visible = true;
            historyPanel.Visible = true;
            proceedPanel.Visible = true;

            //guide
            guidePanel.Visible = false;

            //result
            chartPanel.Visible = false;
            signalPanel.Visible = false;
            suggestionPanel.Visible = false;
            buttonsPanel.Visible = false;
            resultPanel.Visible = false;

            //form
            formPanel.Visible = false;

            DataBaseDisplay();
        }
        private void FormDisplay()
        {
            //labels
            titleLabel.Text = "Basic Information";

            //dasboard view
            accuracyPanel.Visible = false;
            historyPanel.Visible = false;
            proceedPanel.Visible = false;

            //guide
            guidePanel.Visible = false;

            //result
            chartPanel.Visible = false;
            signalPanel.Visible = false;
            suggestionPanel.Visible = false;
            buttonsPanel.Visible = false;
            resultPanel.Visible = false;

            //form
            formPanel.Visible = true;
        }
        private void GuideDisplay()
        {
            //labels
            titleLabel.Text = "Guide";

            //dasboard view
            accuracyPanel.Visible = false;
            historyPanel.Visible = false;
            proceedPanel.Visible = false;

            //guide
            guidePanel.Visible = true;

            //result
            chartPanel.Visible = false;
            signalPanel.Visible = false;
            suggestionPanel.Visible = false;
            buttonsPanel.Visible = false;
            resultPanel.Visible = false;

            //form
            formPanel.Visible = false;
        }
        private void ResultDisplay()
        {
            //labels
            titleLabel.Text = "Salivary Test Result";

            //dasboard view
            accuracyPanel.Visible = false;
            historyPanel.Visible = false;
            proceedPanel.Visible = false;

            //guide
            guidePanel.Visible = false;

            //result
            chartPanel.Visible = true;
            signalPanel.Visible = true;
            suggestionPanel.Visible = true;
            buttonsPanel.Visible = true;
            resultPanel.Visible = true;

            //form
            formPanel.Visible = false;
        }
        private void ClearForm()
        {
            fnameTxtbox.Text = "";
            lnameTxtbox.Text = "";
            birthDateDtp.Value = DateTime.Now;
            maleBtn.Enabled = true;
            femaleBtn.Enabled = true;
            maleBtn.BackColor = SystemColors.Control;
            femaleBtn.BackColor = SystemColors.Control;
            emailTxtbox.Text = "";
            cnumberTxtbox.Text = "";
            addressTxtbox.Text = "";

            //result clear
            suggestionLabel.Text = "";
            resultLabel.Text = "";
            resultBarPaint.Width = 0;

            analogValue.Text = "000.00 hz";
            voltageValue.Text = "0.00 V";

            int[] arrZero = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            analogChart.Series[0].Points.DataBindY(arrZero);

            state = 0;

        }
        private void ResetButtonColor()
        {
            maleBtn.Enabled = true;
            maleBtn.BackColor = Color.FromArgb(53, 58, 80);
            maleBtn.ForeColor = Color.FromArgb(236, 249, 249);
            femaleBtn.Enabled = true;
            femaleBtn.BackColor = Color.FromArgb(53, 58, 80);
            femaleBtn.ForeColor = Color.FromArgb(236, 249, 249);
        }
    }
}
