using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildSearchAutoSearchTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildSearchAutoSearchResponse> onSuccess;

		private Action<ErrorType, int, GuildSearchAutoSearchResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildSearchAutoSearchTask(GuildSearchAutoSearchRequest request, Action<GuildSearchAutoSearchResponse> onSuccess, Action<ErrorType, int, GuildSearchAutoSearchResponse> onError)
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
