namespace primeiroaplicativo
{
    partial class frmvisualisadordeimagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvisualisadordeimagem));
            this.pbimagem = new System.Windows.Forms.PictureBox();
            this.rbstretch = new System.Windows.Forms.RadioButton();
            this.rbnormal = new System.Windows.Forms.RadioButton();
            this.ofdimagem = new System.Windows.Forms.OpenFileDialog();
            this.btnmostrarimagem = new System.Windows.Forms.Button();
            this.btnlimparimagem = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbimagem
            // 
            this.pbimagem.Image = global::primeiroaplicativo.Properties.Resources._05647_HD1;
            this.pbimagem.Location = new System.Drawing.Point(12, 12);
            this.pbimagem.Name = "pbimagem";
            this.pbimagem.Size = new System.Drawing.Size(776, 352);
            this.pbimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagem.TabIndex = 0;
            this.pbimagem.TabStop = false;
            // 
            // rbstretch
            // 
            this.rbstretch.AutoSize = true;
            this.rbstretch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbstretch.Location = new System.Drawing.Point(494, 397);
            this.rbstretch.Name = "rbstretch";
            this.rbstretch.Size = new System.Drawing.Size(65, 20);
            this.rbstretch.TabIndex = 1;
            this.rbstretch.TabStop = true;
            this.rbstretch.Text = "stretch";
            this.rbstretch.UseVisualStyleBackColor = true;
            this.rbstretch.CheckedChanged += new System.EventHandler(this.rbstretch_CheckedChanged);
            // 
            // rbnormal
            // 
            this.rbnormal.AutoSize = true;
            this.rbnormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnormal.Location = new System.Drawing.Point(631, 397);
            this.rbnormal.Name = "rbnormal";
            this.rbnormal.Size = new System.Drawing.Size(67, 20);
            this.rbnormal.TabIndex = 2;
            this.rbnormal.TabStop = true;
            this.rbnormal.Text = "normal";
            this.rbnormal.UseVisualStyleBackColor = true;
            this.rbnormal.CheckedChanged += new System.EventHandler(this.rbnormal_CheckedChanged);
            // 
            // ofdimagem
            // 
            this.ofdimagem.FileName = "openFileDialog1";
            // 
            // btnmostrarimagem
            // 
            this.btnmostrarimagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrarimagem.Location = new System.Drawing.Point(117, 391);
            this.btnmostrarimagem.Name = "btnmostrarimagem";
            this.btnmostrarimagem.Size = new System.Drawing.Size(141, 33);
            this.btnmostrarimagem.TabIndex = 3;
            this.btnmostrarimagem.Text = "mostrar imagem";
            this.btnmostrarimagem.UseVisualStyleBackColor = true;
            this.btnmostrarimagem.Click += new System.EventHandler(this.btnmostrarimagem_Click);
            // 
            // btnlimparimagem
            // 
            this.btnlimparimagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimparimagem.Location = new System.Drawing.Point(293, 391);
            this.btnlimparimagem.Name = "btnlimparimagem";
            this.btnlimparimagem.Size = new System.Drawing.Size(140, 33);
            this.btnlimparimagem.TabIndex = 4;
            this.btnlimparimagem.Text = "limpar imagem";
            this.btnlimparimagem.UseVisualStyleBackColor = true;
            this.btnlimparimagem.Click += new System.EventHandler(this.btnlimparimagem_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Khaki;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(12, 396);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "Voltar";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmvisualisadordeimagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimparimagem);
            this.Controls.Add(this.btnmostrarimagem);
            this.Controls.Add(this.rbnormal);
            this.Controls.Add(this.rbstretch);
            this.Controls.Add(this.pbimagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmvisualisadordeimagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "visualisador de imagem";
            ((System.ComponentModel.ISupportInitialize)(this.pbimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbimagem;
        private System.Windows.Forms.RadioButton rbstretch;
        private System.Windows.Forms.RadioButton rbnormal;
        private System.Windows.Forms.OpenFileDialog ofdimagem;
        private System.Windows.Forms.Button btnmostrarimagem;
        private System.Windows.Forms.Button btnlimparimagem;
        private System.Windows.Forms.Button btnsair;
    }
}