/*
 * Created by SharpDevelop.
 * User: Elite
 * Date: 2/16/2021
 * Time: 10:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PracticeOSFontEditor {
	
	public partial class Editor : Form {
		
		private List<Byte> dataToWrite;
		
		public Editor (FontType ft) {
			
			const UInt16 x8=
				// 1= first byte to signify whether it is 8x,16x,32x,64x
				1+
				(
					// 8 - signify the amount of rows
					// *
					// 8 - the bits per row
					(8*8)
					
				);
			
			switch (ft) {
					
				case FontType.x8:
					this.dataToWrite=new List<Byte>(x8);
					this.dataToWrite.Add(0x00);
					break;
					
				case FontType.x16:
					this.dataToWrite=new List<Byte>(33);
					this.dataToWrite.Add(0x03);
					break;
					
				case FontType.x32:
					this.dataToWrite=new List<Byte>(97);
					this.dataToWrite.Add(0x0F);
					break;
					
				case FontType.x64:
					this.dataToWrite=new List<Byte>(257);
					this.dataToWrite.Add(0x3F);
					break;
					
				default:
					// I don't see how this could ever happen
					MessageBox.Show("An unexpected error has occured.");
					Environment.Exit(1);
					break;
					
			}
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			this.createDrawGrid();
			
		}
		
		private void EditorFormClosed (Object sender, FormClosedEventArgs e) { Environment.Exit(0); }
		
		private void createDrawGrid () {
			
			Int32 dimension=(Int32)(Math.Sqrt(this.dataToWrite.Capacity-1)),fixedDimension=dimension-1;
			UInt16 ctr=0,x=0,y=0;
			
			while (ctr!=(dataToWrite.Capacity-1)) {
				
				Panel p=new Panel(){Width=dimension,Height=dimension,Left=(x*dimension),Top=(y*dimension),BackColor=Color.White,Name=ctr.ToString()+"_drawGridSubPanel"};
				
				p.MouseDown+= delegate (Object sender,MouseEventArgs args) {
					
					if (args.Button==MouseButtons.Left)
						p.BackColor=Color.Black;
					else if (args.Button==MouseButtons.Right)
						p.BackColor=Color.White;
					
				};
				p.MouseMove+= delegate {
					
					if (!(Control.MouseButtons==MouseButtons.Left)&&!(Control.MouseButtons==MouseButtons.Right))
						return;
					
					foreach (Control c in this.drawGridPanel.Controls) {
						
						Point p0=this.drawGridPanel.PointToClient(Editor.MousePosition);
						
						if (new Rectangle(p0.X,p0.Y,1,1).IntersectsWith(c.Bounds))
							c.BackColor=(Control.MouseButtons==MouseButtons.Left)?Color.Black:Color.White;
						
					}
					
				};
				
				this.drawGridPanel.Controls.Add(p);
				if (x==(fixedDimension)) {
					++y;
					x=0;
				}
				else
					++x;
				++ctr;
				
			}
			
		}
		
	}
	
}