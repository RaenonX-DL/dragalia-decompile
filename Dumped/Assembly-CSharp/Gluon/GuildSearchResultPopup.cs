/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildSearchResultPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GuildInfoTableViewController searchList;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildSearchResultPopup";
		private List<GuildInfoCellData> cellDataList;
		private GuildInfoCellData.FilterOption filter;
		private Action<int, GuildInfoCellData, Action> onApply;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public GuildSearchResultPopup __4__this;
			public GuildInfoCellData data;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _OnCellPressed_b__0();
			internal void _OnCellPressed_b__1();
		}
	
		// Constructors
		public GuildSearchResultPopup();
	
		// Methods
		public static GuildSearchResultPopup Create(List<GuildInfoCellData> dataList, Action<int, GuildInfoCellData, Action> onApply);
		protected override void Start();
		public void OnCellPressed(GuildInfoCellData data);
		[CompilerGenerated]
		private void _Start_b__6_0(GuildInfoCellData.FilterOption filter, Action<List<GuildInfoCellData>> onRetrived);
	}
}
