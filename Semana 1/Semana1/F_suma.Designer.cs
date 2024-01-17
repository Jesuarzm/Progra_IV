namespace Semana1
{
    partial class F_suma
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
            groupBox1 = new GroupBox();
            bt_cerrar = new Button();
            bt_limpiar = new Button();
            bt_sumar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_total = new TextBox();
            tb_num_2 = new TextBox();
            tb_num_1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_cerrar);
            groupBox1.Controls.Add(bt_limpiar);
            groupBox1.Controls.Add(bt_sumar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_total);
            groupBox1.Controls.Add(tb_num_2);
            groupBox1.Controls.Add(tb_num_1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // bt_cerrar
            // 
            bt_cerrar.Location = new Point(472, 227);
            bt_cerrar.Name = "bt_cerrar";
            bt_cerrar.Size = new Size(75, 23);
            bt_cerrar.TabIndex = 8;
            bt_cerrar.Text = "Cerrar";
            bt_cerrar.UseVisualStyleBackColor = true;
            bt_cerrar.Click += bt_cerrar_Click;
            // 
            // bt_limpiar
            // 
            bt_limpiar.Location = new Point(472, 180);
            bt_limpiar.Name = "bt_limpiar";
            bt_limpiar.Size = new Size(75, 23);
            bt_limpiar.TabIndex = 7;
            bt_limpiar.Text = "Limpiar";
            bt_limpiar.UseVisualStyleBackColor = true;
            bt_limpiar.Click += bt_limpiar_Click;
            // 
            // bt_sumar
            // 
            bt_sumar.Location = new Point(472, 131);
            bt_sumar.Name = "bt_sumar";
            bt_sumar.Size = new Size(75, 23);
            bt_sumar.TabIndex = 6;
            bt_sumar.Text = "Sumar";
            bt_sumar.UseVisualStyleBackColor = true;
            bt_sumar.Click += bt_sumar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 245);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 162);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 89);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // tb_total
            // 
            tb_total.Location = new Point(136, 263);
            tb_total.Name = "tb_total";
            tb_total.ReadOnly = true;
            tb_total.Size = new Size(100, 23);
            tb_total.TabIndex = 2;
            // 
            // tb_num_2
            // 
            tb_num_2.Location = new Point(136, 180);
            tb_num_2.Name = "tb_num_2";
            tb_num_2.Size = new Size(100, 23);
            tb_num_2.TabIndex = 1;
            // 
            // tb_num_1
            // 
            tb_num_1.Location = new Point(136, 107);
            tb_num_1.Name = "tb_num_1";
            tb_num_1.Size = new Size(100, 23);
            tb_num_1.TabIndex = 0;
            // 
            // F_suma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "F_suma";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button bt_cerrar;
        private Button bt_limpiar;
        private Button bt_sumar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_total;
        private TextBox tb_num_2;
        private TextBox tb_num_1;
    }
}