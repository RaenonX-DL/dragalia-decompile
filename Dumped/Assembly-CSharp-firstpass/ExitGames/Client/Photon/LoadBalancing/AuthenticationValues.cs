/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon.LoadBalancing
{
	public class AuthenticationValues
	{
		// Fields
		private CustomAuthenticationType authType;
		[CompilerGenerated]
		private string _AuthGetParameters_k__BackingField;
		[CompilerGenerated]
		private object _AuthPostData_k__BackingField;
		[CompilerGenerated]
		private string _Token_k__BackingField;
		[CompilerGenerated]
		private string _UserId_k__BackingField;
	
		// Properties
		public CustomAuthenticationType AuthType { get; set; }
		public string AuthGetParameters { [CompilerGenerated] get; [CompilerGenerated] set; }
		public object AuthPostData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string Token { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string UserId { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public AuthenticationValues();
		public AuthenticationValues(string userId);
	
		// Methods
		public virtual void SetAuthPostData(string stringData);
		public virtual void SetAuthPostData(byte[] byteData);
		public virtual void AddAuthParameter(string key, string value);
		public override string ToString();
	}
}
