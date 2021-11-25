using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugDebugTimeResetUserLoginLotteryTimeTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugDebugTimeResetUserLoginLotteryTimeResponse> onSuccess;

		private Action<ErrorType, int, DebugDebugTimeResetUserLoginLotteryTimeResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugDebugTimeResetUserLoginLotteryTimeTask(DebugDebugTimeResetUserLoginLotteryTimeRequest request, Action<DebugDebugTimeResetUserLoginLotteryTimeResponse> onSuccess, Action<ErrorType, int, DebugDebugTimeResetUserLoginLotteryTimeResponse> onError)
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
