/*
 * Created by SharpDevelop.
 * User: Elite
 * Date: 2/17/2021
 * Time: 2:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PracticeOSFontInterpreter {
	
	/// <summary>
	/// An exception that is thrown when a PracticeOS Font file is attempted to be read in an invalid format
	/// </summary>
	public class InvalidFileFormatException : Exception {
		
		/// <summary>
		/// Create a PracticeOS Font InvalidFileFormat exception
		/// </summary>
		/// <param name="data">The data related to the exception</param>
		internal InvalidFileFormatException (String data) : base ("Invalid PracticeOS Font Format: "+data) { }
		
	}
}
