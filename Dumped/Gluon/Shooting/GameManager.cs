using System;
using System.Collections;
using UnityEngine;
using XLua;

namespace Gluon.Shooting
{
	[LuaCallCSharp(GenFlag.No)]
	public class GameManager : SceneBase
	{
		[CSharpCallLua]
		public delegate void LuaOnUpdate(int time);

		[CSharpCallLua]
		public delegate void LuaOnEnemyUpdate(Enemy enemy, EnemyManager.TemplateType type, int level);

		private static GameManager instance;

		[SerializeField]
		[Header("Node")]
		public Transform bulletLayerNode;

		public Transform playerBulletLayerNode;

		public Transform enemyLayerNode;

		public Transform uiNode;

		public Transform stageNode;

		public Transform playerNode;

		public Transform itemLayerNode;

		public Transform flashNode;

		[SerializeField]
		[Header("Camera")]
		public Camera stageCamera;

		public Camera camera2D;

		public Camera camera3D;

		[SerializeField]
		[Header("Canvas")]
		public Canvas canvas;

		[SerializeField]
		[Header("Script")]
		public TextAsset extremeTextAsset;

		public TextAsset normalTextAsset;

		public bool isExtreme;

		[SerializeField]
		[Header("Flash")]
		public FlashPlayerManager flashPlayerManager;

		private FlashPlayer flashPlayer;

		private bool isFlashInDone;

		private bool isFlashOutDone;

		[NonSerialized]
		public STGUI stgUI;

		[NonSerialized]
		public BulletManager bulletManager;

		[NonSerialized]
		public PlayerBulletManager playerBulletManager;

		[NonSerialized]
		public EnemyManager enemyManager;

		[NonSerialized]
		public ItemManager itemManager;

		[NonSerialized]
		public ShootingBG shootingBG;

		[NonSerialized]
		public int time;

		private TextAsset luaScript;

		private LuaEnv luaEnv;

		private LuaTable scriptEnv;

		private LuaOnUpdate onLuaUpdate;

		private LuaOnEnemyUpdate onLuaEnemyUpdate;

		public const string prefabPath = "Prefabs/OutGame/APRIL2019_STG/";

		[NonSerialized]
		public int currentEnemyOrder;

		[NonSerialized]
		public int currentEnemyLevel;

		[NonSerialized]
		public int currentFafnirLevel;

		[NonSerialized]
		public int currentTeamTime;

		[NonSerialized]
		public int waitEnemyMaxTime;

		[NonSerialized]
		public int debugLoopSchedule;

		[NonSerialized]
		public GameParameterController.ParseEnemyOrderTable schedule;

		[NonSerialized]
		public GameParameterController.ParseEnemyPatternDefineTable subSchedule;

		[NonSerialized]
		public GameParameterController.ParseEnemyPatternDefineTable subFafSchedule;

		[NonSerialized]
		public int bossLevel;

		public const int scheduleEnemyInterval = 30;

		public const int firstWaveTime = 150;

		[NonSerialized]
		public int teamInterval;

		public const int stopWaveTime = 5500;

		public const int normalBGMFadeOutTime = 5838;

		public const int bossWakeTime = 6300;

		public const int encounterBossVoice = 6350;

		public const int bossAppearShowTime = 6450;

		public const int stageEntryTime = 50;

		private bool firstEntry;

		private ShootingUnitShaderSettings unitShaderSettings;

		private static Vector3 usingVector3;

		private static Matrix4x4 viewPortToWorldMatrix;

		private static Vector3 halfScreenSize;

		private static float aspect;

		private static float orthoSize;

		private int slowTimer;

		private float slowRate;

		public static GameManager Instance => null;

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		private GameManager()
		{
		}

		static GameManager()
		{
		}

		protected virtual void Awake()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public static Vector2 GamePosToCamPos(float x, float y)
		{
			return default(Vector2);
		}

		private void AdjustEtoE()
		{
		}

		private void LoadPlayer()
		{
		}

		private void LoadBG()
		{
		}

		private void LoadBulletLayer()
		{
		}

		private void LoadPlayerBulletLayer()
		{
		}

		private void LoadItemLayer()
		{
		}

		private void LoadEnemyLayer()
		{
		}

		private void LoadUI()
		{
		}

		private void LoadLuaScript()
		{
		}

		public void GoResult()
		{
		}

		public void ReloadLua()
		{
		}

		public void Restart(bool fromMenu = false)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnterScene()
		{
		}

		private IEnumerator LoadScene()
		{
			return null;
		}

		private void OnPrevSceneExitDone()
		{
		}

		public bool IsRunning()
		{
			return default(bool);
		}

		private void OnInitReady()
		{
		}

		public void StopGame()
		{
		}

		public void OnEnemyUpdate(Enemy enemy, EnemyManager.TemplateType type, int level)
		{
		}

		private bool IsPlayerMovable()
		{
			return default(bool);
		}

		public void TriggerFafnirSpecialSchedule(int guideAction)
		{
		}

		private void ArrangeNextSchedule()
		{
		}

		public int GetBossLevel()
		{
			return default(int);
		}

		private void ScheduleEnemy()
		{
		}

		public void SetSlow(int val, float rate = 0.5f)
		{
		}

		public bool CanPause()
		{
			return default(bool);
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
