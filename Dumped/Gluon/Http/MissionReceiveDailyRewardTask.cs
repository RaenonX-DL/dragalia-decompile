using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionReceiveDailyRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionReceiveDailyRewardResponse> onSuccess;

		private Action<ErrorType, int, MissionReceiveDailyRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionReceiveDailyRewardTask(MissionReceiveDailyRewardRequest request, Action<MissionReceiveDailyRewardResponse> onSuccess, Action<ErrorType, int, MissionReceiveDailyRewardResponse> onError)
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
