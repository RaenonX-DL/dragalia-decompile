/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitStoryListCell : TableViewCell<Gluon.UnitStoryListCellData>
	{
		// Fields
		[SerializeField]
		private Image newIconImage;
		[SerializeField]
		private Shader exchangeShader;
		[Header]
		[SerializeField]
		private Button cellButton;
		[SerializeField]
		private GameObject storyCell;
		[SerializeField]
		private CommonIcon unitIcon;
		[SerializeField]
		private UnityEngine.UI.Text unitNameText;
		[SerializeField]
		private UnityEngine.UI.Text titleNameText;
		[SerializeField]
		private GameObject lockLayer;
		[SerializeField]
		private UnityEngine.UI.Text triggerText;
		[SerializeField]
		private GameObject characterCell;
		[SerializeField]
		private CommonIcon characterIconWide;
		[SerializeField]
		private UnityEngine.UI.Text characterNameText;
		[Header]
		[SerializeField]
		private Button castleCellButton;
		[SerializeField]
		private Image castleCellBgImage;
		[SerializeField]
		private UnityEngine.UI.Text castleTitleNameText;
		[SerializeField]
		private GameObject castleLockLayer;
		[SerializeField]
		private UnityEngine.UI.Text castleItemUseNumText;
		[SerializeField]
		private Image castleItemIconImage;
		private UnityAction pressedCallback;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public UnitStoryListCell __4__this;
			public UnitStoryListCellData data;
	
			// Constructors
			public __c__DisplayClass19_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_1
		{
			// Fields
			public UnitStoryGroupElement group;
			public UnitStoryElement story;
			public __c__DisplayClass19_0 CS___8__locals1;
			public UnityAction __9__3;
	
			// Constructors
			public __c__DisplayClass19_1();
	
			// Methods
			internal void _UpdateContent_b__0();
			internal void _UpdateContent_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_2
		{
			// Fields
			public DownloadOperation downloadOperationWithoutVoice;
			public DownloadOperation downloadOperation;
			public __c__DisplayClass19_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass19_2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_3
		{
			// Fields
			public SelectableDownloadPopup popup;
			public __c__DisplayClass19_2 CS___8__locals3;
	
			// Constructors
			public __c__DisplayClass19_3();
	
			// Methods
			internal void _UpdateContent_b__1();
			internal void _UpdateContent_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_4
		{
			// Fields
			public CastleStoryElement story;
			public __c__DisplayClass19_0 CS___8__locals4;
			public UnityAction __9__8;
	
			// Constructors
			public __c__DisplayClass19_4();
	
			// Methods
			internal void _UpdateContent_b__4();
			internal void _UpdateContent_b__5();
			internal void _UpdateContent_b__8();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_5
		{
			// Fields
			public DownloadOperation downloadOperationWithoutVoice;
			public DownloadOperation downloadOperation;
			public __c__DisplayClass19_4 CS___8__locals5;
	
			// Constructors
			public __c__DisplayClass19_5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_6
		{
			// Fields
			public SelectableDownloadPopup popup;
			public __c__DisplayClass19_5 CS___8__locals6;
	
			// Constructors
			public __c__DisplayClass19_6();
	
			// Methods
			internal void _UpdateContent_b__6();
			internal void _UpdateContent_b__7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_7
		{
			// Fields
			public UnitStoryGroupElement group;
			public __c__DisplayClass19_0 CS___8__locals7;
	
			// Constructors
			public __c__DisplayClass19_7();
	
			// Methods
			internal void _UpdateContent_b__9();
		}
	
		// Constructors
		public UnitStoryListCell();
	
		// Methods
		public override void UpdateContent(UnitStoryListCellData data);
		public void OnCellButtonPressed();
	}
}
