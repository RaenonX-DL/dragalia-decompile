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
	public class CollectEventInfoCtrl : EventInfoCtrlBase
	{
		// Fields
		[SerializeField]
		private GameObject[] itemParent;
		[SerializeField]
		private Image[] itemIcon;
		[SerializeField]
		private UnityEngine.UI.Text[] itemCountText;
		[SerializeField]
		private UnityEngine.UI.Text hintText;
		[SerializeField]
		private UnityEngine.UI.Text hintTitleText;
		private const int usingCollectEventItemType = 1;
	
		// Constructors
		public CollectEventInfoCtrl();
	
		// Methods
		public static CollectEventInfoCtrl Create(Transform parent);
		public override void SetEventInfo();
		private void SetEventHintText();
	}
}
