using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ExchangeGetUnitListTask : IHttpTask
	{
		private byte[] postData;

		private Action<ExchangeGetUnitListResponse> onSuccess;

		private Action<ErrorType, int, ExchangeGetUnitListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ExchangeGetUnitListTask(ExchangeGetUnitListRequest request, Action<ExchangeGetUnitListResponse> onSuccess, Action<ErrorType, int, ExchangeGetUnitListResponse> onError)
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
