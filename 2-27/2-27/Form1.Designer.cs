namespace _2_27
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
            this.lblFileSelect = new System.Windows.Forms.Label();
            this.lblFileContent = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFileStatus = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnDisplayFile = new System.Windows.Forms.Button();
            this.btnPushTop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpReturnValue = new System.Windows.Forms.GroupBox();
            this.lblReturnValue = new System.Windows.Forms.Label();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnUpdateFile = new System.Windows.Forms.Button();
            this.btnPushRight = new System.Windows.Forms.Button();
            this.lblClock = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.grpReturnValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFileSelect
            // 
            this.lblFileSelect.AutoSize = true;
            this.lblFileSelect.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFileSelect.Location = new System.Drawing.Point(37, 41);
            this.lblFileSelect.Name = "lblFileSelect";
            this.lblFileSelect.Size = new System.Drawing.Size(85, 12);
            this.lblFileSelect.TabIndex = 0;
            this.lblFileSelect.Text = "ファイル選択　：";
            // 
            // lblFileContent
            // 
            this.lblFileContent.AutoSize = true;
            this.lblFileContent.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFileContent.Location = new System.Drawing.Point(37, 69);
            this.lblFileContent.Name = "lblFileContent";
            this.lblFileContent.Size = new System.Drawing.Size(85, 12);
            this.lblFileContent.TabIndex = 1;
            this.lblFileContent.Text = "ファイル内容　：";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(129, 41);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(250, 19);
            this.txtFilePath.TabIndex = 2;
            // 
            // lblFileStatus
            // 
            this.lblFileStatus.AutoSize = true;
            this.lblFileStatus.Location = new System.Drawing.Point(129, 69);
            this.lblFileStatus.Name = "lblFileStatus";
            this.lblFileStatus.Size = new System.Drawing.Size(0, 12);
            this.lblFileStatus.TabIndex = 3;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.Yellow;
            this.btnSelectFile.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSelectFile.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnSelectFile.Location = new System.Drawing.Point(385, 39);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(90, 23);
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Text = "ファイル選択";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnDisplayFile
            // 
            this.btnDisplayFile.BackColor = System.Drawing.Color.Yellow;
            this.btnDisplayFile.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDisplayFile.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnDisplayFile.Location = new System.Drawing.Point(385, 69);
            this.btnDisplayFile.Name = "btnDisplayFile";
            this.btnDisplayFile.Size = new System.Drawing.Size(90, 23);
            this.btnDisplayFile.TabIndex = 5;
            this.btnDisplayFile.Text = "表示";
            this.btnDisplayFile.UseVisualStyleBackColor = false;
            this.btnDisplayFile.Click += new System.EventHandler(this.btnDisplayFile_Click);
            // 
            // btnPushTop
            // 
            this.btnPushTop.BackColor = System.Drawing.Color.DimGray;
            this.btnPushTop.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPushTop.ForeColor = System.Drawing.Color.White;
            this.btnPushTop.Location = new System.Drawing.Point(385, 115);
            this.btnPushTop.Name = "btnPushTop";
            this.btnPushTop.Size = new System.Drawing.Size(90, 23);
            this.btnPushTop.TabIndex = 6;
            this.btnPushTop.Text = "PUSH";
            this.btnPushTop.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(26, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 126);
            this.panel1.TabIndex = 7;
            // 
            // grpReturnValue
            // 
            this.grpReturnValue.Controls.Add(this.lblReturnValue);
            this.grpReturnValue.Location = new System.Drawing.Point(26, 167);
            this.grpReturnValue.Name = "grpReturnValue";
            this.grpReturnValue.Size = new System.Drawing.Size(336, 119);
            this.grpReturnValue.TabIndex = 8;
            this.grpReturnValue.TabStop = false;
            this.grpReturnValue.Text = "返却値";
            // 
            // lblReturnValue
            // 
            this.lblReturnValue.Location = new System.Drawing.Point(0, 15);
            this.lblReturnValue.Name = "lblReturnValue";
            this.lblReturnValue.Size = new System.Drawing.Size(336, 104);
            this.lblReturnValue.TabIndex = 15;
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnYellow.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnYellow.Location = new System.Drawing.Point(385, 167);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(90, 23);
            this.btnYellow.TabIndex = 9;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Yellow;
            this.btnGreen.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGreen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnGreen.Location = new System.Drawing.Point(385, 196);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(90, 23);
            this.btnGreen.TabIndex = 10;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Yellow;
            this.btnBlue.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBlue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnBlue.Location = new System.Drawing.Point(385, 225);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(90, 23);
            this.btnBlue.TabIndex = 11;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnUpdateFile
            // 
            this.btnUpdateFile.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateFile.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdateFile.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnUpdateFile.Location = new System.Drawing.Point(385, 254);
            this.btnUpdateFile.Name = "btnUpdateFile";
            this.btnUpdateFile.Size = new System.Drawing.Size(90, 23);
            this.btnUpdateFile.TabIndex = 12;
            this.btnUpdateFile.Text = "ファイル更新";
            this.btnUpdateFile.UseVisualStyleBackColor = false;
            // 
            // btnPushRight
            // 
            this.btnPushRight.BackColor = System.Drawing.Color.DimGray;
            this.btnPushRight.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPushRight.ForeColor = System.Drawing.Color.White;
            this.btnPushRight.Location = new System.Drawing.Point(385, 297);
            this.btnPushRight.Name = "btnPushRight";
            this.btnPushRight.Size = new System.Drawing.Size(90, 23);
            this.btnPushRight.TabIndex = 13;
            this.btnPushRight.Text = "PUSH";
            this.btnPushRight.UseVisualStyleBackColor = false;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClock.Location = new System.Drawing.Point(53, 308);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(192, 48);
            this.lblClock.TabIndex = 14;
            this.lblClock.Text = "00:00:00";
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 376);
            this.Controls.Add(this.grpReturnValue);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnPushRight);
            this.Controls.Add(this.btnUpdateFile);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnPushTop);
            this.Controls.Add(this.btnDisplayFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.lblFileStatus);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFileContent);
            this.Controls.Add(this.lblFileSelect);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form①";
            this.grpReturnValue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileSelect;
        private System.Windows.Forms.Label lblFileContent;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFileStatus;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnDisplayFile;
        private System.Windows.Forms.Button btnPushTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpReturnValue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnUpdateFile;
        private System.Windows.Forms.Button btnPushRight;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lblReturnValue;
    }
}

