using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class SummonExcludeGetOddsDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<SummonExcludeGetOddsDataResponse> onSuccess;

		private Action<ErrorType, int, SummonExcludeGetOddsDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public SummonExcludeGetOddsDataTask(SummonExcludeGetOddsDataRequest request, Action<SummonExcludeGetOddsDataResponse> onSuccess, Action<ErrorType, int, SummonExcludeGetOddsDataResponse> onError)
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
