/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF;
using NPF.Inquiry;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.User
{
	public class BaaSUser
	{
		// Fields
		[CompilerGenerated]
		private string _UserId_k__BackingField;
		[CompilerGenerated]
		private string _IdToken_k__BackingField;
		[CompilerGenerated]
		private string _AccessToken_k__BackingField;
		[CompilerGenerated]
		private string _DeviceAccount_k__BackingField;
		[CompilerGenerated]
		private string _DevicePassword_k__BackingField;
		[CompilerGenerated]
		private string _Nickname_k__BackingField;
		[CompilerGenerated]
		private string _Country_k__BackingField;
		[CompilerGenerated]
		private Gender _Gender_k__BackingField;
		[CompilerGenerated]
		private int _BirthdayDay_k__BackingField;
		[CompilerGenerated]
		private int _BirthdayMonth_k__BackingField;
		[CompilerGenerated]
		private int _BirthdayYear_k__BackingField;
		[CompilerGenerated]
		private bool _PersonalAnalytics_k__BackingField;
		[CompilerGenerated]
		private bool _PersonalNotification_k__BackingField;
		[CompilerGenerated]
		private long _PersonalAnalyticsUpdatedAt_k__BackingField;
		[CompilerGenerated]
		private long _PersonalNotificationUpdatedAt_k__BackingField;
		[CompilerGenerated]
		private InquiryStatus _InquiryStatus_k__BackingField;
		[CompilerGenerated]
		private NintendoAccount _NintendoAccount_k__BackingField;
		[CompilerGenerated]
		private long _CreatedAt_k__BackingField;
		[CompilerGenerated]
		private Dictionary<string, LinkedAccount> _LinkedAccounts_k__BackingField;
	
		// Properties
		public string UserId { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string IdToken { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string AccessToken { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string DeviceAccount { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string DevicePassword { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string Nickname { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string Country { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Gender Gender { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int BirthdayDay { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int BirthdayMonth { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int BirthdayYear { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool PersonalAnalytics { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public bool PersonalNotification { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		internal long PersonalAnalyticsUpdatedAt { [CompilerGenerated] get; [CompilerGenerated] set; }
		internal long PersonalNotificationUpdatedAt { [CompilerGenerated] get; [CompilerGenerated] set; }
		public InquiryStatus InquiryStatus { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public NintendoAccount NintendoAccount { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public long CreatedAt { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public Dictionary<string, LinkedAccount> LinkedAccounts { [CompilerGenerated] get; [CompilerGenerated] internal set; }
	
		// Nested types
		public delegate void AuthorizationResult(BaaSUser user, NPFError error);
	
		public delegate void LinkNintendoAccountResult(NPFError error);
	
		public delegate void SwitchByNintendoAccountResult(string oldUserId, string newUserId, NintendoAccount nintendoAccount, NPFError error);
	
		// Constructors
		internal BaaSUser();
	
		// Methods
		public void LinkNintendoAccount(NintendoAccount nintendoAccount, LinkNintendoAccountResult callback);
		public void SwitchByNintendoAccount(IList<string> scope, IDictionary<string, string> profileSource, SwitchByNintendoAccountResult callback);
		internal void Reset();
	}
}
