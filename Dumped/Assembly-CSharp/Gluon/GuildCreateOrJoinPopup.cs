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
	public class GuildCreateOrJoinPopup : PopupBase
	{
		// Fields
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildCreateOrJoinPopup";
		[SerializeField]
		private GameObject inviteBadge;
	
		// Constructors
		public GuildCreateOrJoinPopup();
	
		// Methods
		public static GuildCreateOrJoinPopup Create();
		protected override void Start();
		public void OnCreateGuildButtonPressed();
		public void OnJoinGuildButtonPressed();
		public void OnCheckInviteGuildButtonPressed();
	}
}
