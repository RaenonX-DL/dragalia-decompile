using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace MsgPack
{
	public class MsgPackReader
	{
		private Stream _strm;

		private byte[] _tmp0;

		private byte[] _tmp1;

		private Encoding _encoding;

		private byte[] _buf;

		public TypePrefixes Type
		{
			[CompilerGenerated]
			get
			{
				return default(TypePrefixes);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool ValueBoolean
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public uint Length
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public uint ValueUnsigned
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ulong ValueUnsigned64
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int ValueSigned
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long ValueSigned64
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float ValueFloat
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public double ValueDouble
		{
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MsgPackReader(Stream strm)
		{
		}

		public bool IsSigned()
		{
			return default(bool);
		}

		public bool IsBoolean()
		{
			return default(bool);
		}

		public bool IsSigned64()
		{
			return default(bool);
		}

		public bool IsUnsigned()
		{
			return default(bool);
		}

		public bool IsUnsigned64()
		{
			return default(bool);
		}

		public bool IsRaw()
		{
			return default(bool);
		}

		public bool IsArray()
		{
			return default(bool);
		}

		public bool IsMap()
		{
			return default(bool);
		}

		public bool Read()
		{
			return default(bool);
		}

		public int ReadValueRaw(byte[] buf, int offset, int count)
		{
			return default(int);
		}

		public string ReadRawString()
		{
			return null;
		}

		public string ReadRawString(byte[] buf)
		{
			return null;
		}
	}
}
