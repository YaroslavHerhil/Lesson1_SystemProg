
namespace Lesson1_SystemProg
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
            btnStart = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            process1 = new System.Diagnostics.Process();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox1 = new System.Windows.Forms.TextBox();
            listView1 = new System.Windows.Forms.ListView();
            button1 = new System.Windows.Forms.Button();
            btnPlay = new System.Windows.Forms.Button();
            process2 = new System.Diagnostics.Process();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnStart.Location = new System.Drawing.Point(688, 390);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(112, 33);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += Start_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnStop.Location = new System.Drawing.Point(26, 390);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(112, 33);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "notepad", "calc", "mspaint", "cmd", "windirstat" });
            comboBox1.Location = new System.Drawing.Point(260, 391);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(229, 33);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Select an application";
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(26, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(774, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listView1
            // 
            listView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(26, 62);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(774, 306);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button1.Location = new System.Drawing.Point(144, 390);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(110, 33);
            button1.TabIndex = 6;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnPlay
            // 
            btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnPlay.Location = new System.Drawing.Point(570, 390);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new System.Drawing.Size(112, 34);
            btnPlay.TabIndex = 7;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // process2
            // 
            process2.StartInfo.Domain = "";
            process2.StartInfo.LoadUserProfile = false;
            process2.StartInfo.Password = null;
            process2.StartInfo.StandardErrorEncoding = null;
            process2.StartInfo.StandardInputEncoding = null;
            process2.StartInfo.StandardOutputEncoding = null;
            process2.StartInfo.UserName = "";
            process2.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(833, 436);
            Controls.Add(btnPlay);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPlay;
        private System.Diagnostics.Process process2;
    }
}

