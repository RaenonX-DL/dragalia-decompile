/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main.Utility;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	public sealed class FlRootManager : FlMonoSingleton<FLATOUT.Main.FlRootManager>
	{
		// Fields
		private string _unityVersion;
		private FlUIManager _uiManager;
		private List<FlRoot> _rootList;
		private Hashtable _rootTable;
		private List<FlRoot> _tempRootList;
		private Hashtable _rootParameterTable;
		private List<FlRootParameter> _tempRootParameterList;
		private Hashtable _meshParameterTable;
		private List<FlMeshParameter> _tempMeshParameterList;
		private Hashtable _planeShaderTable;
		private List<string> _planeShaderPathList;
		private List<FlShaderTypes> _planeShaderTypeList;
		private Hashtable _planeA8ShaderTable;
		private Hashtable _planeNoAlphaTexShaderTable;
		private Hashtable _fontShaderTable;
		private Hashtable _fontIconShaderTable;
		private Hashtable _fontMaterialTable;
		private Hashtable _fontIconMaterialTable;
		private Material _tempMaterial00;
		private Material _tempMaterial01;
		private int _maxLayerCount;
		private List<int> _layerBitFlagList;
		private List<string> _layerNameList;
		private Hashtable _layerTableByBitFlagKey;
		private Hashtable _layerTableByNameKey;
		private List<int> _activeLayerBitFlagList;
		private Hashtable _activeLayerTableByBitFlagKey;
		private List<int> _sortingLayerIndexList;
		private List<string> _sortingLayerNameList;
		private Hashtable _sortingLayerTableByIndexKey;
		private Hashtable _sortingLayerTableByNameKey;
		private Hashtable _gaussianBlurValueTable;
		private FlGlobalData _globalData;
		private bool _existGlobalData;
		private float _screenWidth;
		private float _screenHeight;
		[HideInInspector]
		public float _currentTime;
		private float _prevTime;
		[HideInInspector]
		public float _currentOneFrameTime;
		private int _currentTargetFrameRate;
		private float _prevTargetFrameRate;
		[HideInInspector]
		public float _currentDeltaTime;
		private float _customTimeScale;
		private List<string> _horizontalAxisNameList;
		private List<string> _verticalAxisNameList;
		private List<string> _subumitButtonNameList;
		private List<string> _cancelButtonNameList;
		private bool _useDebugComponent;
		private bool _useDebugLog;
		private static Vector2 _customScreenSize;
	
		// Properties
		public string UnityVersion { get; }
		public FlUIManager UIManager { get; }
		public Hashtable PlaneShadarTable { get; }
		public Hashtable PlaneA8ShadarTable { get; }
		public Hashtable PlaneNoAlphaTexShadarTable { get; }
		public Hashtable FontShadarTable { get; }
		public Hashtable FontIconShadarTable { get; }
		public FlGlobalData GlobalData { get; }
		public bool ExistGlobalData { get; }
		public float ScreenWidth { get; }
		public float ScreenHeight { get; }
		public float CurrentDeltaTime { get; }
		public float CurrentTime { get; }
		public float PrevTime { get; }
		public bool UseDebugComponent { get; }
		public bool UseDebugLog { get; }
		public List<int> LayerBitFlagList { get; }
		public List<string> LayerNameList { get; }
		public List<int> ActiveLayerBitFlagList { get; }
		public List<int> SortingLayerIndexList { get; }
		public List<string> SortingLayerNameList { get; }
	
		// Constructors
		public FlRootManager();
		static FlRootManager();
	
		// Methods
		private void Update();
		public override void _OnInitialize();
		public override void _OnLoaded();
		public override void _OnFinalize();
		public void OptimizeAll();
		public void _AddRoot(FlRoot target);
		public void _RemoveRoot(FlRoot target);
		private bool _ExistRoot(FlRoot target);
		private void _OptimizeRootList();
		public FlRootParameter _GetRootParameter(FlRootParameter rootParameter);
		private void _OptimizeRootParameterTable();
		public FlMeshParameter _GetMeshParameter(FlMeshParameter meshParameter);
		private void _OptimizeMeshParameterTable();
		private void _OptimizeOtherTable();
		private void _CreatePlaneMainShaderTable();
		public Shader _GetPlaneMainShader(FlShaderTypes targetShader = FlShaderTypes.Normal);
		private void _CreatePlaneA8ShaderTable();
		public Shader _GetPlaneA8Shader(FlShaderTypes targetShader = FlShaderTypes.Normal);
		private void _CreatePlaneNoTexAlphaShaderTable();
		public Shader _GetPlaneNoTexAlphaShader(FlShaderTypes targetShader = FlShaderTypes.Normal);
		private void _CreateTextMainShaderTable();
		public Shader _GetTextMainShader(FlShaderTypes targetShader = FlShaderTypes.Normal);
		private void _CreateTextIconShaderTable();
		public Shader _GetTextIconShader(FlShaderTypes targetShader = FlShaderTypes.Normal);
		public Font _GetFont(string fontName);
		public bool _GetFontMaterial(string fontName, FlShaderTypes shaderType, int stencilRef, ref Material fontMaterial);
		private void _CreateFontMaterial(string fontName, FlShaderTypes shaderType, int stencilRef, ref Material fontMaterial);
		public bool _CloneFontMaterial(Material baseFontMaterial, string id, ref Material fontMaterial);
		public void _CloneTextIconMaterialList(string id, FlShaderTypes shaderType, int stencilRef, ref Material[] materialList);
		private bool _GetFontIconMaterial(string fontIconName, FlShaderTypes shaderType, int stencilRef, ref Material fontIconMaterial);
		private void _CreateFontIconMaterial(string fontIconName, FlShaderTypes shaderType, int stencilRef, ref Material fontIconMaterial);
		public bool _CloneFontIconMaterial(Material baseFontIconMaterial, string id, ref Material fontIconMaterial);
		private void _LoadGlobalData();
		public void ReloadLocalizedTarget();
		public void SetLocalizeTaget(string localizeTarget);
		public static void SetCustomScreenSize(Vector2 screenSize);
		private void _UpdateScreenSize();
		public T _GetFlBaseFromGameObject<T>(GameObject targetObject)
			where T : FlBase;
		public int _GetUpdateGroup(int interval);
		public void SetCustomTimeScale(float timeScale);
		public float _GetDefaultLongTouchTime();
		public float _GetKeyInputChangeStartDelayTime();
		public float _GetKeyInputChangeDelayTime();
		public float _GetRayInputSubmitDelay();
		public List<string> _GetHorizontalAxisNameList(int playerIndex);
		public List<string> _GetVerticalAxisNameList(int playerIndex);
		public List<string> _GetSubmitButtonNameList(int playerIndex);
		public List<string> _GetCancelButtonNameList(int playerIndex);
		public int _GetTextSortOderRoundValue();
		public int _GetStencilMaskInterval();
		public int _GetStencilMaskOffset();
		public float _GetBaseScreenWidth();
		public float _GetScrollStartPixel();
		public float _GetScrollSpeedValue();
		public float _GetScrollAccelValue();
		public float _GetScrollIncrementValue();
		private void _UpdateLayerTable();
		public int _GetLayerBitFlag(string layerName);
		public string _GetLayerName(int layerBitFlag);
		private void _AddActiveLayerTable(GameObject gameObject);
		private void _OptimizeActiveLayerTable();
		private void _UpdateSortingLayerTable();
		public int _GetSortingLayerIndex(string sortingLayerName);
		public string _GetSortingLayerName(int sortingLayerIndex);
		public List<float[]> _GetGaussianBlurValue(int quality, int precision);
		public void _LoadEditorSetting();
		private void _UpdateDebugComponent();
	}
}
