using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class InquiryTopTask : IHttpTask
	{
		private byte[] postData;

		private Action<InquiryTopResponse> onSuccess;

		private Action<ErrorType, int, InquiryTopResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public InquiryTopTask(InquiryTopRequest request, Action<InquiryTopResponse> onSuccess, Action<ErrorType, int, InquiryTopResponse> onError)
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
