using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class BuildEventGetEventDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<BuildEventGetEventDataResponse> onSuccess;

		private Action<ErrorType, int, BuildEventGetEventDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public BuildEventGetEventDataTask(BuildEventGetEventDataRequest request, Action<BuildEventGetEventDataResponse> onSuccess, Action<ErrorType, int, BuildEventGetEventDataResponse> onError)
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
