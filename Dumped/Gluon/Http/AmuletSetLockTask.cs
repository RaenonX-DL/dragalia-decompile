using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AmuletSetLockTask : IHttpTask
	{
		private byte[] postData;

		private Action<AmuletSetLockResponse> onSuccess;

		private Action<ErrorType, int, AmuletSetLockResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AmuletSetLockTask(AmuletSetLockRequest request, Action<AmuletSetLockResponse> onSuccess, Action<ErrorType, int, AmuletSetLockResponse> onError)
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
