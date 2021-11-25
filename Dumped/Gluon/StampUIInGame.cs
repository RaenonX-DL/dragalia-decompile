using System;
using System.Collections.Generic;
using Cute.Core;
using DG.Tweening;
using Gluon.Event;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class StampUIInGame : FastUpdateMonoBehaviour
	{
		private class LoadData : IReplicable<LoadData>, ICleanable
		{
			public int id;

			public Action<Material> onLoaded;

			public void Replicate(LoadData other)
			{
			}

			public void Clean()
			{
			}
		}

		public enum LoadStat
		{
			None,
			Loading
		}

		[SerializeField]
		[Header("component")]
		private StampControllerIngame stampCtrl;

		[SerializeField]
		private GameObject backGround;

		[SerializeField]
		private Image panel0;

		[SerializeField]
		private RectTransform panel1;

		[SerializeField]
		private Button button;

		[SerializeField]
		private GameObject inactive;

		[SerializeField]
		private ChatIconUIIngame baseChatIcon;

		[SerializeField]
		private RectTransform adjustRt;

		[SerializeField]
		private RectTransform ofsRt;

		[SerializeField]
		private RectTransform stampButtonRt;

		[SerializeField]
		private RectMask2D rectMask;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private Image buttonImage;

		[SerializeField]
		private Sprite[] buttonSprite;

		[SerializeField]
		private GameObject colliderAreaParent;

		[SerializeField]
		[Header("parameter")]
		private float fadeTime;

		[SerializeField]
		private float stayTime;

		[SerializeField]
		private float minIntervalTime;

		[SerializeField]
		private float moveInTime;

		[SerializeField]
		private float moveOutTime;

		[SerializeField]
		private float bgWidthOffset;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082¿ã\u0083³ã\u0083\u0097å\u0085\u00a8ä½\u0093ã\u0081®æ\u008f\u008fç\u0094»é\u00a0\u0086")]
		private int StampBaseSortingOrder;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082¿ã\u0083³ã\u0083\u0097ã\u0083\u009cã\u0082¿ã\u0083³ã\u0081®æ\u008f\u008fç\u0094»é\u00a0\u0086")]
		private int StampButtonSortingOrder;

		private const int MaxNumIcon = 8;

		private const int MaxPage = 3;

		private VisibleUIObject rootVisible;

		private GameObject panel0Go;

		private GameObject panel1Go;

		private float width;

		private float iconInvalidTime;

		private float ofsHeight;

		private bool slideIn;

		private bool slideOut;

		private Tweener tweenerMove;

		private Stamp eventStamp;

		private UnityAction<int> onClickStamp;

		private Vector3 buttonInitialPosition;

		private RectTransform bgRt;

		private bool isSwap;

		private ChatIconUIIngame[] chatIconList;

		private List<Transform> workChatItemSortList;

		private Dictionary<int, int> displayingStampIdDicForPlayerNo;

		private Dictionary<CharacterBase, int> displayingStampIdDicForChara;

		private SimpleQueue<LoadData> loadQue;

		private LoadData loadData;

		private LoadStat loadStat;

		public static StampUIInGame Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		public void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdateStampButtonPosition()
		{
		}

		private void OnClickIcon(int id)
		{
		}

		private int GetPlayerNo()
		{
			return default(int);
		}

		private void OnClickStamp(int id)
		{
		}

		public void DisplayStamp(int playerIndex, int id, bool callbakFlag)
		{
		}

		public void DisplayStamp(int playerIndex, int id)
		{
		}

		public void HiddenStamp(int playerIndex)
		{
		}

		private void EntryLoadData(int id, Action<Material> onLoaded)
		{
		}

		private void OnLoaded(Material mtrl)
		{
		}

		private void OnLoadedButton(GameObject go)
		{
		}

		private string GetStampPath(int stampId)
		{
			return null;
		}

		private void OnUpdateMoveIn(float value)
		{
		}

		private void OnCompleteMoveIn()
		{
		}

		private void OnUpdateMoveOut(float value)
		{
		}

		private void OnCompleteMoveOut()
		{
		}

		private void HideImmediate()
		{
		}

		private void Interact(bool interact)
		{
		}

		private void OnClickButton()
		{
		}

		public void AddListenerOnClickButton(ref Button _button)
		{
		}

		public void OnClickBG()
		{
		}

		public void Close()
		{
		}

		public void SetButtonActive(bool b)
		{
		}

		public void SetActive(bool b)
		{
		}

		public void SetDisplayingStampId(CharacterBase chara, int stampId)
		{
		}

		public int GetDisplayingStampId(CharacterBase chara)
		{
			return default(int);
		}

		public bool IsDisplayingStamp(CharacterBase chara)
		{
			return default(bool);
		}
	}
}
