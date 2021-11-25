using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugCharaUpdateUnlockEditSkillAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugCharaUpdateUnlockEditSkillAllResponse> onSuccess;

		private Action<ErrorType, int, DebugCharaUpdateUnlockEditSkillAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugCharaUpdateUnlockEditSkillAllTask(DebugCharaUpdateUnlockEditSkillAllRequest request, Action<DebugCharaUpdateUnlockEditSkillAllResponse> onSuccess, Action<ErrorType, int, DebugCharaUpdateUnlockEditSkillAllResponse> onError)
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
