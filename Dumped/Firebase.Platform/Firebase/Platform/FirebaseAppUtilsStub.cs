/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 40: Firebase.Platform.dll - Assembly: Firebase.Platform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Platform
{
	internal class FirebaseAppUtilsStub : IFirebaseAppUtils
	{
		// Fields
		private static FirebaseAppUtilsStub _instance;
	
		// Properties
		public static FirebaseAppUtilsStub Instance { get; }
	
		// Constructors
		public FirebaseAppUtilsStub();
		static FirebaseAppUtilsStub();
	
		// Methods
		public void TranslateDllNotFoundException(Action action);
		public void PollCallbacks();
		public PlatformLogLevel GetLogLevel();
	}
}
