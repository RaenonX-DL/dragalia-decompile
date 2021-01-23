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
	public class QuestResultRaidBoostPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public RaidBoostCell boostCell;
		public RaidBoostCell rareBoostCell;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text comment;
		public const string prefabPath = "Prefabs/OutGame/QuestResult/Popup/QuestResultRaidBoostPopup";
		private const string flashPath = "Prefabs/OutGame/QuestResult/pf_QuestResultRareRaidBoost";
	
		// Constructors
		public QuestResultRaidBoostPopup();
	
		// Methods
		public static QuestResultRaidBoostPopup Create();
		public static bool IsRaidBoostDropped();
		private List<RaidBoostPopup.RaidBoostModel.CellData> GetRaidBoostList();
		private List<RaidBoostPopup.RaidBoostModel.CellData> GetRareBoostList();
		protected override void Start();
	}
}
