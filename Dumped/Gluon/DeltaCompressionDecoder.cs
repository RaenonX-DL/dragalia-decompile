namespace Gluon
{
	public class DeltaCompressionDecoder
	{
		private byte[] _bytes;

		private int _nextByteIndex;

		private int _nextDiffFlagBitIndex;

		private int _diffFlagLength;

		public void SetBinary(byte[] bytes)
		{
		}

		public bool ReadInteger(int? prev, out int result)
		{
			return default(bool);
		}

		public bool ReadByte(byte? prev, out byte result)
		{
			return default(bool);
		}

		public bool ReadFloat(float? prev, out float result)
		{
			return default(bool);
		}

		public bool ReadBool(bool? prev, out bool result)
		{
			return default(bool);
		}

		public bool ReadString(string prev, out string result)
		{
			return default(bool);
		}

		private bool ReadDiffFlag(out bool result)
		{
			return default(bool);
		}
	}
}
