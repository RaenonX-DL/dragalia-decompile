using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeExpeditionStartTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeExpeditionStartResponse> onSuccess;

		private Action<ErrorType, int, DmodeExpeditionStartResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeExpeditionStartTask(DmodeExpeditionStartRequest request, Action<DmodeExpeditionStartResponse> onSuccess, Action<ErrorType, int, DmodeExpeditionStartResponse> onError)
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
