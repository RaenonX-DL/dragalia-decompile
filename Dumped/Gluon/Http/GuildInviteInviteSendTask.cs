using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildInviteInviteSendTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildInviteInviteSendResponse> onSuccess;

		private Action<ErrorType, int, GuildInviteInviteSendResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildInviteInviteSendTask(GuildInviteInviteSendRequest request, Action<GuildInviteInviteSendResponse> onSuccess, Action<ErrorType, int, GuildInviteInviteSendResponse> onError)
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
