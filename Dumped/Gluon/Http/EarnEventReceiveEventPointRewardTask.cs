using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EarnEventReceiveEventPointRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<EarnEventReceiveEventPointRewardResponse> onSuccess;

		private Action<ErrorType, int, EarnEventReceiveEventPointRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EarnEventReceiveEventPointRewardTask(EarnEventReceiveEventPointRewardRequest request, Action<EarnEventReceiveEventPointRewardResponse> onSuccess, Action<ErrorType, int, EarnEventReceiveEventPointRewardResponse> onError)
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
