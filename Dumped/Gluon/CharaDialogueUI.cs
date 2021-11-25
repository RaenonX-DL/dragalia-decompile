using System.Runtime.CompilerServices;
using Cute.Core;
using Cute.Cri;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CharaDialogueUI : FastUpdateMonoBehaviour
	{
		public enum Balloon
		{
			Standard,
			Intense
		}

		[SerializeField]
		[Header("component")]
		private RectTransform iconAlign;

		[SerializeField]
		private Image imageIcon;

		[SerializeField]
		private Image imageBalloon;

		[SerializeField]
		private Text text;

		[SerializeField]
		private AlphaControlUI rootAlpha;

		[SerializeField]
		private MoveControlUI rootMove;

		[SerializeField]
		private ScaleControlUI iconScale;

		[SerializeField]
		private ScaleControlUI balloonScale;

		[SerializeField]
		private RotZControlUI balloonRotZ;

		[SerializeField]
		[Header("resource")]
		private Sprite[] leftBalloon;

		[SerializeField]
		private Sprite[] rightBalloon;

		[SerializeField]
		[Header("parameter")]
		private float positionY;

		[SerializeField]
		private float moveDistance;

		[SerializeField]
		private float stayTime;

		[SerializeField]
		private float moveTime;

		[SerializeField]
		private float iconScaleTime;

		[SerializeField]
		private float balloonDelayTime;

		[SerializeField]
		private float balloonScaleTime;

		[SerializeField]
		private float balloonRotTime;

		[SerializeField]
		private float balloonRotZDeg;

		[SerializeField]
		[Header("alignment")]
		private Vector2 leftIconPos;

		[SerializeField]
		private Vector2 leftBalloonPivot;

		[SerializeField]
		private float leftBalloonPosX;

		[SerializeField]
		private Vector2 leftTextPos;

		[SerializeField]
		private Vector2 rightIconPos;

		[SerializeField]
		private Vector2 rightBalloonPivot;

		[SerializeField]
		private float rightBalloonPosX;

		[SerializeField]
		private Vector2 rightTextPos;

		[SerializeField]
		private float[] balloonPosY;

		[SerializeField]
		private float fastForwardSpeed;

		private RectTransform rectTransformBalloon;

		private RectTransform rectTransformText;

		private RectTransform rectTransformTextDragon;

		private SimpleStateProcessor stateProcessor;

		private SimpleState stateIn;

		private SimpleState stateStay;

		private SimpleState stateOut;

		private float remainTime;

		private string voice;

		private bool waitVoiceEnd;

		private float waitVoiceEndAbortTimer;

		private AudioPlayback voicePlayback;

		private InGameSound.Priority voicePriority;

		private RectTransform rootRect;

		private bool isManual;

		private bool isClose;

		private bool isActive;

		private bool leftIcon;

		private bool isFastForward;

		private Font fontDefault;

		public Font textFont => null;

		public Font fontDragon
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Visible(bool b, bool force = false)
		{
		}

		public void Initialize()
		{
		}

		public void Display(Material mtrl, string str, bool leftIcon, string voice, InGameSound.Priority voicePriority, bool isManual, Balloon balloon, bool waitVoiceEnd)
		{
		}

		public bool Close(bool force = false)
		{
			return default(bool);
		}

		public bool IsActive()
		{
			return default(bool);
		}

		public bool IsLeaving()
		{
			return default(bool);
		}

		public override void FastUpdate()
		{
		}

		public void SetFastForward(bool b)
		{
		}

		public void SetText(string str, string voice)
		{
		}

		public void Release()
		{
		}

		private void StateInBegin(SimpleState prev)
		{
		}

		private void StateInEnd(SimpleState next)
		{
		}

		private void OnCompleteBalloonRot(RotZControlUI sender)
		{
		}

		private void StateStayEnd(SimpleState next)
		{
		}

		private void StateStayTick()
		{
		}

		private void OnCompleteAlpha(AlphaControlUI sender)
		{
		}
	}
}
