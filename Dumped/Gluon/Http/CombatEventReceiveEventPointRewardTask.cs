using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CombatEventReceiveEventPointRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<CombatEventReceiveEventPointRewardResponse> onSuccess;

		private Action<ErrorType, int, CombatEventReceiveEventPointRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CombatEventReceiveEventPointRewardTask(CombatEventReceiveEventPointRewardRequest request, Action<CombatEventReceiveEventPointRewardResponse> onSuccess, Action<ErrorType, int, CombatEventReceiveEventPointRewardResponse> onError)
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
