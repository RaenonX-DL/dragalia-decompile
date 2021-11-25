using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendSetSupportCharaTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendSetSupportCharaResponse> onSuccess;

		private Action<ErrorType, int, FriendSetSupportCharaResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendSetSupportCharaTask(FriendSetSupportCharaRequest request, Action<FriendSetSupportCharaResponse> onSuccess, Action<ErrorType, int, FriendSetSupportCharaResponse> onError)
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
