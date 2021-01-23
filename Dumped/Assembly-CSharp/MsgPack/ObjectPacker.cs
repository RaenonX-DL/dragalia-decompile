/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MsgPack
{
	public class ObjectPacker
	{
		// Fields
		private byte[] _buf;
		private static Dictionary<Type, PackDelegate> PackerMapping;
		private static Dictionary<Type, UnpackDelegate> UnpackerMapping;
		private bool debugFlag;
		public static string currentFieldName;
	
		// Nested types
		private delegate void PackDelegate(ObjectPacker packer, MsgPackWriter writer, object o);
	
		private delegate object UnpackDelegate(ObjectPacker packer, MsgPackReader reader);
	
		// Constructors
		static ObjectPacker();
		public ObjectPacker();
	
		// Methods
		public byte[] Pack(object o);
		public void Pack(Stream strm, object o);
		private void Pack(MsgPackWriter writer, object o);
		public T Unpack<T>(byte[] buf);
		public T Unpack<T>(byte[] buf, int offset, int size);
		public T Unpack<T>(Stream strm);
		public object Unpack(Type type, byte[] buf);
		public object Unpack(Type type, byte[] buf, int offset, int size);
		public object Unpack(Type type, Stream strm);
		private bool IsEmptyArray(MsgPackReader reader);
		private void SkipValue(MsgPackReader reader);
		private object Unpack(MsgPackReader reader, Type t);
		private void CheckBufferSize(int size);
		private static void StringPacker(ObjectPacker packer, MsgPackWriter writer, object o);
		private static object StringUnpacker(ObjectPacker packer, MsgPackReader reader);
	}
}
