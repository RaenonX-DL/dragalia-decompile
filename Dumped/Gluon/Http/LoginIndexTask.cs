using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class LoginIndexTask : IHttpTask
	{
		private byte[] postData;

		private Action<LoginIndexResponse> onSuccess;

		private Action<ErrorType, int, LoginIndexResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public LoginIndexTask(LoginIndexRequest request, Action<LoginIndexResponse> onSuccess, Action<ErrorType, int, LoginIndexResponse> onError)
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
