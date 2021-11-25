using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FortBuildEndTask : IHttpTask
	{
		private byte[] postData;

		private Action<FortBuildEndResponse> onSuccess;

		private Action<ErrorType, int, FortBuildEndResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FortBuildEndTask(FortBuildEndRequest request, Action<FortBuildEndResponse> onSuccess, Action<ErrorType, int, FortBuildEndResponse> onError)
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
