using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AbilityCrestTradeTradeTask : IHttpTask
	{
		private byte[] postData;

		private Action<AbilityCrestTradeTradeResponse> onSuccess;

		private Action<ErrorType, int, AbilityCrestTradeTradeResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AbilityCrestTradeTradeTask(AbilityCrestTradeTradeRequest request, Action<AbilityCrestTradeTradeResponse> onSuccess, Action<ErrorType, int, AbilityCrestTradeTradeResponse> onError)
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
