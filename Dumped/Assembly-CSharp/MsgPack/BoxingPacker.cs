/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MsgPack
{
	public class BoxingPacker
	{
		// Fields
		private static Type KeyValuePairDefinitionType;
		private static UTF8Encoding utf8enc;
	
		// Constructors
		static BoxingPacker();
		public BoxingPacker();
	
		// Methods
		public void Pack(Stream strm, object o);
		public byte[] Pack(object o);
		private void Pack(MsgPackWriter writer, object o);
		public object Unpack(Stream strm);
		public object Unpack(byte[] buf, int offset, int size);
		public object Unpack(byte[] buf);
		private object Unpack(MsgPackReader reader);
	}
}
