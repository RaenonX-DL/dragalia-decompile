using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendRequestTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendRequestResponse> onSuccess;

		private Action<ErrorType, int, FriendRequestResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendRequestTask(FriendRequestRequest request, Action<FriendRequestResponse> onSuccess, Action<ErrorType, int, FriendRequestResponse> onError)
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
