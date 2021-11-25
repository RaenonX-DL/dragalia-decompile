using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildGetGuildApplyDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildGetGuildApplyDataResponse> onSuccess;

		private Action<ErrorType, int, GuildGetGuildApplyDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildGetGuildApplyDataTask(GuildGetGuildApplyDataRequest request, Action<GuildGetGuildApplyDataResponse> onSuccess, Action<ErrorType, int, GuildGetGuildApplyDataResponse> onError)
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
