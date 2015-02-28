namespace CefBrowserTest
{
    partial class FrmBrowser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_viewCode = new System.Windows.Forms.Button();
            this.btn_runScript = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.cefBrowserEx = new CefBrowserEx.CefBrowserEx();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btn_viewCode);
            this.panel1.Controls.Add(this.btn_runScript);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_forward);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_go);
            this.panel1.Controls.Add(this.tb_url);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 50);
            this.panel1.TabIndex = 1;
            // 
            // btn_viewCode
            // 
            this.btn_viewCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewCode.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_viewCode.ForeColor = System.Drawing.Color.Black;
            this.btn_viewCode.Location = new System.Drawing.Point(853, 12);
            this.btn_viewCode.Name = "btn_viewCode";
            this.btn_viewCode.Size = new System.Drawing.Size(66, 26);
            this.btn_viewCode.TabIndex = 2;
            this.btn_viewCode.Text = "查看源代码";
            this.btn_viewCode.UseVisualStyleBackColor = false;
            this.btn_viewCode.Click += new System.EventHandler(this.btn_viewCode_Click);
            // 
            // btn_runScript
            // 
            this.btn_runScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_runScript.BackColor = System.Drawing.Color.Transparent;
            this.btn_runScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_runScript.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_runScript.ForeColor = System.Drawing.Color.Black;
            this.btn_runScript.Location = new System.Drawing.Point(930, 12);
            this.btn_runScript.Name = "btn_runScript";
            this.btn_runScript.Size = new System.Drawing.Size(66, 26);
            this.btn_runScript.TabIndex = 3;
            this.btn_runScript.Text = "执行脚本";
            this.btn_runScript.UseVisualStyleBackColor = false;
            this.btn_runScript.Click += new System.EventHandler(this.btn_runScript_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_stop.ForeColor = System.Drawing.Color.Black;
            this.btn_stop.Location = new System.Drawing.Point(225, 12);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(60, 26);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Text = "停 止";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.Location = new System.Drawing.Point(154, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(60, 26);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "刷 新";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_forward.BackColor = System.Drawing.Color.Transparent;
            this.btn_forward.Enabled = false;
            this.btn_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forward.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_forward.ForeColor = System.Drawing.Color.Black;
            this.btn_forward.Location = new System.Drawing.Point(83, 12);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(60, 26);
            this.btn_forward.TabIndex = 5;
            this.btn_forward.Text = "前 进";
            this.btn_forward.UseVisualStyleBackColor = false;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.Enabled = false;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(60, 26);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "后 退";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_go
            // 
            this.btn_go.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_go.BackColor = System.Drawing.Color.Transparent;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_go.ForeColor = System.Drawing.Color.Black;
            this.btn_go.Location = new System.Drawing.Point(807, 12);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(35, 26);
            this.btn_go.TabIndex = 1;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = false;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // tb_url
            // 
            this.tb_url.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_url.BackColor = System.Drawing.SystemColors.Window;
            this.tb_url.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_url.Location = new System.Drawing.Point(296, 13);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(500, 23);
            this.tb_url.TabIndex = 0;
            this.tb_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_url_KeyPress);
            // 
            // cefBrowserEx
            // 
            this.cefBrowserEx.BackColor = System.Drawing.Color.White;
            this.cefBrowserEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cefBrowserEx.Location = new System.Drawing.Point(0, 50);
            this.cefBrowserEx.Name = "cefBrowserEx";
            this.cefBrowserEx.Size = new System.Drawing.Size(1008, 680);
            this.cefBrowserEx.TabIndex = 0;
            this.cefBrowserEx.Url = "http://www.cnblogs.com/";
            this.cefBrowserEx.OnNewWindow += new CefBrowserEx.NewWindowEventHandler(this.cefBrowserEx_OnNewWindow);
            this.cefBrowserEx.OnLoadStart += new CefBrowserEx.LoadEventHandler(this.cefBrowserEx_LoadStartEvent);
            this.cefBrowserEx.OnLoadEnd += new CefBrowserEx.LoadEventHandler(this.cefBrowserEx_LoadEndEvent);
            this.cefBrowserEx.OnLoadingStateChange += new CefBrowserEx.LoadingStateChangeEventHandler(this.cefBrowserEx_OnLoadingStateChange);
            // 
            // FrmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.cefBrowserEx);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "浏览器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CefBrowserEx.CefBrowserEx cefBrowserEx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_runScript;
        private System.Windows.Forms.Button btn_viewCode;
    }
}