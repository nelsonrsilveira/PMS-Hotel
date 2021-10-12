namespace HM
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.PainelSeletor = new System.Windows.Forms.Panel();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnDetalhesHospede = new System.Windows.Forms.Button();
            this.btnAdicionarQuarto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.CU_DetalhesHospede2 = new HM.ControleUsuarios.CU_DetalhesHospede();
            this.CU_Cancelar1 = new HM.ControleUsuarios.CU_Cancelar();
            this.cU_AddQuarto3 = new HM.ControleUsuarios.CU_AddQuarto();
            this.cU_Registro3 = new HM.ControleUsuarios.CU_Registro();
            this.cU_AddQuarto2 = new HM.ControleUsuarios.CU_AddQuarto();
            this.cU_Registro2 = new HM.ControleUsuarios.CU_Registro();
            this.CU_Funcionario1 = new HM.ControleUsuarios.CU_Funcionario();
            this.CU_DetalhesHospede1 = new HM.ControleUsuarios.CU_DetalhesHospede();
            this.CU_Checkout1 = new HM.ControleUsuarios.CU_Checkout();
            this.CU_Registro1 = new HM.ControleUsuarios.CU_Registro();
            this.CU_AddQuarto1 = new HM.ControleUsuarios.CU_AddQuarto();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.PainelSeletor);
            this.panel1.Controls.Add(this.btnFuncionario);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.btnDetalhesHospede);
            this.panel1.Controls.Add(this.btnAdicionarQuarto);
            this.panel1.Location = new System.Drawing.Point(33, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1498, 130);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1229, 23);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(236, 85);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar Hospedagem";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PainelSeletor
            // 
            this.PainelSeletor.BackColor = System.Drawing.Color.White;
            this.PainelSeletor.Location = new System.Drawing.Point(19, 23);
            this.PainelSeletor.Name = "PainelSeletor";
            this.PainelSeletor.Size = new System.Drawing.Size(236, 6);
            this.PainelSeletor.TabIndex = 16;
            this.PainelSeletor.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelSeletor_Paint);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Location = new System.Drawing.Point(987, 23);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(236, 85);
            this.btnFuncionario.TabIndex = 15;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(503, 23);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(236, 85);
            this.btnCheckOut.TabIndex = 14;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(261, 23);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(236, 85);
            this.btnRegistro.TabIndex = 13;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnDetalhesHospede
            // 
            this.btnDetalhesHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalhesHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhesHospede.Location = new System.Drawing.Point(745, 23);
            this.btnDetalhesHospede.Name = "btnDetalhesHospede";
            this.btnDetalhesHospede.Size = new System.Drawing.Size(236, 85);
            this.btnDetalhesHospede.TabIndex = 12;
            this.btnDetalhesHospede.Text = "Detalhes do Hóspede";
            this.btnDetalhesHospede.UseVisualStyleBackColor = true;
            this.btnDetalhesHospede.Click += new System.EventHandler(this.btnDetalhesHospede_Click);
            // 
            // btnAdicionarQuarto
            // 
            this.btnAdicionarQuarto.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.btnAdicionarQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarQuarto.Location = new System.Drawing.Point(19, 23);
            this.btnAdicionarQuarto.Name = "btnAdicionarQuarto";
            this.btnAdicionarQuarto.Size = new System.Drawing.Size(236, 85);
            this.btnAdicionarQuarto.TabIndex = 11;
            this.btnAdicionarQuarto.Text = "Adicionar Quarto";
            this.btnAdicionarQuarto.UseVisualStyleBackColor = true;
            this.btnAdicionarQuarto.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.CU_DetalhesHospede2);
            this.panel2.Controls.Add(this.CU_Cancelar1);
            this.panel2.Controls.Add(this.cU_AddQuarto3);
            this.panel2.Controls.Add(this.cU_Registro3);
            this.panel2.Controls.Add(this.cU_AddQuarto2);
            this.panel2.Controls.Add(this.cU_Registro2);
            this.panel2.Controls.Add(this.CU_Funcionario1);
            this.panel2.Controls.Add(this.CU_DetalhesHospede1);
            this.panel2.Controls.Add(this.CU_Checkout1);
            this.panel2.Controls.Add(this.CU_Registro1);
            this.panel2.Controls.Add(this.CU_AddQuarto1);
            this.panel2.Location = new System.Drawing.Point(20, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 593);
            this.panel2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(2, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(29, 27);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(2, 36);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // CU_DetalhesHospede2
            // 
            this.CU_DetalhesHospede2.BackColor = System.Drawing.Color.White;
            this.CU_DetalhesHospede2.Location = new System.Drawing.Point(0, 0);
            this.CU_DetalhesHospede2.Name = "CU_DetalhesHospede2";
            this.CU_DetalhesHospede2.Size = new System.Drawing.Size(1297, 593);
            this.CU_DetalhesHospede2.TabIndex = 10;
            // 
            // CU_Cancelar1
            // 
            this.CU_Cancelar1.BackColor = System.Drawing.Color.White;
            this.CU_Cancelar1.Location = new System.Drawing.Point(3, 3);
            this.CU_Cancelar1.Name = "CU_Cancelar1";
            this.CU_Cancelar1.Size = new System.Drawing.Size(1086, 626);
            this.CU_Cancelar1.TabIndex = 9;
            // 
            // cU_AddQuarto3
            // 
            this.cU_AddQuarto3.BackColor = System.Drawing.Color.White;
            this.cU_AddQuarto3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cU_AddQuarto3.Location = new System.Drawing.Point(3, 3);
            this.cU_AddQuarto3.Name = "cU_AddQuarto3";
            this.cU_AddQuarto3.Size = new System.Drawing.Size(1276, 593);
            this.cU_AddQuarto3.TabIndex = 8;
            this.cU_AddQuarto3.Load += new System.EventHandler(this.cU_AddQuarto3_Load);
            // 
            // cU_Registro3
            // 
            this.cU_Registro3.BackColor = System.Drawing.Color.White;
            this.cU_Registro3.Location = new System.Drawing.Point(0, 0);
            this.cU_Registro3.Name = "cU_Registro3";
            this.cU_Registro3.Size = new System.Drawing.Size(1353, 593);
            this.cU_Registro3.TabIndex = 7;
            // 
            // cU_AddQuarto2
            // 
            this.cU_AddQuarto2.BackColor = System.Drawing.Color.White;
            this.cU_AddQuarto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cU_AddQuarto2.Location = new System.Drawing.Point(-3, 0);
            this.cU_AddQuarto2.Name = "cU_AddQuarto2";
            this.cU_AddQuarto2.Size = new System.Drawing.Size(1297, 593);
            this.cU_AddQuarto2.TabIndex = 6;
            // 
            // cU_Registro2
            // 
            this.cU_Registro2.BackColor = System.Drawing.Color.White;
            this.cU_Registro2.Location = new System.Drawing.Point(0, 3);
            this.cU_Registro2.Name = "cU_Registro2";
            this.cU_Registro2.Size = new System.Drawing.Size(1000, 574);
            this.cU_Registro2.TabIndex = 5;
            // 
            // CU_Funcionario1
            // 
            this.CU_Funcionario1.BackColor = System.Drawing.Color.White;
            this.CU_Funcionario1.Location = new System.Drawing.Point(3, 3);
            this.CU_Funcionario1.Name = "CU_Funcionario1";
            this.CU_Funcionario1.Size = new System.Drawing.Size(1034, 626);
            this.CU_Funcionario1.TabIndex = 4;
            // 
            // CU_DetalhesHospede1
            // 
            this.CU_DetalhesHospede1.BackColor = System.Drawing.Color.White;
            this.CU_DetalhesHospede1.Location = new System.Drawing.Point(0, -30);
            this.CU_DetalhesHospede1.Name = "CU_DetalhesHospede1";
            this.CU_DetalhesHospede1.Size = new System.Drawing.Size(1034, 626);
            this.CU_DetalhesHospede1.TabIndex = 3;
            // 
            // CU_Checkout1
            // 
            this.CU_Checkout1.BackColor = System.Drawing.Color.White;
            this.CU_Checkout1.Location = new System.Drawing.Point(3, 3);
            this.CU_Checkout1.Name = "CU_Checkout1";
            this.CU_Checkout1.Size = new System.Drawing.Size(1000, 574);
            this.CU_Checkout1.TabIndex = 2;
            // 
            // CU_Registro1
            // 
            this.CU_Registro1.BackColor = System.Drawing.Color.White;
            this.CU_Registro1.Location = new System.Drawing.Point(0, 0);
            this.CU_Registro1.Name = "CU_Registro1";
            this.CU_Registro1.Size = new System.Drawing.Size(1034, 500);
            this.CU_Registro1.TabIndex = 1;
            this.CU_Registro1.Load += new System.EventHandler(this.CU_Registro1_Load);
            // 
            // CU_AddQuarto1
            // 
            this.CU_AddQuarto1.BackColor = System.Drawing.Color.White;
            this.CU_AddQuarto1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CU_AddQuarto1.Location = new System.Drawing.Point(0, 0);
            this.CU_AddQuarto1.Name = "CU_AddQuarto1";
            this.CU_AddQuarto1.Size = new System.Drawing.Size(1000, 553);
            this.CU_AddQuarto1.TabIndex = 0;
            this.CU_AddQuarto1.Load += new System.EventHandler(this.CU_AddQuarto1_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1620, 862);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionarQuarto;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnDetalhesHospede;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Panel PainelSeletor;
        private ControleUsuarios.CU_AddQuarto CU_AddQuarto1;
        private ControleUsuarios.CU_Registro CU_Registro1;
        private ControleUsuarios.CU_Checkout CU_Checkout1;
        private ControleUsuarios.CU_DetalhesHospede CU_DetalhesHospede1;
        private ControleUsuarios.CU_Funcionario CU_Funcionario1;
        private ControleUsuarios.CU_Registro cU_Registro2;
        private ControleUsuarios.CU_AddQuarto cU_AddQuarto2;
        private ControleUsuarios.CU_Registro cU_Registro3;
        private ControleUsuarios.CU_AddQuarto cU_AddQuarto3;
        private System.Windows.Forms.Button btnCancelar;
        private ControleUsuarios.CU_Cancelar CU_Cancelar1;
        private ControleUsuarios.CU_DetalhesHospede CU_DetalhesHospede2;
    }
}