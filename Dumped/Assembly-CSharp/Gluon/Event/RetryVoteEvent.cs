/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class RetryVoteEvent : EventBase<RetryVoteEvent>
	{
		// Fields
		[Key]
		public RetryVoteEventTypes type;
		[Key]
		public int value;
	
		// Nested types
		public enum RetryVoteEventTypes : byte
		{
			ChangeVoteState = 0,
			GoToRetry = 1,
			SetIsLastVote = 2,
			GoToContinueImpossible = 3,
			LostStartVoteRight = 4
		}
	
		// Constructors
		public RetryVoteEvent();
	}
}
