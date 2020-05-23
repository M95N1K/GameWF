namespace Multiple
{
    partial class MessageForm
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
            this.ButtonClose = new System.Windows.Forms.Button();
            this.Targets = new System.Windows.Forms.Label();
            this.LabelMessages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Location = new System.Drawing.Point(2, 247);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(583, 23);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "ОК";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Targets
            // 
            this.Targets.AutoSize = true;
            this.Targets.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Targets.Location = new System.Drawing.Point(220, 153);
            this.Targets.Name = "Targets";
            this.Targets.Size = new System.Drawing.Size(134, 31);
            this.Targets.TabIndex = 1;
            this.Targets.Text = "00000000";
            // 
            // LabelMessages
            // 
            this.LabelMessages.AutoSize = true;
            this.LabelMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessages.Location = new System.Drawing.Point(168, 90);
            this.LabelMessages.Name = "LabelMessages";
            this.LabelMessages.Size = new System.Drawing.Size(238, 39);
            this.LabelMessages.TabIndex = 2;
            this.LabelMessages.Text = "Надо набрать";
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 282);
            this.Controls.Add(this.LabelMessages);
            this.Controls.Add(this.Targets);
            this.Controls.Add(this.ButtonClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.ShowInTaskbar = false;
            this.Text = "Сообщение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelMessages;
        private System.Windows.Forms.Label Targets;
    }
}