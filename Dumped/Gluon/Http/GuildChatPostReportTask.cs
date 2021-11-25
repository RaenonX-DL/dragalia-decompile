using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildChatPostReportTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildChatPostReportResponse> onSuccess;

		private Action<ErrorType, int, GuildChatPostReportResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildChatPostReportTask(GuildChatPostReportRequest request, Action<GuildChatPostReportResponse> onSuccess, Action<ErrorType, int, GuildChatPostReportResponse> onError)
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
