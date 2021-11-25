using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua;

namespace Gluon.Shooting
{
	[LuaCallCSharp(GenFlag.No)]
	public class Player : BaseObject
	{
		[Flags]
		public enum State
		{
			None = 0x0,
			Entering = 0x1,
			Shot = 0x2,
			Die = 0x8,
			Shoot = 0x10,
			Drain = 0x20,
			Graze = 0x1000,
			Bomb = 0x2000
		}

		public enum InvincibleReason
		{
			None,
			Entering,
			Exiting,
			Chat,
			Shot,
			Die,
			Debug,
			Recharge,
			Bomb
		}

		private static Player instance;

		[SerializeField]
		[Header("Unit")]
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

		[SerializeField]
		[Header("Effect")]
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

		public static Player Instance => null;

		public bool isInvincible => default(bool);

		public bool isNonDebugInvincible => default(bool);

		public bool isOnShotAvoid => default(bool);

		public bool isDebugInvincible
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isDebugKeepShooting
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		private Player()
		{
		}

		static Player()
		{
		}

		public void LoadResource()
		{
		}

		public void Restart()
		{
		}

		public void Continue()
		{
		}

		private bool EnterStage()
		{
			return default(bool);
		}

		private bool Shot()
		{
			return default(bool);
		}

		private bool Shoot()
		{
			return default(bool);
		}

		private void SetInvincible(InvincibleReason reason, int time)
		{
		}

		public void DoShot()
		{
		}

		public void DoAddScore(int addScore, int enemyLevel = -1, ItemManager.TemplateType type = ItemManager.TemplateType.None)
		{
		}

		public void DoAddShootLevel(int addLevel)
		{
		}

		public void DoBomb()
		{
		}

		public int DoItemGet(Item item, float _x, float _y)
		{
			return default(int);
		}

		public void DoGraze(float x, float y)
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateMove()
		{
		}

		private bool Bomb()
		{
			return default(bool);
		}

		public void Action(int time)
		{
		}
	}
}
