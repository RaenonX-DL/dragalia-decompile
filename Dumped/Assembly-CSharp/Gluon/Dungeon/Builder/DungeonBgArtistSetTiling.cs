/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Builder
{
	public class DungeonBgArtistSetTiling : MonoBehaviour
	{
		// Fields
		public Transform targetTransform;
		public Renderer targetRendeerer;
		private Material targetMaterial;
		[SerializeField]
		private TilingBaseType uType;
		[SerializeField]
		private TilingBaseType vType;
		[SerializeField]
		private TilingOptionData optionData;
	
		// Nested types
		public enum TilingBaseType
		{
			None = 0,
			ScaleX = 1,
			ScaleY = 2,
			ScaleZ = 3
		}
	
		[Serializable]
		public class TilingOptionData
		{
			// Fields
			public bool startOnlyFlag;
			public bool useMaterialScale;
			public Vector2 uvBaseScale;
			public bool useMaterialOffset;
			public Vector2 uvBaseOffset;
			public bool uFlip;
			public bool vFlip;
	
			// Constructors
			public TilingOptionData();
		}
	
		// Constructors
		public DungeonBgArtistSetTiling();
	
		// Methods
		private void Start();
		private void LateUpdate();
		private void InitTiling();
		private void UpdateTiling();
		private float GetTilingParam(TilingBaseType type, Vector3 scale);
	}
}
