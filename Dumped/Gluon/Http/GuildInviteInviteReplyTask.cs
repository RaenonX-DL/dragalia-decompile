using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildInviteInviteReplyTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildInviteInviteReplyResponse> onSuccess;

		private Action<ErrorType, int, GuildInviteInviteReplyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildInviteInviteReplyTask(GuildInviteInviteReplyRequest request, Action<GuildInviteInviteReplyResponse> onSuccess, Action<ErrorType, int, GuildInviteInviteReplyResponse> onError)
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
