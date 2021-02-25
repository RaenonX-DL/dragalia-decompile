/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterManager : IGetCharacter
	{
		// Fields
		public const int DUNGEON_PARTY_MAX = 8;
		public const int BR_DUNGEON_PARTY_MAX = 16;
		public const int PARTY_MEMBER_MAX = 4;
		[CompilerGenerated]
		private PlayerCtrl _player_k__BackingField;
		[CompilerGenerated]
		private CharacterSelector _supportRequestChara_k__BackingField;
		private bool loaded;
		private List<int> inactivateUsers;
		private GraphicManager _graphicManager;
		private Dictionary<int, ActionContainerElement> _dictActionDataResource;
		[CompilerGenerated]
		private bool _isOperatedPlayer_k__BackingField;
		private Action CharacterFilterRevertCallback;
		[CompilerGenerated]
		private CharacterPartySwitch _partySwitch_k__BackingField;
		[CompilerGenerated]
		private bool _canFinishDragonOnPause_k__BackingField;
	
		// Properties
		public PlayerCtrl player { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<CharacterSelector> parties { get; }
		public List<CharacterSelector> guestCharacters { get; }
		public List<CharacterSelector> playerCharacters { get; }
		public List<CharacterSelector> characterSelectors { get; }
		public List<CharacterSelector> otherEnemyCharacters { get; }
		public List<CharacterSelector> servantCharacters { get; }
		public List<CharacterSelector>[] dungeonPartyMembers { get; }
		public List<CharacterSelector> sortedCharacterSelectors { get; }
		public CharacterSelector supporter { get; }
		public CharacterSelector reserver { get; }
		public CharacterSelector supportRequestChara { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<PlayerEventReceiver> otherPlayerCharacterEventReceivers { get; }
		public List<PlayerEventReceiver> otherEnemyCharacterEventReceivers { get; }
		public List<PlayerEventReceiver> otherPlayerServantCharacterEventReceivers { get; }
		public Dictionary<int, ActionContainerElement> dictActionDataResource { get; }
		public bool isOperatedPlayer { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterLoadBalancer LoadBalancer { get; }
		public CharacterPartySwitch partySwitch { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool canFinishDragonOnPause { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int characterCount { get; }
	
		// Nested types
		public class PartyInfo
		{
			// Fields
			public int nParty;
			public MemberInfo[] memberInfo;
	
			// Nested types
			public class MemberInfo
			{
				// Fields
				public int nMember;
				public int nLiving;
				public int[] hp;
				public int[] maxHp;
				public int totalHp;
				public int totalMaxHp;
				public int actorId;
	
				// Constructors
				public MemberInfo();
			}
	
			// Constructors
			public PartyInfo();
	
			// Methods
			public void Initialize();
		}
	
		[CompilerGenerated]
		private sealed class _Initialize_d__58 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CharacterManager __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Initialize_d__58(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<CharacterSelector> __9__75_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LoadPlayers_b__75_0(CharacterSelector a, CharacterSelector b);
		}
	
		[CompilerGenerated]
		private sealed class _LoadPlayers_d__75 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CharacterManager __4__this;
			private int _actorIdSelf_5__2;
			private GameDataManager _gameDataManager_5__3;
			private GameUserData _gameUserData_5__4;
			private List<List<HeroParam>> __heroParamsList_5__5;
			private List<List<HeroParamExData>> __heroParamExsList_5__6;
			private bool _isPlayingBR_5__7;
			private HeroParam _supporterHeroParam_5__8;
			private HeroParam _guestHeroParam_5__9;
			private List<CharacterSelector> _otherPlayerCharacters_5__10;
			private int _partySwitchIndex_5__11;
			private int _partyCharaNum_5__12;
			private int _i_5__13;
			private Dictionary<int, CharacterData> _e_5__14;
			private CharacterData _characterData_5__15;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadPlayers_d__75(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass99_0
		{
			// Fields
			public CharacterId characterId;
	
			// Constructors
			public __c__DisplayClass99_0();
	
			// Methods
			internal bool _FindPlayerEventReceiver_b__0(PlayerEventReceiver c);
			internal bool _FindPlayerEventReceiver_b__1(PlayerEventReceiver c);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass148_0
		{
			// Fields
			public bool[] prevIgnore;
			public bool[] prevAvoidIgnore;
	
			// Constructors
			public __c__DisplayClass148_0();
	
			// Methods
			internal void _SetIgnorePlayerFilter_b__0();
		}
	
		// Constructors
		public CharacterManager();
	
		// Methods
		[IteratorStateMachine]
		public IEnumerator Initialize();
		public void EnableNavMeshAgent(bool enable);
		public void InitializePosition();
		public Vector3 GetFollowerWorldPosition(Vector3 localPos);
		public List<CharacterBase> BulkWarp(Vector3 pos, Quaternion rot, bool checkIsDead);
		public void Warp(Vector3 pos, Quaternion rot, bool checkIsDead);
		private void SetMoveFlagMulti(CharacterBase character);
		private void SetRaidPosition(CharacterSelector selector);
		private void SetQuestPosition(CharacterSelector selector);
		public CharacterBase GetCurrentCharacter(CharacterBase target);
		public CharacterBase GetCurrentCharacterAndSupport(CharacterBase target);
		public CharacterBase GetOriginalCharacter(CharacterBase target);
		public CharacterBase GetActiveSupportCharacter();
		public CharacterBase GetNearestCharacter(Vector3 position, float searchRange, bool isContainDeadMan = false);
		public CharacterBase GetHpRateLowestCharacter(CharacterSelector selector, bool includeOtherParty);
		public float GetPartyHpRate();
		private void GetCharaAndDragonIdsFromHeroParam(HeroParam param, HashSet<int> charaIds, HashSet<int> dragonIds);
		[IteratorStateMachine]
		private IEnumerator LoadPlayers();
		private CharacterSelector CreateCharacter(HeroParam heroParam, HeroParamExData heroParamEx, bool isPartyMember, CharacterBase.HitType hitType, int actorIndex, int partySwitchIndex, bool isSupporter = false);
		public CharacterSelector CreateServant(HeroParam heroParam, HumanCharacter human, bool isPartyMember);
		private bool IsNeedShadow(bool isPartyMember, bool isSupporter);
		public void SetPlayer(int index, bool withEffectAndVoice = true);
		private FollowerController SetFollower(CharacterSelector follower);
		private void SetFollowPosition();
		private bool IsDoll(CharacterSelector selector);
		private bool IsNotDeadAndNotDoll(CharacterSelector selector);
		public bool IsAllDead();
		public bool IsExistAliveParties();
		public void ChangeReserver(int dpIdx, int dpPos);
		public void EnterSupporter();
		public void ExitSupporter();
		private void SetupChangeCharacter(CharacterSelector selector);
		public CharacterBase GetCharacter(int index);
		public CharacterBase GetSortedCharacter(int index);
		public CharacterSelector GetSelecter(CharacterBase chara, bool checkDragon = false);
		public bool IsExistAliveCharacters();
		public List<CharacterBase> GetAliveCharacters();
		public List<CharacterBase> GetAliveSortedCharacters();
		public PlayerEventSender FindPlayerEventSender(CharacterId characterId);
		public PlayerEventReceiver FindPlayerEventReceiver(CharacterId characterId);
		public void SetStateIdle();
		public void SetStateEvent();
		public void SetPrevState();
		public void SetPause(bool flag, bool includeOtherSwitchParty = false);
		public void ActivateQuestStartAbility();
		public void ActivateActiveGaugeAbility();
		public void ActivateCharacterMode();
		public void StartAreaChange();
		public void EndAreaChange();
		public void PauseCharacterTimer(bool flag);
		public void SetQuestClear();
		public void SetQuestFailure();
		public void SetTimeStop(bool isStop);
		public void SetTimeStopForCutIn(bool isStop);
		public void RestoreAnimation();
		public void DeleteAllBullet();
		public void ClearAllEffect();
		public void ClearAllSE();
		public void InactivateOtherPlayerCharacters(int actorId);
		public void NotifyChangeControlledPlayer(int actorId, PlayerEventReceiver receiver);
		private void InactivateOtherPlayerCharactersImpl(int inactivatedActorId);
		private void SetupSender(int nextOwnerActorId, Vector3 followOffset, CharacterSelector selector);
		public bool IsControlCharacter(CharacterBase chara);
		public bool IsOtherPlayerCharacter(CharacterBase chara);
		public bool IsMyParty(CharacterBase chara);
		public bool IsExistDragonInMyParty();
		public bool IsExistDragonInMyPartyForBGM(CharacterBase checker);
		public void SetSkillLinkInvincbleTime();
		public bool HasUniqueTransform();
		public bool HasUniqueTransform(CharacterBase chara);
		public void RecoveryUtp(int point);
		public void RecoveryUtpRatio(float rate);
		public void RequestCharacterChangeEffect(CharacterSelector target);
		public void InitializeCharacterRenderState();
		public void SetLightProbeParam();
		private void SetCharacterShader(List<CharacterSelector> characterSelectorList, bool isDefault, bool isRestart);
		private void SetCharacterShader(CharacterSelector characterSelector, bool isDefault, bool isRestart);
		private void SetCharacterShader(List<PlayerEventReceiver> playerEventReceiverList, bool isDefault, bool isRestart);
		public void SetMainCharacterShader(int no, bool isRestart);
		public void InitializeGraphics();
		public void RemoveActionDataResource(int id);
		public void RemoveAllActionDataResource();
		public void GetPartyInfo(ref PartyInfo partyInfo);
		public CharacterSelector FindCharacterSelectorFromParties(DragonCharacter dragon);
		public CharacterSelector FindCharacterSelectorFromOthers(DragonCharacter dragon);
		public CharacterSelector FindCharacterSelectorFromOtherEnemyCharacters(DragonCharacter dragon);
		public CharacterSelector GetControlledCharacter(int actorId, bool seeAlsoLastControlled = false);
		public void SetIgnorePlayerFilter();
		public void RevertIgnorePlayerFilter();
		public List<CharacterBase> GetRebornTargetCharas();
		public bool CanReborn(CharacterBase chara);
		public int GetOwnerActorId(CharacterSelector selecter);
		private void SendChangedCharaOwner(int inactivatedActorId, List<CharacterFormation.FormationData> affectedList);
		public List<HumanCharacter> GetPartySwitchMembers(int partySwitchIndex);
		public void SwitchParty(int prevpartySwitchIndex, int nextpartySwitchIndex);
	}
}
