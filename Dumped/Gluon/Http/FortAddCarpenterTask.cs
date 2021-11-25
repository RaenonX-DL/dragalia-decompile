using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FortAddCarpenterTask : IHttpTask
	{
		private byte[] postData;

		private Action<FortAddCarpenterResponse> onSuccess;

		private Action<ErrorType, int, FortAddCarpenterResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FortAddCarpenterTask(FortAddCarpenterRequest request, Action<FortAddCarpenterResponse> onSuccess, Action<ErrorType, int, FortAddCarpenterResponse> onError)
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
