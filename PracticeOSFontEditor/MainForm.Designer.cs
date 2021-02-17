/*
 * Created by SharpDevelop.
 * User: Elite
 * Date: 2/16/2021
 * Time: 10:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PracticeOSFontEditor
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
			this.fontQualityComboBox = new System.Windows.Forms.ComboBox();
			this.startButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fontQualityComboBox
			// 
			this.fontQualityComboBox.FormattingEnabled = true;
			this.fontQualityComboBox.Items.AddRange(new object[] {
									"8x",
									"16x",
									"32x",
									"64x"});
			this.fontQualityComboBox.Location = new System.Drawing.Point(12, 12);
			this.fontQualityComboBox.Name = "fontQualityComboBox";
			this.fontQualityComboBox.Size = new System.Drawing.Size(121, 21);
			this.fontQualityComboBox.TabIndex = 0;
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(141, 10);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(87, 23);
			this.startButton.TabIndex = 1;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(240, 45);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.fontQualityComboBox);
			this.Name = "MainForm";
			this.Text = "PracticeOSFontEditor";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.ComboBox fontQualityComboBox;
	}
}
