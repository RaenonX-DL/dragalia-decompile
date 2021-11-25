using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FortBuildStartTask : IHttpTask
	{
		private byte[] postData;

		private Action<FortBuildStartResponse> onSuccess;

		private Action<ErrorType, int, FortBuildStartResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FortBuildStartTask(FortBuildStartRequest request, Action<FortBuildStartResponse> onSuccess, Action<ErrorType, int, FortBuildStartResponse> onError)
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
