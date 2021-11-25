using System.Collections;
using System.Collections.Generic;
using FLATOUT.Main.Utility;
using UnityEngine;

namespace FLATOUT.Main
{
	public sealed class FlRootManager : FlMonoSingleton<FlRootManager>
	{
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

		public string UnityVersion => null;

		public FlUIManager UIManager => null;

		public Hashtable PlaneShadarTable => null;

		public Hashtable PlaneA8ShadarTable => null;

		public Hashtable PlaneNoAlphaTexShadarTable => null;

		public Hashtable FontShadarTable => null;

		public Hashtable FontIconShadarTable => null;

		public FlGlobalData GlobalData => null;

		public bool ExistGlobalData => default(bool);

		public float ScreenWidth => default(float);

		public float ScreenHeight => default(float);

		public float CurrentDeltaTime => default(float);

		public float CurrentTime => default(float);

		public float PrevTime => default(float);

		public bool UseDebugComponent => default(bool);

		public bool UseDebugLog => default(bool);

		public List<int> LayerBitFlagList => null;

		public List<string> LayerNameList => null;

		public List<int> ActiveLayerBitFlagList => null;

		public List<int> SortingLayerIndexList => null;

		public List<string> SortingLayerNameList => null;

		private void Update()
		{
		}

		public override void _OnInitialize()
		{
		}

		public override void _OnLoaded()
		{
		}

		public override void _OnFinalize()
		{
		}

		public void OptimizeAll()
		{
		}

		public void _AddRoot(FlRoot target)
		{
		}

		public void _RemoveRoot(FlRoot target)
		{
		}

		private bool _ExistRoot(FlRoot target)
		{
			return default(bool);
		}

		private void _OptimizeRootList()
		{
		}

		public FlRootParameter _GetRootParameter(FlRootParameter rootParameter)
		{
			return null;
		}

		private void _OptimizeRootParameterTable()
		{
		}

		public FlMeshParameter _GetMeshParameter(FlMeshParameter meshParameter)
		{
			return null;
		}

		private void _OptimizeMeshParameterTable()
		{
		}

		private void _OptimizeOtherTable()
		{
		}

		private void _CreatePlaneMainShaderTable()
		{
		}

		public Shader _GetPlaneMainShader(FlShaderTypes targetShader = FlShaderTypes.Normal)
		{
			return null;
		}

		private void _CreatePlaneA8ShaderTable()
		{
		}

		public Shader _GetPlaneA8Shader(FlShaderTypes targetShader = FlShaderTypes.Normal)
		{
			return null;
		}

		private void _CreatePlaneNoTexAlphaShaderTable()
		{
		}

		public Shader _GetPlaneNoTexAlphaShader(FlShaderTypes targetShader = FlShaderTypes.Normal)
		{
			return null;
		}

		private void _CreateTextMainShaderTable()
		{
		}

		public Shader _GetTextMainShader(FlShaderTypes targetShader = FlShaderTypes.Normal)
		{
			return null;
		}

		private void _CreateTextIconShaderTable()
		{
		}

		public Shader _GetTextIconShader(FlShaderTypes targetShader = FlShaderTypes.Normal)
		{
			return null;
		}

		public Font _GetFont(string fontName)
		{
			return null;
		}

		public bool _GetFontMaterial(string fontName, FlShaderTypes shaderType, int stencilRef, ref Material fontMaterial)
		{
			return default(bool);
		}

		private void _CreateFontMaterial(string fontName, FlShaderTypes shaderType, int stencilRef, ref Material fontMaterial)
		{
		}

		public bool _CloneFontMaterial(Material baseFontMaterial, string id, ref Material fontMaterial)
		{
			return default(bool);
		}

		public void _CloneTextIconMaterialList(string id, FlShaderTypes shaderType, int stencilRef, ref Material[] materialList)
		{
		}

		private bool _GetFontIconMaterial(string fontIconName, FlShaderTypes shaderType, int stencilRef, ref Material fontIconMaterial)
		{
			return default(bool);
		}

		private void _CreateFontIconMaterial(string fontIconName, FlShaderTypes shaderType, int stencilRef, ref Material fontIconMaterial)
		{
		}

		public bool _CloneFontIconMaterial(Material baseFontIconMaterial, string id, ref Material fontIconMaterial)
		{
			return default(bool);
		}

		private void _LoadGlobalData()
		{
		}

		public void ReloadLocalizedTarget()
		{
		}

		public void SetLocalizeTaget(string localizeTarget)
		{
		}

		public static void SetCustomScreenSize(Vector2 screenSize)
		{
		}

		private void _UpdateScreenSize()
		{
		}

		public T _GetFlBaseFromGameObject<T>(GameObject targetObject) where T : FlBase
		{
			return null;
		}

		public int _GetUpdateGroup(int interval)
		{
			return default(int);
		}

		public void SetCustomTimeScale(float timeScale)
		{
		}

		public float _GetDefaultLongTouchTime()
		{
			return default(float);
		}

		public float _GetKeyInputChangeStartDelayTime()
		{
			return default(float);
		}

		public float _GetKeyInputChangeDelayTime()
		{
			return default(float);
		}

		public float _GetRayInputSubmitDelay()
		{
			return default(float);
		}

		public List<string> _GetHorizontalAxisNameList(int playerIndex)
		{
			return null;
		}

		public List<string> _GetVerticalAxisNameList(int playerIndex)
		{
			return null;
		}

		public List<string> _GetSubmitButtonNameList(int playerIndex)
		{
			return null;
		}

		public List<string> _GetCancelButtonNameList(int playerIndex)
		{
			return null;
		}

		public int _GetTextSortOderRoundValue()
		{
			return default(int);
		}

		public int _GetStencilMaskInterval()
		{
			return default(int);
		}

		public int _GetStencilMaskOffset()
		{
			return default(int);
		}

		public float _GetBaseScreenWidth()
		{
			return default(float);
		}

		public float _GetScrollStartPixel()
		{
			return default(float);
		}

		public float _GetScrollSpeedValue()
		{
			return default(float);
		}

		public float _GetScrollAccelValue()
		{
			return default(float);
		}

		public float _GetScrollIncrementValue()
		{
			return default(float);
		}

		private void _UpdateLayerTable()
		{
		}

		public int _GetLayerBitFlag(string layerName)
		{
			return default(int);
		}

		public string _GetLayerName(int layerBitFlag)
		{
			return null;
		}

		private void _AddActiveLayerTable(GameObject gameObject)
		{
		}

		private void _OptimizeActiveLayerTable()
		{
		}

		private void _UpdateSortingLayerTable()
		{
		}

		public int _GetSortingLayerIndex(string sortingLayerName)
		{
			return default(int);
		}

		public string _GetSortingLayerName(int sortingLayerIndex)
		{
			return null;
		}

		public List<float[]> _GetGaussianBlurValue(int quality, int precision)
		{
			return null;
		}

		public void _LoadEditorSetting()
		{
		}

		private void _UpdateDebugComponent()
		{
		}
	}
}
