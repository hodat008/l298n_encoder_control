namespace BTL_do_luong_cn
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCOM = new System.Windows.Forms.ComboBox();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.BttConnect = new System.Windows.Forms.Button();
            this.BttDisconnect = new System.Windows.Forms.Button();
            this.BttExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_rotate_right = new System.Windows.Forms.Button();
            this.button_rotate_left = new System.Windows.Forms.Button();
            this.butSend = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_rotate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Angle_real = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select COM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Baudrate";
            // 
            // cboCOM
            // 
            this.cboCOM.FormattingEnabled = true;
            this.cboCOM.Location = new System.Drawing.Point(219, 55);
            this.cboCOM.Name = "cboCOM";
            this.cboCOM.Size = new System.Drawing.Size(143, 33);
            this.cboCOM.TabIndex = 3;
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Location = new System.Drawing.Point(219, 124);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(143, 33);
            this.cboBaudrate.TabIndex = 4;
            // 
            // BttConnect
            // 
            this.BttConnect.BackColor = System.Drawing.Color.Lime;
            this.BttConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BttConnect.Location = new System.Drawing.Point(28, 276);
            this.BttConnect.Name = "BttConnect";
            this.BttConnect.Size = new System.Drawing.Size(143, 51);
            this.BttConnect.TabIndex = 5;
            this.BttConnect.Text = "Connect";
            this.BttConnect.UseVisualStyleBackColor = false;
            this.BttConnect.Click += new System.EventHandler(this.BttConnect_Click);
            // 
            // BttDisconnect
            // 
            this.BttDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BttDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttDisconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BttDisconnect.Location = new System.Drawing.Point(209, 276);
            this.BttDisconnect.Name = "BttDisconnect";
            this.BttDisconnect.Size = new System.Drawing.Size(143, 51);
            this.BttDisconnect.TabIndex = 6;
            this.BttDisconnect.Text = "Disconnect";
            this.BttDisconnect.UseVisualStyleBackColor = false;
            this.BttDisconnect.Click += new System.EventHandler(this.BttDisconnect_Click);
            // 
            // BttExit
            // 
            this.BttExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BttExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttExit.Location = new System.Drawing.Point(118, 348);
            this.BttExit.Name = "BttExit";
            this.BttExit.Size = new System.Drawing.Size(144, 45);
            this.BttExit.TabIndex = 7;
            this.BttExit.Text = "Exit";
            this.BttExit.UseVisualStyleBackColor = false;
            this.BttExit.Click += new System.EventHandler(this.BttExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "State";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbState.Location = new System.Drawing.Point(209, 206);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(143, 25);
            this.lbState.TabIndex = 9;
            this.lbState.Text = "Disconnected";
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAngle.Location = new System.Drawing.Point(139, 44);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(104, 30);
            this.textBoxAngle.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_reset);
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Controls.Add(this.button_rotate_right);
            this.groupBox1.Controls.Add(this.button_rotate_left);
            this.groupBox1.Controls.Add(this.butSend);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxAngle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(413, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 247);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Tomato;
            this.button_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_reset.Location = new System.Drawing.Point(216, 105);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(106, 39);
            this.button_reset.TabIndex = 28;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_stop.ForeColor = System.Drawing.Color.White;
            this.button_stop.Location = new System.Drawing.Point(396, 105);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(101, 39);
            this.button_stop.TabIndex = 24;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_rotate_right
            // 
            this.button_rotate_right.Location = new System.Drawing.Point(309, 177);
            this.button_rotate_right.Name = "button_rotate_right";
            this.button_rotate_right.Size = new System.Drawing.Size(188, 45);
            this.button_rotate_right.TabIndex = 22;
            this.button_rotate_right.Text = "Rotate left";
            this.button_rotate_right.UseVisualStyleBackColor = true;
            this.button_rotate_right.Click += new System.EventHandler(this.button_rotate_right_Click);
            // 
            // button_rotate_left
            // 
            this.button_rotate_left.Location = new System.Drawing.Point(40, 177);
            this.button_rotate_left.Name = "button_rotate_left";
            this.button_rotate_left.Size = new System.Drawing.Size(220, 45);
            this.button_rotate_left.TabIndex = 21;
            this.button_rotate_left.Text = "Rotate right";
            this.button_rotate_left.UseVisualStyleBackColor = true;
            this.button_rotate_left.Click += new System.EventHandler(this.button_rotate_left_Click);
            // 
            // butSend
            // 
            this.butSend.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.butSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butSend.Location = new System.Drawing.Point(40, 105);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(106, 39);
            this.butSend.TabIndex = 20;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = false;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(120, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pulses";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbState);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BttExit);
            this.groupBox2.Controls.Add(this.cboBaudrate);
            this.groupBox2.Controls.Add(this.BttDisconnect);
            this.groupBox2.Controls.Add(this.cboCOM);
            this.groupBox2.Controls.Add(this.BttConnect);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 433);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_rotate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label_state);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_Angle_real);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(415, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 157);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motor Status";
            // 
            // label_rotate
            // 
            this.label_rotate.AutoSize = true;
            this.label_rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rotate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_rotate.Location = new System.Drawing.Point(389, 56);
            this.label_rotate.Name = "label_rotate";
            this.label_rotate.Size = new System.Drawing.Size(61, 25);
            this.label_rotate.TabIndex = 24;
            this.label_rotate.Text = "Right";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(272, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Rotate";
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_state.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_state.Location = new System.Drawing.Point(132, 56);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(57, 25);
            this.label_state.TabIndex = 22;
            this.label_state.Text = "Stop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "State";
            // 
            // textBox_Angle_real
            // 
            this.textBox_Angle_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Angle_real.Location = new System.Drawing.Point(43, 108);
            this.textBox_Angle_real.Name = "textBox_Angle_real";
            this.textBox_Angle_real.Size = new System.Drawing.Size(407, 30);
            this.textBox_Angle_real.TabIndex = 20;
            this.textBox_Angle_real.TextChanged += new System.EventHandler(this.textBox_Angle_real_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 459);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCOM;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.Button BttConnect;
        private System.Windows.Forms.Button BttDisconnect;
        private System.Windows.Forms.Button BttExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbState;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_rotate_right;
        private System.Windows.Forms.Button button_rotate_left;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.TextBox textBox_Angle_real;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_rotate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_reset;
    }
}

