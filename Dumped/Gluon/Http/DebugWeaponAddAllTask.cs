using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugWeaponAddAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugWeaponAddAllResponse> onSuccess;

		private Action<ErrorType, int, DebugWeaponAddAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugWeaponAddAllTask(DebugWeaponAddAllRequest request, Action<DebugWeaponAddAllResponse> onSuccess, Action<ErrorType, int, DebugWeaponAddAllResponse> onError)
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
