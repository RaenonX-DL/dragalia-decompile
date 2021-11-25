using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WallGetMonthlyRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<WallGetMonthlyRewardResponse> onSuccess;

		private Action<ErrorType, int, WallGetMonthlyRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WallGetMonthlyRewardTask(WallGetMonthlyRewardRequest request, Action<WallGetMonthlyRewardResponse> onSuccess, Action<ErrorType, int, WallGetMonthlyRewardResponse> onError)
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
