using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonFailTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonFailResponse> onSuccess;

		private Action<ErrorType, int, DungeonFailResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonFailTask(DungeonFailRequest request, Action<DungeonFailResponse> onSuccess, Action<ErrorType, int, DungeonFailResponse> onError)
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
