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
	public class MultiPlayPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private MultiPlaySelector multiPlay;
	
		// Constructors
		public MultiPlayPopup();
	
		// Methods
		public void SetContent(int questId);
		public void OnPublicButtonPressed();
		public void OnPrivateButtonPressed();
		public void OnCustomButtonPressed();
		public void OnGuildButtonPressed();
		public void OnAutoJoinButtonPressed();
		public void OnCreateResult(bool result);
	}
}
