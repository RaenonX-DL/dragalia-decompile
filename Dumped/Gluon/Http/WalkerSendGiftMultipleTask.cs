using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WalkerSendGiftMultipleTask : IHttpTask
	{
		private byte[] postData;

		private Action<WalkerSendGiftMultipleResponse> onSuccess;

		private Action<ErrorType, int, WalkerSendGiftMultipleResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WalkerSendGiftMultipleTask(WalkerSendGiftMultipleRequest request, Action<WalkerSendGiftMultipleResponse> onSuccess, Action<ErrorType, int, WalkerSendGiftMultipleResponse> onError)
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
