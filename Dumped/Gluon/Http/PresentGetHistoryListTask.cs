using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class PresentGetHistoryListTask : IHttpTask
	{
		private byte[] postData;

		private Action<PresentGetHistoryListResponse> onSuccess;

		private Action<ErrorType, int, PresentGetHistoryListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public PresentGetHistoryListTask(PresentGetHistoryListRequest request, Action<PresentGetHistoryListResponse> onSuccess, Action<ErrorType, int, PresentGetHistoryListResponse> onError)
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
