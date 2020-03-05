namespace MeetingReminderBlackout
{
    partial class MeetingReminderWindow
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
            this.MeetingReminderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeetingReminderButton
            // 
            this.MeetingReminderButton.AutoSize = true;
            this.MeetingReminderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeetingReminderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingReminderButton.Location = new System.Drawing.Point(0, 0);
            this.MeetingReminderButton.Name = "MeetingReminderButton";
            this.MeetingReminderButton.Size = new System.Drawing.Size(1445, 856);
            this.MeetingReminderButton.TabIndex = 0;
            this.MeetingReminderButton.Text = "You have an Upcoming Meeting!";
            this.MeetingReminderButton.UseVisualStyleBackColor = true;
            this.MeetingReminderButton.Click += new System.EventHandler(this.MeetingReminderButton_Click);
            // 
            // MeetingReminderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 856);
            this.ControlBox = false;
            this.Controls.Add(this.MeetingReminderButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeetingReminderWindow";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MeetingReminderButton;
    }
}

