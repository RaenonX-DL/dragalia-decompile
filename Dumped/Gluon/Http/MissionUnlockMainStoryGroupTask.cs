using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionUnlockMainStoryGroupTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionUnlockMainStoryGroupResponse> onSuccess;

		private Action<ErrorType, int, MissionUnlockMainStoryGroupResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionUnlockMainStoryGroupTask(MissionUnlockMainStoryGroupRequest request, Action<MissionUnlockMainStoryGroupResponse> onSuccess, Action<ErrorType, int, MissionUnlockMainStoryGroupResponse> onError)
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
