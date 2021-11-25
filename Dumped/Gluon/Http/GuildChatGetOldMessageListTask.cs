using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildChatGetOldMessageListTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildChatGetOldMessageListResponse> onSuccess;

		private Action<ErrorType, int, GuildChatGetOldMessageListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildChatGetOldMessageListTask(GuildChatGetOldMessageListRequest request, Action<GuildChatGetOldMessageListResponse> onSuccess, Action<ErrorType, int, GuildChatGetOldMessageListResponse> onError)
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
