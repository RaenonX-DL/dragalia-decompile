/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using NPF;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.User
{
	public class NintendoAccount
	{
		// Fields
		[CompilerGenerated]
		private string _NintendoAccountId_k__BackingField;
		[CompilerGenerated]
		private NAType _Type_k__BackingField;
		[CompilerGenerated]
		private string _IdToken_k__BackingField;
		[CompilerGenerated]
		private string _AccessToken_k__BackingField;
		[CompilerGenerated]
		private string _Nickname_k__BackingField;
		[CompilerGenerated]
		private Gender _Gender_k__BackingField;
		[CompilerGenerated]
		private string _Language_k__BackingField;
		[CompilerGenerated]
		private string _Country_k__BackingField;
		[CompilerGenerated]
		private string _Region_k__BackingField;
		[CompilerGenerated]
		private string _Timezone_k__BackingField;
		[CompilerGenerated]
		private int _BirthdayDay_k__BackingField;
		[CompilerGenerated]
		private int _BirthdayMonth_k__BackingField;
		[CompilerGenerated]
		private int _BirthdayYear_k__BackingField;
		[CompilerGenerated]
		private string _Email_k__BackingField;
		[CompilerGenerated]
		private string _NintendoNetworkId_k__BackingField;
		[CompilerGenerated]
		private Mii _Mii_k__BackingField;
	
		// Properties
		public string NintendoAccountId { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public NAType Type { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string IdToken { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string AccessToken { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string Nickname { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public Gender Gender { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string Language { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string Country { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string Region { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string Timezone { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public int BirthdayDay { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public int BirthdayMonth { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public int BirthdayYear { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string Email { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string NintendoNetworkId { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public Mii Mii { [CompilerGenerated] get; [CompilerGenerated] internal set; }
	
		// Nested types
		public enum NAType
		{
			UNKNOWN = 0,
			GENERAL = 1,
			CHILD = 2
		}
	
		public delegate void AuthorizationResult(NintendoAccount nintendoAccount, NPFError error);
	
		// Constructors
		public NintendoAccount();
	
		// Methods
		internal void ResetNintendoAccountInstance();
	}
}
