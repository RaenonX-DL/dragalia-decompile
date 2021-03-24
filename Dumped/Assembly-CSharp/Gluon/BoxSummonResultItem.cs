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
	public class BoxSummonResultItem : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonIcon icon;
		[SerializeField]
		private UnityEngine.UI.Text nameText;
		[SerializeField]
		private Image lineImage;
		[SerializeField]
		private UnityEngine.UI.Text quantityText;
	
		// Constructors
		public BoxSummonResultItem();
	
		// Methods
		public void SetContent(BoxSummonResultPopup.BoxSummonResultData itemData);
		public void SetDispBorderline(bool f);
	}
}
