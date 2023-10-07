using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson1_SystemProg
{
    public partial class Form1 : Form
    {
        private Process[] allProcesses;
        string filter = "";
        public Form1()
        {
            InitializeComponent();
            allProcesses = Process.GetProcesses();
            process1.StartInfo = new System.Diagnostics.ProcessStartInfo("notepad");
            process2.StartInfo = new System.Diagnostics.ProcessStartInfo("C:\\Users\\yarik\\source\\repos\\ExamIII_Wild_Hunt\\ExamIII_Wild_Hunt\\bin\\Debug\\net5.0-windows\\ExamIII_Wild_Hunt");
            ListOfProcessesReset();
            listView1.Columns.Add("Name", 260);
            listView1.Columns.Add("Id", 86);
            listView1.Columns.Add("Start Time", 200);
            listView1.Columns.Add("Count", 100);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                process1.Close();
                process1.StartInfo = new System.Diagnostics.ProcessStartInfo(comboBox1.SelectedItem.ToString());
            }
            process1.Start();
            ListOfProcessesReset();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            try
            {
                string processName = listView1.FocusedItem.Text;
                
                foreach (var process in Process.GetProcessesByName(processName))
                {
                    process.Kill();

                }
                MessageBox.Show($"process \"{processName}\" killed");
            }
            catch (Exception x)
            {
                MessageBox.Show($"cant kill process \"{x.Message}\"");
            }
            ListOfProcessesReset();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {

            process2.Start();

            process2.WaitForExit();

            ListOfProcessesReset();
        }

        private void ListOfProcessesReset()
        {
            listView1.Items.Clear();
            allProcesses = null;
            allProcesses = Process.GetProcesses();


            foreach (var process in allProcesses)
            {
                ListViewItem item = new ListViewItem();

                int pFrom = process.ToString().IndexOf('(') + 1;
                int pTo = process.ToString().LastIndexOf(')') - pFrom;
                string processName = process.ToString().Substring(pFrom, pTo);
                if (processName.Contains(filter))
                {
                    string pCount = "0";
                    string pId = process.Id.ToString();
                    string pStartTime;
                    try
                    {
                        pStartTime = process.StartTime.ToString();

                    }
                    catch
                    {
                        pStartTime = "Access denied exception";
                    }


                    if (listView1.Items.Count == 0)
                    {
                        item.Name = processName;
                        item.Text = processName;
                        item.SubItems.Add(pId);
                        item.SubItems.Add(pStartTime);
                        item.SubItems.Add(pCount);
                        listView1.Items.Add(item);
                    }
                    bool found = false;
                    foreach (ListViewItem lvi in listView1.Items)
                    {

                        if (lvi.SubItems[0].Text == processName)
                        {
                            found = true;
                            lvi.SubItems[3].Text = (int.Parse(lvi.SubItems[3].Text) + 1).ToString();
                        }

                    }
                    if (!found)
                    {
                        item.Name = processName;
                        item.Text = processName;
                        item.SubItems.Add(pId);
                        item.SubItems.Add(pStartTime);
                        item.SubItems.Add(pCount);
                        listView1.Items.Add(item);
                    }

                }

            }
        }

        private void btnProcessSelect_Click(object sender, EventArgs e)
        {

            process1.Close();
            System.Windows.Forms.Button tempButton = (System.Windows.Forms.Button)sender;
            process1.StartInfo = new System.Diagnostics.ProcessStartInfo(tempButton.Name.Substring(3));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter = textBox1.Text;
            ListOfProcessesReset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfProcessesReset();
        }
    }
}
