using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildInviteGetGuildInviteReceiveDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildInviteGetGuildInviteReceiveDataResponse> onSuccess;

		private Action<ErrorType, int, GuildInviteGetGuildInviteReceiveDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildInviteGetGuildInviteReceiveDataTask(GuildInviteGetGuildInviteReceiveDataRequest request, Action<GuildInviteGetGuildInviteReceiveDataResponse> onSuccess, Action<ErrorType, int, GuildInviteGetGuildInviteReceiveDataResponse> onError)
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
