using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Http;
using DG.Tweening;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class EventRankingListCanvas : MonoBehaviour
	{
		public EventRankingListBase eventRankingListBase;

		public EventRankingListController eventRankingListController;

		public UnityAction cellButtonCallBack;

		public UnityAction backButtonCallBack;

		[SerializeField]
		private GameObject sliderObjRoot;

		[SerializeField]
		[Header("â\u0080»ã\u0082¹ã\u0082\u00afã\u0083­ã\u0083¼ã\u0083«ã\u0083\u0090ã\u0083¼ã\u0080\u0081ã\u0083\u009eã\u0083«ã\u0083\u0081ã\u0081®é\u00a0\u0086")]
		private Vector3 openDelayTime;

		[SerializeField]
		private Text rankRangeText;

		[SerializeField]
		private int rankingRangeFromTarget;

		private SceneUICanvas _sceneUiCanvas;

		private int currentDrumTopIndex;

		private int curTargetRank;

		private bool waitingForLoadingRankingUserAdditionalList;

		private int[,] sortRankRangeTable;

		public EventRankingListPage eventRankingPage
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

		public SceneUICanvas sceneUiCanvas
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private void Start()
		{
		}

		private void CellButtonPressed(EventRankingListCellData selectData)
		{
		}

		public void InitFortEnteringAnim()
		{
		}

		public void LoadRankingUserList()
		{
		}

		public void LoadRankingUserAdditionalList(bool isHigher = true)
		{
		}

		private IEnumerator WaitForLoadingRankingUserAdditionalListCoroutine(Vector2 scrollPos)
		{
			return null;
		}

		private void GetRankingList()
		{
		}

		private void GetDataOnSuccess(QuestGetSupportUserListResponse res)
		{
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}

		private void GetCurRankingRange(out int startRank, out int endRank)
		{
		}

		private int GetCurTargetRank()
		{
			return default(int);
		}

		private List<EventRankingListController.UserRanking> GetEventRankingList(int startRank, int endRank)
		{
			return null;
		}

		public void OnSortButtonPressed()
		{
		}

		private string GetRankRangeText(int startRank, int endRank)
		{
			return null;
		}

		public void CloseButtonPressed()
		{
		}

		public void OnOpen()
		{
		}

		public void OnClose()
		{
		}

		private void StartObjFadeAnim(GameObject obj, Ease easing, float startAlpha, float endAlpha, float duration, float delayTime)
		{
		}

		private void StartObjMoveYAnim(GameObject obj, Ease easing, float startRelativeY, float endRelativeY, float duration, float delayTime)
		{
		}
	}
}
