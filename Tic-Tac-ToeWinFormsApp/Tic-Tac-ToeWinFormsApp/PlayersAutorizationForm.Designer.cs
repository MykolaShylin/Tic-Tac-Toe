namespace Tic_Tac_ToeWinFormsApp
{
    partial class PlayersAutorizationForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.player1CharButtonO = new System.Windows.Forms.Button();
            this.player1CharButtonX = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.player1TextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.player2CharButtonO = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.player2CharButtonX = new System.Windows.Forms.Button();
            this.player2TextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.player1CharButtonO);
            this.splitContainer1.Panel1.Controls.Add(this.player1CharButtonX);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.player1TextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.player2CharButtonO);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.player2CharButtonX);
            this.splitContainer1.Panel2.Controls.Add(this.player2TextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(503, 211);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // player1CharButtonO
            // 
            this.player1CharButtonO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player1CharButtonO.AutoSize = true;
            this.player1CharButtonO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player1CharButtonO.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player1CharButtonO.Location = new System.Drawing.Point(139, 157);
            this.player1CharButtonO.Name = "player1CharButtonO";
            this.player1CharButtonO.Size = new System.Drawing.Size(61, 47);
            this.player1CharButtonO.TabIndex = 4;
            this.player1CharButtonO.Text = "О";
            this.player1CharButtonO.UseVisualStyleBackColor = true;
            this.player1CharButtonO.Click += new System.EventHandler(this.player1CharButtonO_Click);
            // 
            // player1CharButtonX
            // 
            this.player1CharButtonX.AutoSize = true;
            this.player1CharButtonX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player1CharButtonX.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player1CharButtonX.Location = new System.Drawing.Point(38, 157);
            this.player1CharButtonX.Name = "player1CharButtonX";
            this.player1CharButtonX.Size = new System.Drawing.Size(61, 47);
            this.player1CharButtonX.TabIndex = 3;
            this.player1CharButtonX.Text = "Х";
            this.player1CharButtonX.UseVisualStyleBackColor = true;
            this.player1CharButtonX.Click += new System.EventHandler(this.player1CharButtonX_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-2, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Игровой символ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1TextBox
            // 
            this.player1TextBox.BeepOnError = true;
            this.player1TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player1TextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.player1TextBox.Location = new System.Drawing.Point(3, 61);
            this.player1TextBox.Mask = "LLLLLLLLLLLL";
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.RejectInputOnFirstFailure = true;
            this.player1TextBox.Size = new System.Drawing.Size(240, 34);
            this.player1TextBox.SkipLiterals = false;
            this.player1TextBox.TabIndex = 1;
            this.player1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player1TextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игрок 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2CharButtonO
            // 
            this.player2CharButtonO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player2CharButtonO.AutoSize = true;
            this.player2CharButtonO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player2CharButtonO.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player2CharButtonO.Location = new System.Drawing.Point(137, 157);
            this.player2CharButtonO.Name = "player2CharButtonO";
            this.player2CharButtonO.Size = new System.Drawing.Size(61, 47);
            this.player2CharButtonO.TabIndex = 6;
            this.player2CharButtonO.Text = "О";
            this.player2CharButtonO.UseVisualStyleBackColor = true;
            this.player2CharButtonO.Click += new System.EventHandler(this.player2CharButtonO_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Игровой символ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2CharButtonX
            // 
            this.player2CharButtonX.AutoSize = true;
            this.player2CharButtonX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player2CharButtonX.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player2CharButtonX.Location = new System.Drawing.Point(40, 157);
            this.player2CharButtonX.Name = "player2CharButtonX";
            this.player2CharButtonX.Size = new System.Drawing.Size(61, 47);
            this.player2CharButtonX.TabIndex = 5;
            this.player2CharButtonX.Text = "Х";
            this.player2CharButtonX.UseVisualStyleBackColor = true;
            this.player2CharButtonX.Click += new System.EventHandler(this.player2CharButtonX_Click);
            // 
            // player2TextBox
            // 
            this.player2TextBox.BeepOnError = true;
            this.player2TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player2TextBox.Location = new System.Drawing.Point(3, 61);
            this.player2TextBox.Mask = "LLLLLLLLLLLL";
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(240, 34);
            this.player2TextBox.TabIndex = 2;
            this.player2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Игрок 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.BackColor = System.Drawing.Color.Moccasin;
            this.startButton.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(0, 217);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(503, 58);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // PlayersAutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 275);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(521, 322);
            this.MinimumSize = new System.Drawing.Size(521, 322);
            this.Name = "PlayersAutorizationForm";
            this.Text = "Авторизация";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button startButton;
        private Label label1;
        private Label label2;
        private MaskedTextBox player1TextBox;
        private MaskedTextBox player2TextBox;
        private Label label3;
        private Label label4;
        private Button player1CharButtonO;
        private Button player1CharButtonX;
        private Button player2CharButtonO;
        private Button player2CharButtonX;
    }
}