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
	public class AddCreatorDialogController : PopupBase
	{
		// Fields
		[SerializeField]
		private GameObject dialogObj;
		private FortViewController fortViewCtrl;
		[SerializeField]
		private UnityEngine.UI.Text dialogTitle;
		[SerializeField]
		private UnityEngine.UI.Text smithTitle;
		[SerializeField]
		private UnityEngine.UI.Text infoLabel;
		[SerializeField]
		private UnityEngine.UI.Text currentSmithCountLabel;
		[SerializeField]
		private UnityEngine.UI.Text addedSmithCountLabel;
		[SerializeField]
		private UnityEngine.UI.Text curCrystalLabel;
		[SerializeField]
		private UnityEngine.UI.Text curStoneLabel;
		[SerializeField]
		private UnityEngine.UI.Text lackOfCrystalLabel;
		[SerializeField]
		private Button crystalButton;
		[SerializeField]
		private Button cancelButton;
		[SerializeField]
		private UnityEngine.UI.Text costCrystalLabel;
		[SerializeField]
		private UnityEngine.UI.Text costStoneLabel;
		[SerializeField]
		private GameObject purchaseStoneImage;
		[SerializeField]
		private GameObject usePaidStoneImage;
		private int cost;
	
		// Constructors
		public AddCreatorDialogController();
	
		// Methods
		public void OnInit(FortViewController fortViewCtrl);
		public void OnBackButtonPressed();
		public void OnAddCreatorByStoneButtonPressed();
		public void OnAddCreatorByDiamondButtonPressed();
	}
}
