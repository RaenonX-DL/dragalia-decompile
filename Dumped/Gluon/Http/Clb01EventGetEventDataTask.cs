using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class Clb01EventGetEventDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<Clb01EventGetEventDataResponse> onSuccess;

		private Action<ErrorType, int, Clb01EventGetEventDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public Clb01EventGetEventDataTask(Clb01EventGetEventDataRequest request, Action<Clb01EventGetEventDataResponse> onSuccess, Action<ErrorType, int, Clb01EventGetEventDataResponse> onError)
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
