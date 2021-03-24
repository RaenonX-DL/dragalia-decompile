/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildSearchConditionPopup : PopupBase
	{
		// Fields
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildSearchConditionPopup";
		[SerializeField]
		public Toggle[] approvalToggles;
		public Toggle[] activityToggles;
		public Toggle[] populationToggles;
		public Button okButton;
		private Action<GuildInfoCellData.FilterOption> onFilterApplied;
		private GuildInfoCellData.FilterOption filter;
	
		// Constructors
		public GuildSearchConditionPopup();
	
		// Methods
		public static GuildSearchConditionPopup Create(GuildInfoCellData.FilterOption filter, Action<GuildInfoCellData.FilterOption> onFilterApplied);
		protected override void Start();
		private void Update();
		public void OnApplyButtonPressed();
	}
}
