using System.Collections.Generic;
using System.IO;

namespace Gluon
{
	public class DeltaCompressionEncoder
	{
		private MemoryStream _stream;

		private BinaryWriter _writer;

		private List<bool> _diffFlagList;

		public bool WriteInteger(int? prev, int next)
		{
			return default(bool);
		}

		public bool WriteByte(byte? prev, byte next)
		{
			return default(bool);
		}

		public bool WriteFloat(float? prev, float next)
		{
			return default(bool);
		}

		public bool WriteBool(bool? prev, bool next)
		{
			return default(bool);
		}

		public bool WriteString(string prev, string next)
		{
			return default(bool);
		}

		public byte[] GetBinary()
		{
			return null;
		}

		public void Clear()
		{
		}

		private void WriteDiffFlag(bool b)
		{
		}
	}
}
