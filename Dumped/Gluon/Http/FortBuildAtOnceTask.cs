using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FortBuildAtOnceTask : IHttpTask
	{
		private byte[] postData;

		private Action<FortBuildAtOnceResponse> onSuccess;

		private Action<ErrorType, int, FortBuildAtOnceResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FortBuildAtOnceTask(FortBuildAtOnceRequest request, Action<FortBuildAtOnceResponse> onSuccess, Action<ErrorType, int, FortBuildAtOnceResponse> onError)
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
