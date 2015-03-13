using System.Collections.Generic;
using System.Windows.Automation;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System;
using System.Text.RegularExpressions;
using System.Net;


namespace UnityScriptTemplateTool
{
    public partial class frm_Main : Form
    {
        private const string DefaultUnityApplicationDirectory = @"\Unity\Editor\Unity.exe";
        private const string DefaultTemplateDirectory = @"\Unity\Editor\Data\Resources\ScriptTemplates";
        private const string UnityProcessName = "Unity";

        private Process unityProcess;
        private bool unityRunning;


        #region - Unity Running -
        public bool UnityRunning
        {
            set
            {
                if (value != unityRunning)
                {
                    // Set the text to inform you if Unity is running or not
                    lbl_UnityRunning.Text = string.Format("Unity Running: {0}", unityRunning);

                    // Toggle the buttons debendin on the process state
                    btn_RestartUnity.Enabled = unityRunning;
                    btn_StartUnity.Enabled = !unityRunning;

                    unityRunning = value;
                }
            }
        }
        #endregion

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

            // Set the text to inform you if Unity is running or not
            lbl_UnityRunning.Text = string.Format("Unity Running: {0}", unityRunning);

            // Toggle the buttons debendin on the process state
            btn_RestartUnity.Enabled = unityRunning;
            btn_StartUnity.Enabled = !unityRunning;
        }
        #endregion

        #region - Refresh Unity Process -
        private void refreshUnityProcess()
        {
            // Try to get the Unity process
            if (unityProcess == null)
            {
                Process[] UnityProcesses = Process.GetProcessesByName(UnityProcessName);

                if (UnityProcesses.Length > 0)
                    unityProcess = UnityProcesses[0];
            }
            else
            {
                if (unityProcess.HasExited)
                {
                    unityProcess = null;
                    UnityRunning = false;
                }
            }

            // Is it available?
            UnityRunning = unityProcess != null;
        }
        #endregion


        // Callbacks

        #region - Refresh Unity Process Timer -
        private void tmr_RefreshUnityProcess_Tick(object sender, EventArgs e)
        {
            refreshUnityProcess();
        }
        #endregion

        #region - Start New Unity -
        private void startNewUnity()
        {
            refreshUnityProcess();

            // Is unity already running?
            if (unityRunning)
            {
                MessageBox.Show("Unity is already running!");
                return;
            }

            // Get the path and check it exists
            string exePath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + DefaultUnityApplicationDirectory;
            if (!File.Exists(exePath))
            {
                MessageBox.Show("Could not get unity executable at '" + exePath + "'");
                return;
            }

            // We have everything we need, so start the damn thing :)
            ProcessStartInfo si = new ProcessStartInfo(exePath);
            Process.Start(si);
        }
        #endregion

        #region - Give Unity Focus -
        private void giveUnityFocus()
        {
            if (unityProcess != null)
            {
                AutomationElement element = AutomationElement.FromHandle(unityProcess.MainWindowHandle);
                if (element != null)
                    element.SetFocus();
            }
        }
        #endregion





        // Button Clicks

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

        #region - Restart Unity Clicked -
        private void btn_RestartUnity_Click(object sender, EventArgs e)
        {
            if (unityRunning)
            {
                giveUnityFocus();
                unityProcess.CloseMainWindow();
            }
        }
        #endregion

        #region - Start Unity Clicked -
        private void btn_StartUnity_Click(object sender, EventArgs e)
        {
            startNewUnity();
        }
        #endregion


        private string resultText;

        private void btn_GetContent_Click(object sender, EventArgs e)
        {
            WebClient w = new WebClient();
            try
            {
                resultText = w.DownloadString(txt_URL.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }


            txt_Result.Text = resultText;
        }

        private void btn_Process_Click(object sender, EventArgs e)
        {
            List<LinkItem> links = LinkFinder.Find(resultText);

            string lks = string.Empty;

            for (int i = 0; i < links.Count; i++)
            {
                lks += links[i].Text + "   -   " + links[i].Href + "\r\n";
            }

            txt_Result.Text = lks;
        }

        private LinkItem GetLinkFromName(string LinkName, List<LinkItem> Links)
        {
            return Links.Find(l => l.Text.Equals(LinkName));
        }
    }





    public struct LinkItem
    {
        public string Href;
        public string Text;

        public override string ToString()
        {
            return Href + "\n\t" + Text;
        }
    }

    static class LinkFinder
    {
        public static List<LinkItem> Find(string file)
        {
            List<LinkItem> list = new List<LinkItem>();

            // Find all matches in file.
            MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)", RegexOptions.Singleline);

            // Loop over each match.
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                LinkItem i = new LinkItem();

                // Get href attribute.
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""", RegexOptions.Singleline);
                if (m2.Success)
                    i.Href = m2.Groups[1].Value;

                // Remove inner tags from text.
                string t = Regex.Replace(value, @"\s*<.*?>\s*", "", RegexOptions.Singleline);
                i.Text = t;

                list.Add(i);
            }
            return list;
        }
    }
}
