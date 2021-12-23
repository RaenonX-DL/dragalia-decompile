using System.Collections.Generic;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlVesselBomb : CUGCtrlBase
	{
		private enum VesselBombStates
		{
			CountDown,
			Reserved,
			WaitForCoolTime
		}

		public class VesselBombUiInfo
		{
			public ExtraBuffType VesselBombType;

			public int ActionConditionId;

			public int RemainCount;

			public int MaxCount;

			public bool IsCoolTimeRunning;

			public float RemainCoolTime;

			public float MaxCoolTime;
		}

		private class CountdownCoolTimeCtrl
		{
			private class CountdownRecord
			{
				public CharacterBase Chara;

				public int ActionConditionId;

				public int ActionId;

				public int SkillId;

				public float RemainCoolTime;
			}

			private List<CountdownRecord> _recordList;

			public void ResetCountdownCoolTime()
			{
			}

			public void UpdateCountdownCoolTime(float dt)
			{
			}

			public bool CheckCountdown(CharacterBase appender, int actionId, int skillId, int actionConditionId)
			{
				return default(bool);
			}

			public void ResetCoolTime(CharacterBase appender, int actionId, int skillId, int actionConditionId)
			{
			}
		}

		private class CharacterBuffTriggerReactionVesselBomb : CharacterBuffTriggerReactionBase
		{
			public class BuffRecord
			{
				public VesselBombStates VesselBombState;

				public CharacterBuff.BuffUnion TargetBuff;

				public int Damage;

				public CharacterBase BuffAppender;

				public CollisionHitAttribute HitAttribute;

				public int ActionConditionId;

				public BuffExplosionDataElement BuffExplosionData;

				public VesselBombUiInfo UiInfo;

				public CountdownCoolTimeCtrl CountDownCoolTimeCtrl;

				public void Countdown()
				{
				}

				public bool IsOtherPartyVesselBomb(int dungeonPartyIndex)
				{
					return default(bool);
				}
			}

			private List<BuffRecord> _buffList;

			private EnemyCharacter _owner;

			private CtrlVesselBomb _ctrlVesselBomb;

			public List<BuffRecord> BuffList => null;

			public void SetOwner(CtrlVesselBomb ctrlVesselBomb, EnemyCharacter owner)
			{
			}

			public override void Update()
			{
			}

			public override bool CanAcceptTrigger(ref CharacterAppendBuffTrigger trigger)
			{
				return default(bool);
			}

			public override void OnAppendBuff(ref CharacterAppendBuffTrigger trigger)
			{
			}

			public override bool CanAcceptTrigger(ref CharacterRemoveBuffTrigger trigger)
			{
				return default(bool);
			}

			public override void OnRemoveBuff(ref CharacterRemoveBuffTrigger trigger)
			{
			}

			private void ExecRemoveBuffExtraDamage(BuffRecord record)
			{
			}

			private void PlayEffect(CharacterBase target, CharacterBase appender, BuffExplosionDataElement data)
			{
			}
		}

		private CharacterBuffTriggerReactionVesselBomb reaction;

		private VesselBombUI vesselBombUI;

		private static int _nextTaskId;

		private VesselBombEvent _tmpSendCountdown;

		private VesselBombEvent _tmpSendCountdownWithCoolTime;

		private VesselBombEvent _tmpSendResisted;

		public static Color RESIST_FONT_COLOR => default(Color);

		public static int CreateTaskId()
		{
			return default(int);
		}

		public static void ResetTaskId()
		{
		}

		public void Setup(EnemyCharacter enemy)
		{
		}

		public override void Update(CharacterBase src)
		{
		}

		private void UpdateUI()
		{
		}

		public void UpdateUI(VesselBombUiInfo uiInfo)
		{
		}

		public static bool IsVesselBombDebuff(int actionConditionId)
		{
			return default(bool);
		}

		public static bool IsVesselBombDebuff(ActionConditionElement ace)
		{
			return default(bool);
		}

		public static void OnApplyDebuffRefused(CharacterBase owner, CharacterBase lastHitChara, int conditionId)
		{
		}

		public static void OnApplyDebuffRefused(CharacterBase owner, CharacterBase lastHitChara, ActionConditionElement ace)
		{
		}

		public bool OnPreApplyVesselBomb(CharacterBase lastHitChara, ActionConditionElement ace, CharacterBase from)
		{
			return default(bool);
		}

		public void OnPostApplyAbnormalStatus(CollisionHitAttribute hitAttr)
		{
		}

		public VesselBombUiInfo GetCurrentUiInfo()
		{
			return null;
		}

		private void SendCountdownEvent(CharacterBuffTriggerReactionVesselBomb.BuffRecord record)
		{
		}

		private void SendCountdownWithCoolTimeEvent(CharacterBuffTriggerReactionVesselBomb.BuffRecord record, CharacterBase appender, int actionId, int skillId, int actionConditionId)
		{
		}

		private void SendResistedEvent(Vector3 hitPos)
		{
		}

		public void OnReceiveEvent(VesselBombEvent recvEvent)
		{
		}

		public override void TakeOverStatus(EnemyCharacter src, bool restoreEff = true)
		{
		}
	}
}
