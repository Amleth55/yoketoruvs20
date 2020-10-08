namespace yoketoruvs20
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.starLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.titleButton = new System.Windows.Forms.Button();
            this.clearLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.templabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLabel.Font = new System.Drawing.Font("MS UI Gothic", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titleLabel.Location = new System.Drawing.Point(103, 78);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(586, 107);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる2020";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(314, 301);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(142, 71);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "スタート";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copyRightLabel.Location = new System.Drawing.Point(464, 404);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(317, 27);
            this.copyRightLabel.TabIndex = 2;
            this.copyRightLabel.Text = "Copyright © 2020　佐藤 廉";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(12, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(137, 34);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "Time 100";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // starLabel
            // 
            this.starLabel.AutoSize = true;
            this.starLabel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starLabel.Location = new System.Drawing.Point(707, 16);
            this.starLabel.Name = "starLabel";
            this.starLabel.Size = new System.Drawing.Size(74, 34);
            this.starLabel.TabIndex = 4;
            this.starLabel.Text = "★:10";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("MS UI Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hiLabel.Location = new System.Drawing.Point(239, 3);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(308, 47);
            this.hiLabel.TabIndex = 5;
            this.hiLabel.Text = "HighScore 100";
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.Font = new System.Drawing.Font("MS UI Gothic", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gameoverLabel.Location = new System.Drawing.Point(211, 175);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(358, 74);
            this.gameoverLabel.TabIndex = 6;
            this.gameoverLabel.Text = "GameOver";
            // 
            // titleButton
            // 
            this.titleButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleButton.Location = new System.Drawing.Point(314, 301);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(142, 71);
            this.titleButton.TabIndex = 7;
            this.titleButton.Text = "タイトルへ";
            this.titleButton.UseVisualStyleBackColor = true;
            this.titleButton.Click += new System.EventHandler(this.titleButton_Click);
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("MS UI Gothic", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearLabel.Location = new System.Drawing.Point(291, 175);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(195, 74);
            this.clearLabel.TabIndex = 8;
            this.clearLabel.Text = "Clear";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // templabel
            // 
            this.templabel.AutoSize = true;
            this.templabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.templabel.Location = new System.Drawing.Point(70, 216);
            this.templabel.Name = "templabel";
            this.templabel.Size = new System.Drawing.Size(47, 33);
            this.templabel.TabIndex = 9;
            this.templabel.Text = "★";
            this.templabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.templabel);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.gameoverLabel);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.starLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.copyRightLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label copyRightLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label starLabel;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label templabel;
    }
}

