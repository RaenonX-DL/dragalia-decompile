/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QSTableViewController : QuestCommonTableViewController<Gluon.QSTableViewData>
	{
		// Fields
		[SerializeField]
		private int _groupId;
	
		// Properties
		public int groupId { get; set; }
	
		// Constructors
		public QSTableViewController();
	
		// Methods
		public bool IsExist(QuestMainMenuElement a_qmme);
		public virtual bool IsEnable(QuestMainMenuElement qmme);
		public virtual bool IsAppear(QuestMainMenuElement a_qmme);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		public QuestCommonTableViewCell<QSTableViewData> GetQuestCommonTableViewCell(int questId);
	}
}
