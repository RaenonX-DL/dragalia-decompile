using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cute.AssetBundle
{
	public static class AssetBundleCreator
	{
		public static Func<byte[], byte[]> DecryptMethod
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static UnityEngine.AssetBundle LoadManifest(string path, bool isPrein = false)
		{
			return null;
		}

		public static UnityEngine.AssetBundle LoadManifest(byte[] src)
		{
			return null;
		}

		public static void SaveManifestWithHash(byte[] bytes, string outputManifestPath)
		{
		}

		public static UnityEngine.AssetBundle LoadAssetBundle(string path, bool isEncrypted, bool isPrein = false)
		{
			return null;
		}

		public static AssetBundleCreateRequest LoadAssetBundleAsync(string path, bool isEncrypted, bool isPrein = false)
		{
			return null;
		}

		public static byte[] ReadFileData(string path, bool isPrein)
		{
			return null;
		}

		private static bool Equal(byte[] left, byte[] right)
		{
			return default(bool);
		}
	}
}
