using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeDungeonFloorTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeDungeonFloorResponse> onSuccess;

		private Action<ErrorType, int, DmodeDungeonFloorResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeDungeonFloorTask(DmodeDungeonFloorRequest request, Action<DmodeDungeonFloorResponse> onSuccess, Action<ErrorType, int, DmodeDungeonFloorResponse> onError)
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
