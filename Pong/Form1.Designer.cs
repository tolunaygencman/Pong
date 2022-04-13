
namespace Pong
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
            this.Cmb_Countdown = new System.Windows.Forms.ComboBox();
            this.Cmb_ScoreLimit = new System.Windows.Forms.ComboBox();
            this.Txt_PlayerName = new System.Windows.Forms.TextBox();
            this.Btn_Basla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_BotName = new System.Windows.Forms.TextBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cmb_Countdown
            // 
            this.Cmb_Countdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Countdown.FormattingEnabled = true;
            this.Cmb_Countdown.Location = new System.Drawing.Point(88, 110);
            this.Cmb_Countdown.Name = "Cmb_Countdown";
            this.Cmb_Countdown.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Countdown.TabIndex = 0;
            // 
            // Cmb_ScoreLimit
            // 
            this.Cmb_ScoreLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_ScoreLimit.FormattingEnabled = true;
            this.Cmb_ScoreLimit.Location = new System.Drawing.Point(88, 137);
            this.Cmb_ScoreLimit.Name = "Cmb_ScoreLimit";
            this.Cmb_ScoreLimit.Size = new System.Drawing.Size(121, 21);
            this.Cmb_ScoreLimit.TabIndex = 1;
            // 
            // Txt_PlayerName
            // 
            this.Txt_PlayerName.Location = new System.Drawing.Point(88, 164);
            this.Txt_PlayerName.Name = "Txt_PlayerName";
            this.Txt_PlayerName.Size = new System.Drawing.Size(121, 20);
            this.Txt_PlayerName.TabIndex = 2;
            // 
            // Btn_Basla
            // 
            this.Btn_Basla.Location = new System.Drawing.Point(88, 228);
            this.Btn_Basla.Name = "Btn_Basla";
            this.Btn_Basla.Size = new System.Drawing.Size(121, 23);
            this.Btn_Basla.TabIndex = 3;
            this.Btn_Basla.Text = "START";
            this.Btn_Basla.UseVisualStyleBackColor = true;
            this.Btn_Basla.Click += new System.EventHandler(this.Btn_Basla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 91);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time Limit :\r\n\r\nScore Limit :\r\n\r\nPlayer Name :\r\n\r\nBot Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 76);
            this.label2.TabIndex = 5;
            this.label2.Text = "PONG";
            // 
            // Txt_BotName
            // 
            this.Txt_BotName.Location = new System.Drawing.Point(88, 190);
            this.Txt_BotName.Name = "Txt_BotName";
            this.Txt_BotName.Size = new System.Drawing.Size(121, 20);
            this.Txt_BotName.TabIndex = 2;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(88, 258);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(121, 23);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "EXIT";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 289);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Basla);
            this.Controls.Add(this.Txt_BotName);
            this.Controls.Add(this.Txt_PlayerName);
            this.Controls.Add(this.Cmb_ScoreLimit);
            this.Controls.Add(this.Cmb_Countdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_Countdown;
        private System.Windows.Forms.ComboBox Cmb_ScoreLimit;
        private System.Windows.Forms.TextBox Txt_PlayerName;
        private System.Windows.Forms.Button Btn_Basla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_BotName;
        private System.Windows.Forms.Button Btn_Exit;
    }
}

