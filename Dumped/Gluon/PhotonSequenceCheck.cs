using System.Collections.Generic;
using Gluon.Common;

namespace Gluon
{
	public class PhotonSequenceCheck
	{
		private Dictionary<int, ushort> _sequenceIdDic;

		private ushort _nextSequenceId;

		private bool _isCheckEnabled;

		public void BeginCheck()
		{
		}

		public void Clear()
		{
		}

		public bool OnReceive(EventCode code, int actorId, ushort sequenceId)
		{
			return default(bool);
		}

		public ushort TakeNextSequenceId(EventCode code)
		{
			return default(ushort);
		}

		private static bool IsPhotonServerSendEventCode(EventCode code)
		{
			return default(bool);
		}

		private static bool IsPhotonServerReceiveEventCode(EventCode code)
		{
			return default(bool);
		}

		private bool IsNextSequenceId(ushort currentId, ushort newId)
		{
			return default(bool);
		}
	}
}
