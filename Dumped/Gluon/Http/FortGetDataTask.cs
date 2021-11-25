using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FortGetDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<FortGetDataResponse> onSuccess;

		private Action<ErrorType, int, FortGetDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FortGetDataTask(FortGetDataRequest request, Action<FortGetDataResponse> onSuccess, Action<ErrorType, int, FortGetDataResponse> onError)
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
