namespace ProjectJsonToCsvConverter
{
    partial class JsonToCsvForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxJson = new System.Windows.Forms.TextBox();
            this.textBoxCsv = new System.Windows.Forms.TextBox();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.labelEndpoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAPI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxJson
            // 
            this.textBoxJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxJson.Location = new System.Drawing.Point(12, 89);
            this.textBoxJson.Multiline = true;
            this.textBoxJson.Name = "textBoxJson";
            this.textBoxJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxJson.Size = new System.Drawing.Size(403, 556);
            this.textBoxJson.TabIndex = 2;
            this.textBoxJson.TextChanged += new System.EventHandler(this.textBoxJson_TextChanged);
            // 
            // textBoxCsv
            // 
            this.textBoxCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCsv.Location = new System.Drawing.Point(648, 89);
            this.textBoxCsv.Multiline = true;
            this.textBoxCsv.Name = "textBoxCsv";
            this.textBoxCsv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCsv.Size = new System.Drawing.Size(510, 556);
            this.textBoxCsv.TabIndex = 5;
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Location = new System.Drawing.Point(523, 23);
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(354, 27);
            this.textBoxUserInput.TabIndex = 1;
            this.textBoxUserInput.Text = "name/peru";
            // 
            // labelEndpoints
            // 
            this.labelEndpoints.AutoSize = true;
            this.labelEndpoints.Location = new System.Drawing.Point(306, 26);
            this.labelEndpoints.Name = "labelEndpoints";
            this.labelEndpoints.Size = new System.Drawing.Size(0, 20);
            this.labelEndpoints.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 180);
            this.label1.TabIndex = 5;
            this.label1.Text = "Endpoints:\r\n- name/(name)\r\n  name/peru\r\n- region/(region)\r\n  (region/europe)\r\n- s" +
    "ubregion/(region)\r\n  (subregion/europe)\r\n- capital/(capital)\r\n  (capital/llima)\r" +
    "\n";
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(441, 89);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(172, 51);
            this.btnRequest.TabIndex = 3;
            this.btnRequest.Text = "Request API";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(441, 172);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(172, 46);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert to CSV";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Visible = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "JSON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(884, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "CSV";
            // 
            // textBoxAPI
            // 
            this.textBoxAPI.Location = new System.Drawing.Point(184, 23);
            this.textBoxAPI.Name = "textBoxAPI";
            this.textBoxAPI.Size = new System.Drawing.Size(333, 27);
            this.textBoxAPI.TabIndex = 10;
            this.textBoxAPI.Text = "https://restcountries.com/v3.1/";
            this.textBoxAPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // JsonToCsvForm
            // 
            this.AcceptButton = this.btnRequest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 657);
            this.Controls.Add(this.textBoxAPI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEndpoints);
            this.Controls.Add(this.textBoxUserInput);
            this.Controls.Add(this.textBoxCsv);
            this.Controls.Add(this.textBoxJson);
            this.Name = "JsonToCsvForm";
            this.Text = "JsonToCsv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxJson;
        private TextBox textBoxCsv;
        private TextBox textBoxUserInput;
        private Label labelEndpoints;
        private Label label1;
        private Button btnRequest;
        private Button btnConvert;
        private Label label2;
        private Label label3;
        private TextBox textBoxAPI;
    }
}
