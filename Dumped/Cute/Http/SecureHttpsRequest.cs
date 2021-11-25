using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cute.Http
{
	public class SecureHttpsRequest : IWebRequest, IDisposable
	{
		private byte[] result;

		public byte[] bytes => null;

		public bool isDone
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string error
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Dictionary<string, string> responseHeaders => null;

		public void Dispose()
		{
		}

		public void Post(string url, byte[] postData, Dictionary<string, string> headers)
		{
		}
	}
}
