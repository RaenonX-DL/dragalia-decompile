/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSkipTicketClearFlashPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private GameObject flashNode;
		[SerializeField]
		private Camera _flashCamera;
		[SerializeField]
		private FlashPlayerManager _flashPlayerManager;
		[NonSerialized]
		public Canvas canvas;
		private FlashPlayer flashPlayerClear;
		private Action onFinish;
		private Action onOutLabel;
		private bool isSkip;
		private bool isPrepare;
		[CompilerGenerated]
		private bool _isFinish_k__BackingField;
	
		// Properties
		public Camera flashCamera { get; }
		public FlashPlayerManager flashPlayerManager { get; }
		public bool isFinish { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int sortingOrder { get; }
	
		// Constructors
		public QuestSkipTicketClearFlashPopup();
	
		// Methods
		public static QuestSkipTicketClearFlashPopup Create();
		public void Prepare(Action finish, Action outLabel);
		private void OnClearF2ULoad(int index);
		public void Play(Action finish, Action outLabel);
		private void OnOutLabelStart();
		public void ClosePage();
		public void OnSkip();
	}
}
