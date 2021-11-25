using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildJoinReplyTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildJoinReplyResponse> onSuccess;

		private Action<ErrorType, int, GuildJoinReplyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildJoinReplyTask(GuildJoinReplyRequest request, Action<GuildJoinReplyResponse> onSuccess, Action<ErrorType, int, GuildJoinReplyResponse> onError)
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
