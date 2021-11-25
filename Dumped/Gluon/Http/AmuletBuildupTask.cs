using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AmuletBuildupTask : IHttpTask
	{
		private byte[] postData;

		private Action<AmuletBuildupResponse> onSuccess;

		private Action<ErrorType, int, AmuletBuildupResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AmuletBuildupTask(AmuletBuildupRequest request, Action<AmuletBuildupResponse> onSuccess, Action<ErrorType, int, AmuletBuildupResponse> onError)
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
