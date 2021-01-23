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
	public class LotteryLetterMain : PageBase
	{
		// Fields
		public Button skipButton;
		[SerializeField]
		private GameObject tapToNextItem;
		private Action onSkipButtonPlessed;
	
		// Constructors
		public LotteryLetterMain();
	
		// Methods
		public void TapToNextItemEnable(bool isActive);
		public void SetSkipButtonAction(Action onSkip);
		public void OnSkipButtonPlessed();
	}
}
