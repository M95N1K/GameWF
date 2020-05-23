namespace Multiple
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonDouble = new System.Windows.Forms.Button();
            this.ButtonUndo = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.LabelCurrent = new System.Windows.Forms.Label();
            this.LabelTarget = new System.Windows.Forms.Label();
            this.LabelStep = new System.Windows.Forms.Label();
            this.LabelMaxSteps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(473, 12);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Tag = "1";
            this.ButtonStart.Text = "Старт";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Enabled = false;
            this.ButtonPlus.Location = new System.Drawing.Point(473, 59);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlus.TabIndex = 1;
            this.ButtonPlus.Tag = "2";
            this.ButtonPlus.Text = "+1";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonDouble
            // 
            this.ButtonDouble.Enabled = false;
            this.ButtonDouble.Location = new System.Drawing.Point(473, 88);
            this.ButtonDouble.Name = "ButtonDouble";
            this.ButtonDouble.Size = new System.Drawing.Size(75, 23);
            this.ButtonDouble.TabIndex = 2;
            this.ButtonDouble.Tag = "3";
            this.ButtonDouble.Text = "x2";
            this.ButtonDouble.UseVisualStyleBackColor = true;
            this.ButtonDouble.Click += new System.EventHandler(this.ButtonDouble_Click);
            // 
            // ButtonUndo
            // 
            this.ButtonUndo.Enabled = false;
            this.ButtonUndo.Location = new System.Drawing.Point(473, 117);
            this.ButtonUndo.Name = "ButtonUndo";
            this.ButtonUndo.Size = new System.Drawing.Size(75, 23);
            this.ButtonUndo.TabIndex = 3;
            this.ButtonUndo.Tag = "4";
            this.ButtonUndo.Text = "Отмена";
            this.ButtonUndo.UseVisualStyleBackColor = true;
            this.ButtonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Enabled = false;
            this.ButtonReset.Location = new System.Drawing.Point(473, 168);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 4;
            this.ButtonReset.Tag = "5";
            this.ButtonReset.Text = "Сброс";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // LabelCurrent
            // 
            this.LabelCurrent.AutoSize = true;
            this.LabelCurrent.Location = new System.Drawing.Point(12, 9);
            this.LabelCurrent.Name = "LabelCurrent";
            this.LabelCurrent.Size = new System.Drawing.Size(111, 13);
            this.LabelCurrent.TabIndex = 5;
            this.LabelCurrent.Text = "Текущее значение 0";
            // 
            // LabelTarget
            // 
            this.LabelTarget.AutoSize = true;
            this.LabelTarget.Location = new System.Drawing.Point(13, 37);
            this.LabelTarget.Name = "LabelTarget";
            this.LabelTarget.Size = new System.Drawing.Size(110, 13);
            this.LabelTarget.TabIndex = 6;
            this.LabelTarget.Text = "Целевое значение 0";
            // 
            // LabelStep
            // 
            this.LabelStep.AutoSize = true;
            this.LabelStep.Location = new System.Drawing.Point(12, 64);
            this.LabelStep.Name = "LabelStep";
            this.LabelStep.Size = new System.Drawing.Size(109, 13);
            this.LabelStep.TabIndex = 7;
            this.LabelStep.Text = "Количество шагов 0";
            // 
            // LabelMaxSteps
            // 
            this.LabelMaxSteps.AutoSize = true;
            this.LabelMaxSteps.Location = new System.Drawing.Point(12, 98);
            this.LabelMaxSteps.Name = "LabelMaxSteps";
            this.LabelMaxSteps.Size = new System.Drawing.Size(188, 13);
            this.LabelMaxSteps.TabIndex = 8;
            this.LabelMaxSteps.Text = "Максимальное количество шагов 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 206);
            this.Controls.Add(this.LabelMaxSteps);
            this.Controls.Add(this.LabelStep);
            this.Controls.Add(this.LabelTarget);
            this.Controls.Add(this.LabelCurrent);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonUndo);
            this.Controls.Add(this.ButtonDouble);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonStart);
            this.Name = "MainForm";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonDouble;
        private System.Windows.Forms.Button ButtonUndo;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Label LabelCurrent;
        private System.Windows.Forms.Label LabelTarget;
        private System.Windows.Forms.Label LabelStep;
        private System.Windows.Forms.Label LabelMaxSteps;

        private GameClass GameCore;
    }
}

