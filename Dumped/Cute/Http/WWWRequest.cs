using System;
using System.Collections.Generic;
using UnityEngine.Networking;

namespace Cute.Http
{
	public class WWWRequest : IWebRequest, IDisposable
	{
		private UnityWebRequest request;

		public byte[] bytes => null;

		public bool isDone => default(bool);

		public string error => null;

		public Dictionary<string, string> responseHeaders => null;

		public void Dispose()
		{
		}

		public void Post(string url, byte[] postData, Dictionary<string, string> headers)
		{
		}
	}
}
