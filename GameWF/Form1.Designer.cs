namespace GameWF
{
    partial class GamePolygon
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
            this.components = new System.ComponentModel.Container();
            this.shipPlayer = new System.Windows.Forms.Button();
            this.torp = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.enemy1 = new System.Windows.Forms.Button();
            this.enemy2 = new System.Windows.Forms.Button();
            this.civil = new System.Windows.Forms.Button();
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // shipPlayer
            // 
            this.shipPlayer.Enabled = false;
            this.shipPlayer.Location = new System.Drawing.Point(235, 87);
            this.shipPlayer.Name = "shipPlayer";
            this.shipPlayer.Size = new System.Drawing.Size(75, 23);
            this.shipPlayer.TabIndex = 0;
            this.shipPlayer.UseVisualStyleBackColor = true;
            // 
            // torp
            // 
            this.torp.Location = new System.Drawing.Point(245, 213);
            this.torp.Name = "torp";
            this.torp.Size = new System.Drawing.Size(75, 23);
            this.torp.TabIndex = 1;
            this.torp.UseVisualStyleBackColor = true;
            this.torp.Visible = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(13, 13);
            this.score.TabIndex = 2;
            this.score.Text = "0";
            // 
            // gameover
            // 
            this.gameover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameover.ForeColor = System.Drawing.Color.Red;
            this.gameover.Location = new System.Drawing.Point(324, 179);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(132, 25);
            this.gameover.TabIndex = 3;
            this.gameover.Text = "GAME OVER";
            this.gameover.Visible = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Red;
            this.enemy1.Enabled = false;
            this.enemy1.Location = new System.Drawing.Point(187, 306);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(75, 23);
            this.enemy1.TabIndex = 4;
            this.enemy1.UseVisualStyleBackColor = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Red;
            this.enemy2.Enabled = false;
            this.enemy2.Location = new System.Drawing.Point(366, 306);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(75, 23);
            this.enemy2.TabIndex = 5;
            this.enemy2.UseVisualStyleBackColor = false;
            // 
            // civil
            // 
            this.civil.BackColor = System.Drawing.Color.Green;
            this.civil.Enabled = false;
            this.civil.Location = new System.Drawing.Point(483, 258);
            this.civil.Name = "civil";
            this.civil.Size = new System.Drawing.Size(75, 23);
            this.civil.TabIndex = 6;
            this.civil.UseVisualStyleBackColor = false;
            // 
            // enemyTimer
            // 
            this.enemyTimer.Enabled = true;
            this.enemyTimer.Interval = 1;
            this.enemyTimer.Tick += new System.EventHandler(this.enemyTimer_Tick);
            // 
            // GamePolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.civil);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.score);
            this.Controls.Add(this.torp);
            this.Controls.Add(this.shipPlayer);
            this.KeyPreview = true;
            this.Name = "GamePolygon";
            this.Text = "GameFW";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePolygon_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GamePolygon_KeyDown);
            this.Resize += new System.EventHandler(this.GamePolygon_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shipPlayer;
        private BatleShip playerShip;
        private BatleShip torpeda;
        private BatleShip military1;
        private BatleShip military2;
        private BatleShip civil1;
        private System.Windows.Forms.Button torp;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Button enemy1;
        private System.Windows.Forms.Button enemy2;
        private System.Windows.Forms.Button civil;
        private System.Windows.Forms.Timer enemyTimer;
    }
}

