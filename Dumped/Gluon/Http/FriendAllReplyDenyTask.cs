using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendAllReplyDenyTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendAllReplyDenyResponse> onSuccess;

		private Action<ErrorType, int, FriendAllReplyDenyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendAllReplyDenyTask(FriendAllReplyDenyRequest request, Action<FriendAllReplyDenyResponse> onSuccess, Action<ErrorType, int, FriendAllReplyDenyResponse> onError)
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
