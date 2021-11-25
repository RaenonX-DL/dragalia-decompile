using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class BattleRoyalRecordRoyalRecordMultiTask : IHttpTask
	{
		private byte[] postData;

		private Action<BattleRoyalRecordRoyalRecordMultiResponse> onSuccess;

		private Action<ErrorType, int, BattleRoyalRecordRoyalRecordMultiResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public BattleRoyalRecordRoyalRecordMultiTask(BattleRoyalRecordRoyalRecordMultiRequest request, Action<BattleRoyalRecordRoyalRecordMultiResponse> onSuccess, Action<ErrorType, int, BattleRoyalRecordRoyalRecordMultiResponse> onError)
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
