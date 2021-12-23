using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeExpeditionForceFinishTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeExpeditionForceFinishResponse> onSuccess;

		private Action<ErrorType, int, DmodeExpeditionForceFinishResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeExpeditionForceFinishTask(DmodeExpeditionForceFinishRequest request, Action<DmodeExpeditionForceFinishResponse> onSuccess, Action<ErrorType, int, DmodeExpeditionForceFinishResponse> onError)
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
