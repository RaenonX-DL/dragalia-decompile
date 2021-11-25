using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ExHunterEventEntryTask : IHttpTask
	{
		private byte[] postData;

		private Action<ExHunterEventEntryResponse> onSuccess;

		private Action<ErrorType, int, ExHunterEventEntryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ExHunterEventEntryTask(ExHunterEventEntryRequest request, Action<ExHunterEventEntryResponse> onSuccess, Action<ErrorType, int, ExHunterEventEntryResponse> onError)
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
