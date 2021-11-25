using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendRequestCancelTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendRequestCancelResponse> onSuccess;

		private Action<ErrorType, int, FriendRequestCancelResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendRequestCancelTask(FriendRequestCancelRequest request, Action<FriendRequestCancelResponse> onSuccess, Action<ErrorType, int, FriendRequestCancelResponse> onError)
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
