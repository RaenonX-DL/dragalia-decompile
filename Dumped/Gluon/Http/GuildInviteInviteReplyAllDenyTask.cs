using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildInviteInviteReplyAllDenyTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildInviteInviteReplyAllDenyResponse> onSuccess;

		private Action<ErrorType, int, GuildInviteInviteReplyAllDenyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildInviteInviteReplyAllDenyTask(GuildInviteInviteReplyAllDenyRequest request, Action<GuildInviteInviteReplyAllDenyResponse> onSuccess, Action<ErrorType, int, GuildInviteInviteReplyAllDenyResponse> onError)
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
