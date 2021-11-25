using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class UserGetNAccountInfoTask : IHttpTask
	{
		private byte[] postData;

		private Action<UserGetNAccountInfoResponse> onSuccess;

		private Action<ErrorType, int, UserGetNAccountInfoResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public UserGetNAccountInfoTask(UserGetNAccountInfoRequest request, Action<UserGetNAccountInfoResponse> onSuccess, Action<ErrorType, int, UserGetNAccountInfoResponse> onError)
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
