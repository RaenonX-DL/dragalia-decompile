using System.Collections.Generic;

namespace Gluon
{
	public class MultiPlaySystemMessageCtrl
	{
		private bool _needsOtherPlayerDisconnectMessage;

		private bool _needsDisconnectOwnMessage;

		private bool _needsRankingDisabledMessage;

		private bool _needsSumUpTotalDamageDisabledMessage;

		private bool _needsInstructorBonusMessage;

		private List<ulong> _instructorBonusViewerIdList;

		public void SetupInstructorBonusViewerList(List<ulong> roomViewerIds)
		{
		}

		public bool HasInstructorBonusPlayer()
		{
			return default(bool);
		}

		public void DisplayDisconnectOwnMessage(MultiPlayErrorEventService.Event e)
		{
		}

		public void DisplayDisconnectOtherPlayerMessage(MultiPlayErrorEventService.Event e, MultiPlayManager.PlayerInfo playerInfo)
		{
		}

		public void DisplayDisableInstructorBonusMessage(ulong disconnectViwerId = 0uL)
		{
		}

		public void DisplayRankingDisabledMessage()
		{
		}

		public void DisplaySumUpTotalDamageDisabledMessage()
		{
		}

		public bool NeedsInstructorBonusMessage()
		{
			return default(bool);
		}

		public bool NeedsDisconnectOwnMessage()
		{
			return default(bool);
		}

		public bool NeedsOtherPlayerDisconnectMessage()
		{
			return default(bool);
		}

		public bool NeedsRankingDisabledMessage()
		{
			return default(bool);
		}

		public bool NeedsSumUpTotalDAmageDisabledMessage()
		{
			return default(bool);
		}

		public void OnClearQuest()
		{
		}
	}
}
