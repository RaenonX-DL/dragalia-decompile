using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class LotteryGetOddsDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<LotteryGetOddsDataResponse> onSuccess;

		private Action<ErrorType, int, LotteryGetOddsDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public LotteryGetOddsDataTask(LotteryGetOddsDataRequest request, Action<LotteryGetOddsDataResponse> onSuccess, Action<ErrorType, int, LotteryGetOddsDataResponse> onError)
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
