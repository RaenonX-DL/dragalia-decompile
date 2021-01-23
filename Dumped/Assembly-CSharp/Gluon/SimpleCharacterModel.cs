/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cutt;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SimpleCharacterModel : MonoBehaviour
	{
		// Fields
		private Renderer[] renderers;
		private MaterialPropertyBlock materialPropertyBlock;
		public Transform weaponNodeR;
		public Transform weaponNodeL;
		public Transform modelCenter;
		private bool renderDestroyFlg;
		public bool isDummyModel;
		private CuttCharacterFaceData faceData;
		private Material[] facialMaterials;
		private SimpleCharacterFacialControlInterface[] facialControls;
		public const int cuttDefaultTextureIndexEye = 0;
		public const int cuttDefaultTextureIndexMouth = 0;
	
		// Properties
		public bool isBlinkEnabled { get; set; }
		public bool isMouthAnimationEnabled { get; set; }
	
		// Nested types
		public enum FacialControlKind
		{
			NotAvailable = -1,
			Eye = 0,
			Mouth = 1,
			Nof = 2
		}
	
		public enum ShadowCastMethod
		{
			TexturedQuad = 0,
			TextureProjection = 1,
			MaxNum = 2
		}
	
		[CompilerGenerated]
		private sealed class _GetRenderersDelay_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SimpleCharacterModel __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetRenderersDelay_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SimpleCharacterModel();
	
		// Methods
		public bool IsFacialControlEnabled(FacialControlKind kind);
		public void SetFacialControlEnabled(FacialControlKind kind, bool f);
		public void SetTriggerToFacialControl(FacialControlKind kind, string triggerName);
		public void SetCharaFace(CharaFaceEye eye, CharaFaceMouth mouth);
		private void Awake();
		public void DestroyWeapon();
		[IteratorStateMachine]
		private IEnumerator GetRenderersDelay();
		public void SetupDefaultFacialTexture();
		public void SetDefaultFacialAnimation();
		public void SetupFacialMaterials();
		private Material GetInstantiatedMaterialByName(string materialNamePrefix);
		public void SetFacialTextureByIndex(FacialControlKind kind, int cuttTextureIndex);
		public void SetFacialTextureOffset(FacialControlKind kind, Vector2 offset);
		private void SetDefaultBlinkAnimation(bool isPlay);
		private void SetDefaultMouthAnimation(bool isPlay);
		public void SetFacialControl(FacialControlKind kind, SimpleCharacterFacialControlInterface control, bool isPlay = true);
		public void SetColor(Color color);
		private void LateUpdate();
		public static Transform FindOptimizedChildTransform(Transform parent, string path);
	}
}
