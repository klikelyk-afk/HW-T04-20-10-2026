namespace App_511_Weather
{
    partial class WeatherItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataPanel1 = new DataPanel();
            labelInfo = new Label();
            labelTitle = new Label();
            dataPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataPanel1
            // 
            dataPanel1.BackColor = Color.Transparent;
            dataPanel1.Controls.Add(labelInfo);
            dataPanel1.Controls.Add(labelTitle);
            dataPanel1.Location = new Point(3, 2);
            dataPanel1.Margin = new Padding(3, 2, 3, 2);
            dataPanel1.Name = "dataPanel1";
            dataPanel1.Size = new Size(100, 56);
            dataPanel1.TabIndex = 0;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelInfo.ForeColor = Color.SteelBlue;
            labelInfo.Location = new Point(25, 26);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(47, 15);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "<data>";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(25, 11);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(48, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "<type>";
            // 
            // WeatherItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(dataPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WeatherItemControl";
            Size = new Size(105, 60);
            dataPanel1.ResumeLayout(false);
            dataPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataPanel dataPanel1;
        private Label labelInfo;
        private Label labelTitle;
    }
}
