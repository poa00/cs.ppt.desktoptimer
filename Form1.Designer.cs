
namespace DesktopTimer
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
            this.StartButton = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.buttonReset = new System.Windows.Forms.Button();
            this.msgTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartButton.BackColor = System.Drawing.Color.CadetBlue;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(12, 162);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(630, 65);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(207, 45);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(255, 53);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.Text = "02:00:00";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.LightGray;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(495, 45);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(140, 53);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // msgTextBox
            // 
            this.msgTextBox.Location = new System.Drawing.Point(118, 120);
            this.msgTextBox.MaxLength = 27;
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.Size = new System.Drawing.Size(390, 20);
            this.msgTextBox.TabIndex = 4;
            this.msgTextBox.Text = "Time to take a BREAK!";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 14);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Message Text";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(654, 239);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.msgTextBox);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox msgTextBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}

