using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FortLevelupCancelTask : IHttpTask
	{
		private byte[] postData;

		private Action<FortLevelupCancelResponse> onSuccess;

		private Action<ErrorType, int, FortLevelupCancelResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FortLevelupCancelTask(FortLevelupCancelRequest request, Action<FortLevelupCancelResponse> onSuccess, Action<ErrorType, int, FortLevelupCancelResponse> onError)
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
