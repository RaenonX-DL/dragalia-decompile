/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlayRetryVoteCtrl
	{
		// Fields
		private ControlState _ctrlState;
		private MultiPlayRetryVoteModel.VoteState _lastMyVoteState;
		[CompilerGenerated]
		private MultiPlayRetryVoteModel _RetryVoteModel_k__BackingField;
		public int _myActorIndex;
		private RetryVoteEvent _tmpSendEvent;
		private bool _isLastVote;
	
		// Properties
		public MultiPlayRetryVoteModel RetryVoteModel { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private enum ControlState
		{
			None = 0,
			Ready = 1,
			Waiting = 2,
			Accepted = 3,
			Denied = 4,
			ContinueImpossible = 5
		}
	
		// Constructors
		public MultiPlayRetryVoteCtrl();
	
		// Methods
		public void Initialize();
		public void Update();
		private void UpdateAlways();
		private void UpdateReady();
		private void UpdateWaiting();
		private void UpdateAccepted();
		private void UpdateDenied();
		private bool UpdateTimeUp();
		private void ToReady();
		public void OnReceiveEvent(RetryVoteEvent recvEvent);
		public void OnDisconnectUser(int disconnectActorId);
		private void SendChangeVoteEvent(MultiPlayRetryVoteModel.VoteState state);
		private void SendGoToRetryEvent();
		private void SendSetIsLastVote();
		private void SendGoToContinueImpossibleEvent();
		private void SendLostStartVoteRightEvent(int actorId);
		private void OnReceiveChangeVoteStateEvent(RetryVoteEvent recvEvent);
		private void OnReceiveGoToRetryStateEvent(RetryVoteEvent recvEvent);
		private void OnReceiveSetIsLastVoteEvent(RetryVoteEvent recvEvent);
		private void OnReceiveGoToContinueImpossibleEvent(RetryVoteEvent recvEvent);
		private void OnReceiveLostStartVoteRightEvent(RetryVoteEvent recvEvent);
	}
}
