namespace CefBrowserTest
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
            this.cefBrowserEx = new CefBrowserEx.CefBrowserEx();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cefBrowserEx
            // 
            this.cefBrowserEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cefBrowserEx.Location = new System.Drawing.Point(0, 0);
            this.cefBrowserEx.Name = "cefBrowserEx";
            this.cefBrowserEx.Size = new System.Drawing.Size(1008, 730);
            this.cefBrowserEx.TabIndex = 0;
            this.cefBrowserEx.OnLoadStart += new CefBrowserEx.LoadEventHandler(this.cefBrowserEx_LoadStartEvent);
            this.cefBrowserEx.OnLoadEnd += new CefBrowserEx.LoadEventHandler(this.cefBrowserEx_LoadEndEvent);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cefBrowserEx);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CefBrowserEx.CefBrowserEx cefBrowserEx;
        private System.Windows.Forms.Button button1;


    }
}