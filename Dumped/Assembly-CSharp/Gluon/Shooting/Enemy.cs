/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	[LuaCallCSharp]
	public class Enemy : BaseObject
	{
		// Fields
		public EnemyTemplate template;
		private int infiTimer;
		private int damageTimer;
		[NonSerialized]
		public int level;
		private EnemyManager.TemplateType type;
		private float xplus;
		private float yplus;
		[NonSerialized]
		public float life;
		[NonSerialized]
		public float maxLife;
		[NonSerialized]
		public bool able;
		private int lastAngle;
		private float lastSpeed;
		private ItemManager.TemplateType takeItemType;
		private int takeNum;
		private int fadeOutTime;
		private const int damageTotalTime = 8;
		private bool enteredVisibleArea;
		private int score;
		private int guideAction;
		private int subIndex;
		private GameParameterController.ParseEnemyPatternDefineTable subSchedule;
		private int scheduleNextBulletTime;
		private const int bossStartActionTime = 90;
		private const int bossDamageTime = 90;
		[NonSerialized]
		public int bossPhase;
		private int bossActionIndex;
		private int bossActionTimer;
		private GameParameterController.ParseBossActionOrderTable bossAction;
		[NonSerialized]
		public int totalTimer;
		[NonSerialized]
		public int bossClearRank;
		public static int defaultBossExitTime;
		public static int bossExitTime;
		public static int extremeBossExitTime;
		private const int bossExitExtension = 600;
		private const float bossExitExtensionRate = 0.15f;
		private const int bossExitBlackOutStartTime = 240;
		private const int bossExitBlackOutDuration = 15;
		private const int bossTurnRedTime = 900;
		private const int bossBlackOutStartTime = 360;
		private const int bossBlackOutDuration = 15;
		private const int bossThrowStarBeginTime = 120;
		[NonSerialized]
		public int bossExitTimer;
		private int bossCrushTime;
		private int[,] crushSpeedTable;
		private CatmullRomSpline spline;
		private float startX;
		private float startY;
		private bool applySplineStart;
		private bool splineInvertX;
		private int splineStartTime;
		private FPara fPara;
		private IPara iPara;
		[NonSerialized]
		public SavePara savePara;
		private ActionDefine ac;
		private Phase phase;
	
		// Nested types
		public struct FPara
		{
			// Fields
			public float x;
			public float y;
			public float speed;
			public float friction;
	
			// Methods
			public void Clear();
		}
	
		public struct IPara
		{
			// Fields
			public int angle;
			public int time;
			public int counter;
			public int endTime;
	
			// Methods
			public void Clear();
		}
	
		public struct SavePara
		{
			// Fields
			public int amap;
			public float x;
			public float y;
			public int t;
		}
	
		public enum ActionDefine
		{
			ENAC_NONE = 0,
			ENAC_DIRECTSET_XYSOAOOO = 1,
			ENAC_CHASEPLAYER_OOSFATOO = 2,
			ENAC_CHASEAIM_XYSOAOCE = 3,
			ENAC_TURNANGLE_OOOFATOE = 4,
			ENAC_FADEOUT_OOOOOTOO = 64,
			ENAC_REPOSITION_OOOOOOCO = 128,
			ENAC_OVERPLAYER_XYOOOTCE = 129,
			ENAC_DELAY_OOOOOTOO = 192
		}
	
		public enum Phase
		{
			Normal = 0,
			FadeOut = 1
		}
	
		// Constructors
		public Enemy();
		static Enemy();
	
		// Methods
		private void SetWhiteFlash();
		private void SetBossRed(int t, int totalT);
		public void Action();
		public int GetBossActionTimer();
		public string GetBossAction();
		public Vector2 GetJawPosition();
		public Vector2 GetWingLPosition();
		public Vector2 GetWingRPosition();
		public Vector2 GetTailPosition();
		public Vector2 GetChestPosition();
		public void SetSliderWatch();
		private void BossAction();
		private void ProcessSchedule();
		private void UpdateFadeOutFrame();
		public void SetTake(ItemManager.TemplateType type, int num);
		private void GiveItem();
		public bool OnDamage(float power);
		public bool IsInRect(float aimx, float aimy, float r, float w, float h, int nextstep = 0);
		public void SetSortingOrder(int z);
		public void DoShot();
		public void SetCatmull(EnemyManager.CatmullType type, bool invertX = false, bool applyStart = true);
		public bool ValueSet(int index, float x, float y, int angle, float speed, EnemyManager.TemplateType type, int level, GameParameterController.ParseEnemyPatternDefineTable subSchedule, int guideAction, int subIndex, int infiTimer);
		private void MatchAction();
		public void KickAnimatorTrigger(string trigger);
		public void SetAction(ActionDefine _ac, float _para_x = 0f, float _para_y = 0f, float _para_speed = 0f, float _para_friction = 0f, int _para_angle = 0, int _para_time = 0, int _para_counter = 0, int _para_endtime = 0);
		private void FadeOut();
		public bool IsLivingTeamedEnemy();
	}
}
