using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FortLevelupEndTask : IHttpTask
	{
		private byte[] postData;

		private Action<FortLevelupEndResponse> onSuccess;

		private Action<ErrorType, int, FortLevelupEndResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FortLevelupEndTask(FortLevelupEndRequest request, Action<FortLevelupEndResponse> onSuccess, Action<ErrorType, int, FortLevelupEndResponse> onError)
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
