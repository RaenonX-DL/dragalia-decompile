/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterPartySwitch
	{
		// Fields
		private GameDataManager _gameDataManager;
		public const int DUNGEON_PARTY_MAX = 8;
		public const int DUNGEON_PARTY_MAX_RAID16 = 16;
		public const int BR_DUNGEON_PARTY_MAX = 16;
		public const int PARTY_MEMBER_MAX = 4;
		public const int DEFAULT_SWITCH_PARTY = 0;
		public const int MAX_PARTY_SWITCH_COUNT = 2;
		[CompilerGenerated]
		private List<CharacterSelector> _parties_k__BackingField;
		[CompilerGenerated]
		private List<CharacterSelector> _guestCharacters_k__BackingField;
		[CompilerGenerated]
		private List<CharacterSelector> _playerCharacters_k__BackingField;
		[CompilerGenerated]
		private List<CharacterSelector> _characterSelectors_k__BackingField;
		[CompilerGenerated]
		private List<CharacterSelector> _otherEnemyCharacters_k__BackingField;
		[CompilerGenerated]
		private List<CharacterSelector> _servantCharacters_k__BackingField;
		[CompilerGenerated]
		private List<CharacterSelector>[] _dungeonPartyMembers_k__BackingField;
		[CompilerGenerated]
		private List<CharacterSelector> _sortedCharacterSelectors_k__BackingField;
		[CompilerGenerated]
		private CharacterSelector _supporter_k__BackingField;
		[CompilerGenerated]
		private CharacterSelector _reserver_k__BackingField;
		[CompilerGenerated]
		private List<PlayerEventReceiver> _otherPlayerCharacterEventReceivers_k__BackingField;
		[CompilerGenerated]
		private List<PlayerEventReceiver> _otherEnemyCharacterEventReceivers_k__BackingField;
		[CompilerGenerated]
		private List<PlayerEventReceiver> _otherPlayerServantCharacterEventReceivers_k__BackingField;
		public CharacterFormation formation;
		[CompilerGenerated]
		private CharacterLoadBalancer _LoadBalancer_k__BackingField;
		private int _actorIdSelf;
		private int _currentPartySwitchIndex;
		private List<PartySwitchMemberData> _partySwitchMemberList;
		private List<CharacterSelector> _tmpOtherPlayerCharacters;
	
		// Properties
		public List<CharacterSelector> parties { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<CharacterSelector> guestCharacters { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<CharacterSelector> playerCharacters { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<CharacterSelector> characterSelectors { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<CharacterSelector> otherEnemyCharacters { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<CharacterSelector> servantCharacters { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<CharacterSelector>[] dungeonPartyMembers { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<CharacterSelector> sortedCharacterSelectors { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterSelector supporter { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterSelector reserver { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<PlayerEventReceiver> otherPlayerCharacterEventReceivers { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<PlayerEventReceiver> otherEnemyCharacterEventReceivers { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<PlayerEventReceiver> otherPlayerServantCharacterEventReceivers { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterLoadBalancer LoadBalancer { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private class PartySwitchMemberData
		{
			// Fields
			public List<CharacterSelector> selectors;
			public List<CharacterSelector> servants;
			public List<Vector3> lastPositions;
			public List<Quaternion> lastRotations;
	
			// Constructors
			public PartySwitchMemberData();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<CharacterSelector> __9__81_0;
			public static Comparison<CharacterSelector> __9__86_0;
			public static Func<CharacterSelector, HumanCharacter> __9__90_0;
			public static Func<CharacterSelector, bool> __9__91_0;
			public static Func<CharacterSelector, bool> __9__91_1;
			public static Func<CharacterSelector, bool> __9__91_2;
			public static Func<CharacterSelector, bool> __9__91_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _ApplySupportCharacter_b__81_0(CharacterSelector a, CharacterSelector b);
			internal int _PostSetupCharacter_b__86_0(CharacterSelector a, CharacterSelector b);
			internal HumanCharacter _GetPartySwitchMembers_b__90_0(CharacterSelector s);
			internal bool _CollectAllSwitchPartyCharacters_b__91_0(CharacterSelector s);
			internal bool _CollectAllSwitchPartyCharacters_b__91_1(CharacterSelector s);
			internal bool _CollectAllSwitchPartyCharacters_b__91_2(CharacterSelector s);
			internal bool _CollectAllSwitchPartyCharacters_b__91_3(CharacterSelector s);
		}
	
		// Constructors
		public CharacterPartySwitch();
	
		// Methods
		private void ClearCharacters();
		public void Initialize(GameDataManager gameDataManager);
		public int GetPartySwitchCount();
		public bool IsPartySwitchQuest();
		public void AddPartyCharacter(int partySwitchIndex, CharacterSelector selector);
		public void AddOtherPartyCharacter(int partySwitchIndex, CharacterSelector selector);
		private void ApplyPartyCharacter(CharacterSelector selector, bool isOtherPlayer);
		public void AddServantCharacter(int partySwitchIndex, CharacterSelector servant);
		public void AddOtherServantCharacter(int partySwitchIndex, CharacterSelector servant);
		private void ApplyServantCharacter(CharacterSelector servant);
		public void AddSupportCharacter(int partySwitchIndex, CharacterSelector selector);
		private void ApplySupportCharacter(CharacterSelector selector);
		public void AddGuestCharacter(int partySwitchIndex, CharacterSelector selector);
		public static InGameDef.SwitchPartyNoList GetSwitchPartyNo(int partyIndex);
		public InGameDef.SwitchPartyNoList GetSwitchPartyNo();
		public void PreSetupCharacter();
		public void PostSetupCharacter();
		private void AddDungeonPartyMember(CharacterSelector selector);
		public void InitializeSortedCharacterSelectorList();
		private int ComparerForSortedCharacterSelectors(CharacterSelector a, CharacterSelector b);
		public List<HumanCharacter> GetPartySwitchMembers(int partySwitchIndex);
		public List<CharacterSelector> CollectAllSwitchPartyCharacters(bool includeServant = true, bool includeSupporter = true, bool includeGuest = true, bool includeOtherPlayerChara = true);
		public void SwitchParty(int prevPartySwitchIndex, int nextPartySwitchIndex);
	}
}
