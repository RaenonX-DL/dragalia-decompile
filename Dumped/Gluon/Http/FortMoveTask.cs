using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FortMoveTask : IHttpTask
	{
		private byte[] postData;

		private Action<FortMoveResponse> onSuccess;

		private Action<ErrorType, int, FortMoveResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FortMoveTask(FortMoveRequest request, Action<FortMoveResponse> onSuccess, Action<ErrorType, int, FortMoveResponse> onError)
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
