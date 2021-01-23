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
	public class BoxSummonResultListItem : BoxSummonItem
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text itemNameText;
		[SerializeField]
		private Image newBadgeImage;
	
		// Constructors
		public BoxSummonResultListItem();
	
		// Methods
		public void SetNameText(string name);
		public void SetNewBadge(bool f);
		public void OnCommonIconTouched();
	}
}
