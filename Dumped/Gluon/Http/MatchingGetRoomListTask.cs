using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MatchingGetRoomListTask : IHttpTask
	{
		private byte[] postData;

		private Action<MatchingGetRoomListResponse> onSuccess;

		private Action<ErrorType, int, MatchingGetRoomListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MatchingGetRoomListTask(MatchingGetRoomListRequest request, Action<MatchingGetRoomListResponse> onSuccess, Action<ErrorType, int, MatchingGetRoomListResponse> onError)
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
