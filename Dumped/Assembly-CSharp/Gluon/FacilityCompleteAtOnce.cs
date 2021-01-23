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
	public class FacilityCompleteAtOnce : PopupBase
	{
		// Fields
		private const int necessaryCostOfDragonHammer = 1;
		[SerializeField]
		private UnityEngine.UI.Text titleLabel;
		[SerializeField]
		private Button cancelButton;
		[SerializeField]
		private Button useCrystalButton;
		[SerializeField]
		private Button useStoneButton;
		[SerializeField]
		private Button useDragonHammerButton;
		[SerializeField]
		private UnityEngine.UI.Text content;
		[SerializeField]
		private UnityEngine.UI.Text curCrystalLabel;
		[SerializeField]
		private UnityEngine.UI.Text curStoneLabel;
		[SerializeField]
		private UnityEngine.UI.Text curDragonHammerLabel;
		[SerializeField]
		private UnityEngine.UI.Text costCrystalLabel;
		[SerializeField]
		private UnityEngine.UI.Text costStoneLabel;
		[SerializeField]
		private UnityEngine.UI.Text costDragonHammerLabel;
		private FacilityViewController facilityCtrl;
	
		// Constructors
		public FacilityCompleteAtOnce();
	
		// Methods
		protected override void Start();
		public void SetContent(FacilityViewController facilityVC);
		[CompilerGenerated]
		private void _Start_b__14_0();
		[CompilerGenerated]
		private void _Start_b__14_1();
		[CompilerGenerated]
		private void _Start_b__14_2();
		[CompilerGenerated]
		private void _Start_b__14_3();
	}
}
