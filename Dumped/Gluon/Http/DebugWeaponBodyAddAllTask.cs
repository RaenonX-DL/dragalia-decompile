using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugWeaponBodyAddAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugWeaponBodyAddAllResponse> onSuccess;

		private Action<ErrorType, int, DebugWeaponBodyAddAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugWeaponBodyAddAllTask(DebugWeaponBodyAddAllRequest request, Action<DebugWeaponBodyAddAllResponse> onSuccess, Action<ErrorType, int, DebugWeaponBodyAddAllResponse> onError)
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
