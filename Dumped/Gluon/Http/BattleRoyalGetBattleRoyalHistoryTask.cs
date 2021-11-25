using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class BattleRoyalGetBattleRoyalHistoryTask : IHttpTask
	{
		private byte[] postData;

		private Action<BattleRoyalGetBattleRoyalHistoryResponse> onSuccess;

		private Action<ErrorType, int, BattleRoyalGetBattleRoyalHistoryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public BattleRoyalGetBattleRoyalHistoryTask(BattleRoyalGetBattleRoyalHistoryRequest request, Action<BattleRoyalGetBattleRoyalHistoryResponse> onSuccess, Action<ErrorType, int, BattleRoyalGetBattleRoyalHistoryResponse> onError)
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
