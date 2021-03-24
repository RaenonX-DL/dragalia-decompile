/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Http
{
	public class ResponseCache
	{
		// Fields
		private Dictionary<Type, CacheData> cacheData;
	
		// Nested types
		private class CacheData
		{
			// Fields
			public byte[] response;
			public float expireTime;
	
			// Constructors
			public CacheData();
		}
	
		// Constructors
		public ResponseCache();
	
		// Methods
		public void AddCache(IHttpTask task, byte[] decryptResponseData);
		public byte[] GetCache(IHttpTask task);
		public void Clear();
		public void Clear<T>()
			where T : IHttpTask;
	}
}
