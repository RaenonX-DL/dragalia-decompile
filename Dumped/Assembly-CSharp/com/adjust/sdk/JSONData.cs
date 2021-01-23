/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	public class JSONData : JSONNode
	{
		// Fields
		private string m_Data;
	
		// Properties
		public override string Value { get; set; }
	
		// Constructors
		public JSONData(string aData);
		public JSONData(float aData);
		public JSONData(double aData);
		public JSONData(bool aData);
		public JSONData(int aData);
	
		// Methods
		public override string ToString();
		public override string ToString(string aPrefix);
		public override void Serialize(BinaryWriter aWriter);
	}
}
