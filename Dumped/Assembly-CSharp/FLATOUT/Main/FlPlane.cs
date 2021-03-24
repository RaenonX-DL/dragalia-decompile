/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main.Utility;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	public class FlPlane : FlObjectBase
	{
		// Fields
		private FlPlaneParameter _planeParam;
		private bool _existMesh;
		private MeshRenderer _meshRenderer;
		private MeshFilter _meshFilter;
		private FlMeshInfoParameter[] _meshParamList;
		private FlMeshTypes[] _meshTypeList;
		private Mesh[] _meshList;
		private int _currentMeshIndex;
		private int _prevMeshIndex;
		private int _meshKeyIndex;
		private Material _currentMaterial;
		private Material _outerMaterial;
		private Material[] _currentMaterialList;
		private int[] _currentMaterialIDList;
		private bool _isCurrentMaterialShared;
		private Material _tempMaterial;
		private int _prevMaterialID;
		private Vector3[][] _vertexPositionListGroup;
		private Vector2[] _uvColorInfoList;
		private Vector2[] _uvAlphaInfoList;
		private Vector2 _currentUvColorAnimation;
		private Vector2 _currentUvAlphaAnimation;
		private Vector2 _prevUvColorAnimation;
		private Vector2 _prevUvAlphaAnimation;
		private bool _uvColorChanged;
		private bool _uvAlphaChanged;
		private bool _uvChanged;
		private bool _meshIndexChanged;
		private Color[] _vertexColorList;
		private Color[] _currentVertexColorList;
		private Vector2[] _currentVertexColorOffsetList0;
		private Vector2[] _currentVertexColorOffsetList1;
		private Texture _outerTextureColor;
		private Texture _outerTextureAlpha;
		private int _outerTextureColorID;
		private int _outerTextureAlphaID;
		private int _prevOuterTextureColorID;
		private int _prevOuterTextureAlphaID;
		private FlTextureTypes _outerTextureType;
		private FlTextureTypes _prevOuterTextureType;
		private Vector3[] _outerTextureVertexPositionList;
		private Vector2 _outerTextureScale;
		private Vector3 _outerTextureOffset;
		private bool _outerTextureKeepSize;
		private bool _outerTextureKeepCenter;
		private FlFillType _fillType;
		private float _currentFillValue;
		private float _prevFillValue;
		private bool _changeFillValue;
		private Vector3 _tempVector0;
		private Vector3 _tempVector1;
		private bool _isUguiGraphic;
		private bool _isGraphicChanged;
		private FlUguiGraphic _uGuiGraphic;
		private readonly int _MainTex;
		private readonly int _AlphaTex;
		private readonly int _MaskTex;
	
		// Properties
		public FlPlaneParameter PlaneParameter { get; }
		public MeshRenderer MeshRenderer { get; }
		public MeshFilter MeshFilter { get; }
		public Mesh[] MeshList { get; }
		public Vector2[] UVColorInfoList { get; }
		public Vector2[] UVAlphaInfoList { get; }
		public Color[] VertexColorList { get; }
		public float FillValue { get; }
		public FlFillType FillType { get; }
	
		// Constructors
		public FlPlane(GameObject gameObject);
	
		// Methods
		public override void _CreateEditorData(FlObjectParameterBase parameter, FlMotion parentMotion);
		public override void _ApplyData(FlObjectParameterBase parameter, FlMotion parentMotion);
		public override void _CreateData();
		private void _CreateMeshAndMaterialList();
		private void _CreateUVList();
		private void _CreateVertexColorList();
		public override void _FixData();
		private void _SetMaterial();
		private void _SetParameterToMaterial();
		private void _SetUVParameter();
		private void _SetBlurParameter();
		private bool _IsDefaultUVList(Vector2[] uvList);
		public override void _UpdateFirst();
		private void _UpdateFirstUiGraphic();
		public override void _UpdateSecond();
		protected override void _UpdateColor();
		private void _UpdatePlane();
		private void _UpdateMeshIndex();
		private void _UpdateCurrentMaterialList();
		private void _UpdateCurrentMaterial();
		private void _UpdateVertexColor();
		private void _UpdateVertexPosition();
		private void _UpdateUVParameter();
		private void _UpdateBlurParameter();
		private void _UpdateMeshRendererMaterial();
		private void _UpdateMesh();
		public override void _ResetTime();
		private void _UpdateEnableRenderer(bool enable);
		protected override void _UpdateSortOrder();
		protected override void _UpdateSortLayer();
		protected override void _UpdateStencilRefBase();
		protected override void _SetGrayscaleBase(bool enable);
		public void SetUV(Vector2 value, FlUVValueTypes target, bool alpha, bool updateMaterial = true);
		public void SetVertexColor(int index, Color color);
		public void SetOuterTexture(Texture colorTexture, Texture alphaTexture, bool keepUV = false, bool keepSize = true, float width = 0f, float height = 0f, float offsetX = 0f, float offsetY = 0f, bool keepCenter = false, float uvSizeX = 1f, float uvSizeY = 1f, float uvOffsetX = 0f, float uvOffsetY = 0f);
		public void ReplaceMaterial(Material replaceMat);
		public void ReplaceMaterialShader(Material[] assetMatList, string[] replaceNameList);
		public void SetOuterSprite(Material material, Sprite sprite = null, bool useFlashShader = true, Texture colorTexture = null, Texture alphaTexture = null, bool isSetSize = true, bool isSetUV = true);
		public void SetOuterTextureOffset(Vector3 offset);
		public void SetFill(float fillValue, FlFillType fillType);
		public override void SetBlurQuality(int blurQuality, int blurPrecision, bool affectChildren);
		public void ConvertToQuadGraphic(Texture edgeMaskTex = null, bool isPreConverted = false);
		public void SetUiGraphicVertexColor(int index, Color color);
		public void UpdateUiGraphic();
		private void _UpdateUiGraphicVertexColor();
		private void _UpdateUiGraphicVertexPosition();
		private void _UpdateUiGraphicUVParameter();
		public void ResetOuterMaterial();
	}
}
