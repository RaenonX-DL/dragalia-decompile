using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class HeroParam
	{
		[Key(0)]
		public int level;

		[Key(1)]
		public int characterId;

		[Key(2)]
		public int hp;

		[Key(3)]
		public int attack;

		[Key(4)]
		public int defence;

		[Key(5)]
		public int exAbilityLv;

		[Key(6)]
		public int exAbility2Lv;

		[Key(7)]
		public int ability1Lv;

		[Key(8)]
		public int ability2Lv;

		[Key(9)]
		public int ability3Lv;

		[Key(10)]
		public int skill1Lv;

		[Key(11)]
		public int skill2Lv;

		[Key(12)]
		public int burstAttackLv;

		[Key(13)]
		public int hpPlusCount;

		[Key(14)]
		public int attackPlusCount;

		[Key(15)]
		public int comboBuildupCount;

		[Key(20)]
		public int dragonId;

		[Key(21)]
		public int dragonLevel;

		[Key(22)]
		public int dragonAbility1Lv;

		[Key(23)]
		public int dragonAbility2Lv;

		[Key(24)]
		public int dragonSkill1Lv;

		[Key(25)]
		public int dragonSkill2Lv;

		[Key(26)]
		public int dragonHpPlusCount;

		[Key(27)]
		public int dragonAttackPlusCount;

		[Key(30)]
		public int weaponBodyId;

		[Key(31)]
		public int weaponBodyBuildupCount;

		[Key(34)]
		public int weaponBodySkillNo;

		[Key(35)]
		public int weaponBodySkillLv;

		[Key(36)]
		public int weaponBodyAbility1Lv;

		[Key(37)]
		public int weaponBodyAbility2Lv;

		[Key(38)]
		public int[] weaponPassiveAbilityIds;

		[Key(45)]
		public int weaponSkinId;

		[Key(50)]
		public int abilityCrestId;

		[Key(51)]
		public int abilityCrestBuildupCount;

		[Key(52)]
		public int abilityCrestAbility1Lv;

		[Key(53)]
		public int abilityCrestAbility2Lv;

		[Key(54)]
		public int abilityCrestHpPlusCount;

		[Key(55)]
		public int abilityCrestAttackPlusCount;

		[Key(56)]
		public int abilityCrest2Id;

		[Key(57)]
		public int abilityCrest2BuildupCount;

		[Key(58)]
		public int abilityCrest2Ability1Lv;

		[Key(59)]
		public int abilityCrest2Ability2Lv;

		[Key(60)]
		public int abilityCrest2HpPlusCount;

		[Key(61)]
		public int abilityCrest2AttackPlusCount;

		[Key(62)]
		public int abilityCrest3Id;

		[Key(63)]
		public int abilityCrest3BuildupCount;

		[Key(64)]
		public int abilityCrest3Ability1Lv;

		[Key(65)]
		public int abilityCrest3Ability2Lv;

		[Key(66)]
		public int abilityCrest3HpPlusCount;

		[Key(67)]
		public int abilityCrest3AttackPlusCount;

		[Key(68)]
		public int abilityCrest4Id;

		[Key(69)]
		public int abilityCrest4BuildupCount;

		[Key(70)]
		public int abilityCrest4Ability1Lv;

		[Key(71)]
		public int abilityCrest4Ability2Lv;

		[Key(72)]
		public int abilityCrest4HpPlusCount;

		[Key(73)]
		public int abilityCrest4AttackPlusCount;

		[Key(74)]
		public int abilityCrest5Id;

		[Key(75)]
		public int abilityCrest5BuildupCount;

		[Key(76)]
		public int abilityCrest5Ability1Lv;

		[Key(77)]
		public int abilityCrest5Ability2Lv;

		[Key(78)]
		public int abilityCrest5HpPlusCount;

		[Key(79)]
		public int abilityCrest5AttackPlusCount;

		[Key(90)]
		public int plusHp;

		[Key(91)]
		public int plusAtk;

		[Key(92)]
		public int plusDef;

		[Key(93)]
		public float relativeHp;

		[Key(94)]
		public float relativeAtk;

		[Key(95)]
		public float relativeDef;

		[Key(96)]
		public float dragonRelativeDmg;

		[Key(97)]
		public float dragonTime;

		[Key(98)]
		public int position;

		[Key(99)]
		public int aiType;

		[Key(100)]
		public bool isEnemyTarget;

		[Key(101)]
		public bool isFriend;

		[Key(102)]
		public int dragonReliabilityLevel;

		[Key(103)]
		public float dragonRelativeHp;

		[Key(104)]
		public float dragonRelativeAtk;

		[Key(105)]
		public float dragonRelativeDef;

		[Key(106)]
		public int battleGroup;

		[Key(107)]
		public int[] eventPassiveGrowList;

		[Key(108)]
		public float eventBoostDmg;

		[Key(120)]
		public int editSkillcharacterId1;

		[Key(121)]
		public int editSkillcharacterId2;

		[Key(122)]
		public int editSkillLv1;

		[Key(123)]
		public int editSkillLv2;

		[Key(130)]
		public int abilityCrest6Id;

		[Key(131)]
		public int abilityCrest6BuildupCount;

		[Key(132)]
		public int abilityCrest6Ability1Lv;

		[Key(133)]
		public int abilityCrest6Ability2Lv;

		[Key(134)]
		public int abilityCrest6HpPlusCount;

		[Key(135)]
		public int abilityCrest6AttackPlusCount;

		[Key(136)]
		public int abilityCrest7Id;

		[Key(137)]
		public int abilityCrest7BuildupCount;

		[Key(138)]
		public int abilityCrest7Ability1Lv;

		[Key(139)]
		public int abilityCrest7Ability2Lv;

		[Key(140)]
		public int abilityCrest7HpPlusCount;

		[Key(141)]
		public int abilityCrest7AttackPlusCount;

		[Key(142)]
		public int originalPosition;

		[Key(143)]
		public float relativeHpFort;

		[Key(144)]
		public float relativeAtkFort;

		[Key(145)]
		public float relativeDefFort;

		[Key(146)]
		public float relativeHpAlbum;

		[Key(147)]
		public float relativeAtkAlbum;

		[Key(148)]
		public float relativeDefAlbum;

		[Key(149)]
		public float dragonRelativeHpFort;

		[Key(150)]
		public float dragonRelativeAtkFort;

		[Key(151)]
		public float dragonRelativeDefFort;

		[Key(152)]
		public float dragonRelativeHpAlbum;

		[Key(153)]
		public float dragonRelativeAtkAlbum;

		[Key(154)]
		public float dragonRelativeDefAlbum;

		public HeroParam()
		{
		}

		public HeroParam(int characterId, int level, int weaponBodyId, int weaponBodyBuildupCount, int dragonId, int dragonLevel)
		{
		}
	}
}
