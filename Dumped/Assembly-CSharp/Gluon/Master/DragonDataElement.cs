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
	public class DragonDataElement : IMasterElement
	{
		// Fields
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
		private ElementalType _ElementalType;
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
	
		// Properties
		public int Id { get; }
		public string Name { get; }
		public string SecondName { get; }
		public int EmblemId { get; }
		public int Rarity { get; }
		public ElementalType ElementalType { get; }
		public int MaxLimitBreakCount { get; }
		public int BaseId { get; }
		public int VariationId { get; }
		public int IsPlayable { get; }
		public int CharaBaseId { get; }
		public string AnimFileName { get; }
		public int Deco1 { get; }
		public int Deco2 { get; }
		public int MinHp { get; }
		public int MaxHp { get; }
		public int AddMaxHp1 { get; }
		public int MinAtk { get; }
		public int MaxAtk { get; }
		public int AddMaxAtk1 { get; }
		public int LimitBreakId { get; }
		public int Skill1 { get; }
		public int Skill2 { get; }
		public int SkillFinalAttack { get; }
		public int Abilities11 { get; }
		public int Abilities12 { get; }
		public int Abilities13 { get; }
		public int Abilities14 { get; }
		public int Abilities15 { get; }
		public int Abilities16 { get; }
		public int Abilities21 { get; }
		public int Abilities22 { get; }
		public int Abilities23 { get; }
		public int Abilities24 { get; }
		public int Abilities25 { get; }
		public int Abilities26 { get; }
		public string DragonExplosionDetail { get; }
		public string DragonExplosionIcon { get; }
		public string Profile { get; }
		public string ReleaseStartDate { get; }
		public DragonFavoriteType FavoriteType { get; }
		public DragonVoice VoiceType { get; }
		public string CvInfo { get; }
		public string CvInfoEn { get; }
		public int SellCoin { get; }
		public int SellDewPoint { get; }
		public int LimitBreakMaterialId { get; }
		public int DefaultReliabilityLevel { get; }
		public int IsNoneViewDragonContact { get; }
		public int AvoidActionFront { get; }
		public int AvoidActionBack { get; }
		public int Transform { get; }
		public int DefaultSkill { get; }
		public int BurstAttack { get; }
		public int ComboMax { get; }
		public int MaxChargeLv { get; }
		public float ScaleSize { get; }
		public float DcScaleSize { get; }
		public float DcRotationY { get; }
		public float ShadowSize { get; }
		public float GaugeHeightOffset { get; }
		public float MoveSpeed { get; }
		public float DashSpeedRatio { get; }
		public float TurnSpeed { get; }
		public int IsTurnToDamageDir { get; }
		public int IsLongRangeInGame { get; }
		public float DragonCameraDistance { get; }
		public int MoveType { get; }
		public int IsLongLange { get; }
		public int IsDetailimage { get; }
		public int SilhouetteValue { get; }
		public float SearchRange { get; }
		public int AiType { get; }
		public string ServantFollowPosition { get; }
		public int FootprintsType { get; }
	
		// Constructors
		public DragonDataElement();
	}
}
