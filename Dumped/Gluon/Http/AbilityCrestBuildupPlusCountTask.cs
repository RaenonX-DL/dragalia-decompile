using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AbilityCrestBuildupPlusCountTask : IHttpTask
	{
		private byte[] postData;

		private Action<AbilityCrestBuildupPlusCountResponse> onSuccess;

		private Action<ErrorType, int, AbilityCrestBuildupPlusCountResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AbilityCrestBuildupPlusCountTask(AbilityCrestBuildupPlusCountRequest request, Action<AbilityCrestBuildupPlusCountResponse> onSuccess, Action<ErrorType, int, AbilityCrestBuildupPlusCountResponse> onError)
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
