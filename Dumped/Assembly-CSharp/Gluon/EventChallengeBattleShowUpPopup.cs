﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventChallengeBattleShowUpPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Image bannerImage;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text infoText;
		private const string popupPath = "Prefabs/OutGame/EventQuest/EventChallengeBattleShowUpPopup";
	
		// Constructors
		public EventChallengeBattleShowUpPopup();
	
		// Methods
		public static EventChallengeBattleShowUpPopup Create(QuestEventMenuElement menuElement);
		public void SetContent(QuestEventMenuElement menuElement);
	}
}
