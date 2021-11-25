using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class TimeAttackRankingGetDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<TimeAttackRankingGetDataResponse> onSuccess;

		private Action<ErrorType, int, TimeAttackRankingGetDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public TimeAttackRankingGetDataTask(TimeAttackRankingGetDataRequest request, Action<TimeAttackRankingGetDataResponse> onSuccess, Action<ErrorType, int, TimeAttackRankingGetDataResponse> onError)
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
