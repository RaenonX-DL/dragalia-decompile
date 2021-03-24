/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonAck
	{
		// Fields
		private PhotonClient _client;
		private State _state;
		private long _lastReceiveClientAckReplyTick;
		public static readonly int DisconnectTimeout;
		public static readonly int IntervalTime;
	
		// Nested types
		private enum State
		{
			None = 0,
			WaitForReply = 1,
			CoolTime = 2
		}
	
		// Constructors
		public PhotonAck(PhotonClient client);
		static PhotonAck();
	
		// Methods
		public void Clear();
		public bool IsValid();
		public void EnterAckSection();
		public void LeaveAckSection();
		public void Update();
		public void OnClientAck();
		public void OnServerAck();
		private void SendClientAck();
		private void ReplyServerAck();
		private void SendEnterAckSection();
		private void SendLeaveAckSection();
		private bool CheckTimeout(long currentTick);
		private bool CheckSendClientAck(long currentTick);
		private void OnClientTimeout();
		private long GetCurrentTick();
	}
}
