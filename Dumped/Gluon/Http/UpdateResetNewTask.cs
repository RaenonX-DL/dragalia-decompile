using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class UpdateResetNewTask : IHttpTask
	{
		private byte[] postData;

		private Action<UpdateResetNewResponse> onSuccess;

		private Action<ErrorType, int, UpdateResetNewResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public UpdateResetNewTask(UpdateResetNewRequest request, Action<UpdateResetNewResponse> onSuccess, Action<ErrorType, int, UpdateResetNewResponse> onError)
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
