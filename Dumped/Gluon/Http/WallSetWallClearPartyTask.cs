using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WallSetWallClearPartyTask : IHttpTask
	{
		private byte[] postData;

		private Action<WallSetWallClearPartyResponse> onSuccess;

		private Action<ErrorType, int, WallSetWallClearPartyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WallSetWallClearPartyTask(WallSetWallClearPartyRequest request, Action<WallSetWallClearPartyResponse> onSuccess, Action<ErrorType, int, WallSetWallClearPartyResponse> onError)
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
