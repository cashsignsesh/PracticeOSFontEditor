/*
 * Created by SharpDevelop.
 * User: Elite
 * Date: 2/17/2021
 * Time: 2:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FontReader
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
			this.openFontBtn = new System.Windows.Forms.Button();
			this.displayCharacterBtn = new System.Windows.Forms.Button();
			this.characterIndexTextBox = new System.Windows.Forms.TextBox();
			this.drawPanel = new System.Windows.Forms.Panel();
			this.fontTypeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// openFontBtn
			// 
			this.openFontBtn.Location = new System.Drawing.Point(12, 12);
			this.openFontBtn.Name = "openFontBtn";
			this.openFontBtn.Size = new System.Drawing.Size(84, 23);
			this.openFontBtn.TabIndex = 0;
			this.openFontBtn.Text = "Open a font";
			this.openFontBtn.UseVisualStyleBackColor = true;
			this.openFontBtn.Click += new System.EventHandler(this.OpenFontBtnClick);
			// 
			// displayCharacterBtn
			// 
			this.displayCharacterBtn.Location = new System.Drawing.Point(13, 42);
			this.displayCharacterBtn.Name = "displayCharacterBtn";
			this.displayCharacterBtn.Size = new System.Drawing.Size(149, 23);
			this.displayCharacterBtn.TabIndex = 1;
			this.displayCharacterBtn.Text = "Display character at index";
			this.displayCharacterBtn.UseVisualStyleBackColor = true;
			this.displayCharacterBtn.Click += new System.EventHandler(this.DisplayCharacterBtnClick);
			// 
			// characterIndexTextBox
			// 
			this.characterIndexTextBox.Location = new System.Drawing.Point(169, 44);
			this.characterIndexTextBox.Name = "characterIndexTextBox";
			this.characterIndexTextBox.Size = new System.Drawing.Size(34, 20);
			this.characterIndexTextBox.TabIndex = 2;
			// 
			// drawPanel
			// 
			this.drawPanel.Location = new System.Drawing.Point(13, 72);
			this.drawPanel.Name = "drawPanel";
			this.drawPanel.Size = new System.Drawing.Size(369, 330);
			this.drawPanel.TabIndex = 3;
			// 
			// fontTypeLabel
			// 
			this.fontTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fontTypeLabel.Location = new System.Drawing.Point(103, 11);
			this.fontTypeLabel.Name = "fontTypeLabel";
			this.fontTypeLabel.Size = new System.Drawing.Size(100, 23);
			this.fontTypeLabel.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 414);
			this.Controls.Add(this.fontTypeLabel);
			this.Controls.Add(this.drawPanel);
			this.Controls.Add(this.characterIndexTextBox);
			this.Controls.Add(this.displayCharacterBtn);
			this.Controls.Add(this.openFontBtn);
			this.Name = "MainForm";
			this.Text = "FontReader";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label fontTypeLabel;
		private System.Windows.Forms.Panel drawPanel;
		private System.Windows.Forms.TextBox characterIndexTextBox;
		private System.Windows.Forms.Button displayCharacterBtn;
		private System.Windows.Forms.Button openFontBtn;
		
	}
}
