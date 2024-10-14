namespace Project_Lottery
{
    partial class MainForm
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
            btnEndDayEarly = new Button();
            lblPreparationTime = new Label();
            button1 = new Button();
            button2 = new Button();
            lblDayTime = new Label();
            lstEvents = new ListBox();
            SuspendLayout();
            // 
            // btnEndDayEarly
            // 
            btnEndDayEarly.Location = new Point(713, 365);
            btnEndDayEarly.Name = "btnEndDayEarly";
            btnEndDayEarly.Size = new Size(75, 23);
            btnEndDayEarly.TabIndex = 0;
            btnEndDayEarly.Text = "End Day";
            btnEndDayEarly.UseVisualStyleBackColor = true;
            btnEndDayEarly.Click += btnEndDayEarly_Click;
            // 
            // lblPreparationTime
            // 
            lblPreparationTime.AutoSize = true;
            lblPreparationTime.Location = new Point(335, 35);
            lblPreparationTime.Name = "lblPreparationTime";
            lblPreparationTime.Size = new Size(107, 15);
            lblPreparationTime.TabIndex = 1;
            lblPreparationTime.Text = "lblPreparationTime";
            // 
            // button1
            // 
            button1.Location = new Point(37, 310);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buy Tickets";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(118, 310);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Set Prices";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblDayTime
            // 
            lblDayTime.AutoSize = true;
            lblDayTime.Location = new Point(355, 35);
            lblDayTime.Name = "lblDayTime";
            lblDayTime.Size = new Size(66, 15);
            lblDayTime.TabIndex = 4;
            lblDayTime.Text = "lblDayTime";
            // 
            // lstEvents
            // 
            lstEvents.FormattingEnabled = true;
            lstEvents.ItemHeight = 15;
            lstEvents.Location = new Point(0, 401);
            lstEvents.Margin = new Padding(1);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new Size(801, 49);
            lstEvents.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(lstEvents);
            Controls.Add(lblDayTime);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblPreparationTime);
            Controls.Add(btnEndDayEarly);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEndDayEarly;
        private Label lblPreparationTime;
        private Button button1;
        private Button button2;
        private Label lblDayTime;
        private ListBox lstEvents;
    }
}
