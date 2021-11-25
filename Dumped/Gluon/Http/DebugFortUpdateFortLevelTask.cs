using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugFortUpdateFortLevelTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugFortUpdateFortLevelResponse> onSuccess;

		private Action<ErrorType, int, DebugFortUpdateFortLevelResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugFortUpdateFortLevelTask(DebugFortUpdateFortLevelRequest request, Action<DebugFortUpdateFortLevelResponse> onSuccess, Action<ErrorType, int, DebugFortUpdateFortLevelResponse> onError)
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
