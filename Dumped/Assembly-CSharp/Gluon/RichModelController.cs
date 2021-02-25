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
	public class RichModelController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private RichGraphicData _richGraphicData;
		[CompilerGenerated]
		private GameObject _rootObject_k__BackingField;
		[CompilerGenerated]
		private Renderer[] _renderers_k__BackingField;
		private List<Material> _materialList;
		private Transform _cacheTransform;
	
		// Properties
		public RichGraphicData richGraphicData { get; }
		public GameObject rootObject { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Renderer[] renderers { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		public class MultiMaskData
		{
			// Fields
			public static readonly string allMaterialName;
			[Tooltip]
			public string materialName;
			[Tooltip]
			public Texture2D multiMask;
	
			// Constructors
			public MultiMaskData();
			static MultiMaskData();
		}
	
		[Serializable]
		public class ToonShadingData : IShaderData<ToonShadingData>
		{
			// Fields
			[Tooltip]
			public bool enable;
			[Tooltip]
			public Color toonShadowColor;
			[Tooltip]
			public HSVParameterBase toonShadowHSV;
			[Tooltip]
			public bool overwriteShadowEdge;
			[Tooltip]
			public HSVParameterBase shadowEdgeHSV;
			[Tooltip]
			public MultiMaskData[] multiMaskDataArray;
	
			// Constructors
			public ToonShadingData();
	
			// Methods
			public void Copy(ToonShadingData src);
		}
	
		[Serializable]
		public class OutlineData : IShaderData<OutlineData>
		{
			// Fields
			[Tooltip]
			public bool enable;
			[Tooltip]
			public Color color;
			[Tooltip]
			public Color addColor;
			[Range]
			[Tooltip]
			public float addColorPower;
			[Tooltip]
			public float width;
	
			// Constructors
			public OutlineData();
	
			// Methods
			public void Copy(OutlineData src);
		}
	
		[Serializable]
		public class RichGraphicData : IShaderData<RichGraphicData>
		{
			// Fields
			[Tooltip]
			public ToonShadingData toonShadingData;
			[Tooltip]
			public OutlineData outlineData;
	
			// Constructors
			public RichGraphicData();
	
			// Methods
			public void Copy(RichGraphicData src);
		}
	
		// Constructors
		public RichModelController();
	
		// Methods
		private void Awake();
		private void Start();
		protected virtual void Update();
		private void SetMaterialParameter();
		public void SetupToonShading(GameObject obj, ShaderLodDataObject shaderLodDataObject = null);
		private void LateUpdate();
	}
}
