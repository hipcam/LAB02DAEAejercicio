namespace Lab02Alvarado
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGPedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DGDetallesP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetallesP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTAR PEDIDOS";
            // 
            // DGPedidos
            // 
            this.DGPedidos.AllowUserToAddRows = false;
            this.DGPedidos.AllowUserToDeleteRows = false;
            this.DGPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPedidos.Location = new System.Drawing.Point(36, 44);
            this.DGPedidos.Name = "DGPedidos";
            this.DGPedidos.ReadOnly = true;
            this.DGPedidos.Size = new System.Drawing.Size(989, 183);
            this.DGPedidos.TabIndex = 1;
            this.DGPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPedidos_CellContentClick);
            this.DGPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPedidos_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detalles del pedido";
            // 
            // DGDetallesP
            // 
            this.DGDetallesP.AllowUserToAddRows = false;
            this.DGDetallesP.AllowUserToDeleteRows = false;
            this.DGDetallesP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetallesP.Location = new System.Drawing.Point(36, 307);
            this.DGDetallesP.Name = "DGDetallesP";
            this.DGDetallesP.ReadOnly = true;
            this.DGDetallesP.Size = new System.Drawing.Size(989, 164);
            this.DGDetallesP.TabIndex = 3;
            this.DGDetallesP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetallesP_CellClick);
            this.DGDetallesP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetallesP_CellContentClick);
            this.DGDetallesP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetallesP_CellDoubleClick);
            this.DGDetallesP.DoubleClick += new System.EventHandler(this.DGDetallesP_DoubleClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 513);
            this.Controls.Add(this.DGDetallesP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGPedidos);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3cs";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetallesP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGDetallesP;
    }
}