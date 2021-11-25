using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionReceiveSpecialRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionReceiveSpecialRewardResponse> onSuccess;

		private Action<ErrorType, int, MissionReceiveSpecialRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionReceiveSpecialRewardTask(MissionReceiveSpecialRewardRequest request, Action<MissionReceiveSpecialRewardResponse> onSuccess, Action<ErrorType, int, MissionReceiveSpecialRewardResponse> onError)
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
