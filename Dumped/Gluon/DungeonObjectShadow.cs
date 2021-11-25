using System;
using UnityEngine;

namespace Gluon
{
	public class DungeonObjectShadow
	{
		public enum BrightnessType
		{
			None = -1,
			Hard,
			Middle,
			Soft
		}

		[Serializable]
		public class ShadowData
		{
			public BrightnessType brightness;

			public float witdh;

			public float depth;

			public float rotate;

			public float orthographicSize;
		}

		private static readonly string[] shadowPrefabAssetsNames;

		private GameObject[] _objectShadowTable;

		public void Initialize()
		{
		}

		public GameObject GetShadowObject(BrightnessType brightness)
		{
			return null;
		}
	}
}
