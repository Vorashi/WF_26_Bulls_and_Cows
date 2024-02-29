namespace Task_01
{
    partial class Bull_and_Cows
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.lbxMainUser = new System.Windows.Forms.ListBox();
            this.lbxBics = new System.Windows.Forms.ListBox();
            this.lbxCorov = new System.Windows.Forms.ListBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.lblUserNumber = new System.Windows.Forms.Label();
            this.lblBics = new System.Windows.Forms.Label();
            this.lblCorov = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemIntoProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewGame.Location = new System.Drawing.Point(93, 480);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(375, 43);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Новая Игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(16, 507);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(0, 16);
            this.LblResult.TabIndex = 1;
            // 
            // lbxMainUser
            // 
            this.lbxMainUser.Enabled = false;
            this.lbxMainUser.FormattingEnabled = true;
            this.lbxMainUser.ItemHeight = 16;
            this.lbxMainUser.Location = new System.Drawing.Point(24, 75);
            this.lbxMainUser.Name = "lbxMainUser";
            this.lbxMainUser.Size = new System.Drawing.Size(238, 244);
            this.lbxMainUser.TabIndex = 2;
            // 
            // lbxBics
            // 
            this.lbxBics.Enabled = false;
            this.lbxBics.FormattingEnabled = true;
            this.lbxBics.ItemHeight = 16;
            this.lbxBics.Location = new System.Drawing.Point(348, 75);
            this.lbxBics.Name = "lbxBics";
            this.lbxBics.Size = new System.Drawing.Size(120, 164);
            this.lbxBics.TabIndex = 3;
            // 
            // lbxCorov
            // 
            this.lbxCorov.Enabled = false;
            this.lbxCorov.FormattingEnabled = true;
            this.lbxCorov.ItemHeight = 16;
            this.lbxCorov.Location = new System.Drawing.Point(348, 289);
            this.lbxCorov.Name = "lbxCorov";
            this.lbxCorov.Size = new System.Drawing.Size(120, 164);
            this.lbxCorov.TabIndex = 4;
            // 
            // btnInput
            // 
            this.btnInput.Enabled = false;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInput.Location = new System.Drawing.Point(24, 389);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(238, 43);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Ввод";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Location = new System.Drawing.Point(21, 46);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(86, 16);
            this.lblUserNumber.TabIndex = 6;
            this.lblUserNumber.Text = "Ваше число:";
            // 
            // lblBics
            // 
            this.lblBics.AutoSize = true;
            this.lblBics.Location = new System.Drawing.Point(345, 46);
            this.lblBics.Name = "lblBics";
            this.lblBics.Size = new System.Drawing.Size(43, 16);
            this.lblBics.TabIndex = 7;
            this.lblBics.Text = "Быки:";
            // 
            // lblCorov
            // 
            this.lblCorov.AutoSize = true;
            this.lblCorov.Location = new System.Drawing.Point(345, 261);
            this.lblCorov.Name = "lblCorov";
            this.lblCorov.Size = new System.Drawing.Size(59, 16);
            this.lblCorov.TabIndex = 8;
            this.lblCorov.Text = "Коровы:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemIntoProgramm,
            this.menuItemClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemIntoProgramm
            // 
            this.menuItemIntoProgramm.Name = "menuItemIntoProgramm";
            this.menuItemIntoProgramm.Size = new System.Drawing.Size(118, 24);
            this.menuItemIntoProgramm.Text = "О программе";
            this.menuItemIntoProgramm.Click += new System.EventHandler(this.menuItemIntoProgramm_Click);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(67, 24);
            this.menuItemClose.Text = "Выход";
            this.menuItemClose.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tbxInput
            // 
            this.tbxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxInput.Enabled = false;
            this.tbxInput.Location = new System.Drawing.Point(24, 347);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(238, 22);
            this.tbxInput.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 560);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lblCorov);
            this.Controls.Add(this.lblBics);
            this.Controls.Add(this.lblUserNumber);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lbxCorov);
            this.Controls.Add(this.lbxBics);
            this.Controls.Add(this.lbxMainUser);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WF_26 Быки коровы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.ListBox lbxMainUser;
        private System.Windows.Forms.ListBox lbxBics;
        private System.Windows.Forms.ListBox lbxCorov;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.Label lblBics;
        private System.Windows.Forms.Label lblCorov;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemIntoProgramm;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.ToolStripMenuItem menuItemClose;
    }
}

