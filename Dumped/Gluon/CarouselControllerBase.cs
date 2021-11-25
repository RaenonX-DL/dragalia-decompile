using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CarouselControllerBase : MonoBehaviour
	{
		private class PosElement : IComparable<PosElement>
		{
			public Vector3 pos
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int index
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public QuestSelectWheelElement.WheelChapterSize chapterSize
			{
				[CompilerGenerated]
				get
				{
					return default(QuestSelectWheelElement.WheelChapterSize);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public PosElement(Vector3 a_pos, int a_index)
			{
			}

			public int CompareTo(PosElement a_posElement)
			{
				return default(int);
			}
		}

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

		[SerializeField]
		[Header("æ\u009c\u0080å°\u008fé\u0080\u009fåº¦")]
		protected float miniFirstSpeed;

		[SerializeField]
		[Header("ã\u0082¹ã\u0083\u00afã\u0082¤ã\u0083\u0097é\u0080\u009fåº¦")]
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

		public int CenterIndex
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public CarouselCellBase[] Cells => null;

		public bool EnabledFlag
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

		public void Initialize(Canvas canvas)
		{
		}

		public virtual void Load()
		{
		}

		protected void Create<T>(List<T> data)
		{
		}

		private void Clear()
		{
		}

		private void Update()
		{
		}

		public Vector3 GetNowPoint()
		{
			return default(Vector3);
		}

		public Vector3 GetNowPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		public void SetTopElement(int topElement)
		{
		}

		private void SetRotation(float rot)
		{
		}

		public void OnClickButtonLeft()
		{
		}

		public void OnClickButtonRight()
		{
		}

		private bool IsDown()
		{
			return default(bool);
		}

		private bool IsFlickLeft()
		{
			return default(bool);
		}

		private bool IsFlickRight()
		{
			return default(bool);
		}

		private bool IsUp()
		{
			return default(bool);
		}

		private bool IsDrag()
		{
			return default(bool);
		}

		private bool IsPress()
		{
			return default(bool);
		}

		private bool IsTouchGuard()
		{
			return default(bool);
		}
	}
}
