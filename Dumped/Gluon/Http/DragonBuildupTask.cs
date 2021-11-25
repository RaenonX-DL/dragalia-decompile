using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DragonBuildupTask : IHttpTask
	{
		private byte[] postData;

		private Action<DragonBuildupResponse> onSuccess;

		private Action<ErrorType, int, DragonBuildupResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DragonBuildupTask(DragonBuildupRequest request, Action<DragonBuildupResponse> onSuccess, Action<ErrorType, int, DragonBuildupResponse> onError)
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
