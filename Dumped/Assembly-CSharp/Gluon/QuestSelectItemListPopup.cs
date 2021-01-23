/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectItemListPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private QuestSelectItemListController itemListCtrl;
		[SerializeField]
		private UnityEngine.UI.Text resetText;
		public MaterialType materialType;
		private List<ItemListCellData> cellDataList;
		private const string prefabPath = "Prefabs/OutGame/QuestSelect/Popup/QuestSelectItemListPopup";
	
		// Constructors
		public QuestSelectItemListPopup();
	
		// Methods
		public static QuestSelectItemListPopup Create();
		public void InitContent();
		private void CreateItemDetailPopup(ItemListCellData data);
	}
}
