using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class LotteryLotteryExecTask : IHttpTask
	{
		private byte[] postData;

		private Action<LotteryLotteryExecResponse> onSuccess;

		private Action<ErrorType, int, LotteryLotteryExecResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public LotteryLotteryExecTask(LotteryLotteryExecRequest request, Action<LotteryLotteryExecResponse> onSuccess, Action<ErrorType, int, LotteryLotteryExecResponse> onError)
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
