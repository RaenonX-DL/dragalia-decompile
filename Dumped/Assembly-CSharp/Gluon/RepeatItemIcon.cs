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
	public class RepeatItemIcon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonIcon commonIcon;
		[SerializeField]
		private GameObject selectingImage;
		private bool selecting;
		public ItemList item;
		private QuestRepeatPopup popup;
	
		// Constructors
		public RepeatItemIcon();
	
		// Methods
		public void Initilaize(ItemList item, QuestRepeatPopup popup);
		private void OnClick();
		public void Select();
	}
}
