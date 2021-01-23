/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildIconSelectPopup : PopupBase
	{
		// Fields
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildIconSelectPopup";
		private Action<GuildModel.ProfileIconData> onEditDone;
		[NonSerialized]
		public GuildModel.ProfileIconData selectedIconData;
		public GuildIconTableViewController[] controllers;
	
		// Constructors
		public GuildIconSelectPopup();
	
		// Methods
		public static GuildIconSelectPopup Create(GuildModel.ProfileIconData initIconData, Action<GuildModel.ProfileIconData> onEditDone);
		public void OnIconSelect(GuildModel.ProfileIconData data);
		public void OnOKButtonPressed();
	}
}
