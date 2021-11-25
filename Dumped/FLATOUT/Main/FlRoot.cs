using System;
using System.Collections;
using System.Collections.Generic;
using FLATOUT.Main.Utility;
using UnityEngine;

namespace FLATOUT.Main
{
	public class FlRoot : FlMonoBehaviour
	{
		public FlRootParameter _parameter;

		public FlMeshParameterGroup _meshParameterGroup;

		public bool isPreConverted;

		public bool dontRecreateEditorData;

		private FlMotion _rootMotion;

		private List<FlBase> _dataList;

		private List<FlMotion> _motionList;

		private List<FlObjectBase> _objectList;

		private List<FlBase> _finalizeTargetDataList;

		private int _currentCreateDataIndex;

		private Hashtable _dataTable;

		private Hashtable _meshRendererTable;

		private Hashtable _meshFilterTable;

		private Hashtable _colliderTable;

		private Hashtable _textMeshTable;

		private GameObject _topObject;

		[NonSerialized]
		public bool _initializeFlag;

		private bool _isDestory;

		private int _sortOrderInterval;

		private int _sortOrderCount;

		private int _sortOderCountForDrawTextLater;

		private int _defaultSortOffset;

		private int _defaultStencilRefOffset;

		private int _stencilRefInterval;

		private int _stencilRefCount;

		private float _defaultDepthOffset;

		private float _defaultScaleOffset;

		private float _defaultColliderThickness;

		private bool _drawTextLater;

		private Vector3 _screenRightWorldPosition;

		private Vector3 _screenLeftWorldPosition;

		private Vector3 _currentScreenRightWorldPosition;

		private Vector3 _currentScreenLeftWorldPosition;

		private Vector2 _currentScreenSize;

		private Vector2 _prevScreenSize;

		private float _currentScreenScale;

		private float _screenScale;

		private bool _screenSizeChanged;

		private bool _aspectChanged;

		[NonSerialized]
		public float _deltaTime;

		[NonSerialized]
		public float _syncTime;

		private bool _useCustomSyncTime;

		private float _customSyncTime;

		private bool _useCustomDeltaTime;

		private float _customDeltaTime;

		private int _updateInterval;

		private int _updateGroup;

		private int _currentUpdateState;

		public FlRootParameter Parameter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FlMeshParameterGroup MeshParameterGroup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject TopObject => null;

		public FlMotion RootMotion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlBase> DataList => null;

		public List<FlMotion> MotionList => null;

		public List<FlObjectBase> ObjectList => null;

		public List<FlBase> FinalizeTargetDataList => null;

		public int SortOrderCount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int SortOrderCountForDrawTextLater
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int SortOrderInterval => default(int);

		public int DefaultSortOffset => default(int);

		public int DefaultStencilRefOffset => default(int);

		public int StencilRefInterval => default(int);

		public int StencilRefCount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float DefaultDepthOffset => default(float);

		public float DefaultColliderThickness => default(float);

		public bool DrawTextLater => default(bool);

		public Hashtable DataTable => null;

		public Hashtable MeshRendererTable => null;

		public Hashtable MeshFilterTable => null;

		public Hashtable ColliderTable => null;

		public Hashtable TextMeshTable => null;

		public float DeltaTime => default(float);

		public float CustomDeltaTime => default(float);

		public bool UseCustomDeltaTime => default(bool);

		public float SyncTime => default(float);

		public float CustomSyncTime => default(float);

		public bool UseCustomSyncTime => default(bool);

		public int UpdateInterval => default(int);

		public int UpdateGroup => default(int);

		public Vector3 ScreenRightWorldPosition => default(Vector3);

		public Vector3 ScreenLeftWorldPosition => default(Vector3);

		public Vector3 CurrentScreenRightWorldPosition => default(Vector3);

		public Vector3 CurrentScreenLeftWorldPosition => default(Vector3);

		public bool AspectChanged => default(bool);

		public bool ScreenSizeChanged => default(bool);

		public float ScreenScale => default(float);

		public float CurrentScreenScale => default(float);

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void _Initialize()
		{
		}

		private void _UpdateInitialize()
		{
		}

		private void _Initialize_PostProcess()
		{
		}

		private void _BootManager()
		{
		}

		private void _CreateHierarchy()
		{
		}

		private void _CreateMeshRendererTable()
		{
		}

		private void _CreateMeshFilterTable()
		{
		}

		private void _CreateColliderTable()
		{
		}

		private void _CreateTextMeshTable()
		{
		}

		private void _CalculateScreenPosition()
		{
		}

		private Vector3 _GetScreenToWorldPosition(Vector2 screenPosition, Vector2 screenSize)
		{
			return default(Vector3);
		}

		private void _ApplyData()
		{
		}

		private bool _CreateData()
		{
			return default(bool);
		}

		private void _FixData()
		{
		}

		public void ForceChildrensFixData()
		{
		}

		public void _UpdateRoot(bool updateTime)
		{
		}

		private void _UpdateStart()
		{
		}

		private void _UpdateVisible()
		{
		}

		private void _UpdateChildren()
		{
		}

		private void _UpdateUpdateInterval()
		{
		}

		private void _ResetUpdateInterval()
		{
		}

		private void _UpdateEnd()
		{
		}

		private void _Destroy()
		{
		}

		public override void SetVisible(bool visible)
		{
		}

		public void SetCustomDeltaTime(bool enable, float deltaTime = float.MinValue)
		{
		}

		public void SetCustomSyncTime(bool enable, float syncTime = float.MinValue)
		{
		}

		public void SetUpdateInterval(int interval)
		{
		}

		public void SetDefaultDepthOffset(float defaultDepthOffset)
		{
		}

		public void SetDefaultScaleOffset(float defalutScaleOffset)
		{
		}

		public void SetDefaultSortOffset(int defaultSortOffset)
		{
		}

		public void SetDefaultStencilRefOffset(int defaultStencilRefOffset)
		{
		}

		public void SetDefaultColliderThickness(float defaultColliderThickness)
		{
		}

		public void SetDrawTextLater(bool drawTextLater)
		{
		}

		public T FindComponent<T>(GameObject rootObject, string path, bool fullMatch = false) where T : Component
		{
			return null;
		}

		public T Find<T>(GameObject rootObject, string path, bool fullMatch = false) where T : FlBase
		{
			return null;
		}

		public List<T> Find<T>(GameObject rootObject) where T : FlBase
		{
			return null;
		}

		public T FindUI<T>(GameObject rootObject, string path, bool fullMatch = false) where T : FlUIBase
		{
			return null;
		}

		public T FindAndInitUI<T>(GameObject rootObject, string path, bool fullMatch = false) where T : FlUIBase, new()
		{
			return null;
		}

		public List<FlPlane> FindFLPlanesByContainsName(FlRoot root, List<string> containsNames)
		{
			return null;
		}
	}
}
