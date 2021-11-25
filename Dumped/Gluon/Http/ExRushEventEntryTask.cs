using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ExRushEventEntryTask : IHttpTask
	{
		private byte[] postData;

		private Action<ExRushEventEntryResponse> onSuccess;

		private Action<ErrorType, int, ExRushEventEntryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ExRushEventEntryTask(ExRushEventEntryRequest request, Action<ExRushEventEntryResponse> onSuccess, Action<ErrorType, int, ExRushEventEntryResponse> onError)
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
