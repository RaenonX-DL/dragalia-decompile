using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WeaponSetLockTask : IHttpTask
	{
		private byte[] postData;

		private Action<WeaponSetLockResponse> onSuccess;

		private Action<ErrorType, int, WeaponSetLockResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WeaponSetLockTask(WeaponSetLockRequest request, Action<WeaponSetLockResponse> onSuccess, Action<ErrorType, int, WeaponSetLockResponse> onError)
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
