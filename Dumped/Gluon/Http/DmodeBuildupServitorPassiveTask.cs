using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeBuildupServitorPassiveTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeBuildupServitorPassiveResponse> onSuccess;

		private Action<ErrorType, int, DmodeBuildupServitorPassiveResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeBuildupServitorPassiveTask(DmodeBuildupServitorPassiveRequest request, Action<DmodeBuildupServitorPassiveResponse> onSuccess, Action<ErrorType, int, DmodeBuildupServitorPassiveResponse> onError)
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
