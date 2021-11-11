
namespace PresentacionGUI
{
    partial class FrmConsultaPersona
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
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.personaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pulsacionG01DataSet = new PresentacionGUI.PulsacionG01DataSet();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grupo02DataSet = new PresentacionGUI.Grupo02DataSet();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new PresentacionGUI.Grupo02DataSetTableAdapters.PersonaTableAdapter();
            this.personaTableAdapter1 = new PresentacionGUI.PulsacionG01DataSetTableAdapters.PersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulsacionG01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(83, 230);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.RowHeadersWidth = 102;
            this.dgvPersonas.RowTemplate.Height = 40;
            this.dgvPersonas.Size = new System.Drawing.Size(1975, 200);
            this.dgvPersonas.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(968, 81);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(266, 82);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DataSource = this.personaBindingSource1;
            this.cmbFiltro.DisplayMember = "Sexo";
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(504, 67);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(275, 39);
            this.cmbFiltro.TabIndex = 2;
            // 
            // personaBindingSource1
            // 
            this.personaBindingSource1.DataMember = "Persona";
            this.personaBindingSource1.DataSource = this.pulsacionG01DataSet;
            // 
            // pulsacionG01DataSet
            // 
            this.pulsacionG01DataSet.DataSetName = "PulsacionG01DataSet";
            this.pulsacionG01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(504, 142);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 38);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro Por Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtro por Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 965);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Conteo por Hombres";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 965);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 38);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 1032);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Conteo por Mujeres";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(385, 1032);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 38);
            this.textBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 1095);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Conteo Total";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(385, 1095);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(275, 38);
            this.textBox3.TabIndex = 11;
            // 
            // grupo02DataSet
            // 
            this.grupo02DataSet.DataSetName = "Grupo02DataSet";
            this.grupo02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.grupo02DataSet;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // personaTableAdapter1
            // 
            this.personaTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmConsultaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2434, 1230);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvPersonas);
            this.Name = "FrmConsultaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Personas";
            this.Load += new System.EventHandler(this.FrmConsultaPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulsacionG01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private Grupo02DataSet grupo02DataSet;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private Grupo02DataSetTableAdapters.PersonaTableAdapter personaTableAdapter;
        private PulsacionG01DataSet pulsacionG01DataSet;
        private System.Windows.Forms.BindingSource personaBindingSource1;
        private PulsacionG01DataSetTableAdapters.PersonaTableAdapter personaTableAdapter1;
    }
}