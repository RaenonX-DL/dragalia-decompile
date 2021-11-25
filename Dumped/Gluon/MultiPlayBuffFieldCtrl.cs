using System.Collections.Generic;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class MultiPlayBuffFieldCtrl
	{
		private static long _nextBuffFieldId;

		private List<BuffFieldEvent> _requestEventQueue;

		private ActionStartParameter _tmpActionStartParam;

		public void Update()
		{
		}

		public void RequestCreateBuffField(long buffFieldId, long actionPartsResourceId, string hitAttrLabel, Vector3 position, Quaternion rotation, CharacterBase owner, int actionId, int skillId, int actionProductId, ActionStartParameter actionStartParam, bool isHostRequest)
		{
		}

		public void OnReceiveBuffFieldEvent(BuffFieldEvent recvEvent)
		{
		}

		public void OnDisconnectUser(int disconnectActorId)
		{
		}

		private void CreateBuffField(BuffFieldEvent recvEvent, CharacterBase owner, BuffFieldCreateEventParam param)
		{
		}

		public static long CreateBuffFieldId()
		{
			return default(long);
		}

		public static void ResetBuffFieldId()
		{
		}
	}
}
