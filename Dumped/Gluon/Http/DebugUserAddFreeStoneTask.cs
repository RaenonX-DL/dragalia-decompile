using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserAddFreeStoneTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserAddFreeStoneResponse> onSuccess;

		private Action<ErrorType, int, DebugUserAddFreeStoneResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserAddFreeStoneTask(DebugUserAddFreeStoneRequest request, Action<DebugUserAddFreeStoneResponse> onSuccess, Action<ErrorType, int, DebugUserAddFreeStoneResponse> onError)
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
