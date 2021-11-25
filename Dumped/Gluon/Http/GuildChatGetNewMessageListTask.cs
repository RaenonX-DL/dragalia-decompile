using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildChatGetNewMessageListTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildChatGetNewMessageListResponse> onSuccess;

		private Action<ErrorType, int, GuildChatGetNewMessageListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildChatGetNewMessageListTask(GuildChatGetNewMessageListRequest request, Action<GuildChatGetNewMessageListResponse> onSuccess, Action<ErrorType, int, GuildChatGetNewMessageListResponse> onError)
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
