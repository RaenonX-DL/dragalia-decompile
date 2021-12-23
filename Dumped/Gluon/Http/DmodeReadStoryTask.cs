using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeReadStoryTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeReadStoryResponse> onSuccess;

		private Action<ErrorType, int, DmodeReadStoryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeReadStoryTask(DmodeReadStoryRequest request, Action<DmodeReadStoryResponse> onSuccess, Action<ErrorType, int, DmodeReadStoryResponse> onError)
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
