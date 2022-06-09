/*
 * Created by SharpDevelop.
 * User: User
 * Date: 09/06/2022
 * Time: 12:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UAS_PV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.NIP = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nama = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.jeniskelamin = new System.Windows.Forms.GroupBox();
			this.wanita = new System.Windows.Forms.RadioButton();
			this.pria = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.ipa = new System.Windows.Forms.CheckBox();
			this.ips = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.gaji_pokok = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.insert = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.golongan = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.jeniskelamin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(437, 52);
			this.label1.TabIndex = 0;
			this.label1.Text = "Data Gaji Guru SMA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "NIP Guru";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// NIP
			// 
			this.NIP.Location = new System.Drawing.Point(102, 94);
			this.NIP.Name = "NIP";
			this.NIP.Size = new System.Drawing.Size(258, 20);
			this.NIP.TabIndex = 2;
			this.NIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NIPKeyPress);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 26);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nama Guru";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(102, 120);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(258, 20);
			this.nama.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 26);
			this.label5.TabIndex = 7;
			this.label5.Text = "Jenis Kelamin";
			// 
			// jeniskelamin
			// 
			this.jeniskelamin.Controls.Add(this.wanita);
			this.jeniskelamin.Controls.Add(this.pria);
			this.jeniskelamin.Location = new System.Drawing.Point(102, 176);
			this.jeniskelamin.Name = "jeniskelamin";
			this.jeniskelamin.Size = new System.Drawing.Size(258, 48);
			this.jeniskelamin.TabIndex = 8;
			this.jeniskelamin.TabStop = false;
			this.jeniskelamin.Text = "Jenis Kelamin";
			// 
			// wanita
			// 
			this.wanita.Location = new System.Drawing.Point(146, 16);
			this.wanita.Name = "wanita";
			this.wanita.Size = new System.Drawing.Size(104, 24);
			this.wanita.TabIndex = 1;
			this.wanita.TabStop = true;
			this.wanita.Text = "Wanita";
			this.wanita.UseVisualStyleBackColor = true;
			// 
			// pria
			// 
			this.pria.Location = new System.Drawing.Point(6, 18);
			this.pria.Name = "pria";
			this.pria.Size = new System.Drawing.Size(104, 24);
			this.pria.TabIndex = 0;
			this.pria.TabStop = true;
			this.pria.Text = "Pria";
			this.pria.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 235);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 26);
			this.label6.TabIndex = 9;
			this.label6.Text = "Guru di Kelas";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// ipa
			// 
			this.ipa.Location = new System.Drawing.Point(108, 230);
			this.ipa.Name = "ipa";
			this.ipa.Size = new System.Drawing.Size(104, 24);
			this.ipa.TabIndex = 10;
			this.ipa.Text = "10";
			this.ipa.UseVisualStyleBackColor = true;
			this.ipa.CheckedChanged += new System.EventHandler(this.IpaCheckedChanged);
			// 
			// ips
			// 
			this.ips.Location = new System.Drawing.Point(248, 230);
			this.ips.Name = "ips";
			this.ips.Size = new System.Drawing.Size(112, 24);
			this.ips.TabIndex = 11;
			this.ips.Text = "12";
			this.ips.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 264);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 26);
			this.label7.TabIndex = 12;
			this.label7.Text = "Gaji Pokok";
			// 
			// gaji_pokok
			// 
			this.gaji_pokok.Location = new System.Drawing.Point(102, 261);
			this.gaji_pokok.Name = "gaji_pokok";
			this.gaji_pokok.Size = new System.Drawing.Size(258, 20);
			this.gaji_pokok.TabIndex = 13;
			this.gaji_pokok.TextChanged += new System.EventHandler(this.Gaji_pokokTextChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 308);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(439, 238);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// insert
			// 
			this.insert.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.insert.Location = new System.Drawing.Point(378, 93);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(73, 21);
			this.insert.TabIndex = 16;
			this.insert.Text = "Insert";
			this.insert.UseVisualStyleBackColor = false;
			this.insert.Click += new System.EventHandler(this.InsertClick);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.update.Location = new System.Drawing.Point(378, 119);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(73, 21);
			this.update.TabIndex = 17;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.UpdateClick);
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.delete.Location = new System.Drawing.Point(378, 145);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(73, 21);
			this.delete.TabIndex = 18;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.DeleteClick);
			// 
			// exit
			// 
			this.exit.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.exit.Location = new System.Drawing.Point(378, 172);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(73, 21);
			this.exit.TabIndex = 19;
			this.exit.Text = "Exit";
			this.exit.UseVisualStyleBackColor = false;
			this.exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// golongan
			// 
			this.golongan.FormattingEnabled = true;
			this.golongan.Location = new System.Drawing.Point(102, 146);
			this.golongan.Name = "golongan";
			this.golongan.Size = new System.Drawing.Size(258, 21);
			this.golongan.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 149);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 26);
			this.label8.TabIndex = 21;
			this.label8.Text = "Golongan";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(170, 230);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(72, 24);
			this.checkBox1.TabIndex = 22;
			this.checkBox1.Text = "11";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 558);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.golongan);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.update);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.gaji_pokok);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.ips);
			this.Controls.Add(this.ipa);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.jeniskelamin);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.NIP);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "UAS_PV";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.jeniskelamin.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox golongan;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox gaji_pokok;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox ips;
		private System.Windows.Forms.CheckBox ipa;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton pria;
		private System.Windows.Forms.RadioButton wanita;
		private System.Windows.Forms.GroupBox jeniskelamin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox NIP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
