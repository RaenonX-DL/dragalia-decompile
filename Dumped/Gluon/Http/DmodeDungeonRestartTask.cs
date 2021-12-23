using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeDungeonRestartTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeDungeonRestartResponse> onSuccess;

		private Action<ErrorType, int, DmodeDungeonRestartResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeDungeonRestartTask(DmodeDungeonRestartRequest request, Action<DmodeDungeonRestartResponse> onSuccess, Action<ErrorType, int, DmodeDungeonRestartResponse> onError)
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
