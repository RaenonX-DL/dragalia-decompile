using System;
using UnityEngine;

namespace Gluon
{
	public class UnitViewOffsetAsset : ScriptableObject
	{
		[Serializable]
		public class Dragon3DOffset
		{
			public Vector3 posOffset;

			public Vector3 rotOffset;

			public float scale;
		}

		[Serializable]
		public class Dragon2DOffset
		{
			public Vector2 posOffset;

			public float scale;
		}

		public const string assetBasicPath = "UnitViewOffset/Setting";

		public const string assetPrefix = "unitviewoffset_";

		[SerializeField]
		public Vector2 viewOffset;

		[SerializeField]
		public Dragon2DOffset dragonStrokeViewOffset;

		[SerializeField]
		public Vector2 eyelineOffset;

		[SerializeField]
		public float eyelineScale;

		[SerializeField]
		public Vector2 summonEyelineOffset;

		[SerializeField]
		public Dragon3DOffset dragon3DOffset;

		public static UnitViewOffsetAsset GetViewOffset(int baseId, int varId)
		{
			return null;
		}
	}
}
