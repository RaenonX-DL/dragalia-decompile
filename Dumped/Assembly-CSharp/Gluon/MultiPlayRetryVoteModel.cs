/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlayRetryVoteModel
	{
		// Fields
		public static readonly float MaxVoteCount;
		private DateTime _voteWaitStartTime;
		private DateTime _deniedRemainStartTime;
		private Dictionary<int, VoteState> _voteStateDic;
		private bool _isLastVote;
		private bool _hasStartVoteRight;
	
		// Nested types
		public enum VoteState : byte
		{
			Nothing = 0,
			Ready = 1,
			Request = 2,
			Waiting = 3,
			Accepted = 4,
			Denied = 5
		}
	
		// Constructors
		public MultiPlayRetryVoteModel();
		static MultiPlayRetryVoteModel();
	
		// Methods
		public static float GetMaxVoteWaitTime();
		public static float GetMaxDeniedRemainTime();
		public float GetElapsedVoteWaitTime();
		public float GetElapsedDeniedRemainTime();
		public int GetMyActorIndex();
		public bool HasActorVoteState(VoteState state);
		public bool IsAllActorVoteAccepted();
		public VoteState GetActorVoteState(int voteActorIndex);
		public void StartVoteWaitTimer();
		public void StartDeniedRemainTimer();
		public void SetActorVoteState(int voteActorIndex, VoteState state);
		public void SetIsLastVote();
		public bool IsLastVote();
		public bool HasStartVoteRight();
		public void LostStartVoteRight();
	}
}
