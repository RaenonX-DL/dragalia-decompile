using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;

namespace Gluon
{
	public class MiniMapCtrl : FastUpdateMonoBehaviour
	{
		public enum IconType
		{
			arrow,
			boss1,
			boss2,
			chest,
			enemy1,
			enemy2,
			obj,
			stop,
			nextarrow,
			nextboss,
			BattleTeamBlue,
			BattleTeamRed,
			BattlePortalUnit1,
			BattlePortalUnit2,
			BattlePortalUnit3,
			BattlePortalUnit4,
			BattlePortalUnit5,
			BattleTeamBluePlayer,
			BattleTeamRedPlayer,
			BattleBoss1,
			BattleBoss2,
			BattleEnemy1,
			Player1,
			Player2,
			Player3,
			Player4,
			DefenseFort,
			DefenseHouse,
			DefenseSonar,
			DefenseRouteArrow,
			DefenseBridge,
			DefenseFort2,
			Max
		}

		public enum EventIconType
		{
			BR_Enemy_001,
			BR_Enemy_002,
			Max
		}

		public enum IconSortType
		{
			Boss,
			Enemy,
			CtrlPlayer,
			Player,
			Other,
			Defense
		}

		public enum ButtonSortingOrderType
		{
			Default,
			ContinueCamera
		}

		protected class TweenObject
		{
			private Transform _rootTr;

			private SpriteRenderer[] _images;

			private MiniMapCtrl _miniMapCtrl;

			private MinimapIcon _miniMapIcon;

			private Sequence _sequence;

			private int _index;

			~TweenObject()
			{
			}

			public void InitSonar(MiniMapCtrl ctrl, Transform parent, SpriteRenderer[] images)
			{
			}

			public void InitRoute(MiniMapCtrl ctrl, MinimapIcon icon, SpriteRenderer image, int index)
			{
			}

			public void OnDestroy()
			{
			}

			public void PlayAnimSonar()
			{
			}

			public void PlayAnimRoute()
			{
			}

			public bool IsFinish()
			{
				return default(bool);
			}

			public void Flash()
			{
			}

			public void SetOwner(MinimapIcon icon)
			{
			}
		}

		protected class MinimapIcon
		{
			public MiniMapParam InsideMiniMap;

			private Transform _transIcon;

			private bool _isRotateSync;

			private MiniMapCtrl _miniMapCtrl;

			private CharacterSelector _selector;

			private bool _isActiveIcon;

			private bool _isVisibleIcon;

			private TweenObject _tweenSonar;

			private TweenObject _tweenRoute;

			public GameObject goIcon
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Transform trans
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public CharacterBase chara
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public SpriteRenderer iconImage
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			~MinimapIcon()
			{
			}

			public bool IsActive()
			{
				return default(bool);
			}

			public void SetActiveIcon(bool b)
			{
			}

			public void SetVisibleIcon(bool b)
			{
			}

			public bool IsInside(Vector2 pos)
			{
				return default(bool);
			}

			public void Init(GameObject icon, Transform trans, MiniMapCtrl ctrl, bool isRotateSync = false)
			{
			}

			public void OnDestroy()
			{
			}

			public void Update(Quaternion rotation, Vector3 iconScale)
			{
			}

			private void UpdateAnim(bool isDisp)
			{
			}

			public Vector2 GetMapPos()
			{
				return default(Vector2);
			}

			public void ChangeChara(CharacterBase chara)
			{
			}

			public void UpdateSelectorChara()
			{
			}

			public void ChangeTrans(Transform trans)
			{
			}

			public bool IsPlayAnimSonar()
			{
				return default(bool);
			}

			public void PlayAnimRoute()
			{
			}

			public bool IsPlayAnimRoute()
			{
				return default(bool);
			}
		}

		protected class MiniMapEnemyRouteCtrl
		{
			private MiniMapCtrl _miniMapCtrl;

			private List<Transform> _iconPointList;

			private Sequence _sequence;

			~MiniMapEnemyRouteCtrl()
			{
			}

			public void Init(MiniMapCtrl ctrl, ref List<Transform> list)
			{
			}

			public void OnDestroy()
			{
			}

			public void PlayAnimRoute()
			{
			}

			public bool IsFinish()
			{
				return default(bool);
			}
		}

		[Serializable]
		public class EventIconData
		{
			[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³")]
			public Sprite icon;

			[Tooltip("ã\u0082½ã\u0083¼ã\u0083\u0088é\u00a0\u0086")]
			public IconSortType sort;

			[Tooltip("å\u00af¾è±¡ã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081\u00a8ã\u0081®å\u009b\u009eè»¢å\u0090\u008cæ\u009c\u009fã\u0083\u0095ã\u0083©ã\u0082°")]
			public bool isRotateSync;
		}

		[SerializeField]
		[Header("component")]
		private RectTransform _fullMapRt;

		[SerializeField]
		private RectTransform _smallMapRt;

		[SerializeField]
		private RectTransform _buttonRt;

		[SerializeField]
		private RectTransform _plusButtonRt;

		[SerializeField]
		private RectTransform _minusButtonRt;

		[SerializeField]
		[Header("parameter")]
		private float _smallMapScale;

		[SerializeField]
		private float _fullMapScale;

		[SerializeField]
		[Tooltip("ã\u0083\u009fã\u0083\u008bã\u0083\u009eã\u0083\u0083ã\u0083\u0097ã\u0081®æ\u008f\u008fç\u0094»é\u00a0\u0086")]
		private int _miniMapSortingOrder;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0083«ã\u0083\u009eã\u0083\u0083ã\u0083\u0097ã\u0081®æ\u008f\u008fç\u0094»é\u00a0\u0086")]
		private int _fullMapSortingOrder;

		[SerializeField]
		[Tooltip("ã\u0082½ã\u0083\u008aã\u0083¼ã\u0082¢ã\u0083\u008bã\u0083¡ ï¼\u0091ã\u0083«ã\u0083¼ã\u0083\u0097å\u0086\u0085ã\u0081®è¡\u00a8ç¤ºå\u0080\u008bæ\u0095°")]
		private int _tweenSonarNum;

		[SerializeField]
		[Tooltip("ã\u0082½ã\u0083\u008aã\u0083¼ã\u0082¢ã\u0083\u008bã\u0083¡ ï¼\u0091ã\u0083«ã\u0083¼ã\u0083\u0097å\u0086\u0085ã\u0081®è¡\u00a8ç¤ºé\u0081\u0085å»¶æ\u0099\u0082é\u0096\u0093")]
		private float _tweenSonarDelayTime;

		[SerializeField]
		[Tooltip("ã\u0082½ã\u0083\u008aã\u0083¼ã\u0082¢ã\u0083\u008bã\u0083¡ ã\u0083«ã\u0083¼ã\u0083\u0097å\u009b\u009eæ\u0095°")]
		private int _tweenSonarLoopNum;

		[SerializeField]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0081®å\u0088\u0086å\u0089²è·\u009dé\u009b¢")]
		private float _tweenRouteDivisionLength;

		[SerializeField]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ ï¼\u0091ã\u0083«ã\u0083¼ã\u0083\u0097å\u0086\u0085ã\u0081®è¡\u00a8ç¤ºé\u0081\u0085å»¶æ\u0099\u0082é\u0096\u0093")]
		private float _tweenRouteDelayTime;

		[SerializeField]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ ï¼\u0091ã\u0083«ã\u0083¼ã\u0083\u0097å\u0086\u0085ã\u0081®è¡\u00a8ç¤ºæ\u0099\u0082é\u0096\u0093")]
		private float _tweenRouteDisplayTime;

		[SerializeField]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ ï¼\u0091ã\u0083«ã\u0083¼ã\u0083\u0097å\u0086\u0085ã\u0081®å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093")]
		private float _tweenRouteWaitTime;

		[SerializeField]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ ã\u0083«ã\u0083¼ã\u0083\u0097å\u009b\u009eæ\u0095°")]
		private int _tweenRouteLoopNum;

		[SerializeField]
		[Header("resource")]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³")]
		private Sprite[] _icons;

		[SerializeField]
		[Tooltip("ã\u0082¤ã\u0083\u0099ã\u0083³ã\u0083\u0088ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³")]
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

		private const float fullMapScaleMin = 0.1f;

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

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void DestroyIcon(ref List<MinimapIcon> list)
		{
		}

		public static string MakeMinimapPrefabName(string sceneName)
		{
			return null;
		}

		public static string GetSceneNameFromMinimapPrefabName(string minimapPrefabName)
		{
			return null;
		}

		private void SetMapRotate(float rotate)
		{
		}

		public void SetFullMapData(Vector2 offset, float scale)
		{
		}

		public void SetHiddenEnemyMode(bool enableFlag)
		{
		}

		private void SetHiddenEnemyMode(ref List<MinimapIcon> list, bool enableFlag)
		{
		}

		public void LoadMiniMap()
		{
		}

		public void Initialize()
		{
		}

		private void UpdateMinimapParameter()
		{
		}

		private bool GetIconTypeFromObjName(string name, out int iconType)
		{
			return default(bool);
		}

		private void CreateCharacterIcon()
		{
		}

		public void AttachEnemyIcon(EnemyCharacter enemy)
		{
		}

		public void GetDefenseEventIconIndex(out int fortIconIndex, out int houseIconIndex)
		{
		}

		private bool IsEnableSonarAnim()
		{
			return default(bool);
		}

		private bool IsEnableRouteAnim()
		{
			return default(bool);
		}

		private void CreateDefenseUI()
		{
		}

		private TweenObject CreateTweenSonar()
		{
			return null;
		}

		public void PlayAnimSonar(Transform trans)
		{
		}

		private void AttachDefenseRouteIcon(EnemyCharacter enemy)
		{
		}

		private void CreateDefenseRoutePoint(CharacterBase chara, List<GameObject> pointList, int pointIdx, ref List<Transform> transList)
		{
		}

		private void CreateDefenseRoutePoint(CharacterBase chara, Transform start, Transform end, ref List<Transform> transList)
		{
		}

		public void PlayAnimRoute(Transform trans)
		{
		}

		private MinimapIcon GetRouteIcon()
		{
			return null;
		}

		public override void FastUpdate()
		{
		}

		private Rect CameraRect()
		{
			return default(Rect);
		}

		private void UpdateMiniMap()
		{
		}

		private void UpdateMiniMapIcon(ref List<MinimapIcon> list, ref Vector3 iconScale)
		{
		}

		private void UpdateMiniMapIcon(ref MinimapIcon icon, ref Vector3 iconScale)
		{
		}

		protected GameObject CreateIcon(Sprite iconSprt, Vector2 iconSize, IconSortType sortType, string iconName = "icon")
		{
			return null;
		}

		public void SetActiveMiniMapIcon(GameObject chara, bool b)
		{
		}

		public void SetVisibleMiniMapIcon(CharacterBase chara, bool b)
		{
		}

		private MinimapIcon GetMiniMapIcon(CharacterBase chara)
		{
			return null;
		}

		private bool GetMinimapIcon(ref List<MinimapIcon> list, CharacterBase chara, out MinimapIcon minimapIcon)
		{
			return default(bool);
		}

		private bool GetMinimapIcon(ref List<MinimapIcon> list, GameObject obj, out MinimapIcon minimapIcon)
		{
			return default(bool);
		}

		private bool GetMinimapIcon(ref List<MinimapIcon> list, Transform trans, out MinimapIcon minimapIcon)
		{
			return default(bool);
		}

		private Vector2 GetPivot()
		{
			return default(Vector2);
		}

		public void OnChangeMap()
		{
		}

		private void ExecChangeMap(bool isEffect)
		{
		}

		public void ChangeFullMap(bool b)
		{
		}

		public void RecodeAreaStatus()
		{
		}

		private void RestoreAreaStatus()
		{
		}

		public void EnableButton(bool enable)
		{
		}

		public void AddIntrusionList(MiniMapParam param)
		{
		}

		private void Save()
		{
		}

		private bool Load()
		{
			return default(bool);
		}

		public Vector3 GetMinimapPos(Vector3 worldPos)
		{
			return default(Vector3);
		}

		public void SetButtonSortingOrder(ButtonSortingOrderType type)
		{
		}

		public void UpdatePlayerIconTarget(List<HumanCharacter> currMemberList, List<HumanCharacter> nextMemberList)
		{
		}
	}
}
