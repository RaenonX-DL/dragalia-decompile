using System.Collections.Generic;
using Gluon.Event;

namespace Gluon
{
	public class MultiPlayAuraCtrl
	{
		public static readonly int DefaultKey;

		private AuraEvent _tempSendAuraEvent;

		private Queue<AuraEventCommandData> _auraEventCommandDataQueue;

		private int _nextMultiPlayKey;

		private int _stackLevel;

		public void Initialize()
		{
		}

		public void CommandClear()
		{
		}

		public int CreateMultiPlayKey()
		{
			return default(int);
		}

		private AuraEventCommandData CreateCommandData(CharacterBase target, AuraEventCommandType commandType, int multiPlayKey)
		{
			return default(AuraEventCommandData);
		}

		private AuraEventCommandData CreateCommandData(CharacterBase target, AuraEventCommandType commandType, CharacterAuraCtrl.Parameter parameter, RemoveBuffReason reason = RemoveBuffReason.Other)
		{
			return default(AuraEventCommandData);
		}

		public void NotifyAdd(CharacterBase owner, CharacterAuraCtrl.Parameter parameter)
		{
		}

		public void NotifyUpdate(CharacterBase owner, CharacterBase from, CharacterAuraCtrl.Parameter parameter, bool durationUpdate, bool hideCaption = false)
		{
		}

		public void NotifyRemove(CharacterBase owner, int multiPlayKey, RemoveBuffReason reason)
		{
		}

		public void NotifyPublished(CharacterBase owner, int multiPlayKey, CharacterAuraCtrl.PublishParam publishParam, int maxLimitLevel)
		{
		}

		public void OnRecieveAuraEvent(AuraEvent recvEvent)
		{
		}

		public void BeginStack()
		{
		}

		public void EndStack()
		{
		}

		private void SendAuraEvent()
		{
		}
	}
}
