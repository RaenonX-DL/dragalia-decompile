using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class DmodeCtrl : MonoBehaviour
	{
		public enum AnnounceFlagType
		{
			Rare3 = 1,
			Rare4 = 2,
			Rare5 = 4,
			Skill = 8,
			All = 0xF
		}

		public const string prefsKeyAnnounceType = "DmodeAnnounceType";

		public const string prefsKeyVisibleBttleLog = "DmodeVisibleBattleLog";

		private bool needsAddDragonAbility;

		private string bgm;

		private int bgmContinuousPlayCount;

		private int prevDungeonThemeIdForBGM;

		private List<DmodeDungeonThemeElement> _themeListForLocalMode;

		private Coroutine floorSkillResourceCoroutine;

		private bool isRequestFloorSkillResource;

		public int CurrentFloorNumber
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsLastFloor => default(bool);

		public int DPoint
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int DPointRare
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Score
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DmodeGameDataManager DmodeGameDataManager => null;

		public int RecoveryMaxCount => default(int);

		public int RecoveryCount => default(int);

		public int RecoveryRemainCount => default(int);

		public bool IsEnableRecovery => default(bool);

		public int announceType
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DmodeDungeonDropItemManager dmodeDungeonDropItemManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DmodeResourceLoader resourceLoader
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DmodeDungeonThemeElement CurrentTheme => null;

		public QuestClearType CurrentClearType => default(QuestClearType);

		public QuestFailedType CurrentFailedType => default(QuestFailedType);

		public float CurrentTimeElapsed => default(float);

		public bool IsViewAreaStartEquipment => default(bool);

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void NextFloor()
		{
		}

		public void InitializeForLocalMode(List<DmodeDungeonThemeElement> themeList)
		{
		}

		public void SetupWeaponsAndSkills(HumanCharacter player)
		{
		}

		public void SetupFloorSkillResource(CharacterBase chara)
		{
		}

		public IEnumerator LoadFloorSkillResource(CharacterBase chara, [Optional] Action onLoaded)
		{
			return null;
		}

		private void AppendFloorWeaponSkillId(ref HashSet<int> skillIds)
		{
		}

		private void AppendFloorShareSkillId(ref HashSet<int> skillIds)
		{
		}

		public void ClearWeaponsAndSkills()
		{
		}

		public void ChangeEquipWeapon(int weaponSkinId, int hp, int atk, DmodeDungeonItem prevWeapon)
		{
		}

		public void ChangeEquipAbilityCrests(List<DmodeDungeonItem> prevAbilityCrests, int hp, int atk)
		{
		}

		public void SetupDragons(CharacterSelector selector, List<DmodeDungeonItem> dragonItems)
		{
		}

		public void AddDragon()
		{
		}

		public void SetupDPoint()
		{
		}

		public void AddDPoint(int value)
		{
		}

		public void AddDPointRare(int value)
		{
		}

		public void SetupScore()
		{
		}

		public void AddScore(int value)
		{
		}

		public void SetupAnnounceType()
		{
		}

		public void SetAnnounceType(AnnounceFlagType type, bool b, bool isSave = false)
		{
		}

		public bool IsAnnounceType(AnnounceFlagType type)
		{
			return default(bool);
		}

		public void SaveAnnounceType()
		{
		}

		public void ResetAnnounceType()
		{
		}

		public bool IsDragonSelectArea()
		{
			return default(bool);
		}

		public bool IsOrganizeItems()
		{
			return default(bool);
		}

		public AudioPlayback PlayBGM(bool isOnEndDragon)
		{
			return default(AudioPlayback);
		}

		public bool IsShareSkillIndex(int index)
		{
			return default(bool);
		}

		public void SetVisibleBattleLog(bool isVisible)
		{
		}

		public bool IsVisibleBattleLog()
		{
			return default(bool);
		}

		public bool GetDashSpeedCoef(float dashElapsedTime, out float speedCoef)
		{
			return default(bool);
		}
	}
}
