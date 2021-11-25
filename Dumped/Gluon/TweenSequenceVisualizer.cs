using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class TweenSequenceVisualizer : MonoBehaviour
	{
		private Sequence mainSequence;

		public List<Sequence> workingSequenceList;

		public bool isLoop;

		public bool isResetToInitialState;

		public bool shouldAutoStart;

		public float loopInterval;

		public Transform overrideTweenTransform;

		public RectTransform overrideTweenRectTransform;

		public CanvasGroup overrideTweenCanvas;

		public Image overrideTweenImage;

		public float customEaseErrorValue;

		public List<Object> recordedItemList;

		[HideInInspector]
		public Sequence sequence
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void CompleteSequence()
		{
		}

		private void OnDestroy()
		{
		}

		public void KillAll()
		{
		}

		public bool IsCompleted()
		{
			return default(bool);
		}

		public bool IsActive()
		{
			return default(bool);
		}

		public void PlaySequence()
		{
		}

		public Sequence PushSequence()
		{
			return null;
		}

		public static Sequence PushSequence(ref List<Sequence> seqList)
		{
			return null;
		}

		public Sequence PopSequence()
		{
			return null;
		}

		public static Sequence PopSequence(ref Sequence mainSeq, ref List<Sequence> seqList)
		{
			return null;
		}

		public Sequence AttachAllPushedSequence()
		{
			return null;
		}

		public static Sequence AttachAllPushedSequence(ref Sequence mainSeq, ref List<Sequence> seqList)
		{
			return null;
		}

		public void ApplyChangesOnRun(bool bAutoStart = true, bool bOnRun = false)
		{
		}
	}
}
