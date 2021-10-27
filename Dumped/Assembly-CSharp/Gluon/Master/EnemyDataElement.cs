/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EnemyDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _EnemyGroupName;
		[SerializeField]
		private int _Category;
		[SerializeField]
		private int _BaseId;
		[SerializeField]
		private int _VariationId;
		[SerializeField]
		private int _WeaponId;
		[SerializeField]
		private int _NondominanntHandWeaponId;
		[SerializeField]
		private int _WeaponSkinId;
		[SerializeField]
		private int _NondominanntHandWeaponSkinId;
		[SerializeField]
		private string _AttachEnemyObj;
		[SerializeField]
		private string _AnimFileName;
		[SerializeField]
		private ElementalType _ElementalType;
		[SerializeField]
		private int _BookId;
		[SerializeField]
		private float _BaseRadius;
		[SerializeField]
		private float _BaseHeight;
		[SerializeField]
		private int _IsHitCollisionCenter;
		[SerializeField]
		private int _DeadIdlingFrame;
		[SerializeField]
		private int _IsInitWaitOrder;
		[SerializeField]
		private int _IsForcedDeadNoReward;
		[SerializeField]
		private float _BreakDuration;
		[SerializeField]
		private float _SkinScale;
		[SerializeField]
		private float _BossAppearScale;
		[SerializeField]
		private float _ShadowSize;
		[SerializeField]
		private int _IsHideShadow;
		[SerializeField]
		private float _EffectScale;
		[SerializeField]
		private float _AuraScale;
		[SerializeField]
		private float _EmotionIconScale;
		[SerializeField]
		private float _EmotionIconHeight;
		[SerializeField]
		private int _IsShowBossEnemyMark;
		[SerializeField]
		private int _IsHideHpGauge;
		[SerializeField]
		private float _HpGaugeHeight;
		[SerializeField]
		private int _IsHideDamageUI;
		[SerializeField]
		private int _DamagedTime;
		[SerializeField]
		private float _KbRate;
		[SerializeField]
		private float _KbSpeed;
		[SerializeField]
		private float _SabkbRate;
		[SerializeField]
		private float _AbsorptionRate;
		[SerializeField]
		private float _Mass;
		[SerializeField]
		private float _MoveSpeed;
		[SerializeField]
		private float _TurnSpeed;
		[SerializeField]
		private float _SearchRange;
		[SerializeField]
		private float _SearchLimitDistance;
		[SerializeField]
		private bool _IsBlast;
		[SerializeField]
		private bool _IsTurnToDamageDir;
		[SerializeField]
		private bool _IsValidSplitDamage;
		[SerializeField]
		private bool _IsHitFlash;
		[SerializeField]
		private int _SuperArmor;
		[SerializeField]
		private bool _IsMoveSuperArmor;
		[SerializeField]
		private string _ActionGroupName;
		[SerializeField]
		private int _ActionForQuestSelect;
		[SerializeField]
		private CharaFaceEyeMotion _BossAppearEye;
		[SerializeField]
		private CharaFaceMouthMotion _BossAppearMouth;
		[SerializeField]
		private int _SilhouetteValue;
		[SerializeField]
		private int _StrongerEffect;
		[SerializeField]
		private float _BreakAtkRate;
		[SerializeField]
		private float _BreakDefRate;
		[SerializeField]
		private float _ObAtkRate;
		[SerializeField]
		private float _ObDefRate;
		[SerializeField]
		private float _ToOverdriveTime;
		[SerializeField]
		private string _OdIdleStateName;
		[SerializeField]
		private string _OdWalkStateName;
		[SerializeField]
		private float _BarrierDelay;
		[SerializeField]
		private float _DropRange;
		[SerializeField]
		private string _DmgEffName;
		[SerializeField]
		private string _DmgSeName;
		[SerializeField]
		private int _NotTargetedByPlayerAI;
		[SerializeField]
		private int _NotHitByPlayerAI;
		[SerializeField]
		private int _NotDeleteParts;
		[SerializeField]
		private int _IsPartsSelfDef;
		[SerializeField]
		private int _NotShareBarrier;
		[SerializeField]
		private int _CounterToCenter;
		[SerializeField]
		private float _RespawnInvincibleSec;
		[SerializeField]
		private int _MultipleEnemyNameExtension;
		[SerializeField]
		private int _IgnoreHeightForFollowerTargeting;
		[SerializeField]
		private int _CountdownHP;
		[SerializeField]
		private int _SameHitPriority;
	
		// Properties
		public int Id { get; }
		public string EnemyGroupName { get; }
		public int Category { get; }
		public int BaseId { get; }
		public int VariationId { get; }
		public int WeaponId { get; }
		public int NondominanntHandWeaponId { get; }
		public int WeaponSkinId { get; }
		public int NondominanntHandWeaponSkinId { get; }
		public string AttachEnemyObj { get; }
		public string AnimFileName { get; }
		public ElementalType ElementalType { get; }
		public int BookId { get; }
		public float BaseRadius { get; }
		public float BaseHeight { get; }
		public int IsHitCollisionCenter { get; }
		public int DeadIdlingFrame { get; }
		public int IsInitWaitOrder { get; }
		public int IsForcedDeadNoReward { get; }
		public float BreakDuration { get; }
		public float SkinScale { get; }
		public float BossAppearScale { get; }
		public float ShadowSize { get; }
		public int IsHideShadow { get; }
		public float EffectScale { get; }
		public float AuraScale { get; }
		public float EmotionIconScale { get; }
		public float EmotionIconHeight { get; }
		public int IsShowBossEnemyMark { get; }
		public int IsHideHpGauge { get; }
		public float HpGaugeHeight { get; }
		public int IsHideDamageUI { get; }
		public int DamagedTime { get; }
		public float KbRate { get; }
		public float KbSpeed { get; }
		public float SabkbRate { get; }
		public float AbsorptionRate { get; }
		public float Mass { get; }
		public float MoveSpeed { get; }
		public float TurnSpeed { get; }
		public float SearchRange { get; }
		public float SearchLimitDistance { get; }
		public bool IsBlast { get; }
		public bool IsTurnToDamageDir { get; }
		public bool IsValidSplitDamage { get; }
		public bool IsHitFlash { get; }
		public int SuperArmor { get; }
		public bool IsMoveSuperArmor { get; }
		public string ActionGroupName { get; }
		public int ActionForQuestSelect { get; }
		public CharaFaceEyeMotion BossAppearEye { get; }
		public CharaFaceMouthMotion BossAppearMouth { get; }
		public int SilhouetteValue { get; }
		public int StrongerEffect { get; }
		public float BreakAtkRate { get; }
		public float BreakDefRate { get; }
		public float ObAtkRate { get; }
		public float ObDefRate { get; }
		public float ToOverdriveTime { get; }
		public string OdIdleStateName { get; }
		public string OdWalkStateName { get; }
		public float BarrierDelay { get; }
		public float DropRange { get; }
		public string DmgEffName { get; }
		public string DmgSeName { get; }
		public int NotTargetedByPlayerAI { get; }
		public int NotHitByPlayerAI { get; }
		public int NotDeleteParts { get; }
		public int IsPartsSelfDef { get; }
		public int NotShareBarrier { get; }
		public int CounterToCenter { get; }
		public float RespawnInvincibleSec { get; }
		public int MultipleEnemyNameExtension { get; }
		public int IgnoreHeightForFollowerTargeting { get; }
		public int CountdownHP { get; }
		public int SameHitPriority { get; }
	
		// Constructors
		public EnemyDataElement();
	}
}
