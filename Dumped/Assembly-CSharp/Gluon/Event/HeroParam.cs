/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class HeroParam
	{
		// Fields
		[Key]
		public int level;
		[Key]
		public int characterId;
		[Key]
		public int hp;
		[Key]
		public int attack;
		[Key]
		public int defence;
		[Key]
		public int exAbilityLv;
		[Key]
		public int exAbility2Lv;
		[Key]
		public int ability1Lv;
		[Key]
		public int ability2Lv;
		[Key]
		public int ability3Lv;
		[Key]
		public int skill1Lv;
		[Key]
		public int skill2Lv;
		[Key]
		public int burstAttackLv;
		[Key]
		public int hpPlusCount;
		[Key]
		public int attackPlusCount;
		[Key]
		public int comboBuildupCount;
		[Key]
		public int dragonId;
		[Key]
		public int dragonLevel;
		[Key]
		public int dragonAbility1Lv;
		[Key]
		public int dragonAbility2Lv;
		[Key]
		public int dragonSkill1Lv;
		[Key]
		public int dragonSkill2Lv;
		[Key]
		public int dragonHpPlusCount;
		[Key]
		public int dragonAttackPlusCount;
		[Key]
		public int weaponBodyId;
		[Key]
		public int weaponBodyBuildupCount;
		[Key]
		public int weaponBodySkillNo;
		[Key]
		public int weaponBodySkillLv;
		[Key]
		public int weaponBodyAbility1Lv;
		[Key]
		public int weaponBodyAbility2Lv;
		[Key]
		public int[] weaponPassiveAbilityIds;
		[Key]
		public int weaponSkinId;
		[Key]
		public int abilityCrestId;
		[Key]
		public int abilityCrestBuildupCount;
		[Key]
		public int abilityCrestAbility1Lv;
		[Key]
		public int abilityCrestAbility2Lv;
		[Key]
		public int abilityCrestHpPlusCount;
		[Key]
		public int abilityCrestAttackPlusCount;
		[Key]
		public int abilityCrest2Id;
		[Key]
		public int abilityCrest2BuildupCount;
		[Key]
		public int abilityCrest2Ability1Lv;
		[Key]
		public int abilityCrest2Ability2Lv;
		[Key]
		public int abilityCrest2HpPlusCount;
		[Key]
		public int abilityCrest2AttackPlusCount;
		[Key]
		public int abilityCrest3Id;
		[Key]
		public int abilityCrest3BuildupCount;
		[Key]
		public int abilityCrest3Ability1Lv;
		[Key]
		public int abilityCrest3Ability2Lv;
		[Key]
		public int abilityCrest3HpPlusCount;
		[Key]
		public int abilityCrest3AttackPlusCount;
		[Key]
		public int abilityCrest4Id;
		[Key]
		public int abilityCrest4BuildupCount;
		[Key]
		public int abilityCrest4Ability1Lv;
		[Key]
		public int abilityCrest4Ability2Lv;
		[Key]
		public int abilityCrest4HpPlusCount;
		[Key]
		public int abilityCrest4AttackPlusCount;
		[Key]
		public int abilityCrest5Id;
		[Key]
		public int abilityCrest5BuildupCount;
		[Key]
		public int abilityCrest5Ability1Lv;
		[Key]
		public int abilityCrest5Ability2Lv;
		[Key]
		public int abilityCrest5HpPlusCount;
		[Key]
		public int abilityCrest5AttackPlusCount;
		[Key]
		public int plusHp;
		[Key]
		public int plusAtk;
		[Key]
		public int plusDef;
		[Key]
		public float relativeHp;
		[Key]
		public float relativeAtk;
		[Key]
		public float relativeDef;
		[Key]
		public float dragonRelativeDmg;
		[Key]
		public float dragonTime;
		[Key]
		public int position;
		[Key]
		public int aiType;
		[Key]
		public bool isEnemyTarget;
		[Key]
		public bool isFriend;
		[Key]
		public int dragonReliabilityLevel;
		[Key]
		public float dragonRelativeHp;
		[Key]
		public float dragonRelativeAtk;
		[Key]
		public float dragonRelativeDef;
		[Key]
		public int battleGroup;
		[Key]
		public int[] eventPassiveGrowList;
		[Key]
		public float eventBoostDmg;
		[Key]
		public int editSkillcharacterId1;
		[Key]
		public int editSkillcharacterId2;
		[Key]
		public int editSkillLv1;
		[Key]
		public int editSkillLv2;
		[Key]
		public int abilityCrest6Id;
		[Key]
		public int abilityCrest6BuildupCount;
		[Key]
		public int abilityCrest6Ability1Lv;
		[Key]
		public int abilityCrest6Ability2Lv;
		[Key]
		public int abilityCrest6HpPlusCount;
		[Key]
		public int abilityCrest6AttackPlusCount;
		[Key]
		public int abilityCrest7Id;
		[Key]
		public int abilityCrest7BuildupCount;
		[Key]
		public int abilityCrest7Ability1Lv;
		[Key]
		public int abilityCrest7Ability2Lv;
		[Key]
		public int abilityCrest7HpPlusCount;
		[Key]
		public int abilityCrest7AttackPlusCount;
		[Key]
		public int originalPosition;
		[Key]
		public float relativeHpFort;
		[Key]
		public float relativeAtkFort;
		[Key]
		public float relativeDefFort;
		[Key]
		public float relativeHpAlbum;
		[Key]
		public float relativeAtkAlbum;
		[Key]
		public float relativeDefAlbum;
		[Key]
		public float dragonRelativeHpFort;
		[Key]
		public float dragonRelativeAtkFort;
		[Key]
		public float dragonRelativeDefFort;
		[Key]
		public float dragonRelativeHpAlbum;
		[Key]
		public float dragonRelativeAtkAlbum;
		[Key]
		public float dragonRelativeDefAlbum;
	
		// Constructors
		public HeroParam();
		public HeroParam(int characterId, int level, int weaponBodyId, int weaponBodyBuildupCount, int dragonId, int dragonLevel);
	}
}
