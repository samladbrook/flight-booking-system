
namespace flightBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEcoSeat = new System.Windows.Forms.Label();
            this.labelFCSeat = new System.Windows.Forms.Label();
            this.labelFCPSeat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAmtOwing = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seats Avalible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Economy    -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "FirstClass   -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "FirstClass+ -";
            // 
            // labelEcoSeat
            // 
            this.labelEcoSeat.AutoSize = true;
            this.labelEcoSeat.Location = new System.Drawing.Point(161, 69);
            this.labelEcoSeat.Name = "labelEcoSeat";
            this.labelEcoSeat.Size = new System.Drawing.Size(64, 25);
            this.labelEcoSeat.TabIndex = 4;
            this.labelEcoSeat.Text = "label5";
            // 
            // labelFCSeat
            // 
            this.labelFCSeat.AutoSize = true;
            this.labelFCSeat.Location = new System.Drawing.Point(161, 103);
            this.labelFCSeat.Name = "labelFCSeat";
            this.labelFCSeat.Size = new System.Drawing.Size(64, 25);
            this.labelFCSeat.TabIndex = 5;
            this.labelFCSeat.Text = "label6";
            // 
            // labelFCPSeat
            // 
            this.labelFCPSeat.AutoSize = true;
            this.labelFCPSeat.Location = new System.Drawing.Point(161, 140);
            this.labelFCPSeat.Name = "labelFCPSeat";
            this.labelFCPSeat.Size = new System.Drawing.Size(64, 25);
            this.labelFCPSeat.TabIndex = 6;
            this.labelFCPSeat.Text = "label7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Owing - ";
            // 
            // labelAmtOwing
            // 
            this.labelAmtOwing.AutoSize = true;
            this.labelAmtOwing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmtOwing.Location = new System.Drawing.Point(613, 18);
            this.labelAmtOwing.Name = "labelAmtOwing";
            this.labelAmtOwing.Size = new System.Drawing.Size(31, 32);
            this.labelAmtOwing.TabIndex = 8;
            this.labelAmtOwing.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Purchase Tickets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAmtOwing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFCPSeat);
            this.Controls.Add(this.labelFCSeat);
            this.Controls.Add(this.labelEcoSeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEcoSeat;
        private System.Windows.Forms.Label labelFCSeat;
        private System.Windows.Forms.Label labelFCPSeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAmtOwing;
        private System.Windows.Forms.Button button1;
    }
}

