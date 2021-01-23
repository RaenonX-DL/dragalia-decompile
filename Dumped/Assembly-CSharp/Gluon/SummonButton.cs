/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonButton : MonoBehaviour
	{
		// Fields
		public SummonTopItemData.ButtonType buttonType;
		[HideInInspector]
		public SummonTopItemView itemView;
		[SerializeField]
		private GameObject priceText;
	
		// Constructors
		public SummonButton();
	
		// Methods
		private void Start();
		public void OnPress();
		public void SetInteractable(bool value);
	}
}
