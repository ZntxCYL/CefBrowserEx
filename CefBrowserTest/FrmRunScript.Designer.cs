namespace CefBrowserTest
{
    partial class FrmRunScript
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
            this.tb_script = new System.Windows.Forms.TextBox();
            this.btn_runScript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_script
            // 
            this.tb_script.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_script.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_script.Location = new System.Drawing.Point(0, 0);
            this.tb_script.Multiline = true;
            this.tb_script.Name = "tb_script";
            this.tb_script.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_script.Size = new System.Drawing.Size(484, 332);
            this.tb_script.TabIndex = 2;
            this.tb_script.Text = "function openBaiDu()\r\n{\r\n    window.open(\'http://www.baidu.com/\', \'BaiDu\');\r\n}\r\no" +
    "penBaiDu()";
            // 
            // btn_runScript
            // 
            this.btn_runScript.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_runScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_runScript.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_runScript.Location = new System.Drawing.Point(0, 332);
            this.btn_runScript.Name = "btn_runScript";
            this.btn_runScript.Size = new System.Drawing.Size(484, 30);
            this.btn_runScript.TabIndex = 3;
            this.btn_runScript.Text = "运          行";
            this.btn_runScript.UseVisualStyleBackColor = true;
            this.btn_runScript.Click += new System.EventHandler(this.btn_runScript_Click);
            // 
            // FrmRunScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.tb_script);
            this.Controls.Add(this.btn_runScript);
            this.Name = "FrmRunScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "执行脚本";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_script;
        private System.Windows.Forms.Button btn_runScript;

    }
}