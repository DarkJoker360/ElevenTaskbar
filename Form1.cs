using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using Microsoft.Win32;
using System.Diagnostics;

namespace ElevenTaskbar
{
    public partial class ElevenTaskbar : Form
    {
        private const int Small = 0;
        private const int Default = 1;
        private const int Big = 2;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";

        public ElevenTaskbar()
        {
            InitializeComponent();

            if (Registry.GetValue(keyName, "TaskbarSi", null) == null)
                Registry.SetValue(keyName, "TaskbarSi", Default);

            boxSixe.SelectedIndex = (int) Registry.GetValue(keyName, "TaskbarSi", null);
            btnApply.Enabled = false;

            
        }

        private void RestartExplorer()
        {
            Process p = new Process();
            foreach (Process exe in Process.GetProcesses())
            {
                if (exe.ProcessName == "explorer")
                    exe.Kill();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Registry.SetValue(keyName, "TaskbarSi", boxSixe.SelectedIndex);
            RestartExplorer();
            btnApply.Enabled = false;
        }

        private void boxSixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(boxSixe.SelectedIndex != (int) Registry.GetValue(keyName, "TaskbarSi", null))
                btnApply.Enabled = true;
        }
    }
}
