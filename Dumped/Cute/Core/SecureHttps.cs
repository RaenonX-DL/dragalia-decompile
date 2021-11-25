using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Cute.Core
{
	public class SecureHttps
	{
		private static HashSet<string> fingerPrints;

		private const int readSizeAtOnce = 16384;

		public static bool DisableCertificateCheck
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		static SecureHttps()
		{
		}

		public static void AddFingerPrint(string fingerPrint)
		{
		}

		public static void SetProxy(string address)
		{
		}

		public static void Get(string url, Action<byte[]> onSucceeded, Action<string> onError)
		{
		}

		public static void Download(string url, string filepath, Action onSucceeded, Action<string> onError)
		{
		}

		public static void Download(string url, string filepath, Dictionary<string, string> headers, Action onSucceeded, Action<string> onError)
		{
		}

		public static void Post(string url, byte[] postData, Dictionary<string, string> headers, Action<byte[]> onSucceeded, Action<string> onError)
		{
		}

		private static void BeginGetResponse(HttpWebRequest request, Action<byte[]> onSucceeded, Action<string> onError)
		{
		}

		private static byte[] StreamToBytes(Stream stream)
		{
			return null;
		}

		private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		private static void InitializeHttpsConnectionPluginContext()
		{
		}
	}
}
