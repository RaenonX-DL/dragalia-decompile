using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeDungeonUserHaltTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeDungeonUserHaltResponse> onSuccess;

		private Action<ErrorType, int, DmodeDungeonUserHaltResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeDungeonUserHaltTask(DmodeDungeonUserHaltRequest request, Action<DmodeDungeonUserHaltResponse> onSuccess, Action<ErrorType, int, DmodeDungeonUserHaltResponse> onError)
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
