using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ItemUseRecoveryStaminaTask : IHttpTask
	{
		private byte[] postData;

		private Action<ItemUseRecoveryStaminaResponse> onSuccess;

		private Action<ErrorType, int, ItemUseRecoveryStaminaResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ItemUseRecoveryStaminaTask(ItemUseRecoveryStaminaRequest request, Action<ItemUseRecoveryStaminaResponse> onSuccess, Action<ErrorType, int, ItemUseRecoveryStaminaResponse> onError)
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
