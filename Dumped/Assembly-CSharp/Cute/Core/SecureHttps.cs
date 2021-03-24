/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class SecureHttps
	{
		// Fields
		[CompilerGenerated]
		private static bool _DisableCertificateCheck_k__BackingField;
		private static HashSet<string> fingerPrints;
		private const int readSizeAtOnce = 16384;
	
		// Properties
		public static bool DisableCertificateCheck { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<int> __9__9_0;
			public static Action<int> __9__11_1;
			public static Action<int> __9__12_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Get_b__9_0(int statusCode);
			internal void _Download_b__11_1(int statusCode);
			internal void _Post_b__12_0(int statusCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public Action onSucceeded;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _Download_b__0(byte[] result);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public HttpWebRequest request;
			public Action<byte[]> onSucceeded;
			public Action<string> onError;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _BeginGetResponse_b__0(IAsyncResult result);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_1
		{
			// Fields
			public byte[] bytes;
			public __c__DisplayClass13_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass13_1();
	
			// Methods
			internal void _BeginGetResponse_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_2
		{
			// Fields
			public Exception e;
			public __c__DisplayClass13_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass13_2();
	
			// Methods
			internal void _BeginGetResponse_b__2();
		}
	
		// Constructors
		static SecureHttps();
		public SecureHttps();
	
		// Methods
		public static void AddFingerPrint(string fingerPrint);
		public static void SetProxy(string address);
		public static void Get(string url, Action<byte[]> onSucceeded, Action<string> onError);
		public static void Download(string url, string filepath, Action onSucceeded, Action<string> onError);
		public static void Download(string url, string filepath, Dictionary<string, string> headers, Action onSucceeded, Action<string> onError);
		public static void Post(string url, byte[] postData, Dictionary<string, string> headers, Action<byte[]> onSucceeded, Action<string> onError);
		private static void BeginGetResponse(HttpWebRequest request, Action<byte[]> onSucceeded, Action<string> onError);
		private static byte[] StreamToBytes(Stream stream);
		private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors);
		private static void InitializeHttpsConnectionPluginContext();
	}
}
