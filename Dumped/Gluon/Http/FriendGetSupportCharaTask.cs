using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendGetSupportCharaTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendGetSupportCharaResponse> onSuccess;

		private Action<ErrorType, int, FriendGetSupportCharaResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendGetSupportCharaTask(FriendGetSupportCharaRequest request, Action<FriendGetSupportCharaResponse> onSuccess, Action<ErrorType, int, FriendGetSupportCharaResponse> onError)
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
