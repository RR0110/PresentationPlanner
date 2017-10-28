namespace PresentationPlanner
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPresentationSource = new System.Windows.Forms.Button();
            this.textBoxPresentationSource = new System.Windows.Forms.TextBox();
            this.labelPresentationSource = new System.Windows.Forms.Label();
            this.btnStartPresentation = new System.Windows.Forms.Button();
            this.labelPowerPointSource = new System.Windows.Forms.Label();
            this.textBoxPowerPointSource = new System.Windows.Forms.TextBox();
            this.btnPowerPointSource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPresentationSource
            // 
            this.btnPresentationSource.Location = new System.Drawing.Point(471, 36);
            this.btnPresentationSource.Name = "btnPresentationSource";
            this.btnPresentationSource.Size = new System.Drawing.Size(75, 23);
            this.btnPresentationSource.TabIndex = 0;
            this.btnPresentationSource.Text = "Обзор";
            this.btnPresentationSource.UseVisualStyleBackColor = true;
            this.btnPresentationSource.Click += new System.EventHandler(this.btnPresentationSource_Click);
            // 
            // textBoxPresentationSource
            // 
            this.textBoxPresentationSource.Location = new System.Drawing.Point(187, 38);
            this.textBoxPresentationSource.Name = "textBoxPresentationSource";
            this.textBoxPresentationSource.Size = new System.Drawing.Size(278, 20);
            this.textBoxPresentationSource.TabIndex = 1;
            this.textBoxPresentationSource.Text = "C:\\Users\\a.smirnov93\\Desktop\\Полубиченко";
            this.textBoxPresentationSource.TextChanged += new System.EventHandler(this.textBoxPresentationSource_TextChanged);
            // 
            // labelPresentationSource
            // 
            this.labelPresentationSource.AutoSize = true;
            this.labelPresentationSource.Location = new System.Drawing.Point(14, 41);
            this.labelPresentationSource.Name = "labelPresentationSource";
            this.labelPresentationSource.Size = new System.Drawing.Size(164, 13);
            this.labelPresentationSource.TabIndex = 2;
            this.labelPresentationSource.Text = "Путь к папке с презентациями";
            // 
            // btnStartPresentation
            // 
            this.btnStartPresentation.Location = new System.Drawing.Point(242, 64);
            this.btnStartPresentation.Name = "btnStartPresentation";
            this.btnStartPresentation.Size = new System.Drawing.Size(75, 23);
            this.btnStartPresentation.TabIndex = 3;
            this.btnStartPresentation.Text = "Запустить";
            this.btnStartPresentation.UseVisualStyleBackColor = true;
            this.btnStartPresentation.Click += new System.EventHandler(this.btnStartPresentation_Click);
            // 
            // labelPowerPointSource
            // 
            this.labelPowerPointSource.AutoSize = true;
            this.labelPowerPointSource.Location = new System.Drawing.Point(14, 15);
            this.labelPowerPointSource.Name = "labelPowerPointSource";
            this.labelPowerPointSource.Size = new System.Drawing.Size(130, 13);
            this.labelPowerPointSource.TabIndex = 6;
            this.labelPowerPointSource.Text = "Путь к POWERPNT.EXE";
            this.labelPowerPointSource.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPowerPointSource
            // 
            this.textBoxPowerPointSource.Location = new System.Drawing.Point(187, 12);
            this.textBoxPowerPointSource.Name = "textBoxPowerPointSource";
            this.textBoxPowerPointSource.Size = new System.Drawing.Size(278, 20);
            this.textBoxPowerPointSource.TabIndex = 5;
            this.textBoxPowerPointSource.Text = "C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\POWERPNT.EXE";
            this.textBoxPowerPointSource.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPowerPointSource
            // 
            this.btnPowerPointSource.Location = new System.Drawing.Point(471, 10);
            this.btnPowerPointSource.Name = "btnPowerPointSource";
            this.btnPowerPointSource.Size = new System.Drawing.Size(75, 23);
            this.btnPowerPointSource.TabIndex = 4;
            this.btnPowerPointSource.Text = "Обзор";
            this.btnPowerPointSource.UseVisualStyleBackColor = true;
            this.btnPowerPointSource.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 92);
            this.Controls.Add(this.labelPowerPointSource);
            this.Controls.Add(this.textBoxPowerPointSource);
            this.Controls.Add(this.btnPowerPointSource);
            this.Controls.Add(this.btnStartPresentation);
            this.Controls.Add(this.labelPresentationSource);
            this.Controls.Add(this.textBoxPresentationSource);
            this.Controls.Add(this.btnPresentationSource);
            this.Name = "MainForm";
            this.Text = "Планировщик презентаций";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPresentationSource;
        private System.Windows.Forms.TextBox textBoxPresentationSource;
        private System.Windows.Forms.Label labelPresentationSource;
        private System.Windows.Forms.Button btnStartPresentation;
        private System.Windows.Forms.Label labelPowerPointSource;
        private System.Windows.Forms.TextBox textBoxPowerPointSource;
        private System.Windows.Forms.Button btnPowerPointSource;
    }
}

