using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class SummonGetOddsDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<SummonGetOddsDataResponse> onSuccess;

		private Action<ErrorType, int, SummonGetOddsDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public SummonGetOddsDataTask(SummonGetOddsDataRequest request, Action<SummonGetOddsDataResponse> onSuccess, Action<ErrorType, int, SummonGetOddsDataResponse> onError)
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
