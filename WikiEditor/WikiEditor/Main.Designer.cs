namespace WikiEditor
{
    partial class Main
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.codeTab = new System.Windows.Forms.TabPage();
            this.codeTB = new System.Windows.Forms.TextBox();
            this.previewTab = new System.Windows.Forms.TabPage();
            this.previewBrowser = new System.Windows.Forms.WebBrowser();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.languageCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.codeTab.SuspendLayout();
            this.previewTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.codeTab);
            this.tabControl.Controls.Add(this.previewTab);
            this.tabControl.Controls.Add(this.settingsTab);
            this.tabControl.Controls.Add(this.aboutTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1312, 750);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // codeTab
            // 
            this.codeTab.Controls.Add(this.codeTB);
            this.codeTab.Location = new System.Drawing.Point(4, 28);
            this.codeTab.Name = "codeTab";
            this.codeTab.Padding = new System.Windows.Forms.Padding(3);
            this.codeTab.Size = new System.Drawing.Size(1304, 718);
            this.codeTab.TabIndex = 0;
            this.codeTab.Text = "Code";
            this.codeTab.UseVisualStyleBackColor = true;
            // 
            // codeTB
            // 
            this.codeTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeTB.Location = new System.Drawing.Point(3, 3);
            this.codeTB.Multiline = true;
            this.codeTB.Name = "codeTB";
            this.codeTB.Size = new System.Drawing.Size(1298, 712);
            this.codeTB.TabIndex = 0;
            // 
            // previewTab
            // 
            this.previewTab.Controls.Add(this.previewBrowser);
            this.previewTab.Location = new System.Drawing.Point(4, 28);
            this.previewTab.Name = "previewTab";
            this.previewTab.Padding = new System.Windows.Forms.Padding(3);
            this.previewTab.Size = new System.Drawing.Size(1304, 718);
            this.previewTab.TabIndex = 1;
            this.previewTab.Text = "Preview";
            this.previewTab.UseVisualStyleBackColor = true;
            // 
            // previewBrowser
            // 
            this.previewBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewBrowser.Location = new System.Drawing.Point(3, 3);
            this.previewBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewBrowser.Name = "previewBrowser";
            this.previewBrowser.Size = new System.Drawing.Size(1298, 712);
            this.previewBrowser.TabIndex = 0;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.languageCB);
            this.settingsTab.Controls.Add(this.label1);
            this.settingsTab.Location = new System.Drawing.Point(4, 28);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(1304, 718);
            this.settingsTab.TabIndex = 3;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // languageCB
            // 
            this.languageCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageCB.DropDownWidth = 121;
            this.languageCB.FormattingEnabled = true;
            this.languageCB.Items.AddRange(new object[] {
            "HTML",
            "WikiCreole"});
            this.languageCB.Location = new System.Drawing.Point(12, 30);
            this.languageCB.Name = "languageCB";
            this.languageCB.Size = new System.Drawing.Size(121, 27);
            this.languageCB.Sorted = true;
            this.languageCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Language:";
            // 
            // aboutTab
            // 
            this.aboutTab.Location = new System.Drawing.Point(4, 28);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(1304, 718);
            this.aboutTab.TabIndex = 2;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 750);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WikiEditor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.codeTab.ResumeLayout(false);
            this.codeTab.PerformLayout();
            this.previewTab.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage codeTab;
        private System.Windows.Forms.TextBox codeTB;
        private System.Windows.Forms.TabPage previewTab;
        private System.Windows.Forms.WebBrowser previewBrowser;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.ComboBox languageCB;
        private System.Windows.Forms.Label label1;
    }
}

