using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class QuestMenuList<T> : MonoBehaviour
	{
		[SerializeField]
		private GameObject questViewControllerObj;

		[SerializeField]
		private float eachCellOpenWaitTime;

		private QuestCommonTableViewController<T> questViewController;

		public bool isRenderBgReady
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isOpenCompleted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isCloseCompleted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual void OnOpen()
		{
		}

		protected virtual void Open()
		{
		}

		private IEnumerator WaitOpenCompletedCoroutine()
		{
			return null;
		}

		public virtual void OnClose()
		{
		}

		protected virtual void Close()
		{
		}

		private IEnumerator WaitCloseCompletedCoroutine()
		{
			return null;
		}

		public virtual bool IsOnAnimation()
		{
			return default(bool);
		}
	}
}
