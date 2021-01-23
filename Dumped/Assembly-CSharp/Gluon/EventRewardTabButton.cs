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
	public class EventRewardTabButton : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image normalImage;
		[SerializeField]
		private Image selectedImage;
		[SerializeField]
		private UnityEngine.UI.Text countText;
		[SerializeField]
		private Badge badge;
	
		// Constructors
		public EventRewardTabButton();
	
		// Methods
		public void SetContent(bool isSelected, int curIndex);
	}
}
