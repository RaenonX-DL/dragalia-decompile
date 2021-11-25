using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MatchingGetRoomListByQuestIdTask : IHttpTask
	{
		private byte[] postData;

		private Action<MatchingGetRoomListByQuestIdResponse> onSuccess;

		private Action<ErrorType, int, MatchingGetRoomListByQuestIdResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MatchingGetRoomListByQuestIdTask(MatchingGetRoomListByQuestIdRequest request, Action<MatchingGetRoomListByQuestIdResponse> onSuccess, Action<ErrorType, int, MatchingGetRoomListByQuestIdResponse> onError)
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
