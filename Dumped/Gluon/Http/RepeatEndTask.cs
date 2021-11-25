using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class RepeatEndTask : IHttpTask
	{
		private byte[] postData;

		private Action<RepeatEndResponse> onSuccess;

		private Action<ErrorType, int, RepeatEndResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public RepeatEndTask(RepeatEndRequest request, Action<RepeatEndResponse> onSuccess, Action<ErrorType, int, RepeatEndResponse> onError)
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
