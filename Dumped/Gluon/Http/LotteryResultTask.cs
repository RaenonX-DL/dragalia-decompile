using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class LotteryResultTask : IHttpTask
	{
		private byte[] postData;

		private Action<LotteryResultResponse> onSuccess;

		private Action<ErrorType, int, LotteryResultResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public LotteryResultTask(LotteryResultRequest request, Action<LotteryResultResponse> onSuccess, Action<ErrorType, int, LotteryResultResponse> onError)
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
