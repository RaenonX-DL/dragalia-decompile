/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryBackgroundBillboard : MonoBehaviour
	{
		// Fields
		public Tweener currentTween;
		[SerializeField]
		public MeshFilter meshFilter;
		[SerializeField]
		public MeshRenderer meshRenderer;
		[SerializeField]
		public TextureScroll textureScroll;
		private bool completeVisible;
		private Vector2 completePosition;
		public float initPosZ;
		public static float posOffsetY;
		public string layerName;
		public string assetName;
		public Vector2[] defaultUVs;
		private Material defaultMaterial;
		public const int scrollDataMainIndex = 0;
		public Vector2 offsetUV;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public Vector3 basePos;
			public Vector3 moveTo;
			public StoryBackgroundBillboard __4__this;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _SetMoveToPos_b__0(float fade);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static TweenCallback __9__16_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SetMoveToPos_b__16_1();
		}
	
		// Constructors
		public StoryBackgroundBillboard();
		static StoryBackgroundBillboard();
	
		// Methods
		private void Awake();
		public void SetDefault();
		public void SetMoveToPos(Vector3 moveTo, float sec, Ease ease = Ease.Linear);
		public void SetBackgroundLayerData(BackgroundImageLayerObject.BackgroundImageLayer layerData, string assetName);
		public DifferenceImageController.MaterialParameter GetCharaColorParameter();
		public void SetCompleteData();
		public void SetPosition(Vector2 pos);
		public void SetVisible(bool visible);
		private void OnDestroy();
	}
}
