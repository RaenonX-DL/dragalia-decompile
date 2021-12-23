using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Dungeon;
using Gluon.Dungeon.Gimmick;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class DungeonManager
	{
		public abstract class AreaDataCache<Elem> where Elem : class
		{
			private Dictionary<string, Elem> _cache;

			public Elem GetOrDefault(string key)
			{
				return null;
			}

			public Elem Get(string key)
			{
				return null;
			}

			protected abstract int GetKeyCount();

			protected abstract string GetKey(int index);

			protected abstract Elem GetElem(int index);
		}

		public class PlannerAreaDataCache : AreaDataCache<DungeonAreaPlannerDataElement>
		{
			protected override int GetKeyCount()
			{
				return default(int);
			}

			protected override string GetKey(int index)
			{
				return null;
			}

			protected override DungeonAreaPlannerDataElement GetElem(int index)
			{
				return null;
			}

			public DungeonAreaPlannerDataElement Get(int id)
			{
				return null;
			}
		}

		public class DesignerAreaDataCache : AreaDataCache<DungeonAreaDesignerDataElement>
		{
			protected override int GetKeyCount()
			{
				return default(int);
			}

			protected override string GetKey(int index)
			{
				return null;
			}

			protected override DungeonAreaDesignerDataElement GetElem(int index)
			{
				return null;
			}
		}

		public class DungeonCharacterShaderCache : AreaDataCache<DungeonCharacterShaderDataElement>
		{
			protected override int GetKeyCount()
			{
				return default(int);
			}

			protected override string GetKey(int index)
			{
				return null;
			}

			protected override DungeonCharacterShaderDataElement GetElem(int index)
			{
				return null;
			}
		}

		public class OutDesignerAreaDataCache : AreaDataCache<OutDungeonAreaDesignerDataElement>
		{
			protected override int GetKeyCount()
			{
				return default(int);
			}

			protected override string GetKey(int index)
			{
				return null;
			}

			protected override OutDungeonAreaDesignerDataElement GetElem(int index)
			{
				return null;
			}
		}

		private class HpExpirationCharacter
		{
			public CharacterBase character;

			public int threshold;
		}

		public enum eStageDifficulty
		{
			None,
			Normal,
			Hard,
			VeryHard,
			Extreme,
			Hell,
			Variation6,
			Variation7,
			Variation8,
			Variation9,
			Variation10,
			MaxNum
		}

		private struct SpecialLayerChange
		{
			public int layer1;

			public int layer2;

			public bool isIgnore;

			public bool prevIsIgnore;
		}

		private class RendererData
		{
			public Renderer targetRenderer;

			public bool targetFlag;

			public RendererData(Renderer target)
			{
			}

			public void SetDrawFlag(bool flag)
			{
			}
		}

		public static readonly string[] DifficultyNameArray;

		private GameObject[] _subNodeObjects;

		private Gluon.Dungeon.Environment _environment;

		private EnvironmentMap _environmentMap;

		private List<DungeonObjectBase> _targetableObjects;

		private List<GimmickBase> productionTimeCallbackGimmickList;

		private List<DungeonObjectBase> _ReactionObjects;

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

		private List<Gluon.Dungeon.Environment.BossCameraEnemyData> _bossCameraEnemyList;

		private Gluon.Dungeon.Environment.HpExpiration[] _clearHpExpiration;

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

		private List<RendererData> rendererDataList;

		public GameObject map
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

		public GameObject gimmickRoot => null;

		public GameObject dropRoot => null;

		public GameObject otherRoot => null;

		public Gluon.Dungeon.Environment environment => null;

		public EnvironmentMap environmentMap => null;

		public MapCulling mapCulling => null;

		public List<DungeonObjectBase> TargetableObjects => null;

		public List<DungeonObjectBase> ReactionObjects => null;

		public DungeonBgModelProduction bgModelProduction
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

		public string dungeonSceneName => null;

		public string dungeonSubSceneName => null;

		public string dungeonAreaName => null;

		public DungeonSceneInfo sceneInfo => null;

		public Vector3 playerStartPos
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion playerStartLocalRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public bool locatedPlayerStart
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public eStageDifficulty stageDifficulty => default(eStageDifficulty);

		public string BGM
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

		public CameraType cameraType
		{
			[CompilerGenerated]
			get
			{
				return default(CameraType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BossCamera bossCameraType
		{
			[CompilerGenerated]
			get
			{
				return default(BossCamera);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<Gluon.Dungeon.Environment.BossCameraEnemyData> bossCameraEnemyList => null;

		public Gluon.Dungeon.Environment.HpExpiration[] clearHpExpiration => null;

		private int arrowTargetIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private int previousAreaIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private int currentAreaIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool hasBoss
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

		public DungeonAreaDesignerDataElement DesignerAreaData => null;

		public DungeonAreaPlannerDataElement PlannerAreaData => null;

		public static DesignerAreaDataCache designerAreaDataCache => null;

		public static PlannerAreaDataCache plannerAreaDataCache => null;

		public BossDropItemBoxCtrl BossDropItemBoxCtrl => null;

		public EnemyGenerator[] enemyGenerators => null;

		public EnemyEncountGroup[] enemyEncountGroups => null;

		public eStageDifficulty brEnemyStageDifficulty
		{
			[CompilerGenerated]
			get
			{
				return default(eStageDifficulty);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void EntryProductionTimeCallbackGimmick(GimmickBase tempGimmick)
		{
		}

		public void ClearProductionTimeCallbackGimmick()
		{
		}

		public void SendProductionTimeCallbackToGimmick()
		{
		}

		public void InitializeBgModelProduction()
		{
		}

		public Dictionary<int, int> GetEnemyGenerateLimitData()
		{
			return null;
		}

		public GameObject GetSubNode(DungeonSubNode subNode)
		{
			return null;
		}

		public void SetLoadDungeonData(string scenePath, string areaName, int targetIdx, int previousAreaIdx, int currentAreaIdx, eStageDifficulty difficulty, CameraGroup gameCameraGroup)
		{
		}

		public void SetLoadDungeonDataForDmode(DmodeDungeonAreaElement element, int targetIdx, int previousAreaIdx, int currentAreaIdx, CameraGroup gameCameraGroup)
		{
		}

		public List<string> GetDownloadAssets()
		{
			return null;
		}

		public bool IsMultiScene()
		{
			return default(bool);
		}

		public GameObject GetSubSceneRoot()
		{
			return null;
		}

		public IEnumerator LoadDungeon(bool additiveMode = false)
		{
			return null;
		}

		public DungeonAreaPlannerDataElement GetDmodeAltData()
		{
			return null;
		}

		public void AddInitializeLightProbeObject(GameObject go)
		{
		}

		public void SetLightProbeParam()
		{
		}

		private string GetGimmickEffectGroupName(string gimmickName)
		{
			return null;
		}

		private string GetGimmickEffectGroupShortName(string gimmickName)
		{
			return null;
		}

		private void LoadGimmickEffect(string gimmickName)
		{
		}

		private void LoadGateEffect(string name)
		{
		}

		private void LoadReactionEffect(string name)
		{
		}

		public GameObject CheckClearObject()
		{
			return null;
		}

		public bool ExistBossItemBox()
		{
			return default(bool);
		}

		public void SetBossItemBox(DropItemUI.Parameter param)
		{
		}

		public void DisplayBossItemBox()
		{
		}

		public bool IsOpenBossItemBox()
		{
			return default(bool);
		}

		public void InitializeSpecificTimeOperation()
		{
		}

		public void InitializeHpExpiration()
		{
		}

		public bool CheckHpExpiration()
		{
			return default(bool);
		}

		public float GetClearTermsTimeElapsed()
		{
			return default(float);
		}

		private void LocateObject(Transform parent)
		{
		}

		public void SucceedToAIScript(Action action)
		{
		}

		public void InitializeEnemies()
		{
		}

		public void ActiveEnemyGenerator(bool sw)
		{
		}

		public void StopEnemyGenerator()
		{
		}

		public EnemyGenerator GetEnemyGenerator(int generatorId)
		{
			return null;
		}

		public List<EnemyGenerator> GetActiveEnemyGenerators()
		{
			return null;
		}

		public EnemyEncountGroup GetEnemyEncountGroup(int groupId)
		{
			return null;
		}

		public Vector3 GetPlayerStartPos(int playerIndex)
		{
			return default(Vector3);
		}

		public Quaternion GetPlayerStartLocalRotation(int playerIndex)
		{
			return default(Quaternion);
		}

		public bool IsLocatedPlayerStart(int playerIndex)
		{
			return default(bool);
		}

		private bool IsMapCullingEnableScene()
		{
			return default(bool);
		}

		public EffectObject PlayUniqueEffect(string effectName, Vector3 pos, Quaternion rot, Vector3 scale, [Optional] GameObject go, float duration = 0f)
		{
			return null;
		}

		public EffectObject Play(string effectName, Vector3 pos, Quaternion rot, Vector3 scale, [Optional] GameObject go, float duration = 0f)
		{
			return null;
		}

		public EffectObject PlayNotDependedMaster(string effectName, Vector3 pos, Quaternion rot, Vector3 localScale, GameObject go, float duration, EffectObject.EraseType eraseType, float dissapearTime, int trigger = 0)
		{
			return null;
		}

		private void ApplyEffectModifier(EffectObject effectInst, DungeonEffectPlayParameter playParam)
		{
		}

		public void SetCameraCollision(CameraController cameraController)
		{
		}

		public List<Wall> GetWalls()
		{
			return null;
		}

		public List<NextArrow> GetNextArrows()
		{
			return null;
		}

		public static void SetEnvironmentMap(GameObject targetObj, string envMapLabel)
		{
		}

		public void SpecialLayerIgnoreEntry(int layer1, int layer2, bool isIgnore)
		{
		}

		public void SetSpecialLayerIgnore()
		{
		}

		public void RevertSpecialLayerIgnore()
		{
		}

		public void ClearQuestSkillStaticVariables()
		{
		}

		public AnchorObject GetNearestAnchorObject(Vector3 pos)
		{
			return null;
		}

		public void SetVisibleBgModel(bool visibleFlag)
		{
		}

		public void SetBossAppearCameraForDmode(BossCamera camera, List<Gluon.Dungeon.Environment.BossCameraEnemyData> enemies)
		{
		}
	}
}
