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
	public class TutorialSummonItem : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected CommonIcon icon;
		[SerializeField]
		private Image iconDragonElements;
		[SerializeField]
		private Sprite[] dragonElements;
		private GiftType giftType;
		private int id;
	
		// Constructors
		public TutorialSummonItem();
	
		// Methods
		public void SetContent(SummonResultItemData data, IconLoader.Size size);
		private void SetIconDoragonElement(SummonResultItemData data);
		public void OnIconTouched();
		public void ShowItemDetail(SummonResultItemData itemData);
		private void TutorialFlagReset();
	}
}
