using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildJoinReplyAllDenyTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildJoinReplyAllDenyResponse> onSuccess;

		private Action<ErrorType, int, GuildJoinReplyAllDenyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildJoinReplyAllDenyTask(GuildJoinReplyAllDenyRequest request, Action<GuildJoinReplyAllDenyResponse> onSuccess, Action<ErrorType, int, GuildJoinReplyAllDenyResponse> onError)
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
