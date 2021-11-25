using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class TransitionTransitionByNAccountTask : IHttpTask
	{
		private byte[] postData;

		private Action<TransitionTransitionByNAccountResponse> onSuccess;

		private Action<ErrorType, int, TransitionTransitionByNAccountResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public TransitionTransitionByNAccountTask(TransitionTransitionByNAccountRequest request, Action<TransitionTransitionByNAccountResponse> onSuccess, Action<ErrorType, int, TransitionTransitionByNAccountResponse> onError)
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
