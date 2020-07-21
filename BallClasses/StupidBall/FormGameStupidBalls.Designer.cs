namespace StupidBall
{
    partial class FormGameStupidBalls
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonCatchBall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCountLostBalls = new System.Windows.Forms.Label();
            this.timerCountLostBalls = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(80, 65);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(139, 23);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Начать игру";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonCatchBall
            // 
            this.buttonCatchBall.Location = new System.Drawing.Point(1069, 65);
            this.buttonCatchBall.Name = "buttonCatchBall";
            this.buttonCatchBall.Size = new System.Drawing.Size(135, 23);
            this.buttonCatchBall.TabIndex = 0;
            this.buttonCatchBall.Text = "Поймать шарик";
            this.buttonCatchBall.UseVisualStyleBackColor = true;
            this.buttonCatchBall.Click += new System.EventHandler(this.buttonCatchBall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Подсчет потеряных шариков";
            // 
            // labelCountLostBalls
            // 
            this.labelCountLostBalls.AutoSize = true;
            this.labelCountLostBalls.Location = new System.Drawing.Point(541, 65);
            this.labelCountLostBalls.Name = "labelCountLostBalls";
            this.labelCountLostBalls.Size = new System.Drawing.Size(13, 13);
            this.labelCountLostBalls.TabIndex = 2;
            this.labelCountLostBalls.Text = "0";
            // 
            // timerCountLostBalls
            // 
            this.timerCountLostBalls.Tick += new System.EventHandler(this.timerCountLostBalls_Tick);
            // 
            // FormGameStupidBalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 466);
            this.Controls.Add(this.labelCountLostBalls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCatchBall);
            this.Controls.Add(this.buttonStartGame);
            this.Name = "FormGameStupidBalls";
            this.Text = "Игра ТУПЫЕ ШАРИКИ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonCatchBall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCountLostBalls;
        private System.Windows.Forms.Timer timerCountLostBalls;
    }
}

