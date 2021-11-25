using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonIconListBase : MonoBehaviour
	{
		public UnityAction<CommonIconListCellData, TableViewCell<CommonIconListCellData>> listButtonCallBack;

		public UnityAction<CommonIconListCellData, TableViewCell<CommonIconListCellData>> listButtonLongPressCallBack;

		public UnityAction outButtonCallBack;

		public UnityAction outButtonLongPressCallBack;

		[SerializeField]
		[Header("Count")]
		public Text countText;

		public bool isShowListCount;

		[HideInInspector]
		public CommonSortButton sortButton;

		[SerializeField]
		[Header("Sort (leave blank for common use)")]
		public Transform sortButtonPlaceHolder;

		public UnityAction onSortButtonClicked;

		public bool isShowSortButton;

		public bool isDisableAutoLoadSortButton;

		[SerializeField]
		private GameObject countTextGameObject;

		public virtual void Awake()
		{
		}

		public void SetCountTextActive(bool active)
		{
		}

		public virtual void SetupCountText(int nowCount, int maxCount)
		{
		}

		public virtual void SetupCountText(int nowCount)
		{
		}

		public virtual void SetupCharaCountText(int nowCount)
		{
		}

		public void SetupSkillCountText(int nowCount)
		{
		}

		public void SetupAmuletCountText(int nowCount)
		{
		}

		public void OnSortButtonClicked()
		{
		}

		public void SetSortButtonActive(bool isActive)
		{
		}

		public void LoadSortButton()
		{
		}

		public bool IsLoadedSortButton()
		{
			return default(bool);
		}
	}
}
