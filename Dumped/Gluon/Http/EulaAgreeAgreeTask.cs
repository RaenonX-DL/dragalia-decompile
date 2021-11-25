using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EulaAgreeAgreeTask : IHttpTask
	{
		private byte[] postData;

		private Action<EulaAgreeAgreeResponse> onSuccess;

		private Action<ErrorType, int, EulaAgreeAgreeResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EulaAgreeAgreeTask(EulaAgreeAgreeRequest request, Action<EulaAgreeAgreeResponse> onSuccess, Action<ErrorType, int, EulaAgreeAgreeResponse> onError)
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
