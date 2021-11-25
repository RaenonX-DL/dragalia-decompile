using System;
using System.IO;
using System.Text;

namespace MsgPack
{
	public class BoxingPacker
	{
		private static Type KeyValuePairDefinitionType;

		private static UTF8Encoding utf8enc;

		static BoxingPacker()
		{
		}

		public void Pack(Stream strm, object o)
		{
		}

		public byte[] Pack(object o)
		{
			return null;
		}

		private void Pack(MsgPackWriter writer, object o)
		{
		}

		public object Unpack(Stream strm)
		{
			return null;
		}

		public object Unpack(byte[] buf, int offset, int size)
		{
			return null;
		}

		public object Unpack(byte[] buf)
		{
			return null;
		}

		private object Unpack(MsgPackReader reader)
		{
			return null;
		}
	}
}
