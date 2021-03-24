/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DeltaCompressionDecoder
	{
		// Fields
		private byte[] _bytes;
		private int _nextByteIndex;
		private int _nextDiffFlagBitIndex;
		private int _diffFlagLength;
	
		// Constructors
		public DeltaCompressionDecoder();
	
		// Methods
		public void SetBinary(byte[] bytes);
		public bool ReadInteger(int? prev, out int result);
		public bool ReadByte(byte? prev, out byte result);
		public bool ReadFloat(float? prev, out float result);
		public bool ReadBool(bool? prev, out bool result);
		public bool ReadString(string prev, out string result);
		private bool ReadDiffFlag(out bool result);
	}
}
