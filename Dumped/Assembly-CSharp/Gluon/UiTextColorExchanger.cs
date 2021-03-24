/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UiTextColorExchanger : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text targetText;
		[SerializeField]
		private Color[] exchangeColors;
		[SerializeField]
		private CircleOutline targetTextOutline;
		[SerializeField]
		private Color[] exchangeOutlineColors;
		[SerializeField]
		private DropShadow targetTextDropShadow;
	
		// Constructors
		public UiTextColorExchanger();
	
		// Methods
		public void SetTextColor(int index);
	}
}
