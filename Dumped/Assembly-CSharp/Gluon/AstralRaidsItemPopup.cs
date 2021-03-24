/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AstralRaidsItemPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text picesText;
		[SerializeField]
		private UnityEngine.UI.Text beforePicesNumText;
		[SerializeField]
		private UnityEngine.UI.Text afterPicesNumText;
		[SerializeField]
		private UnityEngine.UI.Text usePicesNumText;
		[SerializeField]
		private CommonSliderSelection picesSlider;
		private int astralPicesNum;
		private int astralPicesUseNum;
		private int astralPicesMaxNum;
		private UnityAction<int> omAstralPicesButtonPressed;
		private readonly int astralPicesMaxCount;
	
		// Constructors
		public AstralRaidsItemPopup();
	
		// Methods
		public static AstralRaidsItemPopup Create(int questId, UnityAction<int> OnOkCallback = null);
		public override void OnCancelButtonPressed();
		public override void OnOkButtonPressed();
		public void SetContent(int questId);
		public void OnValueChanged(float value);
	}
}
