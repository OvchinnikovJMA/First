namespace Проект
{
    partial class Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondButton = new System.Windows.Forms.Button();
            this.SecondOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FirstOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Start = new System.Windows.Forms.Button();
            this.FirstText = new System.Windows.Forms.RichTextBox();
            this.SecondText = new System.Windows.Forms.RichTextBox();
            this.FirstButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первый файл";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(447, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Второй файл";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // SecondButton
            // 
            this.SecondButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondButton.Location = new System.Drawing.Point(430, 274);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(125, 47);
            this.SecondButton.TabIndex = 5;
            this.SecondButton.Text = "Открыть второй файл";
            this.SecondButton.UseVisualStyleBackColor = true;
            // 
            // SecondOpenFileDialog
            // 
            this.SecondOpenFileDialog.FileName = "SecondOpenFileDialog";
            // 
            // FirstOpenFileDialog
            // 
            this.FirstOpenFileDialog.FileName = "FirstOpenFileDialog";
            // 
            // Start
            // 
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(240, 243);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(155, 66);
            this.Start.TabIndex = 6;
            this.Start.Text = "Начать сравнение";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // FirstText
            // 
            this.FirstText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstText.Location = new System.Drawing.Point(0, 0);
            this.FirstText.Name = "FirstText";
            this.FirstText.ReadOnly = true;
            this.FirstText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.FirstText.Size = new System.Drawing.Size(292, 226);
            this.FirstText.TabIndex = 7;
            this.FirstText.Text = "";
            this.FirstText.TextChanged += new System.EventHandler(this.FirstText_TextChanged);
            // 
            // SecondText
            // 
            this.SecondText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SecondText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondText.Location = new System.Drawing.Point(346, -1);
            this.SecondText.Name = "SecondText";
            this.SecondText.ReadOnly = true;
            this.SecondText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.SecondText.Size = new System.Drawing.Size(294, 226);
            this.SecondText.TabIndex = 8;
            this.SecondText.Text = "";
            this.SecondText.TextChanged += new System.EventHandler(this.SecondText_TextChanged);
            // 
            // FirstButton
            // 
            this.FirstButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstButton.Location = new System.Drawing.Point(79, 274);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(118, 47);
            this.FirstButton.TabIndex = 9;
            this.FirstButton.Text = "Открыть первый файл";
            this.FirstButton.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(639, 361);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.SecondText);
            this.Controls.Add(this.FirstText);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.SecondButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(655, 400);
            this.MinimumSize = new System.Drawing.Size(655, 400);
            this.Name = "Form";
            this.Text = "Сравнение текстовых файлов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SecondButton;
        private System.Windows.Forms.OpenFileDialog SecondOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog FirstOpenFileDialog;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RichTextBox FirstText;
        private System.Windows.Forms.RichTextBox SecondText;
        private System.Windows.Forms.Button FirstButton;
    }
}

