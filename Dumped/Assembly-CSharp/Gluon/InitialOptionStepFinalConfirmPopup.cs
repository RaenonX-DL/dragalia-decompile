/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InitialOptionStepFinalConfirmPopup : PopupBase
	{
		// Fields
		public Action onComplete;
		public UnityEngine.UI.Text vocalTypeText;
		public UnityEngine.UI.Text graphicTypeText;
		public UnityEngine.UI.Text uiLayoutTypeText;
	
		// Constructors
		public InitialOptionStepFinalConfirmPopup();
	
		// Methods
		protected override void Start();
		public void OnOKButtonPressed();
		public void OnRestartButtonPressed();
	}
}
