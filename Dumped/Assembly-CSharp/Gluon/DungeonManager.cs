/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;
using Gluon.Dungeon.Gimmick;
using Gluon.Master;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DungeonManager
	{
		// Fields
		public static readonly string[] DifficultyNameArray;
		[CompilerGenerated]
		private GameObject _map_k__BackingField;
		private GameObject[] _subNodeObjects;
		private Gluon.Dungeon.Environment _environment;
		private EnvironmentMap _environmentMap;
		private List<DungeonObjectBase> _targetableObjects;
		private List<GimmickBase> productionTimeCallbackGimmickList;
		private List<DungeonObjectBase> _ReactionObjects;
		[CompilerGenerated]
		private DungeonBgModelProduction _bgModelProduction_k__BackingField;
		public static readonly DungeonSubNode BgModelProductionAttachSubNode;
		private string _dungeonResourcePath;
		private string _dungeonSubSceneResourcePath;
		private string _questPrefabPath;
		private string _dungeonSceneName;
		private string _dungeonSubSceneName;
		private string _dungeonAreaName;
		private DungeonSceneInfo _sceneInfo;
		private Vector3[] _playerStartPositions;
		private Quaternion[] _playerStartLocalRotations;
		private bool[] _locatedPlayerStart;
		public Transform guestStartTransform;
		private eStageDifficulty _stageDifficulty;
		[CompilerGenerated]
		private string _BGM_k__BackingField;
		[CompilerGenerated]
		private CameraType _cameraType_k__BackingField;
		[CompilerGenerated]
		private BossCamera _bossCameraType_k__BackingField;
		private List<Gluon.Dungeon.Environment.BossCameraEnemyData> _bossCameraEnemyList;
		private Gluon.Dungeon.Environment.HpExpiration[] _clearHpExpiration;
		[CompilerGenerated]
		private int _arrowTargetIndex_k__BackingField;
		[CompilerGenerated]
		private int _previousAreaIndex_k__BackingField;
		[CompilerGenerated]
		private int _currentAreaIndex_k__BackingField;
		[CompilerGenerated]
		private bool _hasBoss_k__BackingField;
		private List<HpExpirationCharacter> hpExpirationCharacterList;
		private DungeonAreaDesignerDataElement _designerAreaData;
		private DungeonAreaPlannerDataElement _plannerAreaData;
		private DungeonCharacterShaderDataElement _characterShaderData;
		private static DesignerAreaDataCache _designerAreaDataCache;
		private static PlannerAreaDataCache _plannerAreaDataCache;
		private static DungeonCharacterShaderCache _characterShaderCache;
		public string startSystemMessage;
		private Action _postInitializeSucceedAi;
		private BossDropItemBoxCtrl bossDropItemBoxCtrl;
		private DungeonEffectModifier dungeonEffectModifier;
		private Dictionary<string, EffectObject> dungeonUniqueEffectDict;
		private List<GameObject> initializeLightProbeList;
		private AnchorObject[] allAnchorObjectArray;
		private List<SpecialLayerChange> specialLayerChange;
		private EnemyGeneratorVariationData enemyGeneratorVariationData;
		private EnemyGenerator[] _enemyGenerators;
		private EnemyEncountGroup[] _enemyEncountGroups;
		private CameraGroup _gameCameraGroup;
		public bool isLoadDungeonEnd;
		private List<Wall> wallsCache;
		private List<NextArrow> nextArrowsCache;
		[CompilerGenerated]
		private eStageDifficulty _brEnemyStageDifficulty_k__BackingField;
	
		// Properties
		public GameObject map { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public GameObject gimmickRoot { get; }
		public GameObject dropRoot { get; }
		public GameObject otherRoot { get; }
		public Gluon.Dungeon.Environment environment { get; }
		public EnvironmentMap environmentMap { get; }
		public MapCulling mapCulling { get; }
		public List<DungeonObjectBase> TargetableObjects { get; }
		public List<DungeonObjectBase> ReactionObjects { get; }
		public DungeonBgModelProduction bgModelProduction { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string dungeonSceneName { get; }
		public string dungeonSubSceneName { get; }
		public string dungeonAreaName { get; }
		public DungeonSceneInfo sceneInfo { get; }
		public Vector3 playerStartPos { get; set; }
		public Quaternion playerStartLocalRotation { get; set; }
		public bool locatedPlayerStart { get; private set; }
		public eStageDifficulty stageDifficulty { get; }
		public string BGM { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CameraType cameraType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public BossCamera bossCameraType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<Gluon.Dungeon.Environment.BossCameraEnemyData> bossCameraEnemyList { get; }
		public Gluon.Dungeon.Environment.HpExpiration[] clearHpExpiration { get; }
		private int arrowTargetIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		private int previousAreaIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		private int currentAreaIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool hasBoss { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DungeonAreaDesignerDataElement DesignerAreaData { get; }
		public DungeonAreaPlannerDataElement PlannerAreaData { get; }
		public static DesignerAreaDataCache designerAreaDataCache { get; }
		public static PlannerAreaDataCache plannerAreaDataCache { get; }
		public BossDropItemBoxCtrl BossDropItemBoxCtrl { get; }
		public EnemyGenerator[] enemyGenerators { get; }
		public EnemyEncountGroup[] enemyEncountGroups { get; }
		public eStageDifficulty brEnemyStageDifficulty { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public abstract class AreaDataCache<Elem>
			where Elem : class
		{
			// Fields
			private Dictionary<string, Elem> _cache;
	
			// Constructors
			protected AreaDataCache();
	
			// Methods
			public Elem GetOrDefault(string key);
			public Elem Get(string key);
			protected abstract int GetKeyCount();
			protected abstract string GetKey(int index);
			protected abstract Elem GetElem(int index);
		}
	
		public class PlannerAreaDataCache : AreaDataCache<DungeonAreaPlannerDataElement>
		{
			// Constructors
			public PlannerAreaDataCache();
	
			// Methods
			protected override int GetKeyCount();
			protected override string GetKey(int index);
			protected override DungeonAreaPlannerDataElement GetElem(int index);
		}
	
		public class DesignerAreaDataCache : AreaDataCache<DungeonAreaDesignerDataElement>
		{
			// Constructors
			public DesignerAreaDataCache();
	
			// Methods
			protected override int GetKeyCount();
			protected override string GetKey(int index);
			protected override DungeonAreaDesignerDataElement GetElem(int index);
		}
	
		public class DungeonCharacterShaderCache : AreaDataCache<DungeonCharacterShaderDataElement>
		{
			// Constructors
			public DungeonCharacterShaderCache();
	
			// Methods
			protected override int GetKeyCount();
			protected override string GetKey(int index);
			protected override DungeonCharacterShaderDataElement GetElem(int index);
		}
	
		public class OutDesignerAreaDataCache : AreaDataCache<OutDungeonAreaDesignerDataElement>
		{
			// Constructors
			public OutDesignerAreaDataCache();
	
			// Methods
			protected override int GetKeyCount();
			protected override string GetKey(int index);
			protected override OutDungeonAreaDesignerDataElement GetElem(int index);
		}
	
		private class HpExpirationCharacter
		{
			// Fields
			public CharacterBase character;
			public int threshold;
	
			// Constructors
			public HpExpirationCharacter();
		}
	
		public enum eStageDifficulty
		{
			None = 0,
			Normal = 1,
			Hard = 2,
			VeryHard = 3,
			Extreme = 4,
			Hell = 5,
			Variation6 = 6,
			Variation7 = 7,
			Variation8 = 8,
			Variation9 = 9,
			Variation10 = 10,
			MaxNum = 11
		}
	
		private struct SpecialLayerChange
		{
			// Fields
			public int layer1;
			public int layer2;
			public bool isIgnore;
			public bool prevIsIgnore;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass155_0
		{
			// Fields
			public bool isLoaded;
			public bool isLoadedMulti;
			public bool isLoadedQeustPrefab;
	
			// Constructors
			public __c__DisplayClass155_0();
	
			// Methods
			internal void _LoadDungeon_b__0();
			internal void _LoadDungeon_b__1();
			internal void _LoadDungeon_b__2(GameObject go);
		}
	
		[CompilerGenerated]
		private sealed class _LoadDungeon_d__155 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DungeonManager __4__this;
			private __c__DisplayClass155_0 __8__1;
			public bool additiveMode;
			private bool _isMultiScene_5__2;
			private Scene _scene_5__3;
			private Scene _subScene_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadDungeon_d__155(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DungeonManager();
		static DungeonManager();
	
		// Methods
		public void EntryProductionTimeCallbackGimmick(GimmickBase tempGimmick);
		public void ClearProductionTimeCallbackGimmick();
		public void SendProductionTimeCallbackToGimmick();
		public void InitializeBgModelProduction();
		public Dictionary<int, int> GetEnemyGenerateLimitData();
		public GameObject GetSubNode(DungeonSubNode subNode);
		public void SetLoadDungeonData(string scenePath, string areaName, int targetIdx, int previousAreaIdx, int currentAreaIdx, eStageDifficulty difficulty, CameraGroup gameCameraGroup);
		public List<string> GetDownloadAssets();
		public bool IsMultiScene();
		public GameObject GetSubSceneRoot();
		[IteratorStateMachine]
		public IEnumerator LoadDungeon(bool additiveMode = false);
		public void AddInitializeLightProbeObject(GameObject go);
		public void SetLightProbeParam();
		private string GetGimmickEffectGroupName(string gimmickName);
		private string GetGimmickEffectGroupShortName(string gimmickName);
		private void LoadGimmickEffect(string gimmickName);
		private void LoadGateEffect(string name);
		private void LoadReactionEffect(string name);
		public GameObject CheckClearObject();
		public bool ExistBossItemBox();
		public void SetBossItemBox(DropItemUI.Parameter param);
		public void DisplayBossItemBox();
		public bool IsOpenBossItemBox();
		public void InitializeSpecificTimeOperation();
		public void InitializeHpExpiration();
		public bool CheckHpExpiration();
		public float GetClearTermsTimeElapsed();
		private void LocateObject(Transform parent);
		public void SucceedToAIScript(Action action);
		public void InitializeEnemies();
		public void ActiveEnemyGenerator(bool sw);
		public void StopEnemyGenerator();
		public EnemyGenerator GetEnemyGenerator(int generatorId);
		public List<EnemyGenerator> GetActiveEnemyGenerators();
		public EnemyEncountGroup GetEnemyEncountGroup(int groupId);
		public Vector3 GetPlayerStartPos(int playerIndex);
		public Quaternion GetPlayerStartLocalRotation(int playerIndex);
		public bool IsLocatedPlayerStart(int playerIndex);
		private bool IsMapCullingEnableScene();
		public EffectObject PlayUniqueEffect(string effectName, Vector3 pos, Quaternion rot, Vector3 scale, GameObject go = null, float duration = 0f);
		public EffectObject Play(string effectName, Vector3 pos, Quaternion rot, Vector3 scale, GameObject go = null, float duration = 0f);
		public EffectObject PlayNotDependedMaster(string effectName, Vector3 pos, Quaternion rot, Vector3 localScale, GameObject go, float duration, EffectObject.EraseType eraseType, float dissapearTime, int trigger = 0);
		private void ApplyEffectModifier(EffectObject effectInst, DungeonEffectPlayParameter playParam);
		public void SetCameraCollision(CameraController cameraController);
		public List<Wall> GetWalls();
		public List<NextArrow> GetNextArrows();
		public static void SetEnvironmentMap(GameObject targetObj, string envMapLabel);
		public void SpecialLayerIgnoreEntry(int layer1, int layer2, bool isIgnore);
		public void SetSpecialLayerIgnore();
		public void RevertSpecialLayerIgnore();
		public AnchorObject GetNearestAnchorObject(Vector3 pos);
	}
}
