using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendRequestListTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendRequestListResponse> onSuccess;

		private Action<ErrorType, int, FriendRequestListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendRequestListTask(FriendRequestListRequest request, Action<FriendRequestListResponse> onSuccess, Action<ErrorType, int, FriendRequestListResponse> onError)
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
