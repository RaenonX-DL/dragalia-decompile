/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildIconTableViewCell : TableViewCell<Gluon.GuildModel.ProfileIconData>
	{
		// Fields
		[Header]
		[SerializeField]
		public CommonIcon icon;
		public ButtonEvent onCellPressed;
		[Header]
		[SerializeField]
		public GameObject selectedFrame;
		public GuildIconSelectPopup popup;
	
		// Nested types
		[Serializable]
		public class ButtonEvent : UnityEvent<GuildModel.ProfileIconData>
		{
			// Constructors
			public ButtonEvent();
		}
	
		// Constructors
		public GuildIconTableViewCell();
	
		// Methods
		public override void UpdateContent(GuildModel.ProfileIconData data);
		public void OnIconPressed();
	}
}
