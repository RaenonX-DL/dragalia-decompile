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
	[Serializable]
	public class SimpleEventItem
	{
		// Fields
		[SerializeField]
		private GameObject root;
		[SerializeField]
		private UnityEngine.UI.Text simpleEventItemCount;
		[SerializeField]
		private Image simpleEventItemIcon;
	
		// Constructors
		public SimpleEventItem();
	
		// Methods
		public void SetItem(int itemCount, GiftType viewEntityType, int viewEntityId);
	}
}
