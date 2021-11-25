using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CharaLimitBreakAndBuildupManaTask : IHttpTask
	{
		private byte[] postData;

		private Action<CharaLimitBreakAndBuildupManaResponse> onSuccess;

		private Action<ErrorType, int, CharaLimitBreakAndBuildupManaResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CharaLimitBreakAndBuildupManaTask(CharaLimitBreakAndBuildupManaRequest request, Action<CharaLimitBreakAndBuildupManaResponse> onSuccess, Action<ErrorType, int, CharaLimitBreakAndBuildupManaResponse> onError)
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
