/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampListIcon : TableViewCell<Gluon.StampListData>
	{
		// Fields
		public Image newIcon;
		public Image selectIcon;
		public Image nowSetIcon;
		public Image outIcon;
		public RawImage stampIcon;
		[SerializeField]
		public StampListButtonEvent buttonPressed;
		[SerializeField]
		public StampListButtonEvent buttonLongPressed;
	
		// Constructors
		public StampListIcon();
	
		// Methods
		private void Start();
		public override void UpdateContent(StampListData data);
		private void OnButtonPressed();
		private void OnButtonLongPressed();
	}
}
