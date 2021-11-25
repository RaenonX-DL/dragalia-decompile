using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendAutoSearchTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendAutoSearchResponse> onSuccess;

		private Action<ErrorType, int, FriendAutoSearchResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendAutoSearchTask(FriendAutoSearchRequest request, Action<FriendAutoSearchResponse> onSuccess, Action<ErrorType, int, FriendAutoSearchResponse> onError)
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
