/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageBalloon : MonoBehaviour
	{
		// Fields
		public TextType textType;
		public IconType iconType;
		public MoveMapCharaType moveMapCharaType;
		public MyPageTalkCanvas canvas;
		public int myIndex;
		public bool isEventTalk;
		public MyPageObjectsSettings settings;
		public MyPageMoveMapCharaPosSettings moveMapCharaPosSettings;
		public CanvasGroup canvasGroup;
		public UnityEngine.UI.Text characterNameText;
		public UnityEngine.UI.Text textText;
		public OutGameCharacterTalkManager.TalkEntity talk;
		public GameObject[] balloons;
		public UnityEngine.UI.Text[] characterNames;
		public UnityEngine.UI.Text[] texts;
		public float transparentMinZ;
		public float opaqueMinZ;
		public float opaqueMaxZ;
		public float transparentMaxZ;
		private RectTransform rectTransform;
		private Vector3 lastPosition;
		private RectTransform canvasRectTransform;
	
		// Nested types
		public enum TextType
		{
			None = 0,
			Talk_L = 1,
			Talk_R = 2,
			Talk_L_L00 = 3,
			Talk_L_L01 = 4,
			Talk_L_R00 = 5,
			Talk_L_R01 = 6
		}
	
		public enum IconType
		{
			None = 0,
			Question_L = 1,
			Question_R = 2
		}
	
		public enum MoveMapCharaType
		{
			None = -1,
			TalkPair1 = 0,
			TalkPair2 = 1,
			Bye = 2,
			Walking = 3,
			RunMap1 = 4,
			RunMap2 = 5,
			RunMap3 = 6,
			RunMap4 = 7
		}
	
		// Constructors
		public MyPageBalloon();
	
		// Methods
		private void Awake();
		public void ResetBigTalk();
		public void Setup(IconType iconType, TextType textType, string characterName = "", OutGameCharacterTalkManager.TalkEntity talk = null, MoveMapCharaType moveMapCharaType = MoveMapCharaType.None);
		public void SetCanvasPosition(float x, float y);
	}
}
