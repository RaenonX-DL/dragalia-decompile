using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class QuestSelectList : QuestMenuList<QSTableViewData>
	{
		[SerializeField]
		private QuestMainDetailList questMainDetailList;

		private DragEventScrollRect dragEventScrollRect;

		private void Awake()
		{
		}

		public override void OnOpen()
		{
		}

		protected override void Open()
		{
		}

		private IEnumerator WaitOpenCompletedCoroutine()
		{
			return null;
		}

		public override void OnClose()
		{
		}

		protected override void Close()
		{
		}

		private IEnumerator WaitCloseCompletedCoroutine()
		{
			return null;
		}

		public override bool IsOnAnimation()
		{
			return default(bool);
		}
	}
}
