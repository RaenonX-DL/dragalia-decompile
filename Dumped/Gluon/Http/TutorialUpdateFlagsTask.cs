using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class TutorialUpdateFlagsTask : IHttpTask
	{
		private byte[] postData;

		private Action<TutorialUpdateFlagsResponse> onSuccess;

		private Action<ErrorType, int, TutorialUpdateFlagsResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public TutorialUpdateFlagsTask(TutorialUpdateFlagsRequest request, Action<TutorialUpdateFlagsResponse> onSuccess, Action<ErrorType, int, TutorialUpdateFlagsResponse> onError)
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
