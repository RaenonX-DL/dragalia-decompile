using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CharaUnlockEditSkillTask : IHttpTask
	{
		private byte[] postData;

		private Action<CharaUnlockEditSkillResponse> onSuccess;

		private Action<ErrorType, int, CharaUnlockEditSkillResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CharaUnlockEditSkillTask(CharaUnlockEditSkillRequest request, Action<CharaUnlockEditSkillResponse> onSuccess, Action<ErrorType, int, CharaUnlockEditSkillResponse> onError)
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
