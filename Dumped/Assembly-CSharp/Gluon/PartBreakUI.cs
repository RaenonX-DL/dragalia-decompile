/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartBreakUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private GameObject bgTemplate;
		[Header]
		[SerializeField]
		private float margin;
		private int numElement;
		private PartInfo[] partInfo;
		private TargetParts eventParts;
		private NotifyCharacter.CharaDialogueNPCParam dialogueParam;
		private int ownPlayerIndex;
		private string announceText;
		private InGameFollowLayout followLayout;
		private Transform buttonBaseTransform;
		private VisibleUIObject rootVisible;
		private float talkTime;
		public const int maxElement = 4;
		private const float talkTimeDefault = 2.4f;
	
		// Nested types
		public enum Type
		{
			PartBreak = 0,
			SecondElements = 1
		}
	
		public class Param
		{
			// Fields
			public Type displayType;
			public int partNum;
			public int[] partType;
			public string[] partName;
			public float[] partHpRate;
			public bool[] partSecondTime;
			public bool isChangeBoss;
	
			// Constructors
			public Param();
	
			// Methods
			public void Setup(NotifyCharacter.OpenPartBreakParam param);
		}
	
		public class ParamSetPlayer
		{
			// Fields
			public int partIndex;
			public int playerNo;
	
			// Constructors
			public ParamSetPlayer();
		}
	
		private class PartInfo
		{
			// Fields
			public int type;
			public RectTransform bg;
			public RectTransform filter;
			public Button button;
			public UnityEngine.UI.Text label;
			public SpriteRenderer icon;
			public InGameGaugeUISpriteRenderer gauge;
			public VisibleUIObject iconVisible;
			public VisibleUIObject[] playerIconVisible;
	
			// Constructors
			public PartInfo();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public int idx;
			public PartBreakUI __4__this;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public PartBreakUI();
	
		// Methods
		public static PartBreakUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize(Transform parent);
		public void Open(Param param);
		public void Close();
		private void Update();
		public void SetPlayer(int partIndex, int playerNo);
		public void SetHP(int partIndex, float hp, bool immediate, bool secondTime = false);
		public void SetHPForType(int type, float hp, bool immediate, bool secondTime = false);
		public void SetOwnPlayerIndex(int index);
		private void OnClick(int partIndex);
		private void SetTargetParts(int playerIndex, int partsId, int characterId);
		public void OnTargetParts(int playerIndex, int partsId);
	}
}
