/*
 * 
 * Created by SharpDevelop.
 * User: Elite
 * Date: 2/17/2021
 * Time: 2:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PracticeOSFontInterpreter {
	
	/// <summary>
	/// Font point
	/// </summary>
	public struct FPoint {
		
		/// <summary>
		/// If true, then the point is coloured and should be black/whichever colour.
		/// </summary>
		public Boolean coloured;
		
		/// <summary>
		/// The X axis of the point
		/// </summary>
		public UInt16 x;
		
		/// <summary>
		/// The Y axis of the point
		/// </summary>
		public UInt16 y;
		
	}
	
}