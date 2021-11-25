using System;
using System.Collections.Generic;

namespace Cute.Http
{
	public class ResponseCache
	{
		private class CacheData
		{
			public byte[] response;

			public float expireTime;
		}

		private Dictionary<Type, CacheData> cacheData;

		public void AddCache(IHttpTask task, byte[] decryptResponseData)
		{
		}

		public byte[] GetCache(IHttpTask task)
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Clear<T>() where T : IHttpTask
		{
		}
	}
}
