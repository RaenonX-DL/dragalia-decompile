/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Social
{
	public class SocialAccount
	{
		// Fields
		private string socialServiceUserId;
		private bool isLoggedIn;
		private static SocialAccount instance;
	
		// Properties
		public string SocialServiceUserId { get; }
		public static SocialAccount Instance { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public SocialAccount __4__this;
			public Action<bool> callback;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _SignIn_b__0(bool success);
		}
	
		// Constructors
		public SocialAccount();
	
		// Methods
		public void Initialize();
		public void SignIn(Action<bool> callback);
		public void SignOut(Action callback = null);
		public bool IsLoggedIn();
	}
}
