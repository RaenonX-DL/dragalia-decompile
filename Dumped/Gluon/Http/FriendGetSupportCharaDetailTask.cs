using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendGetSupportCharaDetailTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendGetSupportCharaDetailResponse> onSuccess;

		private Action<ErrorType, int, FriendGetSupportCharaDetailResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendGetSupportCharaDetailTask(FriendGetSupportCharaDetailRequest request, Action<FriendGetSupportCharaDetailResponse> onSuccess, Action<ErrorType, int, FriendGetSupportCharaDetailResponse> onError)
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
