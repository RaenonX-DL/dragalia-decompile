using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FriendApplyListTask : IHttpTask
	{
		private byte[] postData;

		private Action<FriendApplyListResponse> onSuccess;

		private Action<ErrorType, int, FriendApplyListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FriendApplyListTask(FriendApplyListRequest request, Action<FriendApplyListResponse> onSuccess, Action<ErrorType, int, FriendApplyListResponse> onError)
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
