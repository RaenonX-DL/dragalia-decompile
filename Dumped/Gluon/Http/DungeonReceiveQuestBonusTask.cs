using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonReceiveQuestBonusTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonReceiveQuestBonusResponse> onSuccess;

		private Action<ErrorType, int, DungeonReceiveQuestBonusResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonReceiveQuestBonusTask(DungeonReceiveQuestBonusRequest request, Action<DungeonReceiveQuestBonusResponse> onSuccess, Action<ErrorType, int, DungeonReceiveQuestBonusResponse> onError)
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
