/*
 * Created by SharpDevelop.
 * User: Elite
 * Date: 2/16/2021
 * Time: 11:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PracticeOSFontInterpreter {
	
	/// <summary>
	/// The type of font, size-wise
	/// </summary>
	public enum FontType {
		
		/// <summary>
		/// A x8 font contains 8 lines, with 1 byte per line
		/// </summary>
		x8,
		
		/// <summary>
		/// A x16 font contains 16 lines, with 2 bytes per line
		/// </summary>
		x16,
		
		/// <summary>
		/// A x32 font contains 32 lines, with 4 bytes per line
		/// </summary>
		x32,
		
		/// <summary>
		/// A x64 font contains 64 lines, with 8 bytes per line
		/// </summary>
		x64
		
	}
	
}
