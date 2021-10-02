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
			
			new Editor((FontType)fontQualityComboBox.SelectedIndex).Show();
			this.Hide();
			
		}
		
	}
	
}
