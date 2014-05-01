/*
 * Created by SharpDevelop.
 * User: CA
 * Date: 29/04/2014
 * Time: 12:33 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UserLogin
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LoginClick(object sender, EventArgs e)
		{
			if(textBox1.Text== "Daniela" && textBox2.Text== "cutonala")
			{
				MessageBox.Show("Ahora estas en linea");
			}
			else
			
				MessageBox.Show("Datos incorrectos");

		}
	}
}
