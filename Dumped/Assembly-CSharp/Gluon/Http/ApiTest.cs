﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class ApiTest
	{
		// Fields
		private static readonly string serverUrl;
		private static Action onCallbackDelegate;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__2_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ApiLoadIndexRequestForSceneDebug_b__2_0();
		}
	
		// Constructors
		public ApiTest();
		static ApiTest();
	
		// Methods
		public static void ApiLoadIndexRequestForSceneDebug(Action onCallback, ulong viewer_id = 0);
		private static void OnSuccessForSceneDebug(LoadIndexResponse res);
	}
}
