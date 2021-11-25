using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class InquiryDetailTask : IHttpTask
	{
		private byte[] postData;

		private Action<InquiryDetailResponse> onSuccess;

		private Action<ErrorType, int, InquiryDetailResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public InquiryDetailTask(InquiryDetailRequest request, Action<InquiryDetailResponse> onSuccess, Action<ErrorType, int, InquiryDetailResponse> onError)
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
