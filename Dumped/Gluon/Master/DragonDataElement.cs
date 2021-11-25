using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DragonDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _SecondName;

		[SerializeField]
		private int _EmblemId;

		[SerializeField]
		private int _Rarity;

		[SerializeField]
		private Gluon.ElementalType _ElementalType;

		[SerializeField]
		private int _MaxLimitBreakCount;

		[SerializeField]
		private int _BaseId;

		[SerializeField]
		private int _VariationId;

		[SerializeField]
		private int _IsPlayable;

		[SerializeField]
		private int _CharaBaseId;

		[SerializeField]
		private string _AnimFileName;

		[SerializeField]
		private int _Deco1;

		[SerializeField]
		private int _Deco2;

		[SerializeField]
		private int _MinHp;

		[SerializeField]
		private int _MaxHp;

		[SerializeField]
		private int _AddMaxHp1;

		[SerializeField]
		private int _MinAtk;

		[SerializeField]
		private int _MaxAtk;

		[SerializeField]
		private int _AddMaxAtk1;

		[SerializeField]
		private int _LimitBreakId;

		[SerializeField]
		private int _Skill1;

		[SerializeField]
		private int _Skill2;

		[SerializeField]
		private int _SkillFinalAttack;

		[SerializeField]
		private int _Abilities11;

		[SerializeField]
		private int _Abilities12;

		[SerializeField]
		private int _Abilities13;

		[SerializeField]
		private int _Abilities14;

		[SerializeField]
		private int _Abilities15;

		[SerializeField]
		private int _Abilities16;

		[SerializeField]
		private int _Abilities21;

		[SerializeField]
		private int _Abilities22;

		[SerializeField]
		private int _Abilities23;

		[SerializeField]
		private int _Abilities24;

		[SerializeField]
		private int _Abilities25;

		[SerializeField]
		private int _Abilities26;

		[SerializeField]
		private string _DragonExplosionDetail;

		[SerializeField]
		private string _DragonExplosionIcon;

		[SerializeField]
		private string _Profile;

		[SerializeField]
		private string _ReleaseStartDate;

		[SerializeField]
		private DragonFavoriteType _FavoriteType;

		[SerializeField]
		private DragonVoice _VoiceType;

		[SerializeField]
		private string _CvInfo;

		[SerializeField]
		private string _CvInfoEn;

		[SerializeField]
		private int _SellCoin;

		[SerializeField]
		private int _SellDewPoint;

		[SerializeField]
		private int _LimitBreakMaterialId;

		[SerializeField]
		private int _DefaultReliabilityLevel;

		[SerializeField]
		private int _IsNoneViewDragonContact;

		[SerializeField]
		private int _AvoidActionFront;

		[SerializeField]
		private int _AvoidActionBack;

		[SerializeField]
		private int _Transform;

		[SerializeField]
		private int _DefaultSkill;

		[SerializeField]
		private int _BurstAttack;

		[SerializeField]
		private int _ComboMax;

		[SerializeField]
		private int _MaxChargeLv;

		[SerializeField]
		private float _ScaleSize;

		[SerializeField]
		private float _DcScaleSize;

		[SerializeField]
		private float _DcRotationY;

		[SerializeField]
		private float _ShadowSize;

		[SerializeField]
		private float _GaugeHeightOffset;

		[SerializeField]
		private float _MoveSpeed;

		[SerializeField]
		private float _DashSpeedRatio;

		[SerializeField]
		private float _TurnSpeed;

		[SerializeField]
		private int _IsTurnToDamageDir;

		[SerializeField]
		private int _IsLongRangeInGame;

		[SerializeField]
		private float _DragonCameraDistance;

		[SerializeField]
		private int _MoveType;

		[SerializeField]
		private int _IsLongLange;

		[SerializeField]
		private int _IsDetailimage;

		[SerializeField]
		private int _SilhouetteValue;

		[SerializeField]
		private float _SearchRange;

		[SerializeField]
		private int _AiType;

		[SerializeField]
		private string _ServantFollowPosition;

		[SerializeField]
		private int _FootprintsType;

		public int Id => default(int);

		public string Name => null;

		public string SecondName => null;

		public int EmblemId => default(int);

		public int Rarity => default(int);

		public Gluon.ElementalType ElementalType => default(Gluon.ElementalType);

		public int MaxLimitBreakCount => default(int);

		public int BaseId => default(int);

		public int VariationId => default(int);

		public int IsPlayable => default(int);

		public int CharaBaseId => default(int);

		public string AnimFileName => null;

		public int Deco1 => default(int);

		public int Deco2 => default(int);

		public int MinHp => default(int);

		public int MaxHp => default(int);

		public int AddMaxHp1 => default(int);

		public int MinAtk => default(int);

		public int MaxAtk => default(int);

		public int AddMaxAtk1 => default(int);

		public int LimitBreakId => default(int);

		public int Skill1 => default(int);

		public int Skill2 => default(int);

		public int SkillFinalAttack => default(int);

		public int Abilities11 => default(int);

		public int Abilities12 => default(int);

		public int Abilities13 => default(int);

		public int Abilities14 => default(int);

		public int Abilities15 => default(int);

		public int Abilities16 => default(int);

		public int Abilities21 => default(int);

		public int Abilities22 => default(int);

		public int Abilities23 => default(int);

		public int Abilities24 => default(int);

		public int Abilities25 => default(int);

		public int Abilities26 => default(int);

		public string DragonExplosionDetail => null;

		public string DragonExplosionIcon => null;

		public string Profile => null;

		public string ReleaseStartDate => null;

		public DragonFavoriteType FavoriteType => default(DragonFavoriteType);

		public DragonVoice VoiceType => default(DragonVoice);

		public string CvInfo => null;

		public string CvInfoEn => null;

		public int SellCoin => default(int);

		public int SellDewPoint => default(int);

		public int LimitBreakMaterialId => default(int);

		public int DefaultReliabilityLevel => default(int);

		public int IsNoneViewDragonContact => default(int);

		public int AvoidActionFront => default(int);

		public int AvoidActionBack => default(int);

		public int Transform => default(int);

		public int DefaultSkill => default(int);

		public int BurstAttack => default(int);

		public int ComboMax => default(int);

		public int MaxChargeLv => default(int);

		public float ScaleSize => default(float);

		public float DcScaleSize => default(float);

		public float DcRotationY => default(float);

		public float ShadowSize => default(float);

		public float GaugeHeightOffset => default(float);

		public float MoveSpeed => default(float);

		public float DashSpeedRatio => default(float);

		public float TurnSpeed => default(float);

		public int IsTurnToDamageDir => default(int);

		public int IsLongRangeInGame => default(int);

		public float DragonCameraDistance => default(float);

		public int MoveType => default(int);

		public int IsLongLange => default(int);

		public int IsDetailimage => default(int);

		public int SilhouetteValue => default(int);

		public float SearchRange => default(float);

		public int AiType => default(int);

		public string ServantFollowPosition => null;

		public int FootprintsType => default(int);
	}
}
