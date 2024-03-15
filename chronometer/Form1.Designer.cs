namespace chronometer
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            chronometer = new System.Windows.Forms.Timer(components);
            startbtn = new Button();
            stopbtn = new Button();
            timerlbl = new Label();
            restartbtn = new Button();
            SuspendLayout();
            // 
            // chronometer
            // 
            chronometer.Tick += Ticking;
            // 
            // startbtn
            // 
            startbtn.BackColor = Color.DarkSeaGreen;
            startbtn.Location = new Point(310, 123);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(112, 34);
            startbtn.TabIndex = 0;
            startbtn.Text = "start";
            startbtn.UseVisualStyleBackColor = false;
            startbtn.Click += StartTimer;
            // 
            // stopbtn
            // 
            stopbtn.BackColor = Color.Chocolate;
            stopbtn.Location = new Point(310, 178);
            stopbtn.Name = "stopbtn";
            stopbtn.Size = new Size(112, 34);
            stopbtn.TabIndex = 1;
            stopbtn.Text = "stop";
            stopbtn.UseVisualStyleBackColor = false;
            stopbtn.Click += StopTimer;
            // 
            // timerlbl
            // 
            timerlbl.AutoSize = true;
            timerlbl.Location = new Point(338, 67);
            timerlbl.Name = "timerlbl";
            timerlbl.Size = new Size(56, 25);
            timerlbl.TabIndex = 2;
            timerlbl.Text = "00:00";
            // 
            // restartbtn
            // 
            restartbtn.BackColor = Color.CadetBlue;
            restartbtn.Location = new Point(310, 235);
            restartbtn.Name = "restartbtn";
            restartbtn.Size = new Size(112, 34);
            restartbtn.TabIndex = 3;
            restartbtn.Text = "restart";
            restartbtn.UseVisualStyleBackColor = false;
            restartbtn.Click += RestartTimer;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(restartbtn);
            Controls.Add(timerlbl);
            Controls.Add(stopbtn);
            Controls.Add(startbtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer chronometer;
        private Button startbtn;
        private Button stopbtn;
        private Label timerlbl;
        private Button restartbtn;
    }
}