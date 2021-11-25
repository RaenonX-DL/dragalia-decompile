using Cute.Core;

namespace Cute.AssetBundle
{
	[ProjectPrefsAttr("RawAssetRootDirectory", "ã\u0083\u0080ã\u0082¦ã\u0083³ã\u0083­ã\u0083¼ã\u0083\u0089å\u00af¾è±¡ã\u0083\u0095ã\u0082¡ã\u0082¤ã\u0083«ç\u0094\u00a8ã\u0083\u0087ã\u0082£ã\u0083¬ã\u0082\u00afã\u0083\u0088ã\u0083ª", "[AssetBundle]")]
	[ProjectPrefsAttr("RawAssetVariantDirectory", "ã\u0083\u0080ã\u0082¦ã\u0083³ã\u0083­ã\u0083¼ã\u0083\u0089å\u00af¾è±¡ã\u0083\u0095ã\u0082¡ã\u0082¤ã\u0083«ã\u0081®variantã\u0083\u0087ã\u0082£ã\u0083¬ã\u0082\u00afã\u0083\u0088ã\u0083ª", "[AssetBundle]")]
	public static class RawAssetManager
	{
		public const string RawAssetRootDirectory = "RawAssetRootDirectory";

		public const string RawAssetVariantDirectory = "RawAssetVariantDirectory";

		public static string GetPath(string filename)
		{
			return null;
		}

		public static string GetPath(string filename, out bool isPrein)
		{
			return null;
		}
	}
}
