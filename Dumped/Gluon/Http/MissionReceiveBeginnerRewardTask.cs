using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionReceiveBeginnerRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionReceiveBeginnerRewardResponse> onSuccess;

		private Action<ErrorType, int, MissionReceiveBeginnerRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionReceiveBeginnerRewardTask(MissionReceiveBeginnerRewardRequest request, Action<MissionReceiveBeginnerRewardResponse> onSuccess, Action<ErrorType, int, MissionReceiveBeginnerRewardResponse> onError)
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
