using Microsoft.Win32;
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
using System.Diagnostics;

namespace UnityScriptTemplateTool
{
    public partial class frm_Main : Form
    {
        private const string DefaultTemplateDirectory = @"\Unity\Editor\Data\Resources\ScriptTemplates";
        private const string UnityProcessName = "Unity";

        private Process unityProcess;
        private bool unityRunning;

        #region - Constructor -
        public frm_Main()
        {
            InitializeComponent();
        }
        #endregion

        #region - Form Load -
        private void Form1_Load(object sender, EventArgs e)
        {
            refreshUnityProcess();

            if (unityRunning)
            {
                unityProcess.Exited += unityProcessExited;
                unityProcess.Disposed += unityProcess_Disposed;
            }
        }


        #endregion

        private void refreshUnityProcess()
        {
            Process[] UnityProcesses = Process.GetProcessesByName(UnityProcessName);

            if (UnityProcesses.Length > 0)
                unityProcess = UnityProcesses[0];

            unityRunning = unityProcess != null;

            lbl_UnityRunning.Text = string.Format("Unity Running: {0}", unityRunning);
        }


        // Callbacks

        #region - Find Directory Clicked -
        private void btn_FindScriptTemplateDirectory_Click(object sender, EventArgs e)
        {
            string tempDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + DefaultTemplateDirectory;

            if (Directory.Exists(tempDirectory))
                txt_ScriptTemplateDirectory.Text = tempDirectory;
            else
                MessageBox.Show("Could not locate the default directory: " + tempDirectory);
        }
        #endregion

        #region - Unity Process Exited -
        void unityProcessExited(object sender, EventArgs e)
        {
            MessageBox.Show("Unity exited");
        }
        #endregion

        void unityProcess_Disposed(object sender, EventArgs e)
        {
            MessageBox.Show("Unity disposed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unityProcess.CloseMainWindow();

        }

        private void frm_Main_Activated(object sender, EventArgs e)
        {
            if (unityProcess != null && unityProcess.HasExited)
            {
                switch (MessageBox.Show("Unity has exited"))
                {
                    case System.Windows.Forms.DialogResult.OK:
                        unityProcess = null;
                        unityRunning = false;
                        break;
                }

            }
        }
    }
}
