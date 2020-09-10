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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.starLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.hiLabel.Location = new System.Drawing.Point(234, 223);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(302, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 71);
            this.button1.TabIndex = 7;
            this.button1.Text = "タイトルへ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(289, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 74);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clear";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

