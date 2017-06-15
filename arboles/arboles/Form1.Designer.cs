namespace arboles
{
    partial class Form1
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
            this.agregar = new System.Windows.Forms.Button();
            this.preOrder = new System.Windows.Forms.Button();
            this.inOrder = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Button();
            this.Contains = new System.Windows.Forms.Button();
            this.post = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(283, 29);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // preOrder
            // 
            this.preOrder.Location = new System.Drawing.Point(74, 171);
            this.preOrder.Name = "preOrder";
            this.preOrder.Size = new System.Drawing.Size(75, 23);
            this.preOrder.TabIndex = 1;
            this.preOrder.Text = "Pre Order";
            this.preOrder.UseVisualStyleBackColor = true;
            this.preOrder.Click += new System.EventHandler(this.preOrder_Click);
            // 
            // inOrder
            // 
            this.inOrder.Location = new System.Drawing.Point(74, 218);
            this.inOrder.Name = "inOrder";
            this.inOrder.Size = new System.Drawing.Size(75, 23);
            this.inOrder.TabIndex = 2;
            this.inOrder.Text = "In Order";
            this.inOrder.UseVisualStyleBackColor = true;
            this.inOrder.Click += new System.EventHandler(this.inOrder_Click);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(283, 104);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(75, 23);
            this.Count.TabIndex = 5;
            this.Count.Text = "Mostrar";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Contains
            // 
            this.Contains.Location = new System.Drawing.Point(283, 72);
            this.Contains.Name = "Contains";
            this.Contains.Size = new System.Drawing.Size(75, 23);
            this.Contains.TabIndex = 4;
            this.Contains.Text = "Buscar";
            this.Contains.UseVisualStyleBackColor = true;
            this.Contains.Click += new System.EventHandler(this.Contains_Click);
            // 
            // post
            // 
            this.post.Location = new System.Drawing.Point(74, 262);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(75, 23);
            this.post.TabIndex = 3;
            this.post.Text = "Post Order";
            this.post.UseVisualStyleBackColor = true;
            this.post.Click += new System.EventHandler(this.post_Click);
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(46, 32);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(204, 20);
            this.Numero.TabIndex = 6;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(46, 104);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(204, 35);
            this.Resultado.TabIndex = 7;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(46, 72);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(204, 20);
            this.Buscar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 361);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Contains);
            this.Controls.Add(this.post);
            this.Controls.Add(this.inOrder);
            this.Controls.Add(this.preOrder);
            this.Controls.Add(this.agregar);
            this.Name = "Form1";
            this.Text = "Post Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button preOrder;
        private System.Windows.Forms.Button inOrder;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button Contains;
        private System.Windows.Forms.Button post;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.TextBox Buscar;
    }
}

