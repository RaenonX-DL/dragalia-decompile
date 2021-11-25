using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class InquiryReplyTask : IHttpTask
	{
		private byte[] postData;

		private Action<InquiryReplyResponse> onSuccess;

		private Action<ErrorType, int, InquiryReplyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public InquiryReplyTask(InquiryReplyRequest request, Action<InquiryReplyResponse> onSuccess, Action<ErrorType, int, InquiryReplyResponse> onError)
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
