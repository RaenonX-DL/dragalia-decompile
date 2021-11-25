using Cute.Core;

namespace Cute.AssetBundle
{
	[ProjectPrefsAttr("AssetBundleCryptKey", "AssetBundleæ\u009a\u0097å\u008f·å\u008c\u0096ã\u0082­ã\u0083¼", "[AssetBundle]")]
	[ProjectPrefsAttr("AssetBundleCryptIV", "AssetBundleæ\u009a\u0097å\u008f·å\u008c\u0096å\u0088\u009dæ\u009c\u009få\u008c\u0096ã\u0083\u0099ã\u0082\u00afã\u0083\u0088ã\u0083«", "[AssetBundle]")]
	public static class DefaultEncryption
	{
		public const string AssetBundleCryptKey = "AssetBundleCryptKey";

		public const string AssetBundleCryptIV = "AssetBundleCryptIV";

		public static byte[] Encrypt(byte[] src)
		{
			return null;
		}

		public static byte[] Decrypt(byte[] src)
		{
			return null;
		}
	}
}
