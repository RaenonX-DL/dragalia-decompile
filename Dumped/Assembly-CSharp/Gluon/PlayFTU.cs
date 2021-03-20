/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Cute.Cri;
using DG.Tweening;
using FLATOUT.Main;
using FLATOUT.Main.Utility;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayFTU : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private int[] textIndex;
		[SerializeField]
		[Tooltip]
		private Texture2D _templateMovieCutInTex;
		private static readonly string[] pathFlash;
		private static readonly Type[] overlapFlashList;
		private static readonly Type[] forceUIHidingIgnoreFlashList;
		private static readonly Dictionary<DifferenceImageSkillCutInObject.Type, DifferenceImageSkillCutInObject.Type> skillTypeToEnhancedSkillDic;
		private static int numType;
		private FlashInfo[] flashInfo;
		private FlashInfo moviePlayFlashInfo;
		private Dictionary<CharacterBase, List<CharaSpecificFlashInfo>> _charaSpecificFlashInfoDic;
		private Camera renderCamera;
		private float referenceResolutionX;
		private float referenceResolutionY;
		private float referenceAspect;
		private Canvas canvas;
		private RectTransform canvasRect;
		private SkillCutInSpriteInfo _skillCutInSpriteInfoPlay;
		private string _skillName;
		private DifferenceImageSkillCutInObject.Type _diffImageSkillIndex;
		private Dictionary<CharacterBase, Dictionary<DifferenceImageSkillCutInObject.Type, SkillCutInSpriteInfo>> skillCutInSpriteInfoDic;
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
		private static readonly Dictionary<DifferenceImageSkillCutInObject.Type, string> skillCutInExtendPathList;
		private int waveCount;
		private int maxWaveCount;
		private FlImageNumberComponent[] waveImageNumbers;
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
		private int[] flashInstancePlayingNum;
		private int[] flashInstanceCurrentSortOrderBase;
	
		// Nested types
		public enum Type
		{
			SkillCutIn = 0,
			SkillCutInDragon = 1,
			QuestStart = 2,
			QuestClear = 3,
			QuestFailure = 4,
			QuestBossBattle = 5,
			QuestTimeUp = 6,
			ChangePlayer = 7,
			ChangePlayerL = 8,
			QuestBreak = 9,
			QuestBreakGauge = 10,
			QuestChance = 11,
			Overdrive = 12,
			OverdriveGauge = 13,
			Berserk = 14,
			RareEnemyAppear = 15,
			RareEnemyDefeat = 16,
			PowerfulEnemyAppear = 17,
			WaveStart = 18,
			TreasureTime = 19,
			BootyGetSack = 20,
			BootyGetWeapon = 21,
			BootyGetAmulet = 22,
			BootyGetMana = 23,
			BootyGetCoin = 24,
			DragonLR = 25,
			BattleDemolish = 26,
			QuestReady = 27,
			RaidFishGrade = 28,
			DefenseEventInfo = 29,
			TutorialSkill = 30,
			TutorialDragon = 31,
			TutorialNaviFlick = 32,
			TutorialNaviSwipe = 33,
			TutorialNaviTouch = 34,
			TutorialReact1 = 35,
			TutorialReact2 = 36,
			TutorialReact3 = 37
		}
	
		public enum CharaSpecificFlashType
		{
			None = 0,
			EightServantCutIn = 1,
			Max = 2
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
			// Fields
			public int index;
			public Material mtrl;
	
			// Constructors
			public MaterialInfo();
		}
	
		public struct F2USetData
		{
			// Fields
			public Material material;
			public Texture colorTexture;
			public Texture alphaTexture;
		}
	
		public class FlashInfo
		{
			// Fields
			public Action<PlayFTU> endFunction;
			public FlRoot flRoot;
			public FlMotion rootMotion;
			public List<FlMotion> listMotion;
			public List<FlPlane> listPlane;
			public Dictionary<string, List<FlPlane>> planeDictionaryList;
			public List<FlText> listText;
			public GameObject flashObj;
			public List<MaterialInfo> material;
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
	
			// Constructors
			public FlashInfo();
	
			// Methods
			public void Reset();
		}
	
		private class CharaSpecificFlashInfo
		{
			// Fields
			[CompilerGenerated]
			private CharaSpecificFlashType _SpecificFlashType_k__BackingField;
			[CompilerGenerated]
			private string _FileName_k__BackingField;
			public FlashInfo flashInfo;
	
			// Properties
			public CharaSpecificFlashType SpecificFlashType { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public string FileName { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public CharaSpecificFlashInfo(CharaSpecificFlashType csfType, string fileName);
		}
	
		public class SkillCutInSpriteInfo
		{
			// Fields
			[CompilerGenerated]
			private bool _isMovieMode_k__BackingField;
			[CompilerGenerated]
			private Sprite _spriteBase_k__BackingField;
			[CompilerGenerated]
			private Sprite[] _spriteParts_k__BackingField;
			private Material _materialBase;
			private DifferenceImageObject differenceImageObject;
			private DifferenceImageSkillCutInObject differenceImageSkillCutInObject;
			private Action _playStartCallback;
			private Action _playEndCallback;
			private MoviePlayerHandle _moviePlayer;
			private bool _isMoviePlaying;
	
			// Properties
			public bool isMovieMode { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Sprite spriteBase { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Sprite[] spriteParts { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Nested types
			[CompilerGenerated]
			private sealed class _PlayLoop_d__27 : IEnumerator<object>
			{
				// Fields
				private int __1__state;
				private object __2__current;
				public SkillCutInSpriteInfo __4__this;
				public DifferenceImageSkillCutInObject.Type skillIndex;
				public FlashInfo fi;
				public SkillCutInSpriteInfo skillCutInSpriteInfoPlay;
				private FlPlane _plane_5__2;
				private DifferenceImageSkillCutInObject.EmotionData[] __7__wrap2;
				private int __7__wrap3;
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public _PlayLoop_d__27(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				[DebuggerHidden]
				void IEnumerator.Reset();
			}
	
			// Constructors
			public SkillCutInSpriteInfo();
	
			// Methods
			public bool GetF2USetData(out F2USetData f2USetData);
			public void CreateDifferenceImageMode(DifferenceImageObject imageObject, DifferenceImageSkillCutInObject imageSkillCutIn = null);
			public void CreateMovieMode(string movieFile, GameObject parentObject, Texture2D tex, MovieManager.MovieCategory category);
			public DifferenceImageSkillCutInObject.SkillData GetDifferenceImageSkillCutInObjectToSkillData(DifferenceImageSkillCutInObject.Type _type);
			public bool HasDifferenceImageSkillCutInObjectToSkillData(DifferenceImageSkillCutInObject.Type _type);
			private void OnMovieStart();
			private void OnMovieEnd();
			public void StartLoop(FlashInfo fi, DifferenceImageSkillCutInObject.Type skillIndex, SkillCutInSpriteInfo skillCutInSpriteInfoPlay, Action playStartCallback = null, Action playEndCallback = null);
			[IteratorStateMachine]
			public IEnumerator PlayLoop(FlashInfo fi, DifferenceImageSkillCutInObject.Type skillIndex, SkillCutInSpriteInfo skillCutInSpriteInfoPlay);
			private void SetSkillCutinDifferenceMaterial(FlPlane plane, DifferenceImageSkillCutInObject.EmotionData emotionData, SkillCutInSpriteInfo skillCutInSpriteInfoPlay);
		}
	
		public enum FlashInstanceType
		{
			RareGet = 0,
			RareGet2 = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public int idx;
			public PlayFTU __4__this;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _Initialize_b__1(GameObject p);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_0
		{
			// Fields
			public PlayFTU __4__this;
			public int idx;
			public Action<PlayFTU> endFunc;
	
			// Constructors
			public __c__DisplayClass72_0();
	
			// Methods
			internal void _Ready_b__0(GameObject p);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public PlayFTU __4__this;
			public CharacterBase chara;
			public CharaSpecificFlashType csfType;
			public string fileName;
			public Action<PlayFTU> endFunc;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal void _ReadyCharaSpecific_b__0(GameObject prefab);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_0
		{
			// Fields
			public Action<PlayFTU> endFunc;
			public PlayFTU __4__this;
	
			// Constructors
			public __c__DisplayClass92_0();
	
			// Methods
			internal void _Play_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_0
		{
			// Fields
			public Action<PlayFTU> endFunc;
			public PlayFTU __4__this;
	
			// Constructors
			public __c__DisplayClass93_0();
	
			// Methods
			internal void _PlayCharaSpecific_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _StartPlayMotionIndex_d__98 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlayFTU __4__this;
			public Type type;
			public string label;
			public int playMotionIdx;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartPlayMotionIndex_d__98(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartPlay_d__112 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Type type;
			public PlayFTU __4__this;
			public string label;
			private FlashInfo _fi_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartPlay_d__112(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartPlayCharaSpecific_d__113 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlayFTU __4__this;
			public CharacterBase chara;
			public CharaSpecificFlashType csfType;
			public string fileName;
			public CharaSpecificFlashAlignment csfAlign;
			public string label;
			private FlashInfo _fi_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartPlayCharaSpecific_d__113(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlaySkillCutIn_d__114 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FlashInfo fi;
			public PlayFTU __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySkillCutIn_d__114(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass130_0
		{
			// Fields
			public int sortOrderBase;
			public PlayFTU __4__this;
			public int index;
			public FlashPlayer player;
	
			// Constructors
			public __c__DisplayClass130_0();
	
			// Methods
			internal void _PlayFlashInstance_b__0();
		}
	
		// Constructors
		public PlayFTU();
		static PlayFTU();
	
		// Methods
		private static int GetTypeNum();
		private static int GetFlashInstanceTypeNum();
		public static PlayFTU Create(GameObject parent, Camera camera, Canvas canvas);
		private void Initialize(Camera camera, Canvas canvas);
		private void OnDestroy();
		public override void FastUpdate();
		private bool UpdateFlash();
		private bool UpdateCharaSpecificFlash();
		private void SetCharacterChangeColor(FlashInfo fi, Color color);
		private void SetQuestChancePosition(FlashInfo fi);
		public void SetMaterial(Type type, List<MaterialInfo> m);
		public void SetVisiblePlane(Type type, string meshName, bool visible);
		private void SetVisiblePlane(FlashInfo fi, string meshName, bool visible);
		public void Ready(Type type, Action<PlayFTU> endFunc = null);
		public void ReadyCharaSpecific(CharacterBase chara, CharaSpecificFlashType csfType, string fileName, Action<PlayFTU> endFunc = null);
		private bool GetCharaSpecificFlashTypeToFileName(string fileName, ref CharaSpecificFlashType csfType);
		private string GetFlashFolderQuest();
		private string GetFlashFolderEvent();
		public bool IsReady(Type type);
		public bool IsReadyCharaSpecific(CharacterBase chara, CharaSpecificFlashType csfType, string fileName);
		private void OnLoadedPrefab(GameObject prefab, int idx, Action<PlayFTU> endFunc);
		private void OnLoadedPrefab(CharacterBase chara, CharaSpecificFlashType csfType, string fileName, GameObject prefab, Action<PlayFTU> endFunc);
		private void SetupFlashInfo(GameObject prefab, Action<PlayFTU> endFunc, ref FlashInfo flashInfo);
		public void SetupSkillCutInInfo(CharacterBase chara);
		private void SetupSkillCutInInfo(CharacterBase chara, string strId, DifferenceImageSkillCutInObject.Type type);
		private SkillCutInSpriteInfo LoadSkillCutInInfo(string strId, DifferenceImageSkillCutInObject.Type type, bool isDragon);
		public void ReadyForSkillCutIn(CharacterBase chara, string text, int index, bool isDragon);
		private void ReadyForSkillCutIn(CharacterBase chara, SkillCutInSpriteInfo info, string text, int index, bool isDragon);
		private DifferenceImageSkillCutInObject.Type GetDifferenceImageSkillIndex(CharacterBase chara, SkillCutInSpriteInfo info, int index, bool isDragon);
		private void OnLoadedSkillCutIn(SkillCutInSpriteInfo info, bool isDragon);
		private int GetSkillFontSize(ref string name);
		public void ReadyForWaveStart(int waveCount, int maxWaveCount);
		public void ReadyForDefenseEventInfo(string desc, string motionLabel, int motionIndex);
		public void Play(Type type, bool isRemove, Action<PlayFTU> endFunc = null, bool isKeeping = false, string label = null);
		public bool PlayCharaSpecific(CharacterBase chara, CharaSpecificFlashType csfType, string fileName, bool isRemove, CharaSpecificFlashAlignment csfAlign = CharaSpecificFlashAlignment.Auto, Action<PlayFTU> endFunc = null, bool isKeeping = false, string label = null);
		private bool GetCharaSpecificFlashInfo(CharacterBase chara, CharaSpecificFlashType csfType, string fileName, out CharaSpecificFlashInfo info);
		public void PlayMotionIndex(Type type, string label = null, int playMotionIdx = -1);
		public void SetSortOrder(Type type, int order);
		public void PlayMotionIndexDelay(Type type, string label = null, int playMotionIdx = -1);
		[IteratorStateMachine]
		private IEnumerator StartPlayMotionIndex(Type type, string label, int playMotionIdx);
		public void Pause(Type type);
		public void Pause(ref FlashInfo flashInfo);
		public void Stop(Type type);
		public void Stop(ref FlashInfo flashInfo);
		public void StopImmediate(Type type);
		public void StopImmediate(ref FlashInfo flashInfo);
		public void StopForForceUIHiding();
		private void StopOverlap(Type type);
		private bool CheckOverlap(Type type);
		private bool CheckForceUIHidingIgnore(Type type);
		private bool CheckPlayForceUIHiding();
		public void SetActive(Type type, bool isActive);
		private void MovieStartPlayCallback();
		[IteratorStateMachine]
		private IEnumerator StartPlay(Type type, string label);
		[IteratorStateMachine]
		private IEnumerator StartPlayCharaSpecific(CharacterBase chara, CharaSpecificFlashType csfType, string fileName, CharaSpecificFlashAlignment csfAlign, string label);
		[IteratorStateMachine]
		private IEnumerator PlaySkillCutIn(FlashInfo fi);
		private void SetVisibleSkillCutInSprite(FlashInfo fi, bool visible);
		private void InitSkillCutInSprite(FlashInfo fi, string meshName);
		private void InitPosition(Type type, ref FlashInfo fi);
		public bool IsActive();
		public bool IsActive(Type type);
		public void ReleaseFlashObj(Type type);
		public void Release();
		public void Visible(Type type, bool v);
		public void Active(Type type, bool a);
		public void SetPosition(Type type, Vector3 offsetPos);
		private bool IsTypeBootyGroup(Type type);
		private bool IsSkillCutin(Type type);
		private bool IsSkillCutin(CharaSpecificFlashType csfType);
		private bool IsEnableSkillCutin(CharacterBase chara = null);
		private void OnLoadedFlashInstancePrefab(GameObject prefab, int index);
		public void PlayFlashInstance(FlashInstanceType type, Vector2 argPos, Transform parent = null);
		private FlashPlayer PlayFlashInstance(GameObject prefab, Vector2 argPos, Transform parent, int sortOrder);
		[CompilerGenerated]
		private void _Initialize_b__62_0(float x);
	}
}
