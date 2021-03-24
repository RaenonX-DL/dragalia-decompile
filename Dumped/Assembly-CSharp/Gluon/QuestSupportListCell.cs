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
	public class QuestSupportListCell : QuestCommonTableViewCell<Gluon.QuestSupportListCellData>
	{
		// Fields
		public GameObject cellBase;
		public CommonFriendListCell supportListCell;
		[SerializeField]
		private GameObject noSupportBase;
		public UnityEngine.UI.Text noSupportText;
		public UnityEngine.UI.Text useSkill4Text;
		public UnityEngine.UI.Text multiPlayText;
		public Image friendIcon;
		[SerializeField]
		public CommonIconButtonEvent buttonPressed;
	
		// Constructors
		public QuestSupportListCell();
	
		// Methods
		public override void UpdateContent(QuestSupportListCellData data);
		public void OnButtonPressed();
	}
}
