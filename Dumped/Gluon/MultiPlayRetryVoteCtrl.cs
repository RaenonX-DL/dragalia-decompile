using System.Runtime.CompilerServices;
using Gluon.Event;

namespace Gluon
{
	public class MultiPlayRetryVoteCtrl
	{
		private enum ControlState
		{
			None,
			Ready,
			Waiting,
			Accepted,
			Denied,
			ContinueImpossible
		}

		private ControlState _ctrlState;

		private MultiPlayRetryVoteModel.VoteState _lastMyVoteState;

		public int _myActorIndex;

		private RetryVoteEvent _tmpSendEvent;

		private bool _isLastVote;

		public MultiPlayRetryVoteModel RetryVoteModel
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

		public void Initialize()
		{
		}

		public void Update()
		{
		}

		private void UpdateAlways()
		{
		}

		private void UpdateReady()
		{
		}

		private void UpdateWaiting()
		{
		}

		private void UpdateAccepted()
		{
		}

		private void UpdateDenied()
		{
		}

		private bool UpdateTimeUp()
		{
			return default(bool);
		}

		private void ToReady()
		{
		}

		public void OnReceiveEvent(RetryVoteEvent recvEvent)
		{
		}

		public void OnDisconnectUser(int disconnectActorId)
		{
		}

		private void SendChangeVoteEvent(MultiPlayRetryVoteModel.VoteState state)
		{
		}

		private void SendGoToRetryEvent()
		{
		}

		private void SendSetIsLastVote()
		{
		}

		private void SendGoToContinueImpossibleEvent()
		{
		}

		private void SendLostStartVoteRightEvent(int actorId)
		{
		}

		private void OnReceiveChangeVoteStateEvent(RetryVoteEvent recvEvent)
		{
		}

		private void OnReceiveGoToRetryStateEvent(RetryVoteEvent recvEvent)
		{
		}

		private void OnReceiveSetIsLastVoteEvent(RetryVoteEvent recvEvent)
		{
		}

		private void OnReceiveGoToContinueImpossibleEvent(RetryVoteEvent recvEvent)
		{
		}

		private void OnReceiveLostStartVoteRightEvent(RetryVoteEvent recvEvent)
		{
		}
	}
}
