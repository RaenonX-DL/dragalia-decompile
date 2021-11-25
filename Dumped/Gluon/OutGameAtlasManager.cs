using System.Collections.Generic;
using Cute.UI;
using UnityEngine;

namespace Gluon
{
	public class OutGameAtlasManager : MonoBehaviour
	{
		private static OutGameAtlasManager _instance;

		private Dictionary<string, Atlas> spriteCacheOld;

		private Dictionary<string, AtlasReference> spriteCache;

		public static OutGameAtlasManager instance => null;

		public static bool hasInstance => default(bool);

		public Sprite GetSpriteOld(string atlasPath, string spriteName)
		{
			return null;
		}

		public Sprite GetSprite(string atlasPath, string spriteName)
		{
			return null;
		}

		public Material GetMaterial(string atlasPath)
		{
			return null;
		}

		public void Clear()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
