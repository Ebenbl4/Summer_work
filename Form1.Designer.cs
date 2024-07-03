namespace Practica1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBoxRazm = new System.Windows.Forms.TextBox();
            this.label_Razm = new System.Windows.Forms.Label();
            this.label_Range = new System.Windows.Forms.Label();
            this.label_MinVol = new System.Windows.Forms.Label();
            this.label_MaxVol = new System.Windows.Forms.Label();
            this.TextBoxMinVol = new System.Windows.Forms.TextBox();
            this.TextBoxMaxVol = new System.Windows.Forms.TextBox();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxRazm
            // 
            this.TextBoxRazm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxRazm.Location = new System.Drawing.Point(27, 63);
            this.TextBoxRazm.Name = "TextBoxRazm";
            this.TextBoxRazm.Size = new System.Drawing.Size(109, 21);
            this.TextBoxRazm.TabIndex = 0;
            this.TextBoxRazm.TextChanged += new System.EventHandler(this.TextBoxRazm_TextChanged);
            // 
            // label_Razm
            // 
            this.label_Razm.AutoSize = true;
            this.label_Razm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Razm.Location = new System.Drawing.Point(24, 31);
            this.label_Razm.Name = "label_Razm";
            this.label_Razm.Size = new System.Drawing.Size(149, 14);
            this.label_Razm.TabIndex = 1;
            this.label_Razm.Text = "Размерность массива:";
            // 
            // label_Range
            // 
            this.label_Range.AutoSize = true;
            this.label_Range.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Range.Location = new System.Drawing.Point(24, 109);
            this.label_Range.Name = "label_Range";
            this.label_Range.Size = new System.Drawing.Size(214, 14);
            this.label_Range.TabIndex = 2;
            this.label_Range.Text = "Диапазон значений элементов:";
            // 
            // label_MinVol
            // 
            this.label_MinVol.AutoSize = true;
            this.label_MinVol.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_MinVol.Location = new System.Drawing.Point(24, 141);
            this.label_MinVol.Name = "label_MinVol";
            this.label_MinVol.Size = new System.Drawing.Size(22, 14);
            this.label_MinVol.TabIndex = 3;
            this.label_MinVol.Text = "от";
            // 
            // label_MaxVol
            // 
            this.label_MaxVol.AutoSize = true;
            this.label_MaxVol.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_MaxVol.Location = new System.Drawing.Point(24, 178);
            this.label_MaxVol.Name = "label_MaxVol";
            this.label_MaxVol.Size = new System.Drawing.Size(23, 14);
            this.label_MaxVol.TabIndex = 4;
            this.label_MaxVol.Text = "до";
            // 
            // TextBoxMinVol
            // 
            this.TextBoxMinVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMinVol.Location = new System.Drawing.Point(61, 141);
            this.TextBoxMinVol.Name = "TextBoxMinVol";
            this.TextBoxMinVol.Size = new System.Drawing.Size(75, 21);
            this.TextBoxMinVol.TabIndex = 5;
            this.TextBoxMinVol.TextChanged += new System.EventHandler(this.TextBoxMinVol_TextChanged);
            // 
            // TextBoxMaxVol
            // 
            this.TextBoxMaxVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMaxVol.Location = new System.Drawing.Point(61, 174);
            this.TextBoxMaxVol.Name = "TextBoxMaxVol";
            this.TextBoxMaxVol.Size = new System.Drawing.Size(75, 21);
            this.TextBoxMaxVol.TabIndex = 6;
            this.TextBoxMaxVol.TextChanged += new System.EventHandler(this.TextBoxMaxVol_TextChanged);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSort.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSort.Location = new System.Drawing.Point(27, 222);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(109, 27);
            this.ButtonSort.TabIndex = 7;
            this.ButtonSort.Text = "Сортировать";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(252, 285);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.TextBoxMaxVol);
            this.Controls.Add(this.TextBoxMinVol);
            this.Controls.Add(this.label_MaxVol);
            this.Controls.Add(this.label_MinVol);
            this.Controls.Add(this.label_Range);
            this.Controls.Add(this.label_Razm);
            this.Controls.Add(this.TextBoxRazm);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Massive sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxRazm;
        private System.Windows.Forms.Label label_Razm;
        private System.Windows.Forms.Label label_Range;
        private System.Windows.Forms.Label label_MinVol;
        private System.Windows.Forms.Label label_MaxVol;
        private System.Windows.Forms.TextBox TextBoxMinVol;
        private System.Windows.Forms.TextBox TextBoxMaxVol;
        private System.Windows.Forms.Button ButtonSort;
    }
}

