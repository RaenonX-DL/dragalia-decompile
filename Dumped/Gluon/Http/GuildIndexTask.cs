using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildIndexTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildIndexResponse> onSuccess;

		private Action<ErrorType, int, GuildIndexResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildIndexTask(GuildIndexRequest request, Action<GuildIndexResponse> onSuccess, Action<ErrorType, int, GuildIndexResponse> onError)
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
