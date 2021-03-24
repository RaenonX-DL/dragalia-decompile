/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi
{
	public class SignInHelper
	{
		// Fields
		private static int True;
		private static int False;
		private const string PromptSignInKey = "prompt_sign_in";
	
		// Constructors
		public SignInHelper();
		static SignInHelper();
	
		// Methods
		public static SignInStatus ToSignInStatus(int code);
		public static void SetPromptUiSignIn(bool value);
		public static bool ShouldPromptUiSignIn();
	}
}
