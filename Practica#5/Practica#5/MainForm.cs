
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica_5
{
	public partial class MainForm : Form
	{
		double pesos;
		double dolares;
		double Tipodecambio;
		
		public MainForm()
		{
		  
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void button1(object sender, EventArgs e)
		{
			
			if(double.TryParse(textBox1.Text, out pesos) 
			   && double.TryParse(textBox2.Text, out Tipodecambio)
			   && pesos !=0 && Tipodecambio !=0){
				
				dolares = pesos/Tipodecambio;
			
			textBox3.Text = dolares.ToString();
			
			
			}else{
				MessageBox.Show("Error\n Los Datos ingresados son incorrectos");
			}
		}
		
		void TextBox2TextChanged(object sender, EventArgs e){
			
		}
	}
}
