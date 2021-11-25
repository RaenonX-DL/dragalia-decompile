using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonGetAreaOddsTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonGetAreaOddsResponse> onSuccess;

		private Action<ErrorType, int, DungeonGetAreaOddsResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonGetAreaOddsTask(DungeonGetAreaOddsRequest request, Action<DungeonGetAreaOddsResponse> onSuccess, Action<ErrorType, int, DungeonGetAreaOddsResponse> onError)
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
