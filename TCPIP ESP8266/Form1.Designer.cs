
namespace TCPIP_ESP8266
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar_connect = new System.Windows.Forms.ProgressBar();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_ipAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_led2Off = new System.Windows.Forms.Button();
            this.button_led2On = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_led1Off = new System.Windows.Forms.Button();
            this.button_led1On = new System.Windows.Forms.Button();
            this.label_potentioInput = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBar_potentio = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar_connect);
            this.groupBox1.Controls.Add(this.textBox_port);
            this.groupBox1.Controls.Add(this.textBox_ipAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // progressBar_connect
            // 
            this.progressBar_connect.Location = new System.Drawing.Point(24, 114);
            this.progressBar_connect.Name = "progressBar_connect";
            this.progressBar_connect.Size = new System.Drawing.Size(130, 23);
            this.progressBar_connect.TabIndex = 25;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(113, 69);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(153, 22);
            this.textBox_port.TabIndex = 21;
            this.textBox_port.Text = "8080";
            // 
            // textBox_ipAddress
            // 
            this.textBox_ipAddress.Location = new System.Drawing.Point(113, 39);
            this.textBox_ipAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ipAddress.Name = "textBox_ipAddress";
            this.textBox_ipAddress.Size = new System.Drawing.Size(153, 22);
            this.textBox_ipAddress.TabIndex = 17;
            this.textBox_ipAddress.Text = "192.168.18.101";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "IP Address :";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(191, 109);
            this.button_connect.Margin = new System.Windows.Forms.Padding(4);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 32);
            this.button_connect.TabIndex = 18;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 284);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED Control";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_led2Off);
            this.groupBox4.Controls.Add(this.button_led2On);
            this.groupBox4.Location = new System.Drawing.Point(17, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LED 2";
            // 
            // button_led2Off
            // 
            this.button_led2Off.Location = new System.Drawing.Point(88, 33);
            this.button_led2Off.Name = "button_led2Off";
            this.button_led2Off.Size = new System.Drawing.Size(63, 40);
            this.button_led2Off.TabIndex = 1;
            this.button_led2Off.Text = "OFF";
            this.button_led2Off.UseVisualStyleBackColor = true;
            this.button_led2Off.Click += new System.EventHandler(this.button_led2Off_Click);
            // 
            // button_led2On
            // 
            this.button_led2On.Location = new System.Drawing.Point(10, 34);
            this.button_led2On.Name = "button_led2On";
            this.button_led2On.Size = new System.Drawing.Size(63, 40);
            this.button_led2On.TabIndex = 0;
            this.button_led2On.Text = "ON";
            this.button_led2On.UseVisualStyleBackColor = true;
            this.button_led2On.Click += new System.EventHandler(this.button_led2On_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_led1Off);
            this.groupBox3.Controls.Add(this.button_led1On);
            this.groupBox3.Location = new System.Drawing.Point(17, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LED 1";
            // 
            // button_led1Off
            // 
            this.button_led1Off.Location = new System.Drawing.Point(89, 34);
            this.button_led1Off.Name = "button_led1Off";
            this.button_led1Off.Size = new System.Drawing.Size(63, 40);
            this.button_led1Off.TabIndex = 1;
            this.button_led1Off.Text = "OFF";
            this.button_led1Off.UseVisualStyleBackColor = true;
            this.button_led1Off.Click += new System.EventHandler(this.button_led1Off_Click);
            // 
            // button_led1On
            // 
            this.button_led1On.Location = new System.Drawing.Point(11, 34);
            this.button_led1On.Name = "button_led1On";
            this.button_led1On.Size = new System.Drawing.Size(63, 40);
            this.button_led1On.TabIndex = 0;
            this.button_led1On.Text = "ON";
            this.button_led1On.UseVisualStyleBackColor = true;
            this.button_led1On.Click += new System.EventHandler(this.button_led1On_Click);
            // 
            // label_potentioInput
            // 
            this.label_potentioInput.AutoSize = true;
            this.label_potentioInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potentioInput.Location = new System.Drawing.Point(132, 48);
            this.label_potentioInput.Name = "label_potentioInput";
            this.label_potentioInput.Size = new System.Drawing.Size(0, 25);
            this.label_potentioInput.TabIndex = 23;
            this.label_potentioInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.progressBar_potentio);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label_potentioInput);
            this.groupBox5.Location = new System.Drawing.Point(12, 177);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 119);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Potentio Input";
            // 
            // progressBar_potentio
            // 
            this.progressBar_potentio.Location = new System.Drawing.Point(36, 83);
            this.progressBar_potentio.Maximum = 93;
            this.progressBar_potentio.Name = "progressBar_potentio";
            this.progressBar_potentio.Size = new System.Drawing.Size(227, 23);
            this.progressBar_potentio.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 310);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "TCP/IP ESP8266";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_ipAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_led2Off;
        private System.Windows.Forms.Button button_led2On;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_led1Off;
        private System.Windows.Forms.Button button_led1On;
        private System.Windows.Forms.Label label_potentioInput;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ProgressBar progressBar_potentio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar_connect;
    }
}

