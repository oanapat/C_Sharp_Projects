namespace op_assignment2
{
    partial class stadium
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
            this.tickets = new System.Windows.Forms.GroupBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.classC = new System.Windows.Forms.Label();
            this.classB = new System.Windows.Forms.Label();
            this.classA = new System.Windows.Forms.Label();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.revenue = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.revenueC = new System.Windows.Forms.Label();
            this.revenueB = new System.Windows.Forms.Label();
            this.revenueA = new System.Windows.Forms.Label();
            this.revenueCalc = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tickets.SuspendLayout();
            this.revenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tickets
            // 
            this.tickets.Controls.Add(this.textBoxB);
            this.tickets.Controls.Add(this.textBoxC);
            this.tickets.Controls.Add(this.textBoxA);
            this.tickets.Controls.Add(this.classC);
            this.tickets.Controls.Add(this.classB);
            this.tickets.Controls.Add(this.classA);
            this.tickets.Controls.Add(this.ticketLabel);
            this.tickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickets.Location = new System.Drawing.Point(12, 30);
            this.tickets.Name = "tickets";
            this.tickets.Size = new System.Drawing.Size(348, 286);
            this.tickets.TabIndex = 0;
            this.tickets.TabStop = false;
            this.tickets.Text = "Tickets Sold";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(121, 211);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(164, 23);
            this.textBoxB.TabIndex = 6;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(121, 161);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(164, 23);
            this.textBoxC.TabIndex = 5;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(121, 118);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(164, 23);
            this.textBoxA.TabIndex = 4;
            // 
            // classC
            // 
            this.classC.AutoSize = true;
            this.classC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classC.Location = new System.Drawing.Point(34, 219);
            this.classC.Name = "classC";
            this.classC.Size = new System.Drawing.Size(51, 15);
            this.classC.TabIndex = 3;
            this.classC.Text = "Class C:";
            // 
            // classB
            // 
            this.classB.AutoSize = true;
            this.classB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classB.Location = new System.Drawing.Point(34, 164);
            this.classB.Name = "classB";
            this.classB.Size = new System.Drawing.Size(51, 15);
            this.classB.TabIndex = 2;
            this.classB.Text = "Class B:";
            // 
            // classA
            // 
            this.classA.AutoSize = true;
            this.classA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classA.Location = new System.Drawing.Point(34, 118);
            this.classA.Name = "classA";
            this.classA.Size = new System.Drawing.Size(50, 15);
            this.classA.TabIndex = 1;
            this.classA.Text = "Class A:";
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.Location = new System.Drawing.Point(22, 51);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(181, 30);
            this.ticketLabel.TabIndex = 0;
            this.ticketLabel.Text = "Enter the number of tickets sold \r\nfor each class of seats";
            // 
            // revenue
            // 
            this.revenue.Controls.Add(this.totalLabel);
            this.revenue.Controls.Add(this.labelC);
            this.revenue.Controls.Add(this.labelB);
            this.revenue.Controls.Add(this.labelA);
            this.revenue.Controls.Add(this.total);
            this.revenue.Controls.Add(this.revenueC);
            this.revenue.Controls.Add(this.revenueB);
            this.revenue.Controls.Add(this.revenueA);
            this.revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenue.Location = new System.Drawing.Point(507, 30);
            this.revenue.Name = "revenue";
            this.revenue.Size = new System.Drawing.Size(331, 286);
            this.revenue.TabIndex = 1;
            this.revenue.TabStop = false;
            this.revenue.Text = "Revenue Generated";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(148, 219);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(138, 26);
            this.totalLabel.TabIndex = 8;
            // 
            // labelC
            // 
            this.labelC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelC.Location = new System.Drawing.Point(148, 151);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(138, 26);
            this.labelC.TabIndex = 7;
            // 
            // labelB
            // 
            this.labelB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelB.Location = new System.Drawing.Point(148, 95);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(138, 26);
            this.labelB.TabIndex = 6;
            // 
            // labelA
            // 
            this.labelA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelA.Location = new System.Drawing.Point(148, 48);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(138, 26);
            this.labelA.TabIndex = 5;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(17, 219);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(37, 15);
            this.total.TabIndex = 4;
            this.total.Text = "Total:";
            // 
            // revenueC
            // 
            this.revenueC.AutoSize = true;
            this.revenueC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueC.Location = new System.Drawing.Point(17, 164);
            this.revenueC.Name = "revenueC";
            this.revenueC.Size = new System.Drawing.Size(51, 15);
            this.revenueC.TabIndex = 3;
            this.revenueC.Text = "Class C:";
            // 
            // revenueB
            // 
            this.revenueB.AutoSize = true;
            this.revenueB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueB.Location = new System.Drawing.Point(17, 108);
            this.revenueB.Name = "revenueB";
            this.revenueB.Size = new System.Drawing.Size(51, 15);
            this.revenueB.TabIndex = 2;
            this.revenueB.Text = "Class B:";
            // 
            // revenueA
            // 
            this.revenueA.AutoSize = true;
            this.revenueA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueA.Location = new System.Drawing.Point(17, 51);
            this.revenueA.Name = "revenueA";
            this.revenueA.Size = new System.Drawing.Size(50, 15);
            this.revenueA.TabIndex = 1;
            this.revenueA.Text = "Class A:";
            // 
            // revenueCalc
            // 
            this.revenueCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueCalc.Location = new System.Drawing.Point(265, 360);
            this.revenueCalc.Name = "revenueCalc";
            this.revenueCalc.Size = new System.Drawing.Size(117, 68);
            this.revenueCalc.TabIndex = 2;
            this.revenueCalc.Text = "Calculate \r\nRevenue";
            this.revenueCalc.UseVisualStyleBackColor = true;
            this.revenueCalc.Click += new System.EventHandler(this.revenueCalc_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(407, 360);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(116, 68);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(550, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 68);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stadium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 470);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.revenueCalc);
            this.Controls.Add(this.revenue);
            this.Controls.Add(this.tickets);
            this.Name = "stadium";
            this.Text = "Stadium Seating";
            this.tickets.ResumeLayout(false);
            this.tickets.PerformLayout();
            this.revenue.ResumeLayout(false);
            this.revenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tickets;
        private System.Windows.Forms.GroupBox revenue;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label classC;
        private System.Windows.Forms.Label classB;
        private System.Windows.Forms.Label classA;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label revenueC;
        private System.Windows.Forms.Label revenueB;
        private System.Windows.Forms.Label revenueA;
        private System.Windows.Forms.Button revenueCalc;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exitButton;
    }
}

