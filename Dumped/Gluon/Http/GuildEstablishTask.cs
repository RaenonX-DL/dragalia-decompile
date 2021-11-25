using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildEstablishTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildEstablishResponse> onSuccess;

		private Action<ErrorType, int, GuildEstablishResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildEstablishTask(GuildEstablishRequest request, Action<GuildEstablishResponse> onSuccess, Action<ErrorType, int, GuildEstablishResponse> onError)
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
