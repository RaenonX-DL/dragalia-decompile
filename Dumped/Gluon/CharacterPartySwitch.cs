using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class CharacterPartySwitch
	{
		private class PartySwitchMemberData
		{
			public List<CharacterSelector> selectors;

			public List<CharacterSelector> servants;

			public List<Vector3> lastPositions;

			public List<Quaternion> lastRotations;
		}

		private GameDataManager _gameDataManager;

		public const int DUNGEON_PARTY_MAX = 8;

		public const int DUNGEON_PARTY_MAX_RAID16 = 16;

		public const int BR_DUNGEON_PARTY_MAX = 16;

		public const int PARTY_MEMBER_MAX = 4;

		public const int DEFAULT_SWITCH_PARTY = 0;

		public const int MAX_PARTY_SWITCH_COUNT = 2;

		public CharacterFormation formation;

		private int _actorIdSelf;

		private int _currentPartySwitchIndex;

		private List<PartySwitchMemberData> _partySwitchMemberList;

		private List<CharacterSelector> _tmpOtherPlayerCharacters;

		public List<CharacterSelector> parties
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

		public List<CharacterSelector> guestCharacters
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

		public List<CharacterSelector> playerCharacters
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

		public List<CharacterSelector> characterSelectors
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

		public List<CharacterSelector> otherEnemyCharacters
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

		public List<CharacterSelector> servantCharacters
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

		public List<CharacterSelector>[] dungeonPartyMembers
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

		public List<CharacterSelector> sortedCharacterSelectors
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

		public CharacterSelector supporter
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

		public CharacterSelector reserver
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

		public List<PlayerEventReceiver> otherPlayerCharacterEventReceivers
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

		public List<PlayerEventReceiver> otherEnemyCharacterEventReceivers
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

		public List<PlayerEventReceiver> otherPlayerServantCharacterEventReceivers
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

		public CharacterLoadBalancer LoadBalancer
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

		private void ClearCharacters()
		{
		}

		public void Initialize(GameDataManager gameDataManager)
		{
		}

		public int GetPartySwitchCount()
		{
			return default(int);
		}

		public bool IsPartySwitchQuest()
		{
			return default(bool);
		}

		public void AddPartyCharacter(int partySwitchIndex, CharacterSelector selector)
		{
		}

		public void AddOtherPartyCharacter(int partySwitchIndex, CharacterSelector selector)
		{
		}

		private void ApplyPartyCharacter(CharacterSelector selector, bool isOtherPlayer)
		{
		}

		public void AddServantCharacter(int partySwitchIndex, CharacterSelector servant)
		{
		}

		public void AddOtherServantCharacter(int partySwitchIndex, CharacterSelector servant)
		{
		}

		private void ApplyServantCharacter(CharacterSelector servant)
		{
		}

		public void AddSupportCharacter(int partySwitchIndex, CharacterSelector selector)
		{
		}

		private void ApplySupportCharacter(CharacterSelector selector)
		{
		}

		public void AddGuestCharacter(int partySwitchIndex, CharacterSelector selector)
		{
		}

		public static InGameDef.SwitchPartyNoList GetSwitchPartyNo(int partyIndex)
		{
			return default(InGameDef.SwitchPartyNoList);
		}

		public InGameDef.SwitchPartyNoList GetSwitchPartyNo()
		{
			return default(InGameDef.SwitchPartyNoList);
		}

		public void PreSetupCharacter()
		{
		}

		public void PostSetupCharacter()
		{
		}

		private void AddDungeonPartyMember(CharacterSelector selector)
		{
		}

		public void InitializeSortedCharacterSelectorList()
		{
		}

		private int ComparerForSortedCharacterSelectors(CharacterSelector a, CharacterSelector b)
		{
			return default(int);
		}

		public List<HumanCharacter> GetPartySwitchMembers(int partySwitchIndex)
		{
			return null;
		}

		public List<CharacterSelector> CollectAllSwitchPartyCharacters(bool includeServant = true, bool includeSupporter = true, bool includeGuest = true, bool includeOtherPlayerChara = true)
		{
			return null;
		}

		public void SwitchParty(int prevPartySwitchIndex, int nextPartySwitchIndex)
		{
		}
	}
}
