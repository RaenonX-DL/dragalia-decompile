/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EnemyParamElement : IMasterElement
	{
		// Fields
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
	
		// Properties
		public int Id { get; }
		public string ParamGroupName { get; }
		public int DataId { get; }
		public string Ai { get; }
		public int ActionSet { get; }
		public int ActionSetBoost { get; }
		public int ActionSetFire { get; }
		public int ActionSetWater { get; }
		public int ActionSetWind { get; }
		public int ActionSetLight { get; }
		public int ActionSetDark { get; }
		public int RouteMode { get; }
		public int Ability01 { get; }
		public int Ability02 { get; }
		public int Ability03 { get; }
		public int Ability04 { get; }
		public int BerserkAbility { get; }
		public EnemyToughType Tough { get; }
		public float RareStayTime { get; }
		public int IsHideUI { get; }
		public int IsDeadRetention { get; }
		public int IsDeadNoEff { get; }
		public EnemyIconType IconType { get; }
		public int DropDpPattern { get; }
		public int DropDpValue { get; }
		public int HP { get; }
		public int Atk { get; }
		public int Def { get; }
		public int Overwhelm { get; }
		public int BaseOD { get; }
		public int BaseBreak { get; }
		public int CounterRate { get; }
		public int BarrierRate { get; }
		public float ActionBehaviorSec { get; }
		public int GetupActionRate { get; }
		public int IsTargetSpecialHate { get; }
		public int UniqueGroup { get; }
		public int RegistAbnormalRate01 { get; }
		public int RegistAbnormalRate02 { get; }
		public int RegistAbnormalRate03 { get; }
		public int RegistAbnormalRate04 { get; }
		public int RegistAbnormalRate05 { get; }
		public int RegistAbnormalRate06 { get; }
		public int RegistAbnormalRate07 { get; }
		public int RegistAbnormalRate08 { get; }
		public int RegistAbnormalRate09 { get; }
		public int RegistAbnormalRate10 { get; }
		public int RegistAbnormalRate11 { get; }
		public int RegistAbnormalRate12 { get; }
		public int RegistAbnormalRate13 { get; }
		public int RegistAbnormalRate14 { get; }
		public int Form2nd { get; }
		public int IsForm2ndDead { get; }
		public int Child01Param { get; }
		public int Child01Num { get; }
		public int Child02Param { get; }
		public int Child02Num { get; }
		public int Child03Param { get; }
		public int Child03Num { get; }
		public bool IsChildIgnoreCollide { get; }
		public int WeakA { get; }
		public int WeakANum { get; }
		public int WeakB { get; }
		public int WeakBNum { get; }
		public int WeakC { get; }
		public int WeakCNum { get; }
		public int PartsA { get; }
		public int PartsB { get; }
		public int PartsC { get; }
		public int PartsD { get; }
		public string PartsNode { get; }
		public int CrashedHpRate { get; }
		public string BossAppearVoiceId { get; }
		public int KeepLegacyRotateToTarget { get; }
	
		// Constructors
		public EnemyParamElement();
	}
}
