using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class InquirySendTask : IHttpTask
	{
		private byte[] postData;

		private Action<InquirySendResponse> onSuccess;

		private Action<ErrorType, int, InquirySendResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public InquirySendTask(InquirySendRequest request, Action<InquirySendResponse> onSuccess, Action<ErrorType, int, InquirySendResponse> onError)
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
