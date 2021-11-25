using System.Collections.Generic;
using Gluon.Event;

namespace Gluon
{
	public class BuffMultiPlayService
	{
		public static readonly int DefaultKey;

		private bool _isDirty;

		private float _nextSendEventTimer;

		private static readonly float SendEventInterval;

		private ChangeBuff _tempSendChangeBuffEvent;

		private Regeneration _tmpSendRegeneEvent;

		private Dispel _tmpSendDispelEvent;

		private int _nextMultiPlayKey;

		public void NotifyAddParametersBuff(CharacterBase owner, int type, CharacterBuff.Parameter parameter, float sacrificeShieldConsumeHp)
		{
		}

		public bool IsSyncImmdediately(CharacterBuffType type)
		{
			return default(bool);
		}

		public void NotifyRemoveParameterBuff(CharacterBase owner, int multiPlayKey, RemoveBuffReason reason)
		{
		}

		public void NotifyAddRegenerationBuff(CharacterBase owner, CharacterBuff.Regeneration regeneration)
		{
		}

		public void NotifyRemoveRegenerationBuff(CharacterBase owner, int multiPlayKey, RemoveBuffReason reason)
		{
		}

		public void NotifyAddGrantBuff(CharacterBase owner, AbilityTargetAction trigger, CharacterBuff.GrantData grant)
		{
		}

		public void NotifyRemoveGrantBuff(CharacterBase owner, int multiPlayKey, RemoveBuffReason reason)
		{
		}

		public void NotifyAddUnifiedParametersBuff(CharacterBase owner, CharacterBuff.UnifiedParameter parameter, float sacrificeShieldConsumeHp)
		{
		}

		public void NotifyRemoveUnifiedParameterBuff(CharacterBase owner, int multiPlayKey, RemoveBuffReason reason)
		{
		}

		public void NotifyRegenerate(CharacterBase owner, Dictionary<CharacterBase, int> froms, CharacterBuffType type, int buffIconId, int heal1, int heal2, int heal3, int heal4, int damage1, bool isFollower, float dragonTimerDamage)
		{
		}

		public void NotifyExtraRegenerate(CharacterBase owner, int heal)
		{
		}

		public void NotifyDispelSucceeded(CharacterBase owner, int actionId, CharacterBase from)
		{
		}

		public int CreateMultiPlayKey(CharacterBase owner)
		{
			return default(int);
		}

		public void UpdateSendEvent(CharacterBase owner)
		{
		}

		public void SendImmediately(CharacterBase owner)
		{
		}

		public void OnRecieveCurrentBuff(CharacterBase owner, ChangeBuff recvEvent)
		{
		}

		public void OnReceiveRegenerate(CharacterBase owner, Regeneration regene)
		{
		}

		public void OnReceiveDispel(CharacterBase owner, Dispel recvEvent)
		{
		}

		private void SendCurrentBuff(CharacterBase owner)
		{
		}

		public bool HasSendImmediatelyBuff()
		{
			return default(bool);
		}

		private void SetDirty()
		{
		}
	}
}
