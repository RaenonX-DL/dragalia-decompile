using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class PresentReceiveTask : IHttpTask
	{
		private byte[] postData;

		private Action<PresentReceiveResponse> onSuccess;

		private Action<ErrorType, int, PresentReceiveResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public PresentReceiveTask(PresentReceiveRequest request, Action<PresentReceiveResponse> onSuccess, Action<ErrorType, int, PresentReceiveResponse> onError)
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
