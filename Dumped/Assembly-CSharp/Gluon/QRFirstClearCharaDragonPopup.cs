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
	public class QRFirstClearCharaDragonPopup : PopupBase
	{
		// Fields
		[SerializeField]
		public CommonIcon icon;
		public UnityEngine.UI.Text bottomText;
		public UnityEngine.UI.Text itemName;
		public UnityEngine.UI.Text itemRuby;
		[SerializeField]
		private UnityEngine.UI.Text title;
		private QuestResultModel.FirstClearModel.FirstClearItemInfo info;
		[CompilerGenerated]
		private bool _isFromLoginBonus_k__BackingField;
	
		// Properties
		public bool isFromLoginBonus { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public Action onOKOrClose;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		// Constructors
		public QRFirstClearCharaDragonPopup();
	
		// Methods
		public static QRFirstClearCharaDragonPopup Create(QuestResultModel.FirstClearModel.FirstClearItemInfo info, Action onOKOrClose, Transform parentTransform = null);
		protected override void Start();
		public QuestResultModel.FirstClearModel.FirstClearItemInfo GetFirstClearItemInfo();
		public void SetTitleText(string str);
	}
}
