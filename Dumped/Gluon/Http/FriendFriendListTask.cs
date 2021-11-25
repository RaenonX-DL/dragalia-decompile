using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendFriendListTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendFriendListResponse> onSuccess;

		private Action<ErrorType, int, FriendFriendListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendFriendListTask(FriendFriendListRequest request, Action<FriendFriendListResponse> onSuccess, Action<ErrorType, int, FriendFriendListResponse> onError)
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
