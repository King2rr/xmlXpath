namespace UC.XMLEducator
{
    partial class Form1
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
            this.lblImport = new System.Windows.Forms.Label();
            this.btnImportXML = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtXMLFilePath = new System.Windows.Forms.TextBox();
            this.rtbXMLContent = new System.Windows.Forms.RichTextBox();
            this.trvQueryResults = new System.Windows.Forms.TreeView();
            this.lblLoadXPath = new System.Windows.Forms.Label();
            this.cmbXPath = new System.Windows.Forms.ComboBox();
            this.openXMLFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.wbrXML = new System.Windows.Forms.WebBrowser();
            this.btnQuery = new System.Windows.Forms.Button();
            this.rtbQueryResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Location = new System.Drawing.Point(13, 13);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(80, 13);
            this.lblImport.TabIndex = 0;
            this.lblImport.Text = "Import XML File";
            // 
            // btnImportXML
            // 
            this.btnImportXML.Location = new System.Drawing.Point(369, 6);
            this.btnImportXML.Name = "btnImportXML";
            this.btnImportXML.Size = new System.Drawing.Size(53, 23);
            this.btnImportXML.TabIndex = 1;
            this.btnImportXML.Text = "Import";
            this.btnImportXML.UseVisualStyleBackColor = true;
            this.btnImportXML.Click += new System.EventHandler(this.btnImportXML_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(425, 6);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(53, 23);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtXMLFilePath
            // 
            this.txtXMLFilePath.Location = new System.Drawing.Point(99, 9);
            this.txtXMLFilePath.Name = "txtXMLFilePath";
            this.txtXMLFilePath.Size = new System.Drawing.Size(264, 20);
            this.txtXMLFilePath.TabIndex = 3;
            this.txtXMLFilePath.TextChanged += new System.EventHandler(this.txtXMLFilePath_TextChanged);
            // 
            // rtbXMLContent
            // 
            this.rtbXMLContent.Location = new System.Drawing.Point(13, 114);
            this.rtbXMLContent.Name = "rtbXMLContent";
            this.rtbXMLContent.Size = new System.Drawing.Size(465, 381);
            this.rtbXMLContent.TabIndex = 4;
            this.rtbXMLContent.Text = "";
            // 
            // trvQueryResults
            // 
            this.trvQueryResults.Location = new System.Drawing.Point(499, 2);
            this.trvQueryResults.Name = "trvQueryResults";
            this.trvQueryResults.Size = new System.Drawing.Size(520, 247);
            this.trvQueryResults.TabIndex = 5;
            // 
            // lblLoadXPath
            // 
            this.lblLoadXPath.AutoSize = true;
            this.lblLoadXPath.Location = new System.Drawing.Point(16, 64);
            this.lblLoadXPath.Name = "lblLoadXPath";
            this.lblLoadXPath.Size = new System.Drawing.Size(36, 13);
            this.lblLoadXPath.TabIndex = 7;
            this.lblLoadXPath.Text = "XPath";
            // 
            // cmbXPath
            // 
            this.cmbXPath.FormattingEnabled = true;
            this.cmbXPath.Location = new System.Drawing.Point(99, 56);
            this.cmbXPath.Name = "cmbXPath";
            this.cmbXPath.Size = new System.Drawing.Size(264, 21);
            this.cmbXPath.TabIndex = 8;
            this.cmbXPath.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openXMLFileDialog
            // 
            this.openXMLFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openXMLFileDialog_FileOk);
            // 
            // wbrXML
            // 
            this.wbrXML.Location = new System.Drawing.Point(19, 114);
            this.wbrXML.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrXML.Name = "wbrXML";
            this.wbrXML.Size = new System.Drawing.Size(446, 381);
            this.wbrXML.TabIndex = 9;
            this.wbrXML.Visible = false;
            this.wbrXML.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbrXML_DocumentCompleted);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(369, 56);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(53, 23);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // rtbQueryResults
            // 
            this.rtbQueryResults.Location = new System.Drawing.Point(499, 256);
            this.rtbQueryResults.Name = "rtbQueryResults";
            this.rtbQueryResults.Size = new System.Drawing.Size(520, 239);
            this.rtbQueryResults.TabIndex = 11;
            this.rtbQueryResults.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 507);
            this.Controls.Add(this.rtbQueryResults);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.wbrXML);
            this.Controls.Add(this.cmbXPath);
            this.Controls.Add(this.lblLoadXPath);
            this.Controls.Add(this.trvQueryResults);
            this.Controls.Add(this.rtbXMLContent);
            this.Controls.Add(this.txtXMLFilePath);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnImportXML);
            this.Controls.Add(this.lblImport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Button btnImportXML;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtXMLFilePath;
        private System.Windows.Forms.RichTextBox rtbXMLContent;
        private System.Windows.Forms.TreeView trvQueryResults;
        private System.Windows.Forms.Label lblLoadXPath;
        private System.Windows.Forms.ComboBox cmbXPath;
        private System.Windows.Forms.OpenFileDialog openXMLFileDialog;
        private System.Windows.Forms.WebBrowser wbrXML;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.RichTextBox rtbQueryResults;
    }
}

