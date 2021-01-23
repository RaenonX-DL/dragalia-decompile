/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomNotify : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text message;
		[SerializeField]
		private RectTransform rectTransform;
		[SerializeField]
		private CanvasGroup canvasGroup;
		[SerializeField]
		private float notifyFadeInTime;
		[SerializeField]
		private float notifyFadeInBeginY;
		[SerializeField]
		private float notifyFadeInEndY;
		[SerializeField]
		private Ease notifyFadeInEase;
		[SerializeField]
		private float notifyIdleTime;
		[SerializeField]
		private float notifyIdleEndY;
		[SerializeField]
		private Ease notifyIdleEase;
		[SerializeField]
		private float notifyFadeOutTime;
		[SerializeField]
		private float notifyFadeOutEndY;
		[SerializeField]
		private Ease notifyFadeOutEase;
		private Sequence sequence;
	
		// Constructors
		public MatchingRoomNotify();
	
		// Methods
		public void SetMessege(string str);
		[ContextMenu]
		public void PlayAnimation();
		public bool IsPlaying();
	}
}
