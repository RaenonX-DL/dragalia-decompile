/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildLoginBonusPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public Transform iconParent;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildLoginBonusPopup";
		private Action onDone;
		private List<EntityData> dataList;
	
		// Constructors
		public GuildLoginBonusPopup();
	
		// Methods
		public static GuildLoginBonusPopup Create(List<EntityData> dataList, Action onDone);
		protected override void Start();
		public void OnCloseButtonPressed();
	}
}
