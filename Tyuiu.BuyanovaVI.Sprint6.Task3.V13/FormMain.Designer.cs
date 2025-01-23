namespace Tyuiu.BuyanovaVI.Sprint6.Task3.V13
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCondition_BVI = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_BVI = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_BVI = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_BVI = new System.Windows.Forms.GroupBox();
            this.textBoxResult_BVI = new System.Windows.Forms.TextBox();
            this.buttonHelp_BVI = new System.Windows.Forms.Button();
            this.buttonToDo_BVI = new System.Windows.Forms.Button();
            this.groupBoxCondition_BVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BVI)).BeginInit();
            this.groupBoxResult_BVI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_BVI
            // 
            this.groupBoxCondition_BVI.Controls.Add(this.textBoxCondition_BVI);
            this.groupBoxCondition_BVI.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_BVI.Name = "groupBoxCondition_BVI";
            this.groupBoxCondition_BVI.Size = new System.Drawing.Size(274, 338);
            this.groupBoxCondition_BVI.TabIndex = 0;
            this.groupBoxCondition_BVI.TabStop = false;
            this.groupBoxCondition_BVI.Text = "Условие";
            // 
            // textBoxCondition_BVI
            // 
            this.textBoxCondition_BVI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_BVI.Location = new System.Drawing.Point(7, 22);
            this.textBoxCondition_BVI.Multiline = true;
            this.textBoxCondition_BVI.Name = "textBoxCondition_BVI";
            this.textBoxCondition_BVI.ReadOnly = true;
            this.textBoxCondition_BVI.Size = new System.Drawing.Size(273, 187);
            this.textBoxCondition_BVI.TabIndex = 0;
            this.textBoxCondition_BVI.Text = "Дана матрица 5 на 5\r\n -7   34  -2  25  5\r\n-16 -12  30 -3 17\r\n  3  -15  12  5  -5\r" +
    "\n 17   22 -3  32 -11\r\n  9    28  1  -9  -2\r\nВыполнить сортировку по возрастанию " +
    "\r\nво втором столбце  ";
            // 
            // dataGridViewMatrix_BVI
            // 
            this.dataGridViewMatrix_BVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_BVI.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_BVI.Location = new System.Drawing.Point(27, 52);
            this.dataGridViewMatrix_BVI.Name = "dataGridViewMatrix_BVI";
            this.dataGridViewMatrix_BVI.ReadOnly = true;
            this.dataGridViewMatrix_BVI.RowHeadersVisible = false;
            this.dataGridViewMatrix_BVI.RowHeadersWidth = 51;
            this.dataGridViewMatrix_BVI.RowTemplate.Height = 24;
            this.dataGridViewMatrix_BVI.Size = new System.Drawing.Size(388, 357);
            this.dataGridViewMatrix_BVI.TabIndex = 1;
            // 
            // groupBoxResult_BVI
            // 
            this.groupBoxResult_BVI.Controls.Add(this.textBoxResult_BVI);
            this.groupBoxResult_BVI.Controls.Add(this.dataGridViewMatrix_BVI);
            this.groupBoxResult_BVI.Location = new System.Drawing.Point(300, 13);
            this.groupBoxResult_BVI.Name = "groupBoxResult_BVI";
            this.groupBoxResult_BVI.Size = new System.Drawing.Size(440, 425);
            this.groupBoxResult_BVI.TabIndex = 2;
            this.groupBoxResult_BVI.TabStop = false;
            this.groupBoxResult_BVI.Text = "Вывод данных";
            // 
            // textBoxResult_BVI
            // 
            this.textBoxResult_BVI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_BVI.Location = new System.Drawing.Point(27, 22);
            this.textBoxResult_BVI.Name = "textBoxResult_BVI";
            this.textBoxResult_BVI.ReadOnly = true;
            this.textBoxResult_BVI.Size = new System.Drawing.Size(133, 15);
            this.textBoxResult_BVI.TabIndex = 2;
            this.textBoxResult_BVI.Text = "Результат:";
            // 
            // buttonHelp_BVI
            // 
            this.buttonHelp_BVI.Location = new System.Drawing.Point(13, 358);
            this.buttonHelp_BVI.Name = "buttonHelp_BVI";
            this.buttonHelp_BVI.Size = new System.Drawing.Size(109, 80);
            this.buttonHelp_BVI.TabIndex = 3;
            this.buttonHelp_BVI.Text = "Справка";
            this.buttonHelp_BVI.UseVisualStyleBackColor = true;
            this.buttonHelp_BVI.Click += new System.EventHandler(this.buttonHelp_BVI_Click);
            // 
            // buttonToDo_BVI
            // 
            this.buttonToDo_BVI.Location = new System.Drawing.Point(128, 358);
            this.buttonToDo_BVI.Name = "buttonToDo_BVI";
            this.buttonToDo_BVI.Size = new System.Drawing.Size(159, 80);
            this.buttonToDo_BVI.TabIndex = 4;
            this.buttonToDo_BVI.Text = "Выполнить";
            this.buttonToDo_BVI.UseVisualStyleBackColor = true;
            this.buttonToDo_BVI.Click += new System.EventHandler(this.buttonToDo_BVI_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.buttonToDo_BVI);
            this.Controls.Add(this.buttonHelp_BVI);
            this.Controls.Add(this.groupBoxResult_BVI);
            this.Controls.Add(this.groupBoxCondition_BVI);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 13 | Буянова В.И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_BVI.ResumeLayout(false);
            this.groupBoxCondition_BVI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BVI)).EndInit();
            this.groupBoxResult_BVI.ResumeLayout(false);
            this.groupBoxResult_BVI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_BVI;
        private System.Windows.Forms.TextBox textBoxCondition_BVI;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_BVI;
        private System.Windows.Forms.GroupBox groupBoxResult_BVI;
        private System.Windows.Forms.TextBox textBoxResult_BVI;
        private System.Windows.Forms.Button buttonHelp_BVI;
        private System.Windows.Forms.Button buttonToDo_BVI;
    }

    }
}
