/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildMemberTableViewController : TableViewController<Gluon.GuildModel.MemberInfo>
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text noItemText;
		[NonSerialized]
		public EditMode editMode;
		private float cellHeight;
		[CompilerGenerated]
		private Action _onRequestLatestData_k__BackingField;
		private List<GuildModel.MemberInfo> originalData;
	
		// Properties
		public Action onRequestLatestData { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum EditMode
		{
			None = 0,
			Admin = 1,
			Approve = 2,
			Invite = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<GuildModel.MemberInfo, GuildModel.Occupation> __9__15_0;
			public static Func<GuildModel.MemberInfo, GuildModel.MemberInfo.OnlineStatus> __9__15_1;
			public static Func<GuildModel.MemberInfo, DateTime> __9__15_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal GuildModel.Occupation _ApplySort_b__15_0(GuildModel.MemberInfo x);
			internal GuildModel.MemberInfo.OnlineStatus _ApplySort_b__15_1(GuildModel.MemberInfo x);
			internal DateTime _ApplySort_b__15_2(GuildModel.MemberInfo x);
		}
	
		// Constructors
		public GuildMemberTableViewController();
	
		// Methods
		protected override void Awake();
		protected override float GetCellHeightAtIndex(int index);
		public void UpdateByData(List<GuildModel.MemberInfo> data);
		protected override TableViewCell<GuildModel.MemberInfo> CreateCellForIndex(int index);
		protected override void UpdateContents();
		public GuildModel.MemberInfo GetSubMasterData();
		private void ApplySort();
	}
}
