namespace HM.ControleUsuarios
{
    partial class CU_Registro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtNumeroCelular = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.ComboBox();
            this.txtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegistrarQuarto = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCama = new System.Windows.Forms.ComboBox();
            this.txtTipoQuarto = new System.Windows.Forms.ComboBox();
            this.meuhotelDataSet = new HM.meuhotelDataSet();
            this.meuhotelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartosTableAdapter = new HM.meuhotelDataSetTableAdapters.quartosTableAdapter();
            this.quartosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNumeroQuarto = new System.Windows.Forms.ComboBox();
            this.quartosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.meuhotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meuhotelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(27, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(187, 26);
            this.txtNome.TabIndex = 0;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNacionalidade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidade.Location = new System.Drawing.Point(27, 292);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(187, 26);
            this.txtNacionalidade.TabIndex = 2;
            // 
            // txtNumeroCelular
            // 
            this.txtNumeroCelular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroCelular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCelular.Location = new System.Drawing.Point(27, 207);
            this.txtNumeroCelular.Name = "txtNumeroCelular";
            this.txtNumeroCelular.Size = new System.Drawing.Size(187, 26);
            this.txtNumeroCelular.TabIndex = 6;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(23, 95);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(47, 19);
            this.Nome.TabIndex = 9;
            this.Nome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Número Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gênero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data Nascimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nacionalidade";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.Location = new System.Drawing.Point(54, 27);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(80, 22);
            this.Registro.TabIndex = 17;
            this.Registro.Text = "Registro";
            // 
            // txtGenero
            // 
            this.txtGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGenero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.FormattingEnabled = true;
            this.txtGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.txtGenero.Location = new System.Drawing.Point(27, 367);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(187, 27);
            this.txtGenero.TabIndex = 18;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDataNasc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNasc.Location = new System.Drawing.Point(27, 458);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(277, 26);
            this.txtDataNasc.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Preço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tipo de Quarto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(487, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Número do Quarto";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.CalendarForeColor = System.Drawing.Color.Orange;
            this.txtCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCheckIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckIn.Location = new System.Drawing.Point(491, 458);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(277, 26);
            this.txtCheckIn.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(487, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "Check-In";
            // 
            // btnRegistrarQuarto
            // 
            this.btnRegistrarQuarto.BackColor = System.Drawing.Color.Green;
            this.btnRegistrarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarQuarto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarQuarto.Location = new System.Drawing.Point(491, 502);
            this.btnRegistrarQuarto.Name = "btnRegistrarQuarto";
            this.btnRegistrarQuarto.Size = new System.Drawing.Size(204, 34);
            this.btnRegistrarQuarto.TabIndex = 36;
            this.btnRegistrarQuarto.Text = "Registrar Quarto";
            this.btnRegistrarQuarto.UseVisualStyleBackColor = false;
            // 
            // txtPreco
            // 
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPreco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(491, 368);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(187, 26);
            this.txtPreco.TabIndex = 37;
            // 
            // txtCama
            // 
            this.txtCama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCama.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCama.FormattingEnabled = true;
            this.txtCama.Items.AddRange(new object[] {
            "Solteiro",
            "Dupla",
            "Tripla",
            "Casal"});
            this.txtCama.Location = new System.Drawing.Point(491, 292);
            this.txtCama.Name = "txtCama";
            this.txtCama.Size = new System.Drawing.Size(187, 27);
            this.txtCama.TabIndex = 39;
            this.txtCama.SelectedIndexChanged += new System.EventHandler(this.txtCama_SelectedIndexChanged);
            // 
            // txtTipoQuarto
            // 
            this.txtTipoQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTipoQuarto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoQuarto.FormattingEnabled = true;
            this.txtTipoQuarto.Items.AddRange(new object[] {
            "Quarto Individual",
            "Quarto Duplo",
            "Quarto Casal"});
            this.txtTipoQuarto.Location = new System.Drawing.Point(491, 207);
            this.txtTipoQuarto.Name = "txtTipoQuarto";
            this.txtTipoQuarto.Size = new System.Drawing.Size(187, 27);
            this.txtTipoQuarto.TabIndex = 40;
            this.txtTipoQuarto.SelectedIndexChanged += new System.EventHandler(this.txtTipoQuarto_SelectedIndexChanged);
            // 
            // meuhotelDataSet
            // 
            this.meuhotelDataSet.DataSetName = "meuhotelDataSet";
            this.meuhotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meuhotelDataSetBindingSource
            // 
            this.meuhotelDataSetBindingSource.DataSource = this.meuhotelDataSet;
            this.meuhotelDataSetBindingSource.Position = 0;
            // 
            // quartosBindingSource
            // 
            this.quartosBindingSource.DataMember = "quartos";
            this.quartosBindingSource.DataSource = this.meuhotelDataSetBindingSource;
            // 
            // quartosTableAdapter
            // 
            this.quartosTableAdapter.ClearBeforeFill = true;
            // 
            // quartosBindingSource1
            // 
            this.quartosBindingSource1.DataMember = "quartos";
            this.quartosBindingSource1.DataSource = this.meuhotelDataSetBindingSource;
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroQuarto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroQuarto.FormattingEnabled = true;
            this.txtNumeroQuarto.Location = new System.Drawing.Point(491, 116);
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.Size = new System.Drawing.Size(187, 27);
            this.txtNumeroQuarto.TabIndex = 41;
            this.txtNumeroQuarto.SelectedIndexChanged += new System.EventHandler(this.txtNumeroQuarto_SelectedIndexChanged);
            // 
            // quartosBindingSource2
            // 
            this.quartosBindingSource2.DataMember = "quartos";
            this.quartosBindingSource2.DataSource = this.meuhotelDataSetBindingSource;
            // 
            // CU_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtNumeroQuarto);
            this.Controls.Add(this.txtTipoQuarto);
            this.Controls.Add(this.txtCama);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnRegistrarQuarto);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtNumeroCelular);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.txtNome);
            this.Name = "CU_Registro";
            this.Size = new System.Drawing.Size(1297, 593);
            this.Load += new System.EventHandler(this.CU_Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meuhotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meuhotelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtNumeroCelular;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.ComboBox txtGenero;
        private System.Windows.Forms.DateTimePicker txtDataNasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtCheckIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegistrarQuarto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ComboBox txtCama;
        private System.Windows.Forms.ComboBox txtTipoQuarto;
        private System.Windows.Forms.BindingSource quartosBindingSource1;
        private System.Windows.Forms.BindingSource meuhotelDataSetBindingSource;
        private meuhotelDataSet meuhotelDataSet;
        private System.Windows.Forms.BindingSource quartosBindingSource;
        private meuhotelDataSetTableAdapters.quartosTableAdapter quartosTableAdapter;
        private System.Windows.Forms.ComboBox txtNumeroQuarto;
        private System.Windows.Forms.BindingSource quartosBindingSource2;
    }
}
