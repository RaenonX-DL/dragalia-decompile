using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionReceiveDrillRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionReceiveDrillRewardResponse> onSuccess;

		private Action<ErrorType, int, MissionReceiveDrillRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionReceiveDrillRewardTask(MissionReceiveDrillRewardRequest request, Action<MissionReceiveDrillRewardResponse> onSuccess, Action<ErrorType, int, MissionReceiveDrillRewardResponse> onError)
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
