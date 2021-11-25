using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyDataElement : IMasterElement
	{
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
		private Gluon.ElementalType _ElementalType;

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
		private Gluon.CharaFaceEyeMotion _BossAppearEye;

		[SerializeField]
		private Gluon.CharaFaceMouthMotion _BossAppearMouth;

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

		public int Id => default(int);

		public string EnemyGroupName => null;

		public int Category => default(int);

		public int BaseId => default(int);

		public int VariationId => default(int);

		public int WeaponId => default(int);

		public int NondominanntHandWeaponId => default(int);

		public int WeaponSkinId => default(int);

		public int NondominanntHandWeaponSkinId => default(int);

		public string AttachEnemyObj => null;

		public string AnimFileName => null;

		public Gluon.ElementalType ElementalType => default(Gluon.ElementalType);

		public int BookId => default(int);

		public float BaseRadius => default(float);

		public float BaseHeight => default(float);

		public int IsHitCollisionCenter => default(int);

		public int DeadIdlingFrame => default(int);

		public int IsInitWaitOrder => default(int);

		public int IsForcedDeadNoReward => default(int);

		public float BreakDuration => default(float);

		public float SkinScale => default(float);

		public float BossAppearScale => default(float);

		public float ShadowSize => default(float);

		public int IsHideShadow => default(int);

		public float EffectScale => default(float);

		public float AuraScale => default(float);

		public float EmotionIconScale => default(float);

		public float EmotionIconHeight => default(float);

		public int IsShowBossEnemyMark => default(int);

		public int IsHideHpGauge => default(int);

		public float HpGaugeHeight => default(float);

		public int IsHideDamageUI => default(int);

		public int DamagedTime => default(int);

		public float KbRate => default(float);

		public float KbSpeed => default(float);

		public float SabkbRate => default(float);

		public float AbsorptionRate => default(float);

		public float Mass => default(float);

		public float MoveSpeed => default(float);

		public float TurnSpeed => default(float);

		public float SearchRange => default(float);

		public float SearchLimitDistance => default(float);

		public bool IsBlast => default(bool);

		public bool IsTurnToDamageDir => default(bool);

		public bool IsValidSplitDamage => default(bool);

		public bool IsHitFlash => default(bool);

		public int SuperArmor => default(int);

		public bool IsMoveSuperArmor => default(bool);

		public string ActionGroupName => null;

		public int ActionForQuestSelect => default(int);

		public Gluon.CharaFaceEyeMotion BossAppearEye => default(Gluon.CharaFaceEyeMotion);

		public Gluon.CharaFaceMouthMotion BossAppearMouth => default(Gluon.CharaFaceMouthMotion);

		public int SilhouetteValue => default(int);

		public int StrongerEffect => default(int);

		public float BreakAtkRate => default(float);

		public float BreakDefRate => default(float);

		public float ObAtkRate => default(float);

		public float ObDefRate => default(float);

		public float ToOverdriveTime => default(float);

		public string OdIdleStateName => null;

		public string OdWalkStateName => null;

		public float BarrierDelay => default(float);

		public float DropRange => default(float);

		public string DmgEffName => null;

		public string DmgSeName => null;

		public int NotTargetedByPlayerAI => default(int);

		public int NotHitByPlayerAI => default(int);

		public int NotDeleteParts => default(int);

		public int IsPartsSelfDef => default(int);

		public int NotShareBarrier => default(int);

		public int CounterToCenter => default(int);

		public float RespawnInvincibleSec => default(float);

		public int MultipleEnemyNameExtension => default(int);

		public int IgnoreHeightForFollowerTargeting => default(int);

		public int CountdownHP => default(int);

		public int SameHitPriority => default(int);
	}
}
