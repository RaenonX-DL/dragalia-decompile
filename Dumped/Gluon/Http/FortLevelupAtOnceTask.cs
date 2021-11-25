using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FortLevelupAtOnceTask : IHttpTask
	{
		private byte[] postData;

		private Action<FortLevelupAtOnceResponse> onSuccess;

		private Action<ErrorType, int, FortLevelupAtOnceResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FortLevelupAtOnceTask(FortLevelupAtOnceRequest request, Action<FortLevelupAtOnceResponse> onSuccess, Action<ErrorType, int, FortLevelupAtOnceResponse> onError)
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
