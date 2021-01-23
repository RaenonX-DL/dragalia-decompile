/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MiniMapCtrl : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _fullMapRt;
		[SerializeField]
		private RectTransform _smallMapRt;
		[SerializeField]
		private RectTransform _buttonRt;
		[SerializeField]
		private RectTransform _plusButtonRt;
		[SerializeField]
		private RectTransform _minusButtonRt;
		[Header]
		[SerializeField]
		private float _smallMapScale;
		[SerializeField]
		private float _fullMapScale;
		[SerializeField]
		[Tooltip]
		private int _miniMapSortingOrder;
		[SerializeField]
		[Tooltip]
		private int _fullMapSortingOrder;
		[SerializeField]
		[Tooltip]
		private int _tweenSonarNum;
		[SerializeField]
		[Tooltip]
		private float _tweenSonarDelayTime;
		[SerializeField]
		[Tooltip]
		private int _tweenSonarLoopNum;
		[SerializeField]
		[Tooltip]
		private float _tweenRouteDivisionLength;
		[SerializeField]
		[Tooltip]
		private float _tweenRouteDelayTime;
		[SerializeField]
		[Tooltip]
		private float _tweenRouteDisplayTime;
		[SerializeField]
		[Tooltip]
		private float _tweenRouteWaitTime;
		[SerializeField]
		[Tooltip]
		private int _tweenRouteLoopNum;
		[Header]
		[SerializeField]
		[Tooltip]
		private Sprite[] _icons;
		[SerializeField]
		[Tooltip]
		private EventIconData[] _eventIcons;
		[SerializeField]
		private Material _iconMaterial;
		[SerializeField]
		private int _iconOrderInLayer;
		[SerializeField]
		private RectTransform _maskCenterNode;
		[NonSerialized]
		private GameObject _miniMap;
		private Transform _miniMapTransform;
		private GameObject _miniMapPointer;
		private SortingGroup _miniMapSortingGroup;
		private MiniMapParam[] _miniMapParams;
		private int _useIconCnt;
		private bool _isFullMapView;
		private float _smallMapRotate;
		private float _fullMapRotate;
		private float _mapRotate;
		private Quaternion _mapRotation;
		private Quaternion _mapInvRotation;
		private Vector3 _baseScale;
		private float _mapScale;
		private MinimapBVH _bvh;
		private int _areaIdx;
		private List<MiniMapParam> _viewMiniMapList;
		private List<MiniMapParam> _intrusionList;
		private Vector2 fullMapOfs;
		private bool enableButton;
		private Vector4 minimapShaderParam;
		private Vector4 minimapFullShaderParam;
		private int prevPositionLeft;
		private bool hiddenEnemyModeFlag;
		private Canvas _buttonCanvas;
		private Vector2[] _iconSize;
		private Vector2[] _eventIconSize;
		public const string MiniMapPath = "Dungeon/MiniMap";
		public const string PrefabNamePrefix = "MINIMAP_";
		private const float FullMapScaleMax = 2f;
		private const float CullingMarginSize = 16f;
		private const float MinimapToWorldScale = 4f;
		private const float PlayerIconScale = 1.5f;
		private const float BRFullIconScale = 3f;
		private static readonly Vector2 FullMapOffset;
		private static readonly string SaveKey;
		private float _fullMapScaleMul;
		private static readonly Dictionary<string, int> ObjName2IconTypeDic;
		private static readonly Dictionary<EnemyIconType, int> EnemyIconType2IconTypeDic;
		private static readonly Dictionary<int, int> EnemyBookId2EventIconTypeDic;
		private static readonly Dictionary<IconSortType, int> IconSortType2SortOffsetDic;
		private MinimapIcon _playerIcon;
		private List<MinimapIcon> _playerIconList;
		private List<MinimapIcon> _enemyIconList;
		private List<MinimapIcon> _otherIconList;
		private const int tweenSonarReserveNum = 8;
		private List<TweenObject> _tweenSonarList;
		private const int routeIconReserveNum = 128;
		private List<MinimapIcon> _enemyRouteIconList;
		private const int enemyRouteCtrlReserveNum = 16;
		private Dictionary<CharacterBase, MiniMapEnemyRouteCtrl> _enemyRouteCtrlDic;
		private List<CharacterBase> _removeEnemyRouteCtrlList;
	
		// Nested types
		public enum IconType
		{
			arrow = 0,
			boss1 = 1,
			boss2 = 2,
			chest = 3,
			enemy1 = 4,
			enemy2 = 5,
			obj = 6,
			stop = 7,
			nextarrow = 8,
			nextboss = 9,
			BattleTeamBlue = 10,
			BattleTeamRed = 11,
			BattlePortalUnit1 = 12,
			BattlePortalUnit2 = 13,
			BattlePortalUnit3 = 14,
			BattlePortalUnit4 = 15,
			BattlePortalUnit5 = 16,
			BattleTeamBluePlayer = 17,
			BattleTeamRedPlayer = 18,
			BattleBoss1 = 19,
			BattleBoss2 = 20,
			BattleEnemy1 = 21,
			Player1 = 22,
			Player2 = 23,
			Player3 = 24,
			Player4 = 25,
			DefenseFort = 26,
			DefenseHouse = 27,
			DefenseSonar = 28,
			DefenseRouteArrow = 29,
			DefenseBridge = 30,
			DefenseFort2 = 31,
			Max = 32
		}
	
		public enum EventIconType
		{
			BR_Enemy_001 = 0,
			BR_Enemy_002 = 1,
			Max = 2
		}
	
		public enum IconSortType
		{
			Boss = 0,
			Enemy = 1,
			CtrlPlayer = 2,
			Player = 3,
			Other = 4,
			Defense = 5
		}
	
		public enum ButtonSortingOrderType
		{
			Default = 0,
			ContinueCamera = 1
		}
	
		protected class TweenObject
		{
			// Fields
			private Transform _rootTr;
			private SpriteRenderer[] _images;
			private MiniMapCtrl _miniMapCtrl;
			private MinimapIcon _miniMapIcon;
			private Sequence _sequence;
			private int _index;
	
			// Constructors
			public TweenObject();
	
			// Methods
			~TweenObject();
			public void InitSonar(MiniMapCtrl ctrl, Transform parent, SpriteRenderer[] images);
			public void InitRoute(MiniMapCtrl ctrl, MinimapIcon icon, SpriteRenderer image, int index);
			public void OnDestroy();
			public void PlayAnimSonar();
			public void PlayAnimRoute();
			public bool IsFinish();
			public void Flash();
			public void SetOwner(MinimapIcon icon);
			[CompilerGenerated]
			private void _PlayAnimSonar_b__10_0();
			[CompilerGenerated]
			private void _PlayAnimRoute_b__11_0();
		}
	
		protected class MinimapIcon
		{
			// Fields
			public MiniMapParam InsideMiniMap;
			private Transform _transIcon;
			private bool _isRotateSync;
			private MiniMapCtrl _miniMapCtrl;
			private CharacterSelector _selector;
			private bool _isActiveIcon;
			private bool _isVisibleIcon;
			[CompilerGenerated]
			private GameObject _goIcon_k__BackingField;
			[CompilerGenerated]
			private Transform _trans_k__BackingField;
			[CompilerGenerated]
			private CharacterBase _chara_k__BackingField;
			[CompilerGenerated]
			private SpriteRenderer _iconImage_k__BackingField;
			private TweenObject _tweenSonar;
			private TweenObject _tweenRoute;
	
			// Properties
			public GameObject goIcon { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Transform trans { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public CharacterBase chara { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public SpriteRenderer iconImage { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public MinimapIcon();
	
			// Methods
			~MinimapIcon();
			public bool IsActive();
			public void SetActiveIcon(bool b);
			public void SetVisibleIcon(bool b);
			public bool IsInside(Vector2 pos);
			public void Init(GameObject icon, Transform trans, MiniMapCtrl ctrl, bool isRotateSync = false);
			public void OnDestroy();
			public void Update(Quaternion rotation, Vector3 iconScale);
			private void UpdateAnim(bool isDisp);
			public Vector2 GetMapPos();
			public void ChangeChara(CharacterBase chara);
			public void UpdateSelectorChara();
			public void ChangeTrans(Transform trans);
			public bool IsPlayAnimSonar();
			public void PlayAnimRoute();
			public bool IsPlayAnimRoute();
		}
	
		protected class MiniMapEnemyRouteCtrl
		{
			// Fields
			private MiniMapCtrl _miniMapCtrl;
			private List<Transform> _iconPointList;
			private Sequence _sequence;
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass6_0
			{
				// Fields
				public Transform iconPoint;
				public MiniMapEnemyRouteCtrl __4__this;
	
				// Constructors
				public __c__DisplayClass6_0();
	
				// Methods
				internal void _PlayAnimRoute_b__1();
			}
	
			// Constructors
			public MiniMapEnemyRouteCtrl();
	
			// Methods
			~MiniMapEnemyRouteCtrl();
			public void Init(MiniMapCtrl ctrl, ref List<Transform> list);
			public void OnDestroy();
			public void PlayAnimRoute();
			public bool IsFinish();
			[CompilerGenerated]
			private void _PlayAnimRoute_b__6_0();
		}
	
		[Serializable]
		public class EventIconData
		{
			// Fields
			[Tooltip]
			public Sprite icon;
			[Tooltip]
			public IconSortType sort;
			[Tooltip]
			public bool isRotateSync;
	
			// Constructors
			public EventIconData();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<MiniMapParam> __9__92_0;
			public static Predicate<TweenObject> __9__101_0;
			public static Predicate<MinimapIcon> __9__106_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Initialize_b__92_0(MiniMapParam x);
			internal bool _PlayAnimSonar_b__101_0(TweenObject x);
			internal bool _GetRouteIcon_b__106_0(MinimapIcon x);
		}
	
		// Constructors
		public MiniMapCtrl();
		static MiniMapCtrl();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		private void DestroyIcon(ref List<MinimapIcon> list);
		public static string MakeMinimapPrefabName(string sceneName);
		public static string GetSceneNameFromMinimapPrefabName(string minimapPrefabName);
		private void SetMapRotate(float rotate);
		public void SetFullMapData(Vector2 offset, float scale);
		public void SetHiddenEnemyMode(bool enableFlag);
		private void SetHiddenEnemyMode(ref List<MinimapIcon> list, bool enableFlag);
		public void LoadMiniMap();
		public void Initialize();
		private void UpdateMinimapParameter();
		private bool GetIconTypeFromObjName(string name, out int iconType);
		private void CreateCharacterIcon();
		public void AttachEnemyIcon(EnemyCharacter enemy);
		private bool IsEnableSonarAnim();
		private bool IsEnableRouteAnim();
		private void CreateDefenseUI();
		private TweenObject CreateTweenSonar();
		public void PlayAnimSonar(Transform trans);
		private void AttachDefenseRouteIcon(EnemyCharacter enemy);
		private void CreateDefenseRoutePoint(CharacterBase chara, List<GameObject> pointList, int pointIdx, ref List<Transform> transList);
		private void CreateDefenseRoutePoint(CharacterBase chara, Transform start, Transform end, ref List<Transform> transList);
		public void PlayAnimRoute(Transform trans);
		private MinimapIcon GetRouteIcon();
		public override void FastUpdate();
		private Rect CameraRect();
		private void UpdateMiniMap();
		private void UpdateMiniMapIcon(ref List<MinimapIcon> list, ref Vector3 iconScale);
		private void UpdateMiniMapIcon(ref MinimapIcon icon, ref Vector3 iconScale);
		protected GameObject CreateIcon(Sprite iconSprt, Vector2 iconSize, IconSortType sortType, string iconName = "icon");
		public void SetActiveMiniMapIcon(GameObject chara, bool b);
		public void SetVisibleMiniMapIcon(CharacterBase chara, bool b);
		private MinimapIcon GetMiniMapIcon(CharacterBase chara);
		private bool GetMinimapIcon(ref List<MinimapIcon> list, CharacterBase chara, out MinimapIcon minimapIcon);
		private bool GetMinimapIcon(ref List<MinimapIcon> list, GameObject obj, out MinimapIcon minimapIcon);
		private bool GetMinimapIcon(ref List<MinimapIcon> list, Transform trans, out MinimapIcon minimapIcon);
		private Vector2 GetPivot();
		public void OnChangeMap();
		public void ChangeFullMap(bool b);
		public void RecodeAreaStatus();
		private void RestoreAreaStatus();
		public void EnableButton(bool enable);
		public void AddIntrusionList(MiniMapParam param);
		private void Save();
		private bool Load();
		public Vector3 GetMinimapPos(Vector3 worldPos);
		public void SetButtonSortingOrder(ButtonSortingOrderType type);
	}
}
