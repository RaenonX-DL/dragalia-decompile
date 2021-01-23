/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSupportListController : QuestCommonTableViewController<Gluon.QuestSupportListCellData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
		public QuestSupportListBase supportListBase;
	
		// Constructors
		public QuestSupportListController();
	
		// Methods
		public void LoadData(int questId, UserSupportList[] supportData);
		public void Reload();
		public void ClearList();
		protected override TableViewCell<QuestSupportListCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__6_0(int cellIndex);
	}
}
