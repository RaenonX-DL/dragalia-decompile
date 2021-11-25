using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class BattleRoyalFailTask : IHttpTask
	{
		private byte[] postData;

		private Action<BattleRoyalFailResponse> onSuccess;

		private Action<ErrorType, int, BattleRoyalFailResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public BattleRoyalFailTask(BattleRoyalFailRequest request, Action<BattleRoyalFailResponse> onSuccess, Action<ErrorType, int, BattleRoyalFailResponse> onError)
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
