using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class CharacterManager : IGetCharacter
	{
		public class PartyInfo
		{
			public class MemberInfo
			{
				public int nMember;

				public int nLiving;

				public int[] hp;

				public int[] maxHp;

				public int totalHp;

				public int totalMaxHp;

				public int actorId;
			}

			public int nParty;

			public MemberInfo[] memberInfo;

			public void Initialize()
			{
			}
		}

		public const int DUNGEON_PARTY_MAX = 8;

		public const int BR_DUNGEON_PARTY_MAX = 16;

		public const int PARTY_MEMBER_MAX = 4;

		private bool loaded;

		private List<int> inactivateUsers;

		private GraphicManager _graphicManager;

		private Dictionary<int, ActionContainerElement> _dictActionDataResource;

		private Action CharacterFilterRevertCallback;

		public PlayerCtrl player
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<CharacterSelector> parties => null;

		public List<CharacterSelector> guestCharacters => null;

		public List<CharacterSelector> playerCharacters => null;

		public List<CharacterSelector> characterSelectors => null;

		public List<CharacterSelector> otherEnemyCharacters => null;

		public List<CharacterSelector> servantCharacters => null;

		public List<CharacterSelector> servitorCharacters => null;

		public List<CharacterSelector>[] dungeonPartyMembers => null;

		public List<CharacterSelector> sortedCharacterSelectors => null;

		public CharacterSelector supporter => null;

		public CharacterSelector reserver => null;

		public CharacterSelector supportRequestChara
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

		public List<PlayerEventReceiver> otherPlayerCharacterEventReceivers => null;

		public List<PlayerEventReceiver> otherEnemyCharacterEventReceivers => null;

		public List<PlayerEventReceiver> otherPlayerServantCharacterEventReceivers => null;

		public Dictionary<int, ActionContainerElement> dictActionDataResource => null;

		public bool isOperatedPlayer
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CharacterLoadBalancer LoadBalancer => null;

		public CharacterPartySwitch partySwitch
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

		public bool canFinishDragonOnPause
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int characterCount => default(int);

		public IEnumerator Initialize()
		{
			return null;
		}

		public void EnableNavMeshAgent(bool enable)
		{
		}

		public void InitializePosition()
		{
		}

		public Vector3 GetFollowerWorldPosition(Vector3 localPos)
		{
			return default(Vector3);
		}

		public List<CharacterBase> BulkWarp(Vector3 pos, Quaternion rot, bool checkIsDead)
		{
			return null;
		}

		public void Warp(Vector3 pos, Quaternion rot, bool checkIsDead)
		{
		}

		private void SetMoveFlagMulti(CharacterBase character)
		{
		}

		private void SetRaidPosition(CharacterSelector selector)
		{
		}

		private void SetQuestPosition(CharacterSelector selector)
		{
		}

		public CharacterBase GetCurrentCharacter(CharacterBase target)
		{
			return null;
		}

		public CharacterBase GetCurrentCharacterAndSupport(CharacterBase target)
		{
			return null;
		}

		public CharacterBase GetOriginalCharacter(CharacterBase target)
		{
			return null;
		}

		public CharacterBase GetActiveSupportCharacter()
		{
			return null;
		}

		public CharacterBase GetNearestCharacter(Vector3 position, float searchRange, bool isContainDeadMan = false)
		{
			return null;
		}

		public CharacterBase GetHpRateLowestCharacter(CharacterSelector selector, bool includeOtherParty)
		{
			return null;
		}

		public float GetPartyHpRate()
		{
			return default(float);
		}

		private void GetCharaAndDragonIdsFromHeroParam(HeroParam param, HashSet<int> charaIds, HashSet<int> dragonIds)
		{
		}

		private IEnumerator LoadPlayers()
		{
			return null;
		}

		private CharacterSelector CreateCharacter(HeroParam heroParam, HeroParamExData heroParamEx, bool isPartyMember, CharacterBase.HitType hitType, int actorIndex, int partySwitchIndex, bool isSupporter = false)
		{
			return null;
		}

		public CharacterSelector CreateServant(HeroParam heroParam, HumanCharacter human, bool isPartyMember)
		{
			return null;
		}

		public CharacterSelector CreateServitor(HeroParam heroParam, HumanCharacter human, bool isPartyMember)
		{
			return null;
		}

		private bool IsNeedShadow(bool isPartyMember, bool isSupporter)
		{
			return default(bool);
		}

		public void SetPlayer(int index, bool withEffectAndVoice = true, bool withUI = true)
		{
		}

		private FollowerController SetFollower(CharacterSelector follower)
		{
			return null;
		}

		private void SetFollowPosition()
		{
		}

		private bool IsDoll(CharacterSelector selector)
		{
			return default(bool);
		}

		private bool IsNotDeadAndNotDoll(CharacterSelector selector)
		{
			return default(bool);
		}

		public bool IsAllDead()
		{
			return default(bool);
		}

		public bool IsExistAliveParties()
		{
			return default(bool);
		}

		public void ChangeReserver(int dpIdx, int dpPos)
		{
		}

		public void EnterSupporter()
		{
		}

		public void ExitSupporter()
		{
		}

		private void SetupChangeCharacter(CharacterSelector selector)
		{
		}

		public CharacterBase GetCharacter(int index)
		{
			return null;
		}

		public CharacterBase GetSortedCharacter(int index)
		{
			return null;
		}

		public CharacterSelector GetSelecter(CharacterBase chara, bool checkDragon = false)
		{
			return null;
		}

		public bool IsExistAliveCharacters()
		{
			return default(bool);
		}

		public List<CharacterBase> GetAliveCharacters()
		{
			return null;
		}

		public List<CharacterBase> GetAliveSortedCharacters()
		{
			return null;
		}

		public int GetMyUserRoseTokenNum()
		{
			return default(int);
		}

		public PlayerEventSender FindPlayerEventSender(CharacterId characterId)
		{
			return null;
		}

		public PlayerEventReceiver FindPlayerEventReceiver(CharacterId characterId)
		{
			return null;
		}

		public void SetStateIdle()
		{
		}

		public void SetStateEvent()
		{
		}

		public void SetPrevState()
		{
		}

		public void SetPause(bool flag, bool includeOtherSwitchParty = false)
		{
		}

		public void ActivateQuestStartAbility()
		{
		}

		public void ActivateActiveGaugeAbility()
		{
		}

		public void ActivateCharacterMode()
		{
		}

		public void ApplyOpeningDebuff(bool postPartySwitch = false)
		{
		}

		public void StartAreaChange()
		{
		}

		public void EndAreaChange()
		{
		}

		public void RecoverForDmodeAreaChange()
		{
		}

		public void SetMaxSpForDmode()
		{
		}

		public void RecoveryHpFully(bool dispUi, bool dispEffect, bool forcibly)
		{
		}

		public void SetMaxDp(bool includeUtp)
		{
		}

		public void PauseCharacterTimer(bool flag)
		{
		}

		public void SetQuestClear()
		{
		}

		public void SetQuestFailure()
		{
		}

		public void StartLastBossDeadAreaChange()
		{
		}

		public void SetTimeStop(bool isStop)
		{
		}

		private void SetTimeStop(CharacterSelector selector)
		{
		}

		private void ReleaseTimeStop(CharacterSelector selector)
		{
		}

		public void SetTimeStopForCutIn(bool isStop)
		{
		}

		public void RestoreAnimation()
		{
		}

		public void DeleteAllBullet()
		{
		}

		public void ClearAllEffect()
		{
		}

		public void ClearAllSE()
		{
		}

		public void InactivateOtherPlayerCharacters(int actorId)
		{
		}

		public void NotifyChangeControlledPlayer(int actorId, PlayerEventReceiver receiver)
		{
		}

		private void InactivateOtherPlayerCharactersImpl(int inactivatedActorId)
		{
		}

		private void SetupSender(int nextOwnerActorId, Vector3 followOffset, CharacterSelector selector)
		{
		}

		public bool IsControlCharacter(CharacterBase chara)
		{
			return default(bool);
		}

		public bool IsOtherPlayerCharacter(CharacterBase chara)
		{
			return default(bool);
		}

		public bool IsMyParty(CharacterBase chara)
		{
			return default(bool);
		}

		public bool IsExistDragonInMyParty()
		{
			return default(bool);
		}

		public bool IsExistDragonInMyPartyForBGM(CharacterBase checker)
		{
			return default(bool);
		}

		public void SetSkillLinkInvincbleTime()
		{
		}

		public bool HasUniqueTransform()
		{
			return default(bool);
		}

		public bool HasUniqueTransform(CharacterBase chara)
		{
			return default(bool);
		}

		public void RecoveryUtp(int point)
		{
		}

		public void RecoveryUtpRatio(float rate)
		{
		}

		public void RequestCharacterChangeEffect(CharacterSelector target)
		{
		}

		public void InitializeCharacterRenderState()
		{
		}

		public void RestoreGraphicsProperties()
		{
		}

		public void SetLightProbeParam()
		{
		}

		private void SetCharacterShader(List<CharacterSelector> characterSelectorList, bool isDefault, bool isRestart)
		{
		}

		private void SetCharacterShader(CharacterSelector characterSelector, bool isDefault, bool isRestart)
		{
		}

		private void SetCharacterShader(List<PlayerEventReceiver> playerEventReceiverList, bool isDefault, bool isRestart)
		{
		}

		public void SetMainCharacterShader(int no, bool isRestart)
		{
		}

		public void InitializeGraphics()
		{
		}

		public void RemoveActionDataResource(int id, bool withUnload = false)
		{
		}

		public void RemoveAllActionDataResource()
		{
		}

		public void GetPartyInfo(ref PartyInfo partyInfo)
		{
		}

		public CharacterSelector FindCharacterSelectorFromParties(DragonCharacter dragon)
		{
			return null;
		}

		public CharacterSelector FindCharacterSelectorFromOthers(DragonCharacter dragon)
		{
			return null;
		}

		public CharacterSelector FindCharacterSelectorFromOtherEnemyCharacters(DragonCharacter dragon)
		{
			return null;
		}

		public CharacterSelector GetControlledCharacter(int actorId, bool seeAlsoLastControlled = false)
		{
			return null;
		}

		public void SetIgnorePlayerFilter()
		{
		}

		public void RevertIgnorePlayerFilter()
		{
		}

		public int GetOwnerActorId(CharacterSelector selecter)
		{
			return default(int);
		}

		private void SendChangedCharaOwner(int inactivatedActorId, List<CharacterFormation.FormationData> affectedList)
		{
		}

		public List<HumanCharacter> GetPartySwitchMembers(int partySwitchIndex)
		{
			return null;
		}

		public void SwitchParty(int prevpartySwitchIndex, int nextpartySwitchIndex)
		{
		}

		public void CheckInactivateUsers()
		{
		}

		public float GetPartyMaxRecoveryDP(CharacterBase owner)
		{
			return default(float);
		}

		public void RestoreAttachEffect()
		{
		}

		private bool CheckNeedsToUseMyModelForOthersModels(int i)
		{
			return default(bool);
		}

		private void ClearOverridenModelFunc()
		{
		}
	}
}
