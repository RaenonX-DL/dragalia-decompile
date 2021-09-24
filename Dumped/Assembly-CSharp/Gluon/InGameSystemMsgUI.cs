/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameSystemMsgUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text message;
		[SerializeField]
		private RectTransform imageRt;
		[Header]
		[SerializeField]
		private float maxFadeTime;
		private CanvasGroup canvasGroup;
		private float fadeTime;
		private float stayTime;
		private Tweener tweenerFade;
		private RectTransform rootRt;
		private const int QueueDataMax = 32;
		private const float MoveY = 40f;
		private bool isDisplaying;
		private MessageStatus currentStatus;
		private SimpleQueue<MessageData> messageQueue;
	
		// Nested types
		public enum MessageStatus
		{
			Closed = 0,
			Opening = 1,
			Showing = 2,
			Closing = 3
		}
	
		private class MessageData : IReplicable<MessageData>, ICleanable
		{
			// Fields
			public float time;
			public string message;
	
			// Constructors
			public MessageData();
	
			// Methods
			public void Replicate(MessageData other);
			public void Clean();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static DOSetter<float> __9__25_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnCompleteFade0_b__25_0(float v);
		}
	
		// Constructors
		public InGameSystemMsgUI();
	
		// Methods
		public static InGameSystemMsgUI Create(GameObject parent, int siblingIndex = -1, string givenPrefabPath = null);
		private void Initialize();
		private void Update();
		public bool IsDisplaying();
		public void Display(float t, string msg, bool isQueueing = true, bool isRegistCheck = false);
		public bool CanRegistMsg(ref string msg);
		private void DisplaySub(float t, string msg);
		public void Open(string msg, bool se);
		public void Close();
		private void OnUpdateFade(float value);
		private void OnCompleteFade0();
		private void OnCompleteFade1();
		private void OnCompleteFadeOut();
		private void OnCompleteFadeIn();
		public void StopAndHide();
		public void AdjustPosY(float posY);
		public MessageStatus GetCurrentStatus();
	}
}
