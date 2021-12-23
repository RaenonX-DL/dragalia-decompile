using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyParamElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _ParamGroupName;

		[SerializeField]
		private int _DataId;

		[SerializeField]
		private string _Ai;

		[SerializeField]
		private int _ActionSet;

		[SerializeField]
		private int _ActionSetBoost;

		[SerializeField]
		private int _ActionSetFire;

		[SerializeField]
		private int _ActionSetWater;

		[SerializeField]
		private int _ActionSetWind;

		[SerializeField]
		private int _ActionSetLight;

		[SerializeField]
		private int _ActionSetDark;

		[SerializeField]
		private int _RouteMode;

		[SerializeField]
		private int _Ability01;

		[SerializeField]
		private int _Ability02;

		[SerializeField]
		private int _Ability03;

		[SerializeField]
		private int _Ability04;

		[SerializeField]
		private int _BerserkAbility;

		[SerializeField]
		private EnemyToughType _Tough;

		[SerializeField]
		private float _RareStayTime;

		[SerializeField]
		private int _IsHideUI;

		[SerializeField]
		private int _IsDeadRetention;

		[SerializeField]
		private int _IsDeadNoEff;

		[SerializeField]
		private EnemyIconType _IconType;

		[SerializeField]
		private int _DropDpPattern;

		[SerializeField]
		private int _DropDpValue;

		[SerializeField]
		private int _DropSpValue;

		[SerializeField]
		private int _HP;

		[SerializeField]
		private int _Atk;

		[SerializeField]
		private int _Def;

		[SerializeField]
		private int _Overwhelm;

		[SerializeField]
		private int _BaseOD;

		[SerializeField]
		private int _BaseBreak;

		[SerializeField]
		private int _CounterRate;

		[SerializeField]
		private int _BarrierRate;

		[SerializeField]
		private float _ActionBehaviorSec;

		[SerializeField]
		private int _GetupActionRate;

		[SerializeField]
		private int _IsTargetSpecialHate;

		[SerializeField]
		private int _UniqueGroup;

		[SerializeField]
		private int _DmodeEnemyParamGroupId;

		[SerializeField]
		private int _DmodeEnemyLevelType;

		[SerializeField]
		private int _RegistAbnormalPerfect;

		[SerializeField]
		private int _RegistAbnormalRate01;

		[SerializeField]
		private int _RegistAbnormalRate02;

		[SerializeField]
		private int _RegistAbnormalRate03;

		[SerializeField]
		private int _RegistAbnormalRate04;

		[SerializeField]
		private int _RegistAbnormalRate05;

		[SerializeField]
		private int _RegistAbnormalRate06;

		[SerializeField]
		private int _RegistAbnormalRate07;

		[SerializeField]
		private int _RegistAbnormalRate08;

		[SerializeField]
		private int _RegistAbnormalRate09;

		[SerializeField]
		private int _RegistAbnormalRate10;

		[SerializeField]
		private int _RegistAbnormalRate11;

		[SerializeField]
		private int _RegistAbnormalRate12;

		[SerializeField]
		private int _RegistAbnormalRate13;

		[SerializeField]
		private int _RegistAbnormalRate14;

		[SerializeField]
		private int _Form2nd;

		[SerializeField]
		private int _IsForm2ndDead;

		[SerializeField]
		private int _Child01Param;

		[SerializeField]
		private int _Child01Num;

		[SerializeField]
		private int _Child02Param;

		[SerializeField]
		private int _Child02Num;

		[SerializeField]
		private int _Child03Param;

		[SerializeField]
		private int _Child03Num;

		[SerializeField]
		private bool _IsChildIgnoreCollide;

		[SerializeField]
		private int _WeakA;

		[SerializeField]
		private int _WeakANum;

		[SerializeField]
		private int _WeakB;

		[SerializeField]
		private int _WeakBNum;

		[SerializeField]
		private int _WeakC;

		[SerializeField]
		private int _WeakCNum;

		[SerializeField]
		private int _PartsA;

		[SerializeField]
		private int _PartsB;

		[SerializeField]
		private int _PartsC;

		[SerializeField]
		private int _PartsD;

		[SerializeField]
		private string _PartsNode;

		[SerializeField]
		private int _CrashedHpRate;

		[SerializeField]
		private string _BossAppearVoiceId;

		[SerializeField]
		private int _KeepLegacyRotateToTarget;

		[SerializeField]
		private int _ResetDebuffOnDead;

		[SerializeField]
		private int _OpeningDebuff;

		[SerializeField]
		private int _PartySwitchDebuff;

		public int Id => default(int);

		public string ParamGroupName => null;

		public int DataId => default(int);

		public string Ai => null;

		public int ActionSet => default(int);

		public int ActionSetBoost => default(int);

		public int ActionSetFire => default(int);

		public int ActionSetWater => default(int);

		public int ActionSetWind => default(int);

		public int ActionSetLight => default(int);

		public int ActionSetDark => default(int);

		public int RouteMode => default(int);

		public int Ability01 => default(int);

		public int Ability02 => default(int);

		public int Ability03 => default(int);

		public int Ability04 => default(int);

		public int BerserkAbility => default(int);

		public EnemyToughType Tough => default(EnemyToughType);

		public float RareStayTime => default(float);

		public int IsHideUI => default(int);

		public int IsDeadRetention => default(int);

		public int IsDeadNoEff => default(int);

		public EnemyIconType IconType => default(EnemyIconType);

		public int DropDpPattern => default(int);

		public int DropDpValue => default(int);

		public int DropSpValue => default(int);

		public int HP => default(int);

		public int Atk => default(int);

		public int Def => default(int);

		public int Overwhelm => default(int);

		public int BaseOD => default(int);

		public int BaseBreak => default(int);

		public int CounterRate => default(int);

		public int BarrierRate => default(int);

		public float ActionBehaviorSec => default(float);

		public int GetupActionRate => default(int);

		public int IsTargetSpecialHate => default(int);

		public int UniqueGroup => default(int);

		public int DmodeEnemyParamGroupId => default(int);

		public int DmodeEnemyLevelType => default(int);

		public int RegistAbnormalPerfect => default(int);

		public int RegistAbnormalRate01 => default(int);

		public int RegistAbnormalRate02 => default(int);

		public int RegistAbnormalRate03 => default(int);

		public int RegistAbnormalRate04 => default(int);

		public int RegistAbnormalRate05 => default(int);

		public int RegistAbnormalRate06 => default(int);

		public int RegistAbnormalRate07 => default(int);

		public int RegistAbnormalRate08 => default(int);

		public int RegistAbnormalRate09 => default(int);

		public int RegistAbnormalRate10 => default(int);

		public int RegistAbnormalRate11 => default(int);

		public int RegistAbnormalRate12 => default(int);

		public int RegistAbnormalRate13 => default(int);

		public int RegistAbnormalRate14 => default(int);

		public int Form2nd => default(int);

		public int IsForm2ndDead => default(int);

		public int Child01Param => default(int);

		public int Child01Num => default(int);

		public int Child02Param => default(int);

		public int Child02Num => default(int);

		public int Child03Param => default(int);

		public int Child03Num => default(int);

		public bool IsChildIgnoreCollide => default(bool);

		public int WeakA => default(int);

		public int WeakANum => default(int);

		public int WeakB => default(int);

		public int WeakBNum => default(int);

		public int WeakC => default(int);

		public int WeakCNum => default(int);

		public int PartsA => default(int);

		public int PartsB => default(int);

		public int PartsC => default(int);

		public int PartsD => default(int);

		public string PartsNode => null;

		public int CrashedHpRate => default(int);

		public string BossAppearVoiceId => null;

		public int KeepLegacyRotateToTarget => default(int);

		public int ResetDebuffOnDead => default(int);

		public int OpeningDebuff => default(int);

		public int PartySwitchDebuff => default(int);
	}
}
