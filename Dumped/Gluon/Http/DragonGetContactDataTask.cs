using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DragonGetContactDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<DragonGetContactDataResponse> onSuccess;

		private Action<ErrorType, int, DragonGetContactDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DragonGetContactDataTask(DragonGetContactDataRequest request, Action<DragonGetContactDataResponse> onSuccess, Action<ErrorType, int, DragonGetContactDataResponse> onError)
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
