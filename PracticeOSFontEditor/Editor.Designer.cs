/*
 * Created by SharpDevelop.
 * User: Elite
 * Date: 2/16/2021
 * Time: 10:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PracticeOSFontEditor
{
	partial class Editor
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
			this.drawGridPanel = new System.Windows.Forms.Panel();
			this.instructionsLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// drawGridPanel
			// 
			this.drawGridPanel.Location = new System.Drawing.Point(13, 13);
			this.drawGridPanel.Name = "drawGridPanel";
			this.drawGridPanel.Size = new System.Drawing.Size(580, 580);
			this.drawGridPanel.TabIndex = 0;
			// 
			// instructionsLabel
			// 
			this.instructionsLabel.Location = new System.Drawing.Point(599, 576);
			this.instructionsLabel.Name = "instructionsLabel";
			this.instructionsLabel.Size = new System.Drawing.Size(196, 17);
			this.instructionsLabel.TabIndex = 1;
			this.instructionsLabel.Text = "Left click = draw, right click = erase";
			// 
			// Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 605);
			this.Controls.Add(this.instructionsLabel);
			this.Controls.Add(this.drawGridPanel);
			this.Name = "Editor";
			this.Text = "Editor";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditorFormClosed);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label instructionsLabel;
		private System.Windows.Forms.Panel drawGridPanel;
	}
}
