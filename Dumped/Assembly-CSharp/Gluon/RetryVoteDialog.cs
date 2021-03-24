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
	public class RetryVoteDialog : InGameDialogBase
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _adjustRt;
		[SerializeField]
		private Button _retryButton;
		[SerializeField]
		private Button _cancelButton;
		[SerializeField]
		private Image _retryButtonBgImage;
		[SerializeField]
		private Image _cancelButtonBgImage;
		[SerializeField]
		private UnityEngine.UI.Text _retryButtonText;
		[SerializeField]
		private UnityEngine.UI.Text _cancelButtonText;
		[SerializeField]
		private InGameGaugeUI _timeGauge;
		[SerializeField]
		private Image[] _voteImage;
		[Header]
		[SerializeField]
		private Color32[] _voteStateColor;
		[Header]
		[SerializeField]
		private Sprite _disableButtonBgImage;
		private VisibleUIObject _rootVisible;
		private int _actorIndex;
		private VoteState _voteState;
		private MultiPlayRetryVoteModel _retryVoteModel;
		private bool _isOpenRequested;
	
		// Nested types
		public enum VoteState
		{
			Waiting = 0,
			Accepted = 1,
			Denied = 2,
			Absence = 3,
			Finish = 4
		}
	
		// Constructors
		public RetryVoteDialog();
	
		// Methods
		public static RetryVoteDialog Create(GameObject parent);
		public void Initialize();
		private void Update();
		private void SetActive(ref RectTransform rt, bool isActive);
		private void UpdateVoteIcon();
		public void RequestOpen();
		public void Open();
		public void Close(bool isPlayCloseSE = false);
		public void SetEnableButtons(bool b);
		public void OnRetryButtonPressed();
		private void ExecRetryButtonPressed(bool force = false);
		public void OnCancelButtonPressed();
		private void ExecCancelButtonPressed();
		private bool IsEnablePress();
		private void DisableButtons();
		public void SetVoteIconColor(int index, VoteState state);
		public void SetTimeRate(float rate, bool immediate = false);
		[CompilerGenerated]
		private void _Initialize_b__18_0();
		[CompilerGenerated]
		private void _Open_b__23_0();
		[CompilerGenerated]
		private void _Close_b__24_0();
	}
}
