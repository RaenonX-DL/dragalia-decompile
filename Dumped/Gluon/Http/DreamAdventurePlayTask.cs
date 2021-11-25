using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DreamAdventurePlayTask : IHttpTask
	{
		private byte[] postData;

		private Action<DreamAdventurePlayResponse> onSuccess;

		private Action<ErrorType, int, DreamAdventurePlayResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DreamAdventurePlayTask(DreamAdventurePlayRequest request, Action<DreamAdventurePlayResponse> onSuccess, Action<ErrorType, int, DreamAdventurePlayResponse> onError)
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
