
namespace QRCode
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
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btRaspoznat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(12, 12);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(170, 158);
            this.pbQRCode.TabIndex = 0;
            this.pbQRCode.TabStop = false;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(11, 232);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(171, 23);
            this.btCreate.TabIndex = 1;
            this.btCreate.Text = "Создать QR код";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(11, 270);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(171, 23);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Сохранить QR код";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(12, 308);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(170, 23);
            this.btLoad.TabIndex = 3;
            this.btLoad.Text = "Загрузить QR код";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btRaspoznat
            // 
            this.btRaspoznat.Location = new System.Drawing.Point(13, 347);
            this.btRaspoznat.Name = "btRaspoznat";
            this.btRaspoznat.Size = new System.Drawing.Size(169, 23);
            this.btRaspoznat.TabIndex = 4;
            this.btRaspoznat.Text = "Распознать QR код";
            this.btRaspoznat.UseVisualStyleBackColor = true;
            this.btRaspoznat.Click += new System.EventHandler(this.btRaspoznat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите текст";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(11, 198);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(171, 20);
            this.tbContent.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 381);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRaspoznat);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.pbQRCode);
            this.Name = "Form1";
            this.Text = "QRCode";
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btRaspoznat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContent;
    }
}

