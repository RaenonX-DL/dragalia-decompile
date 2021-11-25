using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendFriendIndexTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendFriendIndexResponse> onSuccess;

		private Action<ErrorType, int, FriendFriendIndexResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendFriendIndexTask(FriendFriendIndexRequest request, Action<FriendFriendIndexResponse> onSuccess, Action<ErrorType, int, FriendFriendIndexResponse> onError)
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
