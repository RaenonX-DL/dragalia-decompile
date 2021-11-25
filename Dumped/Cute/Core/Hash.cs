namespace Cute.Core
{
	public static class Hash
	{
		public enum EncodeType
		{
			Base32,
			Base64,
			Hex,
			Base32NoPadding
		}

		public static string ComputeSha1Hash(string input, EncodeType encoding = EncodeType.Base32)
		{
			return null;
		}

		public static string ComputeMd5Hash(string input, EncodeType encoding = EncodeType.Base32)
		{
			return null;
		}

		public static string ComputeSha256Hash(string input, EncodeType encoding = EncodeType.Base32)
		{
			return null;
		}

		public static string ComputeSha256Hash(byte[] input, EncodeType encoding = EncodeType.Base32)
		{
			return null;
		}

		public static string ComputeMd5HashOfFile(string path, EncodeType encoding = EncodeType.Base32)
		{
			return null;
		}

		public static string ComputeSha256HashOfFile(string path, EncodeType encoding = EncodeType.Base32)
		{
			return null;
		}

		public static string ToHexString(byte[] src)
		{
			return null;
		}

		private static string Encode(byte[] src, EncodeType encoding)
		{
			return null;
		}
	}
}
