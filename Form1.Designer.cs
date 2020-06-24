namespace Курсовая_Работа
{
    partial class Form1
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
            this.txtBxKeyWordEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richtxtboxEncrypt = new System.Windows.Forms.RichTextBox();
            this.richTtxtboxDecrypt = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияСТекстомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxKeyWordEncrypt
            // 
            this.txtBxKeyWordEncrypt.Location = new System.Drawing.Point(12, 78);
            this.txtBxKeyWordEncrypt.Name = "txtBxKeyWordEncrypt";
            this.txtBxKeyWordEncrypt.Size = new System.Drawing.Size(291, 20);
            this.txtBxKeyWordEncrypt.TabIndex = 16;
            this.txtBxKeyWordEncrypt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxKeyWordEncrypt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Входные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ключ-слово";
            // 
            // richtxtboxEncrypt
            // 
            this.richtxtboxEncrypt.Location = new System.Drawing.Point(16, 142);
            this.richtxtboxEncrypt.Name = "richtxtboxEncrypt";
            this.richtxtboxEncrypt.Size = new System.Drawing.Size(287, 254);
            this.richtxtboxEncrypt.TabIndex = 27;
            this.richtxtboxEncrypt.Text = "";
            // 
            // richTtxtboxDecrypt
            // 
            this.richTtxtboxDecrypt.Location = new System.Drawing.Point(370, 142);
            this.richTtxtboxDecrypt.Name = "richTtxtboxDecrypt";
            this.richTtxtboxDecrypt.ReadOnly = true;
            this.richTtxtboxDecrypt.Size = new System.Drawing.Size(287, 254);
            this.richTtxtboxDecrypt.TabIndex = 28;
            this.richTtxtboxDecrypt.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.действияСТекстомToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click_1);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // действияСТекстомToolStripMenuItem
            // 
            this.действияСТекстомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зашифроватьToolStripMenuItem,
            this.расшифроватьToolStripMenuItem});
            this.действияСТекстомToolStripMenuItem.Name = "действияСТекстомToolStripMenuItem";
            this.действияСТекстомToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.действияСТекстомToolStripMenuItem.Text = "Действия с текстом";
            // 
            // зашифроватьToolStripMenuItem
            // 
            this.зашифроватьToolStripMenuItem.Name = "зашифроватьToolStripMenuItem";
            this.зашифроватьToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.зашифроватьToolStripMenuItem.Text = "Зашифровать";
            this.зашифроватьToolStripMenuItem.Click += new System.EventHandler(this.ЗашифроватьToolStripMenuItem_Click);
            // 
            // расшифроватьToolStripMenuItem
            // 
            this.расшифроватьToolStripMenuItem.Name = "расшифроватьToolStripMenuItem";
            this.расшифроватьToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.расшифроватьToolStripMenuItem.Text = "Расшифровать";
            this.расшифроватьToolStripMenuItem.Click += new System.EventHandler(this.расшифроватьToolStripMenuItem_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Выходные данные";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Files | *.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "saveFileDialog1";
            this.saveFileDialog1.Filter = "Text Files | *.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTtxtboxDecrypt);
            this.Controls.Add(this.richtxtboxEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxKeyWordEncrypt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(723, 464);
            this.MinimumSize = new System.Drawing.Size(723, 464);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Полиалфавитный шифр";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxKeyWordEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richtxtboxEncrypt;
        private System.Windows.Forms.RichTextBox richTtxtboxDecrypt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияСТекстомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расшифроватьToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

