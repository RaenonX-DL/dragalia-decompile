using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EulaGetVersionTask : IHttpTask
	{
		private byte[] postData;

		private Action<EulaGetVersionResponse> onSuccess;

		private Action<ErrorType, int, EulaGetVersionResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EulaGetVersionTask(EulaGetVersionRequest request, Action<EulaGetVersionResponse> onSuccess, Action<ErrorType, int, EulaGetVersionResponse> onError)
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
