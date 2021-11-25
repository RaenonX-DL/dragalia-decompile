using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EventDamageReceiveDamageRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<EventDamageReceiveDamageRewardResponse> onSuccess;

		private Action<ErrorType, int, EventDamageReceiveDamageRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EventDamageReceiveDamageRewardTask(EventDamageReceiveDamageRewardRequest request, Action<EventDamageReceiveDamageRewardResponse> onSuccess, Action<ErrorType, int, EventDamageReceiveDamageRewardResponse> onError)
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
