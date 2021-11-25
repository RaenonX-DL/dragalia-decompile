using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class FortGetMultiIncomeTask : IHttpTask
	{
		private byte[] postData;

		private Action<FortGetMultiIncomeResponse> onSuccess;

		private Action<ErrorType, int, FortGetMultiIncomeResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public FortGetMultiIncomeTask(FortGetMultiIncomeRequest request, Action<FortGetMultiIncomeResponse> onSuccess, Action<ErrorType, int, FortGetMultiIncomeResponse> onError)
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
