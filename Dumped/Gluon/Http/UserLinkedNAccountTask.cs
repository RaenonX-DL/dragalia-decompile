using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class UserLinkedNAccountTask : IHttpTask
	{
		private byte[] postData;

		private Action<UserLinkedNAccountResponse> onSuccess;

		private Action<ErrorType, int, UserLinkedNAccountResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public UserLinkedNAccountTask(UserLinkedNAccountRequest request, Action<UserLinkedNAccountResponse> onSuccess, Action<ErrorType, int, UserLinkedNAccountResponse> onError)
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
