/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonData
	{
		// Fields
		public const int skillNum = 2;
		[CompilerGenerated]
		private DragonDataElement _masterData_k__BackingField;
		[CompilerGenerated]
		private DragonDataElement _equipData_k__BackingField;
		public AbilityDataElement ability1Data;
		public AbilityDataElement ability2Data;
		public CharacterSkillData[] skillData;
		public CharacterSkillData skillFAData;
		[CompilerGenerated]
		private int _level_k__BackingField;
		[CompilerGenerated]
		private int _hp_k__BackingField;
		[CompilerGenerated]
		private int _attack_k__BackingField;
		[CompilerGenerated]
		private int _defense_k__BackingField;
		public int ability1Lv;
		public int ability2Lv;
	
		// Properties
		public DragonDataElement masterData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DragonDataElement equipData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int level { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int hp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int attack { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int defense { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public DragonData(int dragonId, int uniqueDragonId);
	
		// Methods
		public bool Setup(int dragonLv, int plusHp, int plusAttack, ElementalType charaElement);
		public void SetupSkill(int skill1Lv, int skill2Lv);
		public void SetupAbility(int ability1Lv, int ability2Lv);
		public void OnReceiveTransSkill(CharacterBase owner, TransSkill recvEvent);
		private void AddSkillAction(CharacterSkillData data);
		private void AddSkillAction(CharacterSkillData data, int actionId);
		public bool CheckTransSkill(CharacterBase owner, CollisionHitAttribute attr, int idx);
		public void TransformSkill(int idx);
		public void ReleaseTransSkill(CharacterBase owner, int idx);
		public void DisableTrans(int idx);
		public bool IsPauseTransBuff(int idx);
		public void PauseTransBuff(int idx, bool pause);
	}
}
