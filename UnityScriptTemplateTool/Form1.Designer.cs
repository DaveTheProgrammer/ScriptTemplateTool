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
            this.txt_ScriptTemplateDirectory.Size = new System.Drawing.Size(329, 20);
            this.txt_ScriptTemplateDirectory.TabIndex = 1;
            // 
            // btn_FindScriptTemplateDirectory
            // 
            this.btn_FindScriptTemplateDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FindScriptTemplateDirectory.Location = new System.Drawing.Point(479, 4);
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
            this.btn_StartUnity.Location = new System.Drawing.Point(379, 214);
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
            this.btn_RestartUnity.Location = new System.Drawing.Point(62, 213);
            this.btn_RestartUnity.Name = "btn_RestartUnity";
            this.btn_RestartUnity.Size = new System.Drawing.Size(75, 23);
            this.btn_RestartUnity.TabIndex = 5;
            this.btn_RestartUnity.Text = "RestartUnity";
            this.btn_RestartUnity.UseVisualStyleBackColor = true;
            this.btn_RestartUnity.Click += new System.EventHandler(this.btn_RestartUnity_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 406);
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
    }
}

