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
	public class DreamSelectTicketCell : TableViewCell<Gluon.DreamSelectTicketCtrl.DreamSelectItemCellData>
	{
		// Fields
		[SerializeField]
		private CommonIcon icon;
		[SerializeField]
		private UnityEngine.UI.Text alreadyHadText;
		[SerializeField]
		private UnityEngine.UI.Text nameText;
		[SerializeField]
		private UnityEngine.UI.Text countText;
		[SerializeField]
		private GameObject summonButtonObj;
		[SerializeField]
		private GameObject[] rarityObjs;
		public Action<GiftType, int> onSummonButtonClick;
	
		// Constructors
		public DreamSelectTicketCell();
	
		// Methods
		public override void UpdateContent(DreamSelectTicketCtrl.DreamSelectItemCellData itemData);
		private bool IsAlreadyGot();
		public void OnSummonButtonClick();
	}
}
