
namespace BankApp_CSharp_MySQL
{
    partial class AdaugareUtilizator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_utilizator = new System.Windows.Forms.TextBox();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.textBox_prenume = new System.Windows.Forms.TextBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.btn_adaugare_utilizator = new System.Windows.Forms.Button();
            this.btn_stergere_campuri = new System.Windows.Forms.Button();
            this.btn_actualizare_date = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prenume";
            // 
            // textBox_utilizator
            // 
            this.textBox_utilizator.Location = new System.Drawing.Point(134, 44);
            this.textBox_utilizator.Name = "textBox_utilizator";
            this.textBox_utilizator.Size = new System.Drawing.Size(166, 26);
            this.textBox_utilizator.TabIndex = 4;
            // 
            // textBox_parola
            // 
            this.textBox_parola.Location = new System.Drawing.Point(134, 85);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.Size = new System.Drawing.Size(166, 26);
            this.textBox_parola.TabIndex = 5;
            // 
            // textBox_nume
            // 
            this.textBox_nume.Location = new System.Drawing.Point(134, 129);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(166, 26);
            this.textBox_nume.TabIndex = 6;
            // 
            // textBox_prenume
            // 
            this.textBox_prenume.Location = new System.Drawing.Point(134, 178);
            this.textBox_prenume.Name = "textBox_prenume";
            this.textBox_prenume.Size = new System.Drawing.Size(166, 26);
            this.textBox_prenume.TabIndex = 7;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // btn_adaugare_utilizator
            // 
            this.btn_adaugare_utilizator.Location = new System.Drawing.Point(75, 240);
            this.btn_adaugare_utilizator.Name = "btn_adaugare_utilizator";
            this.btn_adaugare_utilizator.Size = new System.Drawing.Size(186, 57);
            this.btn_adaugare_utilizator.TabIndex = 8;
            this.btn_adaugare_utilizator.Text = "Adaugare utilizator";
            this.btn_adaugare_utilizator.UseVisualStyleBackColor = true;
            this.btn_adaugare_utilizator.Click += new System.EventHandler(this.btn_adaugare_utilizator_Click);
            // 
            // btn_stergere_campuri
            // 
            this.btn_stergere_campuri.Location = new System.Drawing.Point(75, 330);
            this.btn_stergere_campuri.Name = "btn_stergere_campuri";
            this.btn_stergere_campuri.Size = new System.Drawing.Size(186, 57);
            this.btn_stergere_campuri.TabIndex = 9;
            this.btn_stergere_campuri.Text = "Stergere campuri";
            this.btn_stergere_campuri.UseVisualStyleBackColor = true;
            // 
            // btn_actualizare_date
            // 
            this.btn_actualizare_date.Location = new System.Drawing.Point(981, 240);
            this.btn_actualizare_date.Name = "btn_actualizare_date";
            this.btn_actualizare_date.Size = new System.Drawing.Size(186, 57);
            this.btn_actualizare_date.TabIndex = 10;
            this.btn_actualizare_date.Text = "Actualizare date";
            this.btn_actualizare_date.UseVisualStyleBackColor = true;
            this.btn_actualizare_date.Click += new System.EventHandler(this.btn_actualizare_date_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(810, 160);
            this.dataGridView1.TabIndex = 11;
            // 
            // AdaugareUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_actualizare_date);
            this.Controls.Add(this.btn_stergere_campuri);
            this.Controls.Add(this.btn_adaugare_utilizator);
            this.Controls.Add(this.textBox_prenume);
            this.Controls.Add(this.textBox_nume);
            this.Controls.Add(this.textBox_parola);
            this.Controls.Add(this.textBox_utilizator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugareUtilizator";
            this.Text = "Adaugare Utilizator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_utilizator;
        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.TextBox textBox_prenume;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button btn_adaugare_utilizator;
        private System.Windows.Forms.Button btn_stergere_campuri;
        private System.Windows.Forms.Button btn_actualizare_date;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}