using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionReceivePeriodRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionReceivePeriodRewardResponse> onSuccess;

		private Action<ErrorType, int, MissionReceivePeriodRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionReceivePeriodRewardTask(MissionReceivePeriodRewardRequest request, Action<MissionReceivePeriodRewardResponse> onSuccess, Action<ErrorType, int, MissionReceivePeriodRewardResponse> onError)
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
