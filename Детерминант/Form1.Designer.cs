namespace Детерминант
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
            this.matrix = new System.Windows.Forms.DataGridView();
            this.SizeX = new System.Windows.Forms.TextBox();
            this.rand = new System.Windows.Forms.Button();
            this.SizeY = new System.Windows.Forms.TextBox();
            this.сolumns = new System.Windows.Forms.Label();
            this.lines = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // matrix
            // 
            this.matrix.AllowUserToAddRows = false;
            this.matrix.AllowUserToDeleteRows = false;
            this.matrix.AllowUserToResizeColumns = false;
            this.matrix.AllowUserToResizeRows = false;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.Location = new System.Drawing.Point(87, 123);
            this.matrix.Name = "matrix";
            this.matrix.RowHeadersWidth = 50;
            this.matrix.Size = new System.Drawing.Size(526, 199);
            this.matrix.TabIndex = 0;
            // 
            // SizeX
            // 
            this.SizeX.Location = new System.Drawing.Point(87, 28);
            this.SizeX.Name = "SizeX";
            this.SizeX.Size = new System.Drawing.Size(112, 20);
            this.SizeX.TabIndex = 1;
            this.SizeX.TextChanged += new System.EventHandler(this.SizeX_TextChanged);
            // 
            // rand
            // 
            this.rand.Location = new System.Drawing.Point(395, 51);
            this.rand.Name = "rand";
            this.rand.Size = new System.Drawing.Size(95, 24);
            this.rand.TabIndex = 2;
            this.rand.Text = "сгенерировать";
            this.rand.UseVisualStyleBackColor = true;
            this.rand.Click += new System.EventHandler(this.rand_Click);
            // 
            // SizeY
            // 
            this.SizeY.Location = new System.Drawing.Point(87, 76);
            this.SizeY.Name = "SizeY";
            this.SizeY.Size = new System.Drawing.Size(112, 20);
            this.SizeY.TabIndex = 3;
            // 
            // сolumns
            // 
            this.сolumns.AutoSize = true;
            this.сolumns.Location = new System.Drawing.Point(221, 31);
            this.сolumns.Name = "сolumns";
            this.сolumns.Size = new System.Drawing.Size(78, 13);
            this.сolumns.TabIndex = 4;
            this.сolumns.Text = "к-во столбцов";
            this.сolumns.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.сolumns.Click += new System.EventHandler(this.label1_Click);
            // 
            // lines
            // 
            this.lines.AutoSize = true;
            this.lines.Location = new System.Drawing.Point(221, 79);
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(60, 13);
            this.lines.TabIndex = 5;
            this.lines.Text = "к-во строк";
            this.lines.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lines);
            this.Controls.Add(this.сolumns);
            this.Controls.Add(this.SizeY);
            this.Controls.Add(this.rand);
            this.Controls.Add(this.SizeX);
            this.Controls.Add(this.matrix);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.TextBox SizeX;
        private System.Windows.Forms.Button rand;
        private System.Windows.Forms.TextBox SizeY;
        private System.Windows.Forms.Label сolumns;
        private System.Windows.Forms.Label lines;
    }
}

