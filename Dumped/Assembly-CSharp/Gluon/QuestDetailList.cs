/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestDetailList : QuestListBase
	{
		// Fields
		[SerializeField]
		private Transform contentTransfrom;
		public AnimationListOneCol listAnimation;
		private List<QuestDataElement> questDataList;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<QuestDataElement> __9__4_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LoadData_b__4_0(QuestDataElement a, QuestDataElement b);
		}
	
		// Constructors
		public QuestDetailList();
	
		// Methods
		public void SetContent(List<QuestCellData> givenCellDataList, QuestCell.SubType subType);
		private void LoadData(List<QuestCellData> givencellDataList);
		private void CreateList(List<QuestCellData> givencellDataList, QuestCell.SubType subType);
	}
}
