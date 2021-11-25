using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class QuestSelectRouteArranger : MonoBehaviour
	{
		[SerializeField]
		private float _firstDotArrangeWait;

		private Dictionary<int, List<QuestSelectRoutePoint>> routePointListList;

		private Dictionary<int, int> waitFrameDic;

		private int _notImmediately;

		public UnityAction onEndArrangingRoutePoints;

		public UnityAction onStartArrangingRoutePoints;

		public UnityAction onReadyEndArrangingRoutePoints;

		public UnityAction onReadyStartArrangingRoutePoints;

		[SerializeField]
		private int defaultWaitFrame;

		private float _firstDotArrangeHastenTime;

		public float firstDotArrangeWait => default(float);

		public bool isSuccessivelyArrangeReady
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

		public int notImmediately
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float FirstDotArrangeHastenTime
		{
			set
			{
			}
		}

		private void Start()
		{
		}

		public void ClearPointList()
		{
		}

		public void AddToPointList(QuestSelectRoutePoint point, int index = 0)
		{
		}

		public void AddFrontToPointList(QuestSelectRoutePoint point, int index = 0)
		{
		}

		private void ArrangeActivateImmediatelyRoutePoints()
		{
		}

		public void StartArrangingRoutePoints(bool isWaitSuccessivelyArrangeReady)
		{
		}

		private IEnumerator ArrageEveryRoutePoint()
		{
			return null;
		}

		private IEnumerator DelayStartActivation(QuestSelectRoutePoint point, int delayFrame, bool flag)
		{
			return null;
		}

		private IEnumerator DelayStartActivation(QuestSelectRoutePoint point, float delayTime)
		{
			return null;
		}

		public int GetListCount()
		{
			return default(int);
		}

		public void SetSpecialWaitFrame(int index, int frame)
		{
		}
	}
}
