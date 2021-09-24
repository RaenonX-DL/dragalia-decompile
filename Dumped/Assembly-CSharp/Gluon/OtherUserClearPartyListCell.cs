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
	public class OtherUserClearPartyListCell : TableViewCell<Gluon.OtherUserClearPartyListCellData>
	{
		// Fields
		public CommonUnitIcon[] charaIcons;
		public GameObject[] emptyCharaIcons;
		[SerializeField]
		private UnityEngine.UI.Text[] partyChangeButtonTextList;
		[Header]
		[SerializeField]
		public CommonUnitIcon[] secondCharaIcons;
		public GameObject[] secondEmptyCharaIcons;
		public Action<int, int> sampleButtonCallBack;
		private OtherUserClearPartyListCellData cellData;
	
		// Constructors
		public OtherUserClearPartyListCell();
	
		// Methods
		public void SetUpButtonText(bool isSoloQuest);
		public override void UpdateContent(OtherUserClearPartyListCellData cellData);
		public void OnSampleButtonPressed(int partySwitchIndex);
	}
}
