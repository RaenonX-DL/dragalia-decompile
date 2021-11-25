using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AbilityCrestTradeGetListTask : IHttpTask
	{
		private byte[] postData;

		private Action<AbilityCrestTradeGetListResponse> onSuccess;

		private Action<ErrorType, int, AbilityCrestTradeGetListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AbilityCrestTradeGetListTask(AbilityCrestTradeGetListRequest request, Action<AbilityCrestTradeGetListResponse> onSuccess, Action<ErrorType, int, AbilityCrestTradeGetListResponse> onError)
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
