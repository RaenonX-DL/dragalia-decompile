using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonRetryTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonRetryResponse> onSuccess;

		private Action<ErrorType, int, DungeonRetryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonRetryTask(DungeonRetryRequest request, Action<DungeonRetryResponse> onSuccess, Action<ErrorType, int, DungeonRetryResponse> onError)
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
