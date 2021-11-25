using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InGameSystemMsgUI : MonoBehaviour
	{
		public enum MessageStatus
		{
			Closed,
			Opening,
			Showing,
			Closing
		}

		private class MessageData : IReplicable<MessageData>, ICleanable
		{
			public float time;

			public string message;

			public void Replicate(MessageData other)
			{
			}

			public void Clean()
			{
			}
		}

		[SerializeField]
		[Header("component")]
		private Text message;

		[SerializeField]
		private RectTransform imageRt;

		[SerializeField]
		[Header("parameter")]
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

		public static InGameSystemMsgUI Create(GameObject parent, int siblingIndex = -1, [Optional] string givenPrefabPath)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void Update()
		{
		}

		public bool IsDisplaying()
		{
			return default(bool);
		}

		public void Display(float t, string msg, bool isQueueing = true, bool isRegistCheck = false)
		{
		}

		public bool CanRegistMsg(ref string msg)
		{
			return default(bool);
		}

		private void DisplaySub(float t, string msg)
		{
		}

		public void Open(string msg, bool se)
		{
		}

		public void Close()
		{
		}

		private void OnUpdateFade(float value)
		{
		}

		private void OnCompleteFade0()
		{
		}

		private void OnCompleteFade1()
		{
		}

		private void OnCompleteFadeOut()
		{
		}

		private void OnCompleteFadeIn()
		{
		}

		public void StopAndHide()
		{
		}

		public void AdjustPosY(float posY)
		{
		}

		public MessageStatus GetCurrentStatus()
		{
			return default(MessageStatus);
		}
	}
}
