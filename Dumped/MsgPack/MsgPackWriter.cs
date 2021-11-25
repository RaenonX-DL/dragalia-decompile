using System.IO;
using System.Text;

namespace MsgPack
{
	public class MsgPackWriter
	{
		private Stream _strm;

		private Encoder _encoder;

		private byte[] _tmp;

		private byte[] _buf;

		public MsgPackWriter(Stream strm)
		{
		}

		public void Write(byte x)
		{
		}

		public void Write(ushort x)
		{
		}

		public void Write(char x)
		{
		}

		public void Write(uint x)
		{
		}

		public void Write(ulong x)
		{
		}

		public void Write(sbyte x)
		{
		}

		public void Write(short x)
		{
		}

		public void Write(int x)
		{
		}

		public void Write(long x)
		{
		}

		public void WriteNil()
		{
		}

		public void Write(bool x)
		{
		}

		public void Write(float x)
		{
		}

		public void Write(double x)
		{
		}

		public void Write(byte[] bytes)
		{
		}

		public void WriteRawHeader(int N)
		{
		}

		public void WriteArrayHeader(int N)
		{
		}

		public void WriteMapHeader(int N)
		{
		}

		private void WriteLengthHeader(int N, int fix_length, byte fix_prefix, byte len16bit_prefix, byte len32bit_prefix)
		{
		}

		public void Write(string x)
		{
		}

		public void Write(string x, bool highProbAscii)
		{
		}

		public void Write(string x, byte[] buf)
		{
		}

		public void Write(string x, byte[] buf, bool highProbAscii)
		{
		}
	}
}
