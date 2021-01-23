/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterRenderBase : CommonObjectStatus
	{
		// Fields
		protected FaceType faceType;
		protected CharacterFace face;
		[CompilerGenerated]
		private Renderer[] _allRenderers_k__BackingField;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		protected MaterialPropertyRenderer _mainMaterialPropertyRenderer;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		protected MaterialPropertyRenderer _mouthMaterialPropertyRenderer;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		protected MaterialPropertyRenderer _eyeMaterialPropertyRenderer;
		[ReadOnly]
		[SerializeField]
		[Tooltip]
		protected MaterialPropertyRenderer _weaponMaterialPropertyRenderer;
		[CompilerGenerated]
		private List<MaterialPropertyData> _materialPropertyDataList_k__BackingField;
		[CompilerGenerated]
		private RenderPartsData _renderPartsData_k__BackingField;
	
		// Properties
		public Renderer[] allRenderers { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public MaterialPropertyRenderer mouseMaterialPropertyRenderer { get; }
		public MaterialPropertyRenderer eyeMaterialPropertyRenderer { get; }
		public bool enableMainMaterialPropertyBlock { get; }
		public List<MaterialPropertyData> materialPropertyDataList { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public RenderPartsData renderPartsData { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		public enum FaceType
		{
			NONE = 0,
			NORMAL = 1,
			BLINK = 2,
			DAMAGE = 3,
			DEAD = 4,
			WIN = 5
		}
	
		// Constructors
		public CharacterRenderBase();
	
		// Methods
		public virtual void SetFaceType(FaceType type);
		public virtual void SetMaterialPropertyBlock();
		public void SetCharaColor(bool isStatusColorSet, CharacterColor colorCtrl);
		public virtual void InitializeRenderState(Func<Renderer, bool> entryRendererFunc = null, Action setInitializeRenderStateFunc = null);
		public void SetFaceMaterial(bool force = false);
		protected void SetRenderers(Renderer[] inRenderers);
		protected void UpdateRenderState();
		protected override void Awake();
		public void SetActiveRenderer(bool isActive);
		protected virtual MaterialPropertyData GetMaterialPropertyBlockFromName(string partsName);
		public void SetMpbMixingTextureRatio(string partsName, float ratio);
		public void SetMpbMixingTexture(string partsName, int mainTexID, Texture2D mainTexture, int subTexID, Texture2D subTexture, float ratio, int mainTexSTID, Vector2 scale, Vector2 offset);
		public void SetMpbAuraColorRaito(float ratio);
		public void SetMpbAuraCutoutRaito(float ratio);
		public void SetCharacterMultiColor(Color multiColor);
		public virtual void LateUpdate();
	}
}
