using System;
using UnityEngine;

namespace Gluon.Dungeon.Builder
{
	public class DungeonBgArtistSetTiling : MonoBehaviour
	{
		public enum TilingBaseType
		{
			None,
			ScaleX,
			ScaleY,
			ScaleZ
		}

		[Serializable]
		public class TilingOptionData
		{
			public bool startOnlyFlag;

			public bool useMaterialScale;

			public Vector2 uvBaseScale;

			public bool useMaterialOffset;

			public Vector2 uvBaseOffset;

			public bool uFlip;

			public bool vFlip;
		}

		public Transform targetTransform;

		public Renderer targetRendeerer;

		private Material targetMaterial;

		[SerializeField]
		private TilingBaseType uType;

		[SerializeField]
		private TilingBaseType vType;

		[SerializeField]
		private TilingOptionData optionData;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void InitTiling()
		{
		}

		private void UpdateTiling()
		{
		}

		private float GetTilingParam(TilingBaseType type, Vector3 scale)
		{
			return default(float);
		}
	}
}
