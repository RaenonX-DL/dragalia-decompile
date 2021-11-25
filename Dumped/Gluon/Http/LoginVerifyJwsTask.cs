using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class LoginVerifyJwsTask : IHttpTask
	{
		private byte[] postData;

		private Action<LoginVerifyJwsResponse> onSuccess;

		private Action<ErrorType, int, LoginVerifyJwsResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public LoginVerifyJwsTask(LoginVerifyJwsRequest request, Action<LoginVerifyJwsResponse> onSuccess, Action<ErrorType, int, LoginVerifyJwsResponse> onError)
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
