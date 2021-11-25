namespace Gluon
{
	public class PhotonAck
	{
		private enum State
		{
			None,
			WaitForReply,
			CoolTime
		}

		private PhotonClient _client;

		private State _state;

		private long _lastReceiveClientAckReplyTick;

		public static readonly int DisconnectTimeout;

		public static readonly int IntervalTime;

		public PhotonAck(PhotonClient client)
		{
		}

		public void Clear()
		{
		}

		public bool IsValid()
		{
			return default(bool);
		}

		public void EnterAckSection()
		{
		}

		public void LeaveAckSection()
		{
		}

		public void Update()
		{
		}

		public void OnClientAck()
		{
		}

		public void OnServerAck()
		{
		}

		private void SendClientAck()
		{
		}

		private void ReplyServerAck()
		{
		}

		private void SendEnterAckSection()
		{
		}

		private void SendLeaveAckSection()
		{
		}

		private bool CheckTimeout(long currentTick)
		{
			return default(bool);
		}

		private bool CheckSendClientAck(long currentTick)
		{
			return default(bool);
		}

		private void OnClientTimeout()
		{
		}

		private long GetCurrentTick()
		{
			return default(long);
		}
	}
}
