using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildJoinRequestCancelTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildJoinRequestCancelResponse> onSuccess;

		private Action<ErrorType, int, GuildJoinRequestCancelResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildJoinRequestCancelTask(GuildJoinRequestCancelRequest request, Action<GuildJoinRequestCancelResponse> onSuccess, Action<ErrorType, int, GuildJoinRequestCancelResponse> onError)
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
