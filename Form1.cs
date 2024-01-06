using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gettingHardwareInfo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private string getProccesorId()
        {
            string txthardwareID = "";
            ManagementObjectSearcher searchinfo = new System.Management.ManagementObjectSearcher("Select * from Win32_Processor");
            foreach (var i in searchinfo.Get())
            {
                txthardwareID = i["ProcessorID"].ToString();
            }
            return txthardwareID;
        }
        private string getHardDiskDriveSerial()
        {
            string temp = "temp";
            ManagementObjectSearcher searcher = new
   ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            int i = 0;
            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                // get the hard drive from collection
                // using index

                // get the hardware serial no.
                if (wmi_HD["SerialNumber"] == null)
                {
                    return "None";
                }

                else
                {
                    return wmi_HD["SerialNumber"].ToString();
                }

                ++i;
            }
            return temp;
        }
        private string getMotherboardSerial()
        {
            string txthardwareID = "";
            ManagementObjectSearcher searchinfo = new System.Management.ManagementObjectSearcher("Select * from Win32_BaseBoard");
            foreach (var i in searchinfo.Get())
            {
                txthardwareID = i["SerialNumber"].ToString();

            }
            return txthardwareID;
        }
        public string EncryptSerialKey()
        {
            string cpu_id = getProccesorId();
            string baseboard_id = getMotherboardSerial();
            string harddiskdrive_id = getHardDiskDriveSerial();
            string encryptedstring = AesOperation.EncryptString("b14ca5898a4e4133bbce2ea2315a1916", cpu_id + baseboard_id + harddiskdrive_id);
            return encryptedstring;



        }
        public string EncryptSerialKeyFromGivenValues()
        {
            string cpu_id = getProccesorId();
            string baseboard_id = getMotherboardSerial();
            string harddiskdrive_id = getHardDiskDriveSerial();
            string encryptedstring = AesOperation.EncryptString("b14ca5898a4e4133bbce2ea2315a1916", cpu_tb.Text + Motherboard_tb.Text + Hard_tb.Text);
            return encryptedstring;



        }
        public string DecryptSerialKey()
        {
            string cpu_id = getProccesorId();
            string baseboard_id = getMotherboardSerial();
            string harddiskdrive_id = getHardDiskDriveSerial();
            string decryptedstring = AesOperation.DecryptString("b14ca5898a4e4133bbce2ea2315a1916", AesOperation.EncryptString("b14ca5898a4e4133bbce2ea2315a1916", cpu_id + baseboard_id + harddiskdrive_id));
            return decryptedstring;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cpu_tb.Text = getProccesorId();
            Motherboard_tb.Text = getMotherboardSerial();
            Hard_tb.Text = getHardDiskDriveSerial();
           // EncryptionKey_tb.Text = "b14ca5898a4e4133bbce2ea2315a1916"; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
 

        private void reload_btn_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
         
            form1.ShowDialog();

        }

      
    }
}
