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
	public class Player : BaseObject
	{
		// Fields
		private static Player instance;
		[Header]
		[SerializeField]
		public Transform characterNode;
		public Transform charaHeadingNode;
		public Animator animator;
		public GameObject mainCharaNode;
		public GameObject subCharaNode;
		public SpriteRenderer itemGetEffect;
		public Sprite[] itemGetSpriteList;
		private int itemGetEffectTimer;
		private const int itemGetEffectProtectTime = 6;
		private const int itemGetEffectTotalTime = 12;
		private const int stackLastInputPos = 3;
		private Vector3[] lastInputPosList;
		private float chasingInputX;
		private float chasingInputY;
		private const float inputScale = 1.3f;
		public const float r = 2f;
		public const float grazeR = 40f;
		public const int saveLastPosCount = 4;
		[NonSerialized]
		public float[] lastX;
		[NonSerialized]
		public float[] lastY;
		private float lastXForMove;
		private const float headingXEps = 1f;
		private const float slowHeadingSpeed = 2f;
		private const float fastHeadingSpeed = 5f;
		private const float headingMax = 30f;
		[NonSerialized]
		public int recoverTimer;
		public const int damageRecoverWaitTime = 300;
		public const int damageRecoverTime = 60;
		public const int damageRecoverToLife = 3;
		public const int extremeCharaLevel = 59;
		public const int extremeSubCharaLevel = 98;
		private Vector3 initHeadingAngles;
		[Header]
		[SerializeField]
		public SPFXAttacher locusEffect;
		public SPFXAttacher damageEffect;
		private const float enteringPosStartX = 0f;
		private const float enteringPosEndX = 320f;
		private const float enteringPosStartY = 920f;
		private const float enteringPosEndY = 780f;
		private int getItemCount;
		private const int enteringTime = 80;
		private const int shotMoveTime = 120;
		[NonSerialized]
		public int nLife;
		[NonSerialized]
		public State state;
		private InvincibleReason invincibleReason;
		private Renderer[] playerRendererList;
		private int invincibleTimer;
		private int shotTimer;
		private int shootTimer;
		private int enterTimer;
		private int nBounceAngle;
		private int bombTimer;
		private const int bombMaxTime = 180;
		private int maxLevel;
		private int powerScoreBonusMulIndex;
		public readonly int[] powerScoreBonusMulList;
		public int score;
		[SerializeField]
		public int level;
		public bool lockLevel;
		[CompilerGenerated]
		private bool _isDebugKeepShooting_k__BackingField;
	
		// Properties
		public static Player Instance { get; }
		public bool isInvincible { get; }
		public bool isNonDebugInvincible { get; }
		public bool isOnShotAvoid { get; }
		public bool isDebugInvincible { get; set; }
		public bool isDebugKeepShooting { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[Flags]
		public enum State
		{
			None = 0,
			Entering = 1,
			Shot = 2,
			Die = 8,
			Shoot = 16,
			Drain = 32,
			Graze = 4096,
			Bomb = 8192
		}
	
		public enum InvincibleReason
		{
			None = 0,
			Entering = 1,
			Exiting = 2,
			Chat = 3,
			Shot = 4,
			Die = 5,
			Debug = 6,
			Recharge = 7,
			Bomb = 8
		}
	
		// Constructors
		private Player();
		static Player();
	
		// Methods
		public static bool IsInstanceEmpty();
		public void LoadResource();
		public void Restart();
		public void Continue();
		private bool EnterStage();
		private bool Shot();
		private bool Shoot();
		private void SetInvincible(InvincibleReason reason, int time);
		public void DoShot();
		public void DoAddScore(int addScore, int enemyLevel = -1, ItemManager.TemplateType type = ItemManager.TemplateType.None);
		public void DoAddShootLevel(int addLevel);
		public void DoBomb();
		public int DoItemGet(Item item, float _x, float _y);
		public void DoGraze(float x, float y);
		private void LateUpdate();
		private void UpdateMove();
		private bool Bomb();
		public void Action(int time);
	}
}
