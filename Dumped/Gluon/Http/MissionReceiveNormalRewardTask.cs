using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionReceiveNormalRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionReceiveNormalRewardResponse> onSuccess;

		private Action<ErrorType, int, MissionReceiveNormalRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionReceiveNormalRewardTask(MissionReceiveNormalRewardRequest request, Action<MissionReceiveNormalRewardResponse> onSuccess, Action<ErrorType, int, MissionReceiveNormalRewardResponse> onError)
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
