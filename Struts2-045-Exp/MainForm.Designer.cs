namespace Struts2_045_Exp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.txt_cmd = new System.Windows.Forms.TextBox();
            this.txt_preview = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_timeout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rad_crlf = new System.Windows.Forms.RadioButton();
            this.rad_lf = new System.Windows.Forms.RadioButton();
            this.rad_cr = new System.Windows.Forms.RadioButton();
            this.cmb_encoding = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(41, 12);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(510, 21);
            this.txt_url.TabIndex = 0;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(12, 318);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_result.Size = new System.Drawing.Size(1026, 321);
            this.txt_result.TabIndex = 1;
            // 
            // txt_cmd
            // 
            this.txt_cmd.Location = new System.Drawing.Point(12, 63);
            this.txt_cmd.Multiline = true;
            this.txt_cmd.Name = "txt_cmd";
            this.txt_cmd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_cmd.Size = new System.Drawing.Size(510, 184);
            this.txt_cmd.TabIndex = 2;
            this.txt_cmd.TextChanged += new System.EventHandler(this.txt_cmd_TextChanged);
            // 
            // txt_preview
            // 
            this.txt_preview.Location = new System.Drawing.Point(528, 63);
            this.txt_preview.Multiline = true;
            this.txt_preview.Name = "txt_preview";
            this.txt_preview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_preview.Size = new System.Drawing.Size(510, 184);
            this.txt_preview.TabIndex = 3;
            this.txt_preview.Text = resources.GetString("txt_preview.Text");
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(12, 253);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(1026, 38);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send (Ctrl + Enter)";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_timeout
            // 
            this.txt_timeout.Location = new System.Drawing.Point(610, 12);
            this.txt_timeout.Name = "txt_timeout";
            this.txt_timeout.Size = new System.Drawing.Size(53, 21);
            this.txt_timeout.TabIndex = 5;
            this.txt_timeout.Text = "3000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "TimeOut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Command";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Payload Preview (Content-Type)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Result";
            // 
            // rad_crlf
            // 
            this.rad_crlf.AutoSize = true;
            this.rad_crlf.Checked = true;
            this.rad_crlf.Location = new System.Drawing.Point(57, 299);
            this.rad_crlf.Name = "rad_crlf";
            this.rad_crlf.Size = new System.Drawing.Size(47, 16);
            this.rad_crlf.TabIndex = 11;
            this.rad_crlf.TabStop = true;
            this.rad_crlf.Text = "CRLF";
            this.rad_crlf.UseVisualStyleBackColor = true;
            // 
            // rad_lf
            // 
            this.rad_lf.AutoSize = true;
            this.rad_lf.Location = new System.Drawing.Point(110, 299);
            this.rad_lf.Name = "rad_lf";
            this.rad_lf.Size = new System.Drawing.Size(35, 16);
            this.rad_lf.TabIndex = 12;
            this.rad_lf.Text = "LF";
            this.rad_lf.UseVisualStyleBackColor = true;
            // 
            // rad_cr
            // 
            this.rad_cr.AutoSize = true;
            this.rad_cr.Location = new System.Drawing.Point(151, 299);
            this.rad_cr.Name = "rad_cr";
            this.rad_cr.Size = new System.Drawing.Size(35, 16);
            this.rad_cr.TabIndex = 13;
            this.rad_cr.Text = "CR";
            this.rad_cr.UseVisualStyleBackColor = true;
            // 
            // cmb_encoding
            // 
            this.cmb_encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_encoding.FormattingEnabled = true;
            this.cmb_encoding.Location = new System.Drawing.Point(192, 295);
            this.cmb_encoding.Name = "cmb_encoding";
            this.cmb_encoding.Size = new System.Drawing.Size(121, 20);
            this.cmb_encoding.Sorted = true;
            this.cmb_encoding.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 651);
            this.Controls.Add(this.cmb_encoding);
            this.Controls.Add(this.rad_cr);
            this.Controls.Add(this.rad_lf);
            this.Controls.Add(this.rad_crlf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_timeout);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_preview);
            this.Controls.Add(this.txt_cmd);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_url);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Struts2-045-Exp 乁(๑˙ω˙๑乁)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.TextBox txt_cmd;
        private System.Windows.Forms.TextBox txt_preview;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_timeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rad_crlf;
        private System.Windows.Forms.RadioButton rad_lf;
        private System.Windows.Forms.RadioButton rad_cr;
        private System.Windows.Forms.ComboBox cmb_encoding;
    }
}

