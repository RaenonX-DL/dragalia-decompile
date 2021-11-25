using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionReceiveMainStoryRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionReceiveMainStoryRewardResponse> onSuccess;

		private Action<ErrorType, int, MissionReceiveMainStoryRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionReceiveMainStoryRewardTask(MissionReceiveMainStoryRewardRequest request, Action<MissionReceiveMainStoryRewardResponse> onSuccess, Action<ErrorType, int, MissionReceiveMainStoryRewardResponse> onError)
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
