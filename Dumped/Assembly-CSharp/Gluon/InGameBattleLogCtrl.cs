/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameBattleLogCtrl : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _adjustRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _buttonRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _logRt;
		[SerializeField]
		[Tooltip]
		private Button _button;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _buttonImage;
		[Header]
		[SerializeField]
		[Tooltip]
		private int _logDisplayNum;
		[Header]
		[SerializeField]
		[Tooltip]
		private Sprite[] _buttonImageList;
		private VisibleUIObject _rootVisible;
		private VisibleUIObject _logVisible;
		private List<InGameBattleLogUI> _logUIList;
		private List<InGameBattleLogUI> _workLogUIList;
		private List<InGameBattleLogUI> _displayLogUIList;
		private List<LogData> _workLogDataList;
		private List<LogData> _standbyLogDataList;
		private List<LogData> _displayLogDataList;
		private List<LogData> _removeLogDataList;
		private bool _isLeft;
		private bool _isShow;
		private bool _isEnable;
		private Canvas _buttonCanvas;
		[CompilerGenerated]
		private bool _IsLogDisplayFast_k__BackingField;
		private const int LogUIListReserveNum = 8;
		private const int LogDataListReserveNum = 64;
		private const float SystemMessageDisplayTime = 2f;
	
		// Properties
		private int LogMaxNum { get; }
		private int LogDisplayNum { get; }
		public bool IsLogDisplayFast { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private enum ButtonImageType
		{
			On = 0,
			On_L = 1,
			Off = 2
		}
	
		public enum LogType
		{
			None = 0,
			SimpleText = 1
		}
	
		public enum ButtonSortingOrderType
		{
			Default = 0,
			ContinueCamera = 1
		}
	
		public class LogData
		{
			// Fields
			public LogType logType;
			public string text;
			public bool isDisplayed;
	
			// Constructors
			public LogData();
	
			// Methods
			public void Setup([IsReadOnly] in LogData data);
			public void Reset();
		}
	
		// Constructors
		public InGameBattleLogCtrl();
	
		// Methods
		public static InGameBattleLogCtrl Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		public override void FastUpdate();
		public void Show();
		public void Hide();
		public void SetLogEnable(bool enable);
		public void OnClickLog();
		private void SetVisibleLog(bool visible, bool force = false);
		private void ChangeButtonImage(bool on);
		private bool IsEnableButtonInput();
		public bool AddLog([IsReadOnly] in LogData data);
		private void RegistDisplayLogDataList([IsReadOnly] in LogData data);
		private void RemoveDisplayLogDataList();
		private void DisplayLog([IsReadOnly] in LogData data, ref List<InGameBattleLogUI> list);
		private void SortHiddenLogUIByLogUIList([IsReadOnly] in InGameBattleLogUI hiddenLogUI);
		private void ResetLog();
		public bool IsDisplayableUI(bool ignoreInside = false);
		private void SetDisplayFast([IsReadOnly] in List<InGameBattleLogUI> list);
		private void GetDisplayLogUIList(ref List<InGameBattleLogUI> list);
		private InGameBattleLogUI GetHiddenLogUI();
		public void SetLayout(bool isLeft, bool force = false);
		public void SetButtonSortingOrder(ButtonSortingOrderType type);
	}
}
