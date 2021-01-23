/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;
using XLua;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	[LuaCallCSharp]
	public class GameManager : SceneBase
	{
		// Fields
		private static GameManager instance;
		[Header]
		[SerializeField]
		public Transform bulletLayerNode;
		public Transform playerBulletLayerNode;
		public Transform enemyLayerNode;
		public Transform uiNode;
		public Transform stageNode;
		public Transform playerNode;
		public Transform itemLayerNode;
		public Transform flashNode;
		[Header]
		[SerializeField]
		public Camera stageCamera;
		public Camera camera2D;
		public Camera camera3D;
		[Header]
		[SerializeField]
		public Canvas canvas;
		[Header]
		[SerializeField]
		public TextAsset extremeTextAsset;
		public TextAsset normalTextAsset;
		public bool isExtreme;
		[Header]
		[SerializeField]
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
	
		// Properties
		public static GameManager Instance { get; }
	
		// Nested types
		[CSharpCallLua]
		public delegate void LuaOnUpdate(int time);
	
		[CSharpCallLua]
		public delegate void LuaOnEnemyUpdate(Enemy enemy, EnemyManager.TemplateType type, int level);
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public bool spfxDone;
			public GameManager __4__this;
	
			// Constructors
			public __c__DisplayClass63_0();
	
			// Methods
			internal void _Start_b__0();
			internal void _Start_b__3();
			internal void _Start_b__4();
			internal bool _Start_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__63_2;
			public static Func<bool> __9__84_0;
			public static Func<bool> __9__84_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__63_2();
			internal bool _LoadScene_b__84_0();
			internal bool _LoadScene_b__84_1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__63 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GameManager __4__this;
			private __c__DisplayClass63_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__63(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadScene_d__84 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GameManager __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadScene_d__84(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		private GameManager();
		static GameManager();
	
		// Methods
		public static bool IsInstanceEmpty();
		protected virtual void Awake();
		private new void OnApplicationPause(bool pauseStatus);
		[IteratorStateMachine]
		private IEnumerator Start();
		public static Vector2 GamePosToCamPos(float x, float y);
		private void AdjustEtoE();
		private void LoadPlayer();
		private void LoadBG();
		private void LoadBulletLayer();
		private void LoadPlayerBulletLayer();
		private void LoadItemLayer();
		private void LoadEnemyLayer();
		private void LoadUI();
		private void LoadLuaScript();
		public void GoResult();
		public void ReloadLua();
		public void Restart(bool fromMenu = false);
		private void OnDestroy();
		private void OnEnterScene();
		[IteratorStateMachine]
		private IEnumerator LoadScene();
		private void OnPrevSceneExitDone();
		public bool IsRunning();
		private void OnInitReady();
		public void StopGame();
		public void OnEnemyUpdate(Enemy enemy, EnemyManager.TemplateType type, int level);
		private bool IsPlayerMovable();
		public void TriggerFafnirSpecialSchedule(int guideAction);
		private void ArrangeNextSchedule();
		public int GetBossLevel();
		private void ScheduleEnemy();
		public void SetSlow(int val, float rate = 0.5f);
		public bool CanPause();
		private void Update();
		private void FixedUpdate();
		[CompilerGenerated]
		private bool _LoadScene_b__84_2();
		[CompilerGenerated]
		private bool _LoadScene_b__84_3();
	}
}
