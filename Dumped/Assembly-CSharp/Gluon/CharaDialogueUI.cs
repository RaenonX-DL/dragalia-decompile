/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Cute.Cri;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaDialogueUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform iconAlign;
		[SerializeField]
		private Image imageIcon;
		[SerializeField]
		private Image imageBalloon;
		[SerializeField]
		private UnityEngine.UI.Text text;
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
		[Header]
		[SerializeField]
		private Sprite[] leftBalloon;
		[SerializeField]
		private Sprite[] rightBalloon;
		[Header]
		[SerializeField]
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
		[Header]
		[SerializeField]
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
		[CompilerGenerated]
		private Font _fontDragon_k__BackingField;
	
		// Properties
		public Font textFont { get; }
		public Font fontDragon { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum Balloon
		{
			Standard = 0,
			Intense = 1
		}
	
		// Constructors
		public CharaDialogueUI();
	
		// Methods
		private void Visible(bool b, bool force = false);
		public void Initialize();
		public void Display(Material mtrl, string str, bool leftIcon, string voice, InGameSound.Priority voicePriority, bool isManual, Balloon balloon, bool waitVoiceEnd);
		public bool Close(bool force = false);
		public bool IsActive();
		public bool IsLeaving();
		public override void FastUpdate();
		public void SetFastForward(bool b);
		public void SetText(string str, string voice);
		public void Release();
		private void StateInBegin(SimpleState prev);
		private void StateInEnd(SimpleState next);
		private void OnCompleteBalloonRot(RotZControlUI sender);
		private void StateStayEnd(SimpleState next);
		private void StateStayTick();
		private void OnCompleteAlpha(AlphaControlUI sender);
	}
}
