using System;
using UnityEngine;

namespace Cute.AssetBundle
{
	public class ScriptableObjectManifest : ScriptableObject
	{
		[Serializable]
		public class Asset
		{
			public string name;

			public string hash;

			public string[] dependencies;

			public int size;

			public int group;

			public string[] assets;
		}

		[Serializable]
		public class RawAsset
		{
			public string name;

			public string hash;

			public int size;

			public int group;
		}

		[Serializable]
		public class Category
		{
			public string name;

			public Asset[] assets;

			public Asset[] encryptedAssets;
		}

		public Category[] categories;

		public RawAsset[] rawAssets;

		public void CopyFrom(ScriptableObjectManifest src)
		{
		}

		public static ScriptableObjectManifest LoadManifest(string manifestSavePath, bool isPrein = false)
		{
			return null;
		}

		public static ScriptableObjectManifest LoadManifest(byte[] bytes)
		{
			return null;
		}
	}
}
