using System;
using System.Collections.Generic;
using System.IO;

namespace MsgPack
{
	public class ObjectPacker
	{
		private delegate void PackDelegate(ObjectPacker packer, MsgPackWriter writer, object o);

		private delegate object UnpackDelegate(ObjectPacker packer, MsgPackReader reader);

		private byte[] _buf;

		private static Dictionary<Type, PackDelegate> PackerMapping;

		private static Dictionary<Type, UnpackDelegate> UnpackerMapping;

		private bool debugFlag;

		public static string currentFieldName;

		static ObjectPacker()
		{
		}

		public byte[] Pack(object o)
		{
			return null;
		}

		public void Pack(Stream strm, object o)
		{
		}

		private void Pack(MsgPackWriter writer, object o)
		{
		}

		public T Unpack<T>(byte[] buf)
		{
			return (T)null;
		}

		public T Unpack<T>(byte[] buf, int offset, int size)
		{
			return (T)null;
		}

		public T Unpack<T>(Stream strm)
		{
			return (T)null;
		}

		public object Unpack(Type type, byte[] buf)
		{
			return null;
		}

		public object Unpack(Type type, byte[] buf, int offset, int size)
		{
			return null;
		}

		public object Unpack(Type type, Stream strm)
		{
			return null;
		}

		private bool IsEmptyArray(MsgPackReader reader)
		{
			return default(bool);
		}

		private void SkipValue(MsgPackReader reader)
		{
		}

		private object Unpack(MsgPackReader reader, Type t)
		{
			return null;
		}

		private void CheckBufferSize(int size)
		{
		}

		private static void StringPacker(ObjectPacker packer, MsgPackWriter writer, object o)
		{
		}

		private static object StringUnpacker(ObjectPacker packer, MsgPackReader reader)
		{
			return null;
		}
	}
}
