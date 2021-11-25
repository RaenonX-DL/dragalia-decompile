using System;
using System.Collections.Generic;

namespace Gluon
{
	public class MultiPlayRetryVoteModel
	{
		public enum VoteState : byte
		{
			Nothing,
			Ready,
			Request,
			Waiting,
			Accepted,
			Denied
		}

		public static readonly float MaxVoteCount;

		private DateTime _voteWaitStartTime;

		private DateTime _deniedRemainStartTime;

		private Dictionary<int, VoteState> _voteStateDic;

		private bool _isLastVote;

		private bool _hasStartVoteRight;

		public static float GetMaxVoteWaitTime()
		{
			return default(float);
		}

		public static float GetMaxDeniedRemainTime()
		{
			return default(float);
		}

		public float GetElapsedVoteWaitTime()
		{
			return default(float);
		}

		public float GetElapsedDeniedRemainTime()
		{
			return default(float);
		}

		public int GetMyActorIndex()
		{
			return default(int);
		}

		public bool HasActorVoteState(VoteState state)
		{
			return default(bool);
		}

		public bool IsAllActorVoteAccepted()
		{
			return default(bool);
		}

		public VoteState GetActorVoteState(int voteActorIndex)
		{
			return default(VoteState);
		}

		public void StartVoteWaitTimer()
		{
		}

		public void StartDeniedRemainTimer()
		{
		}

		public void SetActorVoteState(int voteActorIndex, VoteState state)
		{
		}

		public void SetIsLastVote()
		{
		}

		public bool IsLastVote()
		{
			return default(bool);
		}

		public bool HasStartVoteRight()
		{
			return default(bool);
		}

		public void LostStartVoteRight()
		{
		}
	}
}
