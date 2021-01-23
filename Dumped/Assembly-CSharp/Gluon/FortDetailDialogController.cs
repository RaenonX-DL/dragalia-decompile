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
	public class FortDetailDialogController : PopupBase
	{
		// Fields
		[SerializeField]
		private TabViewBase tabView;
		[SerializeField]
		private UnityEngine.UI.Text facilityCountLable;
		[SerializeField]
		private UnityEngine.UI.Text closeButtonText;
		[SerializeField]
		private UnityEngine.UI.Text levelText;
		[SerializeField]
		private UnityEngine.UI.Text totalLevelText;
	
		// Constructors
		public FortDetailDialogController();
	
		// Methods
		private void Awake();
		protected override void Start();
		public void OnBackButtonPressed();
	}
}
