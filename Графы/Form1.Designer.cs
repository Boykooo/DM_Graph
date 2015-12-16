namespace Графы
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Depth = new System.Windows.Forms.RadioButton();
            this.Breadth = new System.Windows.Forms.RadioButton();
            this.StepButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.Prim = new System.Windows.Forms.RadioButton();
            this.Kruskal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 421);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(596, 386);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(109, 28);
            this.ClearButton.TabIndex = 24;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Depth
            // 
            this.Depth.AutoSize = true;
            this.Depth.Checked = true;
            this.Depth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Depth.Location = new System.Drawing.Point(582, 12);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(94, 23);
            this.Depth.TabIndex = 25;
            this.Depth.TabStop = true;
            this.Depth.Text = "В глубину";
            this.Depth.UseVisualStyleBackColor = true;
            // 
            // Breadth
            // 
            this.Breadth.AutoSize = true;
            this.Breadth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Breadth.Location = new System.Drawing.Point(582, 41);
            this.Breadth.Name = "Breadth";
            this.Breadth.Size = new System.Drawing.Size(94, 23);
            this.Breadth.TabIndex = 26;
            this.Breadth.TabStop = true;
            this.Breadth.Text = "В ширину";
            this.Breadth.UseVisualStyleBackColor = true;
            // 
            // StepButton
            // 
            this.StepButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepButton.Location = new System.Drawing.Point(583, 128);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(122, 28);
            this.StepButton.TabIndex = 27;
            this.StepButton.Text = "Step";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.Location = new System.Drawing.Point(592, 159);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(30, 25);
            this.Status.TabIndex = 28;
            this.Status.Text = "0;";
            // 
            // Prim
            // 
            this.Prim.AutoSize = true;
            this.Prim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prim.Location = new System.Drawing.Point(582, 70);
            this.Prim.Name = "Prim";
            this.Prim.Size = new System.Drawing.Size(120, 23);
            this.Prim.TabIndex = 29;
            this.Prim.TabStop = true;
            this.Prim.Text = "Метод Прима";
            this.Prim.UseVisualStyleBackColor = true;
            // 
            // Kruskal
            // 
            this.Kruskal.AutoSize = true;
            this.Kruskal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kruskal.Location = new System.Drawing.Point(581, 99);
            this.Kruskal.Name = "Kruskal";
            this.Kruskal.Size = new System.Drawing.Size(137, 23);
            this.Kruskal.TabIndex = 30;
            this.Kruskal.TabStop = true;
            this.Kruskal.Text = "Метод Крускала";
            this.Kruskal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 426);
            this.Controls.Add(this.Kruskal);
            this.Controls.Add(this.Prim);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.StepButton);
            this.Controls.Add(this.Breadth);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RadioButton Depth;
        private System.Windows.Forms.RadioButton Breadth;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.RadioButton Prim;
        private System.Windows.Forms.RadioButton Kruskal;
    }
}

