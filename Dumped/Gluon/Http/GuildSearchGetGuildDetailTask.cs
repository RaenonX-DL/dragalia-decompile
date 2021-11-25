using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildSearchGetGuildDetailTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildSearchGetGuildDetailResponse> onSuccess;

		private Action<ErrorType, int, GuildSearchGetGuildDetailResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildSearchGetGuildDetailTask(GuildSearchGetGuildDetailRequest request, Action<GuildSearchGetGuildDetailResponse> onSuccess, Action<ErrorType, int, GuildSearchGetGuildDetailResponse> onError)
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
