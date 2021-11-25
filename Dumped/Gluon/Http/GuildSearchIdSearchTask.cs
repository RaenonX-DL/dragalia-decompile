using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildSearchIdSearchTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildSearchIdSearchResponse> onSuccess;

		private Action<ErrorType, int, GuildSearchIdSearchResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildSearchIdSearchTask(GuildSearchIdSearchRequest request, Action<GuildSearchIdSearchResponse> onSuccess, Action<ErrorType, int, GuildSearchIdSearchResponse> onError)
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
