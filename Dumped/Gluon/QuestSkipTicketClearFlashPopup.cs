using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class QuestSkipTicketClearFlashPopup : CommonPopup
	{
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

		public Camera flashCamera => null;

		public FlashPlayerManager flashPlayerManager => null;

		public bool isFinish
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int sortingOrder => default(int);

		public static QuestSkipTicketClearFlashPopup Create()
		{
			return null;
		}

		public void Prepare(Action finish, Action outLabel)
		{
		}

		private void OnClearF2ULoad(int index)
		{
		}

		public void Play(Action finish, Action outLabel)
		{
		}

		private void OnOutLabelStart()
		{
		}

		public void ClosePage()
		{
		}

		public void OnSkip()
		{
		}
	}
}
