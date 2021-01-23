/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildEmblemSelectPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GuildEmblemTableViewController controller;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildEmblemSelectPopup";
		private Action<int> onEditDone;
		[CompilerGenerated]
		private int _selectedEmblemId_k__BackingField;
	
		// Properties
		public int selectedEmblemId { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public GuildEmblemSelectPopup();
	
		// Methods
		public static GuildEmblemSelectPopup Create(int initEmblemId, Action<int> onEditDone);
		public void OnEmblemSelect(int data);
		public void OnOKButtonPressed();
	}
}
