namespace primeiroaplicativo
{
    partial class frmprincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            this.lblmensagem = new System.Windows.Forms.Label();
            this.btnmostrarmensagem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btntabuada = new System.Windows.Forms.Button();
            this.btnimagem = new System.Windows.Forms.Button();
            this.btnclick = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensagem.Location = new System.Drawing.Point(210, 215);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(0, 37);
            this.lblmensagem.TabIndex = 0;
            this.lblmensagem.Click += new System.EventHandler(this.lblmensagem_Click);
            // 
            // btnmostrarmensagem
            // 
            this.btnmostrarmensagem.BackColor = System.Drawing.Color.Goldenrod;
            this.btnmostrarmensagem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrarmensagem.Location = new System.Drawing.Point(238, 151);
            this.btnmostrarmensagem.Name = "btnmostrarmensagem";
            this.btnmostrarmensagem.Size = new System.Drawing.Size(176, 45);
            this.btnmostrarmensagem.TabIndex = 1;
            this.btnmostrarmensagem.Text = "mostrar mensagem";
            this.btnmostrarmensagem.UseVisualStyleBackColor = false;
            this.btnmostrarmensagem.Click += new System.EventHandler(this.btnmostrarmensagem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.lblmensagem_Click);
            // 
            // btntabuada
            // 
            this.btntabuada.Enabled = false;
            this.btntabuada.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntabuada.Image = global::primeiroaplicativo.Properties.Resources.Calculator_icon__1_;
            this.btntabuada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btntabuada.Location = new System.Drawing.Point(127, 52);
            this.btntabuada.Name = "btntabuada";
            this.btntabuada.Size = new System.Drawing.Size(83, 64);
            this.btntabuada.TabIndex = 5;
            this.btntabuada.Text = "tabuada";
            this.btntabuada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntabuada.UseVisualStyleBackColor = true;
            this.btntabuada.Click += new System.EventHandler(this.btntabuada_Click);
            // 
            // btnimagem
            // 
            this.btnimagem.Enabled = false;
            this.btnimagem.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimagem.Image = global::primeiroaplicativo.Properties.Resources.Images_icon__2_;
            this.btnimagem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnimagem.Location = new System.Drawing.Point(279, 52);
            this.btnimagem.Name = "btnimagem";
            this.btnimagem.Size = new System.Drawing.Size(85, 64);
            this.btnimagem.TabIndex = 4;
            this.btnimagem.Text = "imagens";
            this.btnimagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnimagem.UseVisualStyleBackColor = true;
            this.btnimagem.Click += new System.EventHandler(this.btnimagem_Click);
            // 
            // btnclick
            // 
            this.btnclick.Enabled = false;
            this.btnclick.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclick.Image = global::primeiroaplicativo.Properties.Resources.Actions_document_edit_icon__1_;
            this.btnclick.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnclick.Location = new System.Drawing.Point(452, 52);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(87, 64);
            this.btnclick.TabIndex = 3;
            this.btnclick.Text = "click";
            this.btnclick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Khaki;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(540, 291);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 6;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 326);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btntabuada);
            this.Controls.Add(this.btnimagem);
            this.Controls.Add(this.btnclick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmostrarmensagem);
            this.Controls.Add(this.lblmensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "primeiro aplicativo em c#";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.Click += new System.EventHandler(this.lblmensagem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensagem;
        private System.Windows.Forms.Button btnmostrarmensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.Button btnimagem;
        private System.Windows.Forms.Button btntabuada;
        private System.Windows.Forms.Button btnsair;
    }
}

