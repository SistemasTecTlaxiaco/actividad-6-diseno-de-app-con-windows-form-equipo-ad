namespace Practica_Programación
{
    partial class Form6
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button2 = new Button();
            LabelUsuario = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leckerli One", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(391, 12);
            label1.Name = "label1";
            label1.Size = new Size(327, 54);
            label1.TabIndex = 0;
            label1.Text = "Venta en general";
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Leckerli One", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(114, 54);
            button1.TabIndex = 1;
            button1.Text = "Menú";
            button1.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(255, 192, 192);
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listView1.Location = new Point(52, 155);
            listView1.Name = "listView1";
            listView1.Size = new Size(986, 385);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 230;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Información";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 280;
            // 
            // button2
            // 
            button2.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(52, 95);
            button2.Name = "button2";
            button2.Size = new Size(143, 45);
            button2.TabIndex = 23;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.BackColor = Color.White;
            LabelUsuario.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelUsuario.ForeColor = Color.Black;
            LabelUsuario.Location = new Point(56, 572);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(210, 32);
            LabelUsuario.TabIndex = 12;
            LabelUsuario.Text = "No. de productos:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(52, 640);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 43);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(52, 567);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 43);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Nunito Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(54, 641);
            label2.Name = "label2";
            label2.Size = new Size(96, 38);
            label2.TabIndex = 24;
            label2.Text = "Total:";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.BackgroundImage = Properties.Resources.fondo_figma;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(630, 567);
            button3.Name = "button3";
            button3.Size = new Size(143, 45);
            button3.TabIndex = 25;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.BackgroundImage = Properties.Resources.fondo_figma;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(630, 634);
            button4.Name = "button4";
            button4.Size = new Size(143, 45);
            button4.TabIndex = 26;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.BackgroundImage = Properties.Resources.fondo_figma;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(797, 567);
            button5.Name = "button5";
            button5.Size = new Size(241, 112);
            button5.TabIndex = 27;
            button5.Text = "Cobrar";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_figma;
            ClientSize = new Size(1089, 732);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(LabelUsuario);
            Controls.Add(listView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form6";
            Text = "Form6";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button2;
        private Label LabelUsuario;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}