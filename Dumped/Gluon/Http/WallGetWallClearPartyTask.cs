using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WallGetWallClearPartyTask : IHttpTask
	{
		private byte[] postData;

		private Action<WallGetWallClearPartyResponse> onSuccess;

		private Action<ErrorType, int, WallGetWallClearPartyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WallGetWallClearPartyTask(WallGetWallClearPartyRequest request, Action<WallGetWallClearPartyResponse> onSuccess, Action<ErrorType, int, WallGetWallClearPartyResponse> onError)
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
