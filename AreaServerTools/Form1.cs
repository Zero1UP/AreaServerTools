using AreaServerTools.Extensions;
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

namespace AreaServerTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OpenAS_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog()
            {
                Filter = "Executable (*.exe)|*.exe"
            };


            if(fd.ShowDialog() == DialogResult.OK)
            {
                txt_ASPath.Text = fd.FileName;
            }
            
        }

        private void btn_IPPatch_Click(object sender, EventArgs e)
        {
            //Create a backup first
            try
            {
                File.Copy(txt_ASPath.Text, txt_ASPath.Text + ".bak",true);
                byte[] programData = File.ReadAllBytes(txt_ASPath.Text);
               
                List<byte> ipAddress = new List<byte>();
                ipAddress.AddRange( Encoding.ASCII.GetBytes(txt_IPAddress.Text));
                ipAddress.Add(0x00); //This might not always be needed if you are using a website but for setting an IP it is
                byte[] TamperCheck1PatchData = new byte[] { 0xB8, 0x01, 0x00, 0x00, 0x00 };
                byte[] TamperCheck2PatchData = new byte[] { 0x90, 0x90 };
          
                //This should only ever get 1 occurance
                List<int> position = programData.FindPattern(Patterns.IPAddressSearchPattern, 0);
                programData = programData.PatchData(ipAddress.ToArray(), position[0] + 16);

                //Tamper Check 1
                position = programData.FindPattern(Patterns.TamperCheck1SearchPattern, 0);
                programData = programData.PatchData(TamperCheck1PatchData.ToArray(), position[0] + 17);

                //Tamper Check 2
                position = programData.FindPattern(Patterns.TamperCheck2SearchPattern, 0);
                programData = programData.PatchData(TamperCheck2PatchData, position[0] + 17);
                File.WriteAllBytes(txt_ASPath.Text, programData);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
