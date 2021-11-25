using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildDropMemberTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildDropMemberResponse> onSuccess;

		private Action<ErrorType, int, GuildDropMemberResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildDropMemberTask(GuildDropMemberRequest request, Action<GuildDropMemberResponse> onSuccess, Action<ErrorType, int, GuildDropMemberResponse> onError)
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
