using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ExchangeSelectUnitTask : IHttpTask
	{
		private byte[] postData;

		private Action<ExchangeSelectUnitResponse> onSuccess;

		private Action<ErrorType, int, ExchangeSelectUnitResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ExchangeSelectUnitTask(ExchangeSelectUnitRequest request, Action<ExchangeSelectUnitResponse> onSuccess, Action<ErrorType, int, ExchangeSelectUnitResponse> onError)
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
