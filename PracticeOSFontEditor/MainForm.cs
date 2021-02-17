/*
 * Created by SharpDevelop.
 * User: Elite
 * Date: 2/16/2021
 * Time: 10:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PracticeOSFontEditor {
	
	public partial class MainForm : Form {
		
		public MainForm () {
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		private void StartButtonClick (Object sender, EventArgs e) {
			
			new Editor(this.fontQualityComboBox.SelectedIndex==0?FontType.x8:((this.fontQualityComboBox.SelectedIndex==1)?FontType.x16:((this.fontQualityComboBox.SelectedIndex==2)?FontType.x32:FontType.x64))).Show();
			this.Hide();
			
		}
		
	}
	
}
