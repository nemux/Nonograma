namespace nonoGrama
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonGenerateNanogram = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownFilas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumnas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddValues = new System.Windows.Forms.Button();
            this.textBoxValues = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnas)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(43, 41);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownRows.TabIndex = 0;
            this.numericUpDownRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownColumns
            // 
            this.numericUpDownColumns.Location = new System.Drawing.Point(118, 41);
            this.numericUpDownColumns.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColumns.Name = "numericUpDownColumns";
            this.numericUpDownColumns.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownColumns.TabIndex = 1;
            this.numericUpDownColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columnas:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 117);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(514, 234);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // buttonGenerateNanogram
            // 
            this.buttonGenerateNanogram.Location = new System.Drawing.Point(367, 13);
            this.buttonGenerateNanogram.Name = "buttonGenerateNanogram";
            this.buttonGenerateNanogram.Size = new System.Drawing.Size(144, 37);
            this.buttonGenerateNanogram.TabIndex = 5;
            this.buttonGenerateNanogram.Text = "Generar Nonograma";
            this.buttonGenerateNanogram.UseVisualStyleBackColor = true;
            this.buttonGenerateNanogram.Click += new System.EventHandler(this.drawGrid);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valores (x,y):";
            // 
            // numericUpDownFilas
            // 
            this.numericUpDownFilas.Location = new System.Drawing.Point(180, 41);
            this.numericUpDownFilas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownFilas.Name = "numericUpDownFilas";
            this.numericUpDownFilas.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownFilas.TabIndex = 7;
            // 
            // numericUpDownColumnas
            // 
            this.numericUpDownColumnas.Location = new System.Drawing.Point(264, 41);
            this.numericUpDownColumnas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownColumnas.Name = "numericUpDownColumnas";
            this.numericUpDownColumnas.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownColumnas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor Columna:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Fila:";
            // 
            // buttonAddValues
            // 
            this.buttonAddValues.Location = new System.Drawing.Point(192, 63);
            this.buttonAddValues.Name = "buttonAddValues";
            this.buttonAddValues.Size = new System.Drawing.Size(111, 23);
            this.buttonAddValues.TabIndex = 11;
            this.buttonAddValues.Text = "Agregar valores";
            this.buttonAddValues.UseVisualStyleBackColor = true;
            this.buttonAddValues.Click += new System.EventHandler(this.buttonAddValues_Click);
            // 
            // textBoxValues
            // 
            this.textBoxValues.Location = new System.Drawing.Point(95, 91);
            this.textBoxValues.Name = "textBoxValues";
            this.textBoxValues.ReadOnly = true;
            this.textBoxValues.Size = new System.Drawing.Size(208, 20);
            this.textBoxValues.TabIndex = 12;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(309, 87);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 13;
            this.buttonLimpiar.Text = "Borrar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 363);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxValues);
            this.Controls.Add(this.buttonAddValues);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownColumnas);
            this.Controls.Add(this.numericUpDownFilas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGenerateNanogram);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownColumns);
            this.Controls.Add(this.numericUpDownRows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonGenerateNanogram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownFilas;
        private System.Windows.Forms.NumericUpDown numericUpDownColumnas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddValues;
        private System.Windows.Forms.TextBox textBoxValues;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

