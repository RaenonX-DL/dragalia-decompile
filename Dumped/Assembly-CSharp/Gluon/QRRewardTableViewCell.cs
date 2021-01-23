/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRRewardTableViewCell : TableViewCell<Gluon.QuestResultModel.FirstClearModel.FirstClearItemInfo>
	{
		// Fields
		public CommonIcon icon;
		public UnityEngine.UI.Text title;
		public UnityEngine.UI.Text itemName;
		[SerializeField]
		public UnityEvent<int> buttonPressed;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__4_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _UpdateContent_b__4_0();
		}
	
		// Constructors
		public QRRewardTableViewCell();
	
		// Methods
		public override void UpdateContent(QuestResultModel.FirstClearModel.FirstClearItemInfo data);
		public void OnIconLongTouched();
	}
}
