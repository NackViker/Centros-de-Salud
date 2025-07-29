namespace TurnosCDS
{
    partial class FormCrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cdsDataSet = new TurnosCDS.cdsDataSet();
            this.practicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicaTableAdapter = new TurnosCDS.cdsDataSetTableAdapters.PracticaTableAdapter();
            this.cdsDataSet1 = new TurnosCDS.cdsDataSet1();
            this.profesionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionalTableAdapter = new TurnosCDS.cdsDataSet1TableAdapters.ProfesionalTableAdapter();
            this.cdsDataSet2 = new TurnosCDS.cdsDataSet2();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new TurnosCDS.cdsDataSet2TableAdapters.RoomTableAdapter();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.cdsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profesional";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consultorio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Practica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Importe";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.practicaBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(217, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.profesionalBindingSource;
            this.comboBox2.DisplayMember = "Nombre";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(217, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 28);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.roomBindingSource;
            this.comboBox3.DisplayMember = "Nombre";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(217, 179);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(177, 28);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.ValueMember = "Id";
            // 
            // cdsDataSet
            // 
            this.cdsDataSet.DataSetName = "cdsDataSet";
            this.cdsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // practicaBindingSource
            // 
            this.practicaBindingSource.DataMember = "Practica";
            this.practicaBindingSource.DataSource = this.cdsDataSet;
            // 
            // practicaTableAdapter
            // 
            this.practicaTableAdapter.ClearBeforeFill = true;
            // 
            // cdsDataSet1
            // 
            this.cdsDataSet1.DataSetName = "cdsDataSet1";
            this.cdsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesionalBindingSource
            // 
            this.profesionalBindingSource.DataMember = "Profesional";
            this.profesionalBindingSource.DataSource = this.cdsDataSet1;
            // 
            // profesionalTableAdapter
            // 
            this.profesionalTableAdapter.ClearBeforeFill = true;
            // 
            // cdsDataSet2
            // 
            this.cdsDataSet2.DataSetName = "cdsDataSet2";
            this.cdsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.cdsDataSet2;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(217, 328);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // FormCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 896);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCrud";
            this.Text = "FormCrud";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cdsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private cdsDataSet cdsDataSet;
        private System.Windows.Forms.BindingSource practicaBindingSource;
        private cdsDataSetTableAdapters.PracticaTableAdapter practicaTableAdapter;
        private cdsDataSet1 cdsDataSet1;
        private System.Windows.Forms.BindingSource profesionalBindingSource;
        private cdsDataSet1TableAdapters.ProfesionalTableAdapter profesionalTableAdapter;
        private cdsDataSet2 cdsDataSet2;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private cdsDataSet2TableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}