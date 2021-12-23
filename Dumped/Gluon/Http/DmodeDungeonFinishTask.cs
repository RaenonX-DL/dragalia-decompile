using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeDungeonFinishTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeDungeonFinishResponse> onSuccess;

		private Action<ErrorType, int, DmodeDungeonFinishResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeDungeonFinishTask(DmodeDungeonFinishRequest request, Action<DmodeDungeonFinishResponse> onSuccess, Action<ErrorType, int, DmodeDungeonFinishResponse> onError)
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
