namespace EveryoneCouldBeCHE
{
    partial class MainForm
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.btnOpen = new System.Windows.Forms.Button();
        	this.hThreshold = new System.Windows.Forms.HScrollBar();
        	this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
        	this.SuspendLayout();
        	// 
        	// btnOpen
        	// 
        	this.btnOpen.BackColor = System.Drawing.Color.Black;
        	this.btnOpen.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnOpen.ForeColor = System.Drawing.Color.Red;
        	this.btnOpen.Location = new System.Drawing.Point(9, 11);
        	this.btnOpen.Name = "btnOpen";
        	this.btnOpen.Size = new System.Drawing.Size(135, 48);
        	this.btnOpen.TabIndex = 0;
        	this.btnOpen.Text = "Open your most heroic image...";
        	this.toolTip1.SetToolTip(this.btnOpen, "Click here to open your most heroic image. ");
        	this.btnOpen.UseVisualStyleBackColor = false;
        	this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
        	// 
        	// hThreshold
        	// 
        	this.hThreshold.Location = new System.Drawing.Point(9, 62);
        	this.hThreshold.Maximum = 255;
        	this.hThreshold.Name = "hThreshold";
        	this.hThreshold.Size = new System.Drawing.Size(135, 21);
        	this.hThreshold.TabIndex = 1;
        	this.toolTip1.SetToolTip(this.hThreshold, "Threshold of greatness");
        	this.hThreshold.Value = 128;
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.Red;
        	this.ClientSize = new System.Drawing.Size(157, 97);
        	this.Controls.Add(this.hThreshold);
        	this.Controls.Add(this.btnOpen);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.Name = "MainForm";
        	this.Text = "Everyone Could Be CHE";
        	this.toolTip1.SetToolTip(this, "Everyone Could Be CHE (a,k,a, Cheguevarize) by Trinh Thanh Trung 2009");
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HScrollBar hThreshold;

        #endregion

        private System.Windows.Forms.Button btnOpen;
    }
}

