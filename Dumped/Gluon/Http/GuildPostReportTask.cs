using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildPostReportTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildPostReportResponse> onSuccess;

		private Action<ErrorType, int, GuildPostReportResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildPostReportTask(GuildPostReportRequest request, Action<GuildPostReportResponse> onSuccess, Action<ErrorType, int, GuildPostReportResponse> onError)
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
