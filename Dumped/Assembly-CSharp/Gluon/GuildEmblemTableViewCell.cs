/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildEmblemTableViewCell : TableViewCell<int>
	{
		// Fields
		[Header]
		[SerializeField]
		public RawImage icon;
		public ButtonEvent onCellPressed;
		[Header]
		[SerializeField]
		public GameObject selectedFrame;
		public GuildEmblemSelectPopup popup;
	
		// Nested types
		[Serializable]
		public class ButtonEvent : UnityEvent<int>
		{
			// Constructors
			public ButtonEvent();
		}
	
		// Constructors
		public GuildEmblemTableViewCell();
	
		// Methods
		public override void UpdateContent(int data);
		public void OnIconPressed();
	}
}
