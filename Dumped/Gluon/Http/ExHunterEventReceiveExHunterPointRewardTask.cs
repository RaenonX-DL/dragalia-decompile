using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ExHunterEventReceiveExHunterPointRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<ExHunterEventReceiveExHunterPointRewardResponse> onSuccess;

		private Action<ErrorType, int, ExHunterEventReceiveExHunterPointRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ExHunterEventReceiveExHunterPointRewardTask(ExHunterEventReceiveExHunterPointRewardRequest request, Action<ExHunterEventReceiveExHunterPointRewardResponse> onSuccess, Action<ErrorType, int, ExHunterEventReceiveExHunterPointRewardResponse> onError)
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
