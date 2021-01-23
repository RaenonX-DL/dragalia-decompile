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
	public class FlRoot : FlMonoBehaviour
	{
		// Fields
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
	
		// Properties
		public FlRootParameter Parameter { get; set; }
		public FlMeshParameterGroup MeshParameterGroup { get; set; }
		public GameObject TopObject { get; }
		public FlMotion RootMotion { get; set; }
		public List<FlBase> DataList { get; }
		public List<FlMotion> MotionList { get; }
		public List<FlObjectBase> ObjectList { get; }
		public List<FlBase> FinalizeTargetDataList { get; }
		public int SortOrderCount { get; set; }
		public int SortOrderCountForDrawTextLater { get; set; }
		public int SortOrderInterval { get; }
		public int DefaultSortOffset { get; }
		public int DefaultStencilRefOffset { get; }
		public int StencilRefInterval { get; }
		public int StencilRefCount { get; set; }
		public float DefaultDepthOffset { get; }
		public float DefaultColliderThickness { get; }
		public bool DrawTextLater { get; }
		public Hashtable DataTable { get; }
		public Hashtable MeshRendererTable { get; }
		public Hashtable MeshFilterTable { get; }
		public Hashtable ColliderTable { get; }
		public Hashtable TextMeshTable { get; }
		public float DeltaTime { get; }
		public float CustomDeltaTime { get; }
		public bool UseCustomDeltaTime { get; }
		public float SyncTime { get; }
		public float CustomSyncTime { get; }
		public bool UseCustomSyncTime { get; }
		public int UpdateInterval { get; }
		public int UpdateGroup { get; }
		public Vector3 ScreenRightWorldPosition { get; }
		public Vector3 ScreenLeftWorldPosition { get; }
		public Vector3 CurrentScreenRightWorldPosition { get; }
		public Vector3 CurrentScreenLeftWorldPosition { get; }
		public bool AspectChanged { get; }
		public bool ScreenSizeChanged { get; }
		public float ScreenScale { get; }
		public float CurrentScreenScale { get; }
	
		// Constructors
		public FlRoot();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		private void _Initialize();
		private void _UpdateInitialize();
		private void _Initialize_PostProcess();
		private void _BootManager();
		private void _CreateHierarchy();
		private void _CreateMeshRendererTable();
		private void _CreateMeshFilterTable();
		private void _CreateColliderTable();
		private void _CreateTextMeshTable();
		private void _CalculateScreenPosition();
		private Vector3 _GetScreenToWorldPosition(Vector2 screenPosition, Vector2 screenSize);
		private void _ApplyData();
		private bool _CreateData();
		private void _FixData();
		public void ForceChildrensFixData();
		public void _UpdateRoot(bool updateTime);
		private void _UpdateStart();
		private void _UpdateVisible();
		private void _UpdateChildren();
		private void _UpdateUpdateInterval();
		private void _ResetUpdateInterval();
		private void _UpdateEnd();
		private void _Destroy();
		public override void SetVisible(bool visible);
		public void SetCustomDeltaTime(bool enable, float deltaTime = -3.4028235E+38f);
		public void SetCustomSyncTime(bool enable, float syncTime = -3.4028235E+38f);
		public void SetUpdateInterval(int interval);
		public void SetDefaultDepthOffset(float defaultDepthOffset);
		public void SetDefaultScaleOffset(float defalutScaleOffset);
		public void SetDefaultSortOffset(int defaultSortOffset);
		public void SetDefaultStencilRefOffset(int defaultStencilRefOffset);
		public void SetDefaultColliderThickness(float defaultColliderThickness);
		public void SetDrawTextLater(bool drawTextLater);
		public T FindComponent<T>(GameObject rootObject, string path, bool fullMatch = false)
			where T : Component;
		public T Find<T>(GameObject rootObject, string path, bool fullMatch = false)
			where T : FlBase;
		public List<T> Find<T>(GameObject rootObject)
			where T : FlBase;
		public T FindUI<T>(GameObject rootObject, string path, bool fullMatch = false)
			where T : FlUIBase;
		public T FindAndInitUI<T>(GameObject rootObject, string path, bool fullMatch = false)
			where T : FlUIBase, new();
		public List<FlPlane> FindFLPlanesByContainsName(FlRoot root, List<string> containsNames);
	}
}
