/*
 * Created by SharpDevelop.
 * User: User
 * Date: 09/06/2022
 * Time: 12:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace UAS_PV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = gaji_guru; Uid= root");
        MySqlCommand mycommand = new MySqlCommand();
        MySqlDataAdapter myadapter = new MySqlDataAdapter();
        
        public void ReadData(){
            try{
                mycommand.Connection = co;
                myadapter.SelectCommand = mycommand;
                mycommand.CommandText = "select * from guru";
                DataSet ds = new DataSet();

                if (myadapter.Fill(ds,"dftpesan") > 0){
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "dftpesan";
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }
        
        public void InsertData(){
            try{
                mycommand.Connection=co;
                mycommand.CommandText="insert into guru values('"+NIP.Text+"','"+nama.Text+"','"+golongan.SelectedItem+"','"+gaji_pokok.Text+"')";
                myadapter.SelectCommand= mycommand;
                if (mycommand.ExecuteNonQuery()==1){
                    MessageBox.Show("Data berhasil disimpan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ReadData();
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        
        public void UpdateData(){
               try{
                mycommand.Connection=co;
                mycommand.CommandText = "update guru set NIP='"+NIP.Text+"',nama='"+nama.Text+"',golongan='"+golongan.SelectedItem+"',gaji_pokok='"+gaji_pokok.Text+"' where NIP ='"+NIP.Text+"'";
                myadapter.SelectCommand = mycommand;
                if (mycommand.ExecuteNonQuery()==1){
                    MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ReadData();
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }
        
        public void DeleteData(){
            try{
                mycommand.Connection=co;
                mycommand.CommandText="delete from guru where NIP='"+NIP.Text+"'";
                myadapter.SelectCommand = mycommand;
                if (mycommand.ExecuteNonQuery()==1){
                    MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ReadData();
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            co.Open();
            ReadData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			NIP.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            golongan.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            gaji_pokok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
		}
		
		void InsertClick(object sender, EventArgs e)
		{
			
			InsertData();  
		}
		
		void UpdateClick(object sender, EventArgs e)
		{
			 UpdateData();			
		}
		
		void DeleteClick(object sender, EventArgs e)
		{
			 DeleteData();            
		}
		
		void ExitClick(object sender, EventArgs e)
		{
			Application.Exit();                			
		}
		
		void NIPKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void cbgolongan(){
            golongan.Items.Add("I");
            golongan.Items.Add("II");
            golongan.Items.Add("III");
            golongan.Items.Add("IV");
        }

		
		void MainFormLoad(object sender, EventArgs e)
		{
			cbgolongan();
		}
		
		void Gaji_pokokTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void IpaCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		
	}
}
