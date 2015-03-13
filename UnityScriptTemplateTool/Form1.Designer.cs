namespace UnityScriptTemplateTool
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_STD = new System.Windows.Forms.Label();
            this.txt_ScriptTemplateDirectory = new System.Windows.Forms.TextBox();
            this.btn_FindScriptTemplateDirectory = new System.Windows.Forms.Button();
            this.lbl_UnityRunning = new System.Windows.Forms.Label();
            this.btn_StartUnity = new System.Windows.Forms.Button();
            this.tmr_RefreshUnityProcess = new System.Windows.Forms.Timer(this.components);
            this.btn_RestartUnity = new System.Windows.Forms.Button();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.lbl_URL = new System.Windows.Forms.Label();
            this.btn_GetContent = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.RichTextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_Process = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_STD
            // 
            this.lbl_STD.AutoSize = true;
            this.lbl_STD.Location = new System.Drawing.Point(12, 9);
            this.lbl_STD.Name = "lbl_STD";
            this.lbl_STD.Size = new System.Drawing.Size(126, 13);
            this.lbl_STD.TabIndex = 0;
            this.lbl_STD.Text = "Script Template Directory";
            this.lbl_STD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_ScriptTemplateDirectory
            // 
            this.txt_ScriptTemplateDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ScriptTemplateDirectory.Location = new System.Drawing.Point(144, 6);
            this.txt_ScriptTemplateDirectory.Name = "txt_ScriptTemplateDirectory";
            this.txt_ScriptTemplateDirectory.Size = new System.Drawing.Size(340, 20);
            this.txt_ScriptTemplateDirectory.TabIndex = 1;
            // 
            // btn_FindScriptTemplateDirectory
            // 
            this.btn_FindScriptTemplateDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FindScriptTemplateDirectory.Location = new System.Drawing.Point(490, 4);
            this.btn_FindScriptTemplateDirectory.Name = "btn_FindScriptTemplateDirectory";
            this.btn_FindScriptTemplateDirectory.Size = new System.Drawing.Size(75, 23);
            this.btn_FindScriptTemplateDirectory.TabIndex = 2;
            this.btn_FindScriptTemplateDirectory.Text = "&Find";
            this.btn_FindScriptTemplateDirectory.UseVisualStyleBackColor = true;
            this.btn_FindScriptTemplateDirectory.Click += new System.EventHandler(this.btn_FindScriptTemplateDirectory_Click);
            // 
            // lbl_UnityRunning
            // 
            this.lbl_UnityRunning.AutoSize = true;
            this.lbl_UnityRunning.Location = new System.Drawing.Point(12, 43);
            this.lbl_UnityRunning.Name = "lbl_UnityRunning";
            this.lbl_UnityRunning.Size = new System.Drawing.Size(105, 13);
            this.lbl_UnityRunning.TabIndex = 3;
            this.lbl_UnityRunning.Text = "Unity Running: False";
            // 
            // btn_StartUnity
            // 
            this.btn_StartUnity.Location = new System.Drawing.Point(225, 38);
            this.btn_StartUnity.Name = "btn_StartUnity";
            this.btn_StartUnity.Size = new System.Drawing.Size(75, 23);
            this.btn_StartUnity.TabIndex = 4;
            this.btn_StartUnity.Text = "Start Unity";
            this.btn_StartUnity.UseVisualStyleBackColor = true;
            this.btn_StartUnity.Click += new System.EventHandler(this.btn_StartUnity_Click);
            // 
            // tmr_RefreshUnityProcess
            // 
            this.tmr_RefreshUnityProcess.Enabled = true;
            this.tmr_RefreshUnityProcess.Interval = 10;
            this.tmr_RefreshUnityProcess.Tick += new System.EventHandler(this.tmr_RefreshUnityProcess_Tick);
            // 
            // btn_RestartUnity
            // 
            this.btn_RestartUnity.Location = new System.Drawing.Point(144, 38);
            this.btn_RestartUnity.Name = "btn_RestartUnity";
            this.btn_RestartUnity.Size = new System.Drawing.Size(75, 23);
            this.btn_RestartUnity.TabIndex = 5;
            this.btn_RestartUnity.Text = "RestartUnity";
            this.btn_RestartUnity.UseVisualStyleBackColor = true;
            this.btn_RestartUnity.Click += new System.EventHandler(this.btn_RestartUnity_Click);
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(144, 100);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(329, 20);
            this.txt_URL.TabIndex = 6;
            this.txt_URL.Text = "http://www.dotnetperls.com/scraping-html";
            // 
            // lbl_URL
            // 
            this.lbl_URL.AutoSize = true;
            this.lbl_URL.Location = new System.Drawing.Point(12, 103);
            this.lbl_URL.Name = "lbl_URL";
            this.lbl_URL.Size = new System.Drawing.Size(32, 13);
            this.lbl_URL.TabIndex = 7;
            this.lbl_URL.Text = "URL:";
            // 
            // btn_GetContent
            // 
            this.btn_GetContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetContent.Location = new System.Drawing.Point(490, 98);
            this.btn_GetContent.Name = "btn_GetContent";
            this.btn_GetContent.Size = new System.Drawing.Size(75, 23);
            this.btn_GetContent.TabIndex = 8;
            this.btn_GetContent.Text = "&Get";
            this.btn_GetContent.UseVisualStyleBackColor = true;
            this.btn_GetContent.Click += new System.EventHandler(this.btn_GetContent_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Result.Location = new System.Drawing.Point(144, 126);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(421, 211);
            this.txt_Result.TabIndex = 9;
            this.txt_Result.Text = "\n\n";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(12, 129);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(40, 13);
            this.lbl_Result.TabIndex = 10;
            this.lbl_Result.Text = "Result:";
            // 
            // btn_Process
            // 
            this.btn_Process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Process.Location = new System.Drawing.Point(490, 343);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(75, 23);
            this.btn_Process.TabIndex = 11;
            this.btn_Process.Text = "&Process";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 397);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_GetContent);
            this.Controls.Add(this.lbl_URL);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.btn_RestartUnity);
            this.Controls.Add(this.btn_StartUnity);
            this.Controls.Add(this.lbl_UnityRunning);
            this.Controls.Add(this.btn_FindScriptTemplateDirectory);
            this.Controls.Add(this.txt_ScriptTemplateDirectory);
            this.Controls.Add(this.lbl_STD);
            this.Name = "frm_Main";
            this.Text = "Unity Script Template Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_STD;
        private System.Windows.Forms.TextBox txt_ScriptTemplateDirectory;
        private System.Windows.Forms.Button btn_FindScriptTemplateDirectory;
        private System.Windows.Forms.Label lbl_UnityRunning;
        private System.Windows.Forms.Button btn_StartUnity;
        private System.Windows.Forms.Timer tmr_RefreshUnityProcess;
        private System.Windows.Forms.Button btn_RestartUnity;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Label lbl_URL;
        private System.Windows.Forms.Button btn_GetContent;
        private System.Windows.Forms.RichTextBox txt_Result;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_Process;
    }
}

