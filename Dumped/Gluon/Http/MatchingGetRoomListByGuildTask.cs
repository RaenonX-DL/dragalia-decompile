using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MatchingGetRoomListByGuildTask : IHttpTask
	{
		private byte[] postData;

		private Action<MatchingGetRoomListByGuildResponse> onSuccess;

		private Action<ErrorType, int, MatchingGetRoomListByGuildResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MatchingGetRoomListByGuildTask(MatchingGetRoomListByGuildRequest request, Action<MatchingGetRoomListByGuildResponse> onSuccess, Action<ErrorType, int, MatchingGetRoomListByGuildResponse> onError)
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
