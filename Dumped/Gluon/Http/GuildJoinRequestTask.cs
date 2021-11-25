using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildJoinRequestTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildJoinRequestResponse> onSuccess;

		private Action<ErrorType, int, GuildJoinRequestResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildJoinRequestTask(GuildJoinRequestRequest request, Action<GuildJoinRequestResponse> onSuccess, Action<ErrorType, int, GuildJoinRequestResponse> onError)
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
