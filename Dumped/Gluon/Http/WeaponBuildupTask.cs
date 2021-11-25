using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WeaponBuildupTask : IHttpTask
	{
		private byte[] postData;

		private Action<WeaponBuildupResponse> onSuccess;

		private Action<ErrorType, int, WeaponBuildupResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WeaponBuildupTask(WeaponBuildupRequest request, Action<WeaponBuildupResponse> onSuccess, Action<ErrorType, int, WeaponBuildupResponse> onError)
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
