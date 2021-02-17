/*
 * Created by SharpDevelop.
 * User: Elite
 * Date: 2/17/2021
 * Time: 2:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PracticeOSFontInterpreter;
using System.Linq;

namespace FontReader {
	
	public partial class MainForm : Form {
		
		private String fileName="";
		
		public MainForm () {
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		private void OpenFontBtnClick (Object sender, EventArgs e) {
			
			OpenFileDialog ofd=new OpenFileDialog();
			ofd.Filter="PracticeOS Font Files (*.pfont)|*.pfont";
			ofd.RestoreDirectory=true;
			if (ofd.ShowDialog()==DialogResult.OK)
				this.fileName=ofd.FileName;
			
		}
		
		private void DisplayCharacterBtnClick (Object sender, EventArgs e) {
			
			if (this.fileName=="") return;
			UInt16 index;
			if (!(UInt16.TryParse(this.characterIndexTextBox.Text,out index))) return;
			
			PracticeOSFontInterpreter.Font f=new PracticeOSFontInterpreter.Font(this.fileName);
			this.fontTypeLabel.Text=f.type.ToString();
			
			this.drawPanel.Refresh();
			
			using (Graphics g=this.drawPanel.CreateGraphics()) {
				
				g.Clear(Color.White);
					
				foreach (FPoint fp in f.getDataAt(index))
					g.FillRectangle((fp.coloured)?Brushes.Black:Brushes.White,new RectangleF(fp.x,fp.y,1,1));
				
			}
			
		}
		
	}
	
}
