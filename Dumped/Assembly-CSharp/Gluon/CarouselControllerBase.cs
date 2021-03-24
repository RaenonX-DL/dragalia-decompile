/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CarouselControllerBase : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected GameObject element;
		[SerializeField]
		public Button leftButton;
		[SerializeField]
		public Button rightButton;
		[SerializeField]
		protected GameObject wheel;
		[SerializeField]
		private CarouselLightController lightCtrl;
		protected RectTransform canvasRect;
		protected bool touchInCanvas;
		protected bool touchFlick;
		protected bool touchDrag;
		private bool touchSwipe;
		protected Canvas selfCanvas;
		[SerializeField]
		protected float elementsScele;
		[SerializeField]
		protected float elementsRotConst;
		[SerializeField]
		protected float rotSpeedFirstConst;
		[SerializeField]
		protected float wheelScaleConst;
		[SerializeField]
		protected float breakSpeedOneConst;
		[SerializeField]
		protected float breakSpeedSecondConst;
		[SerializeField]
		protected float reverseSpeedConst;
		[Header]
		[SerializeField]
		protected float miniFirstSpeed;
		[Header]
		[SerializeField]
		private float swipeSpeed;
		protected float rot;
		protected float breakSpeed;
		protected float rotSpeed;
		protected int contentsNum;
		protected int nowCenter;
		protected float beginRot;
		protected float endRot;
		protected float wheelWidth;
		protected float firstTouchRot;
		protected Vector3 firstTouchPos;
		protected Rect wheelRect;
		protected CarouselCellBase[] cells;
		protected CarouselCellBase touchTopWheelElement;
		protected CarouselCellBase topWheelElement;
		public UnityAction<int> onClickCenterCell;
		public UnityAction<int> onChangeCenterCell;
		[CompilerGenerated]
		private bool _EnabledFlag_k__BackingField;
	
		// Properties
		public int CenterIndex { get; private set; }
		public CarouselCellBase[] Cells { get; }
		public bool EnabledFlag { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private class PosElement : IComparable<PosElement>
		{
			// Fields
			[CompilerGenerated]
			private Vector3 _pos_k__BackingField;
			[CompilerGenerated]
			private int _index_k__BackingField;
			[CompilerGenerated]
			private QuestSelectWheelElement.WheelChapterSize _chapterSize_k__BackingField;
	
			// Properties
			public Vector3 pos { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int index { [CompilerGenerated] get; [CompilerGenerated] set; }
			public QuestSelectWheelElement.WheelChapterSize chapterSize { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public PosElement(Vector3 a_pos, int a_index);
	
			// Methods
			public int CompareTo(PosElement a_posElement);
		}
	
		// Constructors
		public CarouselControllerBase();
	
		// Methods
		public void Initialize(Canvas canvas);
		public virtual void Load();
		protected void Create<T>(List<T> data);
		private void Clear();
		private void Update();
		public Vector3 GetNowPoint();
		public Vector3 GetNowPoint(Vector3 pos);
		public void SetTopElement(int topElement);
		private void SetRotation(float rot);
		public void OnClickButtonLeft();
		public void OnClickButtonRight();
		private bool IsDown();
		private bool IsFlickLeft();
		private bool IsFlickRight();
		private bool IsUp();
		private bool IsDrag();
		private bool IsPress();
		private bool IsTouchGuard();
	}
}
