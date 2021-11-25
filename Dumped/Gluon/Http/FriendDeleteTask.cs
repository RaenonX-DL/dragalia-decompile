using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendDeleteTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendDeleteResponse> onSuccess;

		private Action<ErrorType, int, FriendDeleteResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendDeleteTask(FriendDeleteRequest request, Action<FriendDeleteResponse> onSuccess, Action<ErrorType, int, FriendDeleteResponse> onError)
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
