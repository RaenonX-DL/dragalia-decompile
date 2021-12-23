using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using Cute.Cri;
using DG.Tweening;
using FLATOUT.Main;
using FLATOUT.Main.Utility;
using UnityEngine;

namespace Gluon
{
	public class PlayFTU : FastUpdateMonoBehaviour
	{
		public enum Type
		{
			SkillCutIn,
			SkillCutInDragon,
			QuestStart,
			QuestClear,
			QuestFailure,
			QuestBossBattle,
			QuestTimeUp,
			ChangePlayer,
			ChangePlayerL,
			PartySwitch,
			QuestBreak,
			QuestBreakGauge,
			QuestChance,
			Overdrive,
			OverdriveGauge,
			Berserk,
			RareEnemyAppear,
			RareEnemyDefeat,
			PowerfulEnemyAppear,
			WaveStart,
			TreasureTime,
			BootyGetSack,
			BootyGetWeapon,
			BootyGetAmulet,
			BootyGetMana,
			BootyGetCoin,
			DragonLR,
			BattleDemolish,
			QuestReady,
			RaidFishGrade,
			DefenseEventInfo,
			DmodeLevelUp,
			TutorialSkill,
			TutorialDragon,
			TutorialNaviFlick,
			TutorialNaviSwipe,
			TutorialNaviTouch,
			TutorialReact1,
			TutorialReact2,
			TutorialReact3
		}

		public enum SkillCutInInfoType
		{
			Default,
			ExSkill_1,
			ExSkill_2,
			ExSkill_3,
			ExSkill_4,
			Mode_1,
			Mode_2,
			Mode_3,
			Mode_4
		}

		public enum CharaSpecificFlashType
		{
			None,
			EightServantCutIn,
			Max
		}

		public enum CharaSpecificFlashAlignment
		{
			Upper = 0,
			Middle = 1,
			Lower = 2,
			Auto = 99
		}

		public class MaterialInfo
		{
			public int index;

			public Material mtrl;
		}

		public struct F2USetData
		{
			public Material material;

			public Texture colorTexture;

			public Texture alphaTexture;
		}

		public class FlashInfo
		{
			public Action<PlayFTU> endFunction;

			public FlRoot flRoot;

			public FlMotion rootMotion;

			public List<FlMotion> listMotion;

			public List<FlPlane> listPlane;

			public Dictionary<string, List<FlPlane>> planeDictionaryList;

			public List<FlText> listText;

			public GameObject flashObj;

			public List<MaterialInfo> material;

			public FlImageNumberComponent[] numberCtrls;

			public bool running;

			public bool active;

			public bool loading;

			public bool loaded;

			public bool loading2;

			public bool loaded2;

			public bool remove;

			public bool stop;

			public bool isKeeping;

			public bool visible;

			public int[] numberValues;

			public void Reset()
			{
			}
		}

		private class CharaSpecificFlashInfo
		{
			public FlashInfo flashInfo;

			public CharaSpecificFlashType SpecificFlashType
			{
				[CompilerGenerated]
				get
				{
					return default(CharaSpecificFlashType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public string FileName
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

			public CharaSpecificFlashInfo(CharaSpecificFlashType csfType, string fileName)
			{
			}

			~CharaSpecificFlashInfo()
			{
			}

			public void Destroy()
			{
			}
		}

		public class SkillCutInSpriteInfo
		{
			private Material _materialBase;

			private DifferenceImageObject differenceImageObject;

			private DifferenceImageSkillCutInObject differenceImageSkillCutInObject;

			private Action _playStartCallback;

			private Action _playEndCallback;

			private MoviePlayerHandle _moviePlayer;

			private bool _isMoviePlaying;

			public bool isMovieMode
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Sprite spriteBase
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

			public Sprite[] spriteParts
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

			~SkillCutInSpriteInfo()
			{
			}

			public void Destroy()
			{
			}

			public bool GetF2USetData(out F2USetData f2USetData)
			{
				return default(bool);
			}

			public void CreateDifferenceImageMode(DifferenceImageObject imageObject, [Optional] DifferenceImageSkillCutInObject imageSkillCutIn)
			{
			}

			public void CreateMovieMode(string movieFile, GameObject parentObject, Texture2D tex, MovieManager.MovieCategory category)
			{
			}

			public DifferenceImageSkillCutInObject.SkillData GetDifferenceImageSkillCutInObjectToSkillData(DifferenceImageSkillCutInObject.Type _type)
			{
				return null;
			}

			public bool HasDifferenceImageSkillCutInObjectToSkillData(DifferenceImageSkillCutInObject.Type _type)
			{
				return default(bool);
			}

			private void OnMovieStart()
			{
			}

			private void OnMovieEnd()
			{
			}

			public void StartLoop(FlashInfo fi, DifferenceImageSkillCutInObject.Type skillIndex, SkillCutInSpriteInfo skillCutInSpriteInfoPlay, [Optional] Action playStartCallback, [Optional] Action playEndCallback)
			{
			}

			public IEnumerator PlayLoop(FlashInfo fi, DifferenceImageSkillCutInObject.Type skillIndex, SkillCutInSpriteInfo skillCutInSpriteInfoPlay)
			{
				return null;
			}

			private void SetSkillCutinDifferenceMaterial(FlPlane plane, DifferenceImageSkillCutInObject.EmotionData emotionData, SkillCutInSpriteInfo skillCutInSpriteInfoPlay)
			{
			}
		}

		public enum FlashInstanceType
		{
			RareGet,
			RareGet2,
			DmodeExp
		}

		public class InstanceFlashPlayerInfo
		{
			public FlashPlayer player
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

			public Transform trackingTransform
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

			public float trackingTransformOffsetY
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Vector3 trackingPos
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public InstanceFlashPlayerInfo(FlashPlayer player)
			{
			}

			private InstanceFlashPlayerInfo()
			{
			}

			public void Update()
			{
			}

			public void UpdatePosition()
			{
			}

			public void SetTrackingTransform(Transform transform, float transformOffsetY = 0f)
			{
			}
		}

		[SerializeField]
		[Header("Skill Cut In")]
		private int[] textIndex;

		[SerializeField]
		[Tooltip("ã\u0083\u00a0ã\u0083¼ã\u0083\u0093ã\u0083¼ã\u0082«ã\u0083\u0083ã\u0083\u0088ã\u0082¤ã\u0083³ç\u0094\u00a8ã\u0081®ã\u0082¹ã\u0083\u0097ã\u0083©ã\u0082¤ã\u0083\u0088ä½\u009cæ\u0088\u0090ç\u0094\u00a8ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£")]
		private Texture2D _templateMovieCutInTex;

		private static readonly string[] pathFlash;

		private static readonly Type[] overlapFlashList;

		private static readonly Type[] forceUIHidingIgnoreFlashList;

		private static readonly Dictionary<DifferenceImageSkillCutInObject.Type, DifferenceImageSkillCutInObject.Type> skillTypeToEnhancedSkillTypeDict;

		private static readonly Dictionary<int, SkillCutInInfoType> charaModeToModeTypeDict;

		private static int numType;

		private FlashInfo[] flashInfo;

		private FlashInfo moviePlayFlashInfo;

		private Dictionary<CharacterBase, List<CharaSpecificFlashInfo>> charaSpecificFlashInfoDict;

		private Dictionary<CharacterBase, List<CharaSpecificFlashInfo>> dynamicCharaSpecificFlashInfoDict;

		private Camera renderCamera;

		private float referenceResolutionX;

		private float referenceResolutionY;

		private float referenceAspect;

		private Canvas canvas;

		private RectTransform canvasRect;

		private SkillCutInSpriteInfo _skillCutInSpriteInfoPlay;

		private string _skillName;

		private DifferenceImageSkillCutInObject.Type _diffImageSkillIndex;

		private Dictionary<CharacterBase, Dictionary<SkillCutInInfoType, SkillCutInSpriteInfo>> skillCutInSpriteInfoDict;

		private Dictionary<CharacterBase, Dictionary<SkillCutInInfoType, SkillCutInSpriteInfo>> dynamicSkillCutInSpriteInfoDict;

		private Tweener skillCutInTweener;

		private Tweener charaSpecificCutInTweener;

		private Tweener blinkTweener;

		private readonly Color dyingColorMax;

		private readonly Color dyingColorMin;

		private Color dyingColor;

		private Vector2 skillTextOffset;

		private int skillFontSize;

		private const int skillFontSizeL = 44;

		private const int skillFontSizeM = 36;

		private const int skillFontSizeS = 30;

		private static readonly string skillCutInCharaMeshName;

		private static readonly string skillCutInShadowMeshName;

		private static readonly string skillCutInPartsMeshName;

		private static readonly Dictionary<SkillCutInInfoType, string> skillCutInExtendPathDict;

		private int waveCount;

		private int maxWaveCount;

		private Vector3 ftuPos;

		private string defenseEventInfoDesc;

		private string defenseEventInfoMotionLabel;

		private int defenseEventInfoMotionIndex;

		private static readonly string[] pathFlashInstance;

		private static readonly int[] flashInstancePlayingNumMax;

		private static readonly int[] flashInstanceSortingInterval;

		private static readonly int[] flashInstanceSortingLayer;

		private FlashPlayerManager flashPlayerManager;

		private GameObject[] prefabFlashInstance;

		private List<List<InstanceFlashPlayerInfo>> instanceFlashPlayerInfoList;

		private static int GetTypeNum()
		{
			return default(int);
		}

		private static int GetFlashInstanceTypeNum()
		{
			return default(int);
		}

		public static PlayFTU Create(GameObject parent, Camera camera, Canvas canvas)
		{
			return null;
		}

		private void Initialize(Camera camera, Canvas canvas)
		{
		}

		public void SetupInstanceFlash()
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		private bool UpdateFlash()
		{
			return default(bool);
		}

		private bool UpdateCharaSpecificFlash(ref Dictionary<CharacterBase, List<CharaSpecificFlashInfo>> charaSpecificInfoDict)
		{
			return default(bool);
		}

		private bool UpdateInstanceFlash()
		{
			return default(bool);
		}

		private bool UpdateCharaSpecificFlash()
		{
			return default(bool);
		}

		private void SetCharacterChangeColor(FlashInfo fi, Color color)
		{
		}

		private void SetQuestChancePosition(FlashInfo fi)
		{
		}

		public void SetMaterial(Type type, List<MaterialInfo> m)
		{
		}

		public void SetVisiblePlane(Type type, string meshName, bool visible)
		{
		}

		private void SetVisiblePlane(FlashInfo fi, string meshName, bool visible)
		{
		}

		public void Ready(Type type, [Optional] Action<PlayFTU> endFunc)
		{
		}

		private void ReadyCharaSpecific(CharacterBase chara, ref Dictionary<CharacterBase, List<CharaSpecificFlashInfo>> charaSpecificInfoDict, CharaSpecificFlashType csfType, string fileName, [Optional] Action<PlayFTU> endFunc)
		{
		}

		public void ReadyCharaSpecific(CharacterBase chara, CharaSpecificFlashType csfType, string fileName, [Optional] Action<PlayFTU> endFunc)
		{
		}

		private bool GetCharaSpecificFlashTypeToFileName(string fileName, ref CharaSpecificFlashType csfType)
		{
			return default(bool);
		}

		private string GetFlashFolderQuest()
		{
			return null;
		}

		private string GetFlashFolderRaidQuest()
		{
			return null;
		}

		private string GetFlashFolderDefaultQuest()
		{
			return null;
		}

		private string GetFlashFolderEvent()
		{
			return null;
		}

		private bool HasAlloutAssaultUniqueCtrlForAngel()
		{
			return default(bool);
		}

		public bool IsReady(Type type)
		{
			return default(bool);
		}

		public bool IsReadyCharaSpecific(CharacterBase chara, CharaSpecificFlashType csfType, string fileName)
		{
			return default(bool);
		}

		private void OnLoadedPrefab(GameObject prefab, int idx, Action<PlayFTU> endFunc)
		{
		}

		private void OnLoadedPrefab(CharacterBase chara, CharaSpecificFlashType csfType, string fileName, GameObject prefab, Action<PlayFTU> endFunc)
		{
		}

		private void SetupFlashInfo(GameObject prefab, Action<PlayFTU> endFunc, ref FlashInfo flashInfo)
		{
		}

		private void SetupSkillCutInInfo(CharacterBase chara, ref Dictionary<CharacterBase, Dictionary<SkillCutInInfoType, SkillCutInSpriteInfo>> charaInfoDict, ref Dictionary<CharacterBase, List<CharaSpecificFlashInfo>> charaSpecificInfoDict)
		{
		}

		public void SetupSkillCutInInfo(CharacterBase chara)
		{
		}

		public bool SetupReserveDragonSkillCutInInfo(CharacterSelector selector)
		{
			return default(bool);
		}

		private void SetupSkillCutInInfo(CharacterBase chara, ref Dictionary<CharacterBase, Dictionary<SkillCutInInfoType, SkillCutInSpriteInfo>> charaInfoDict, string strId, SkillCutInInfoType type)
		{
		}

		private SkillCutInSpriteInfo LoadSkillCutInInfo(string strId, SkillCutInInfoType type, bool isDragon)
		{
			return null;
		}

		public void ReadyForSkillCutIn(CharacterBase chara, string text, int index, bool isDragon)
		{
		}

		public bool ReadyForSkillCutIn(CharacterBase chara, ref Dictionary<CharacterBase, Dictionary<SkillCutInInfoType, SkillCutInSpriteInfo>> charaInfoDict, string text, int skillIndex, bool isDragon)
		{
			return default(bool);
		}

		private bool GetExSkillCutInSpriteInfoForSkill(CharacterBase chara, int skillIndex, Dictionary<SkillCutInInfoType, SkillCutInSpriteInfo> typeInfoDict, ref SkillCutInSpriteInfo info)
		{
			return default(bool);
		}

		private bool GetExSkillCutInSpriteInfoForCharaMode(CharacterBase chara, Dictionary<SkillCutInInfoType, SkillCutInSpriteInfo> typeInfoDict, ref SkillCutInSpriteInfo info)
		{
			return default(bool);
		}

		private bool HasSkillCutInSpriteInfoForCharaMode(Dictionary<SkillCutInInfoType, SkillCutInSpriteInfo> typeInfoDict)
		{
			return default(bool);
		}

		private void ReadyForSkillCutIn(CharacterBase chara, SkillCutInSpriteInfo info, string text, int index, bool isDragon)
		{
		}

		private DifferenceImageSkillCutInObject.Type GetDifferenceImageSkillIndex(CharacterBase chara, SkillCutInSpriteInfo info, int index, bool isDragon)
		{
			return default(DifferenceImageSkillCutInObject.Type);
		}

		private void OnLoadedSkillCutIn(SkillCutInSpriteInfo info, bool isDragon)
		{
		}

		private int GetSkillFontSize(ref string name)
		{
			return default(int);
		}

		public void ReadyForWaveStart(int waveCount, int maxWaveCount)
		{
		}

		public void ReadyForDefenseEventInfo(string desc, string motionLabel, int motionIndex)
		{
		}

		public void ReadyPartySwitchCurrMember(int index, Material material, int playerNo)
		{
		}

		public void ReadyPartySwitchNextMember(int index, Material material, int playerNo)
		{
		}

		private void ReadyPartySwitch(FlashInfo fi, int index, int playerNo, string planeName, Material material, string playerNoPlaneNameFormat)
		{
		}

		public void Play(Type type, bool isRemove, [Optional] Action<PlayFTU> endFunc, bool isKeeping = false, [Optional] string label)
		{
		}

		private void PlaySE(Type type)
		{
		}

		public bool PlayCharaSpecific(CharacterBase chara, CharaSpecificFlashType csfType, string fileName, bool isRemove, CharaSpecificFlashAlignment csfAlign = CharaSpecificFlashAlignment.Auto, [Optional] Action<PlayFTU> endFunc, bool isKeeping = false, [Optional] string label)
		{
			return default(bool);
		}

		private bool GetCharaSpecificFlashInfo(CharacterBase chara, CharaSpecificFlashType csfType, string fileName, out CharaSpecificFlashInfo info)
		{
			return default(bool);
		}

		private bool GetCharaSpecificFlashInfo(CharacterBase chara, ref Dictionary<CharacterBase, List<CharaSpecificFlashInfo>> charaSpecificInfoDict, CharaSpecificFlashType csfType, string fileName, out CharaSpecificFlashInfo info)
		{
			return default(bool);
		}

		public void PlayMotionIndex(Type type, [Optional] string label, int playMotionIdx = -1)
		{
		}

		public void SetSortOrder(Type type, int order)
		{
		}

		public void PlayMotionIndexDelay(Type type, [Optional] string label, int playMotionIdx = -1)
		{
		}

		private IEnumerator StartPlayMotionIndex(Type type, string label, int playMotionIdx)
		{
			return null;
		}

		public void Pause(Type type)
		{
		}

		public void Pause(ref FlashInfo flashInfo)
		{
		}

		public void Stop(Type type)
		{
		}

		public void Stop(ref FlashInfo flashInfo)
		{
		}

		public void StopImmediate(Type type)
		{
		}

		public void StopImmediate(ref FlashInfo flashInfo)
		{
		}

		public void StopForForceUIHiding()
		{
		}

		private void StopOverlap(Type type)
		{
		}

		private bool CheckOverlap(Type type)
		{
			return default(bool);
		}

		private bool CheckForceUIHidingIgnore(Type type)
		{
			return default(bool);
		}

		private bool CheckPlayForceUIHiding()
		{
			return default(bool);
		}

		public void SetActive(Type type, bool isActive)
		{
		}

		private void MovieStartPlayCallback()
		{
		}

		private IEnumerator StartPlay(Type type, string label)
		{
			return null;
		}

		private IEnumerator StartPlayCharaSpecific(CharacterBase chara, CharaSpecificFlashType csfType, string fileName, CharaSpecificFlashAlignment csfAlign, string label)
		{
			return null;
		}

		private IEnumerator PlaySkillCutIn(FlashInfo fi)
		{
			return null;
		}

		private void SetVisibleSkillCutInSprite(FlashInfo fi, bool visible)
		{
		}

		private void InitSkillCutInSprite(FlashInfo fi, string meshName)
		{
		}

		private void InitPosition(Type type, ref FlashInfo fi)
		{
		}

		public bool IsActive()
		{
			return default(bool);
		}

		public bool IsActive(Type type)
		{
			return default(bool);
		}

		public void ReleaseFlashObj(Type type)
		{
		}

		public void Release()
		{
		}

		public void Visible(Type type, bool v)
		{
		}

		public void Active(Type type, bool a)
		{
		}

		public void SetPosition(Type type, Vector3 offsetPos)
		{
		}

		public void SetNumber(Type type, int value, int value2 = 0)
		{
		}

		private bool IsTypeBootyGroup(Type type)
		{
			return default(bool);
		}

		private bool IsSkillCutin(Type type)
		{
			return default(bool);
		}

		private bool IsSkillCutin(CharaSpecificFlashType csfType)
		{
			return default(bool);
		}

		private bool IsEnableSkillCutin([Optional] CharacterBase chara)
		{
			return default(bool);
		}

		private void OnLoadedFlashInstancePrefab(GameObject prefab, int index)
		{
		}

		public FlashPlayer PlayFlashInstance(FlashInstanceType type, Vector2 argPos, [Optional] Transform parent, [Optional] Transform trackingTransform, float trackingTransformOffsetY = 0f, bool isForcePlay = false)
		{
			return null;
		}

		public FlashPlayer PlayFlashInstanceNumber(FlashInstanceType type, int value, Vector2 argPos, [Optional] Transform parent, [Optional] Transform trackingTransform, float trackingTransformOffsetY = 0f, bool isForcePlay = false)
		{
			return null;
		}

		private void UpdateInstanceFlashSortOrder(FlashInstanceType type)
		{
		}

		private FlashPlayer PlayFlashInstance(GameObject prefab, Vector2 argPos, Transform parent, int sortOrder)
		{
			return null;
		}

		private void SetFlashInstancePosition(FlashPlayer player, Vector2 argPos)
		{
		}
	}
}
