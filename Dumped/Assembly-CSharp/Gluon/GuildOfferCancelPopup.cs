/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildOfferCancelPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Transform guildInfoParent;
		private GuildInfoCellData guildInfo;
		private const string prefabPath = "Prefabs/OutGame/Guild/GuildOfferCancelPopup";
	
		// Constructors
		public GuildOfferCancelPopup();
	
		// Methods
		public static GuildOfferCancelPopup Create();
		public void Setup(GuildData guildInfo);
		private void SetGuildInfoCell(GuildInfoCellData guildInfo);
		public void OnOfferCancelPressed();
		[CompilerGenerated]
		private void _OnOfferCancelPressed_b__6_0(GuildResignResponse res);
		[CompilerGenerated]
		private void _OnOfferCancelPressed_b__6_1();
	}
}
