using Ispan.Utilities._1A2B;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		private string[] answer;
		public Form1()
		{
			InitializeComponent();
			answerlbl.Text=string.Empty;
		}

		private void guessbtn_Click(object sender, EventArgs e)
		{
			string show=string.Empty;
			int countA = 0;
			int countB = 0;
			string[] input=new string[4];
			GetNumber getNumber = new GetNumber();
			try
			{
				input = getNumber.GetInput(guesstxt.Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			for(int i = 0; i < answer.Length; i++)
			{
				if (input[i] == answer[i])
				{
					countA++;
				}
				else if (input[i] == answer[0]|| input[i] == answer[1]|| input[i] == answer[2]|| input[i] == answer[3])
				{
					countB++;
				}
			}
			if (countA == 4) MessageBox.Show("你答對了");
			answertxt.Text += $"{guesstxt.Text}=>{countA}A{countB}B\r\n";
		}

		private void newGamebtn_Click(object sender, EventArgs e)
		{
			GetNumber getNumber = new GetNumber();
			string[] answerArray = getNumber.GetRandom();
			this.answer = answerArray;
		}

		private void answerbtn_Click(object sender, EventArgs e)
		{
			string answerNumber = string.Empty;
			foreach (string s in answer)
			{
				answerNumber += s;
			}
			answerlbl.Text = answerNumber;
		}
	}
}
