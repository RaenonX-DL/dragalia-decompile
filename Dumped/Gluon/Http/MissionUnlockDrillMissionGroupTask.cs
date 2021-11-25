using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionUnlockDrillMissionGroupTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionUnlockDrillMissionGroupResponse> onSuccess;

		private Action<ErrorType, int, MissionUnlockDrillMissionGroupResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionUnlockDrillMissionGroupTask(MissionUnlockDrillMissionGroupRequest request, Action<MissionUnlockDrillMissionGroupResponse> onSuccess, Action<ErrorType, int, MissionUnlockDrillMissionGroupResponse> onError)
		{
		}

		public void SetHeader(string key, string value)
		{
		}

		public IWebRequest Send(string url)
		{
			return null;
		}

		public bool Deserialize(byte[] body)
		{
			return default(bool);
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}
	}
}
