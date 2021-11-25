using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class UpdateNamechangeTask : IHttpTask
	{
		private byte[] postData;

		private Action<UpdateNamechangeResponse> onSuccess;

		private Action<ErrorType, int, UpdateNamechangeResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public UpdateNamechangeTask(UpdateNamechangeRequest request, Action<UpdateNamechangeResponse> onSuccess, Action<ErrorType, int, UpdateNamechangeResponse> onError)
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
