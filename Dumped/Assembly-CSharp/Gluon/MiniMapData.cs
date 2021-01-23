/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.UI;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MiniMapData : MonoBehaviour
	{
		// Fields
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		private MapChipSprite[] _mapChipSprites;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		private AtlasReference[] _atlasReferences;
	
		// Nested types
		[Serializable]
		public struct MapChipSprite
		{
			// Fields
			[Tooltip]
			public string spriteName;
			[Tooltip]
			public SpriteRenderer spriteRenderer;
		}
	
		// Constructors
		public MiniMapData();
	
		// Methods
		private Sprite GetSprite(AtlasReference atlasReference, string name);
		private void Awake();
	}
}
