/*
 * Created by SharpDevelop.
 * User: Elite
 * Date: 2/17/2021
 * Time: 2:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PracticeOSFontInterpreter {
	
	/// <summary>
	/// The interpreted form of .pfont Practice OS Font files
	/// </summary>
	public class Font {
		
		/// <summary>
		/// The type of the font
		/// </summary>
		public readonly FontType type;
		
		/// <summary>
		/// The raw font data in byte array form
		/// </summary>
		private readonly Byte[] data;
		
		/// <summary>
		/// The amount of bytes per character
		/// </summary>
		private readonly UInt16 take;
		
		/// <summary>
		/// The bits per line
		/// </summary>
		private readonly Byte bpl;
		
		/// <summary>
		/// Create an instance of the interpreter
		/// </summary>
		/// <param name="file">the Practice OS Font file</param>
		public Font (String file) : this (File.ReadAllBytes(file)) { }
		
		/// <summary>
		/// Create an instance of the interpreter
		/// </summary>
		/// <param name="data">the Practice OS Font byte data</param>
		public Font (Byte[] data) {
			
			this.data=data;
			
			switch (this.data[0]) {
					
				case 0x00:
					this.type=FontType.x8;
					this.take=8;
					this.bpl=8;
					break;
				case 0x03:
					this.type=FontType.x16;
					this.take=32;
					this.bpl=16;
					break;
				case 0x0F:
					this.type=FontType.x32;
					this.take=128;
					this.bpl=32;
					break;
				case 0x3F:
					this.type=FontType.x64;
					this.take=512;
					this.bpl=64;
					break;
				default:
					throw new InvalidFileFormatException("Invalid header");
					break;
					
			}
			
		}
		
		/// <summary>
		/// Get the data at a specific index in the font.
		/// For example, an index of 0 is generally a capital 'A'. (as of 2/17/2021)
		/// The reason that it is an index instead of a character,
		/// is because the index is not set in stone and might change
		/// to accomodate for other languages or special characters.
		/// </summary>
		/// <param name="index">The index of the character</param>
		/// <returns>Returns the points that can be used to draw the character</returns>
		public IEnumerable<FPoint> getDataAt (UInt16 index) {
			
			StringBuilder sb=new StringBuilder();
			
			foreach (Byte b in this.getRawDataAt(index))
				sb.Append(Convert.ToString(b,2).PadLeft(8,'0'));
			
			UInt16 x=0,y=0;
			Byte fixedBpl=(Byte)(this.bpl-1);
			
			foreach (Char c in sb.ToString()) {
				
				yield return new FPoint{x=x,y=y,coloured=c=='1'};
				
				if (x==fixedBpl) {
				
					++y;
					x=0;
					
				}
				else ++x;
				
			}
			
		}
		
		/// <summary>
		/// Get the raw data at a specific index in the font
		/// </summary>
		/// <param name="index">The index of the character</param>
		/// <returns>The raw data in bytes</returns>
		private IEnumerable<Byte> getRawDataAt (UInt16 index) { return this.data.Skip(1+(this.take*index)).Take(this.take); }
		
	}
	
}