/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using Gluon.Event;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampUIInGame : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
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
		[Header]
		[SerializeField]
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
		[Tooltip]
		private int StampBaseSortingOrder;
		[SerializeField]
		[Tooltip]
		private int StampButtonSortingOrder;
		private const int MaxNumIcon = 8;
		private const int MaxPage = 3;
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
		private SimpleQueue<LoadData> loadQue;
		private LoadData loadData;
		private LoadStat loadStat;
	
		// Nested types
		private class LoadData : IReplicable<LoadData>, ICleanable
		{
			// Fields
			public int id;
			public Action<Material> onLoaded;
	
			// Constructors
			public LoadData();
	
			// Methods
			public void Replicate(LoadData other);
			public void Clean();
		}
	
		public enum LoadStat
		{
			None = 0,
			Loading = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<Transform> __9__50_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _DisplayIcon_b__50_0(Transform x, Transform y);
		}
	
		// Constructors
		public StampUIInGame();
	
		// Methods
		public static StampUIInGame Create(GameObject parent, int siblingIndex = -1);
		public void Initialize();
		public override void FastUpdate();
		private void UpdatePosition();
		private void OnClickIcon(int id);
		private void OnClickStamp(int id);
		public void DisplayIcon(int playerIndex, int id, bool callbakFlag = true);
		public void DisplayStamp(int playerIndex, int id);
		private void EntryLoadData(int id, Action<Material> onLoaded);
		private void OnLoaded(Material mtrl);
		private void OnLoadedButton(GameObject go);
		private string GetStampPath(int stampId);
		private void OnUpdateMoveIn(float value);
		private void OnCompleteMoveIn();
		private void OnUpdateMoveOut(float value);
		private void OnCompleteMoveOut();
		private void HideImmediate();
		private void Interact(bool interact);
		private void OnClickButton();
		public void AddListenerOnClickButton(ref Button _button);
		public void OnClickBG();
		public void Close();
		public void StampUIPosition(Vector2 pos);
		public RectTransform GetStampButtonTrans();
		public void SetButtonActive(bool b);
		public void SetActive(bool b);
		[CompilerGenerated]
		private bool _Initialize_b__45_0(RectTransform x);
	}
}
