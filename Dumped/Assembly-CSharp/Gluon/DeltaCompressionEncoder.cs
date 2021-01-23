/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DeltaCompressionEncoder
	{
		// Fields
		private MemoryStream _stream;
		private BinaryWriter _writer;
		private List<bool> _diffFlagList;
	
		// Constructors
		public DeltaCompressionEncoder();
	
		// Methods
		public bool WriteInteger(int? prev, int next);
		public bool WriteByte(byte? prev, byte next);
		public bool WriteFloat(float? prev, float next);
		public bool WriteBool(bool? prev, bool next);
		public bool WriteString(string prev, string next);
		public byte[] GetBinary();
		public void Clear();
		private void WriteDiffFlag(bool b);
	}
}
