using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FooterIcon : MonoBehaviour
	{
		public Image normalBg;

		public Image normalIcon;

		public Image normalTextImage;

		public Image[] selectedImages;

		public Image selectedTextImage;

		public Image disabledBg;

		public Image disabledIcon;

		public Image disabledTextImage;

		public Image maintenanceObject;

		public Image[] banner;

		public PointerEventHandler transparentButton;

		public Image[] newMarks;

		[HideInInspector]
		public GameObject badge;

		private bool isSelected;

		private bool isEnabled;

		private int currentBannerId;

		private List<int> currentBannerIdList;

		private bool isAlreadyInitialized;

		private bool isOnTempoaryDisabled;

		private Sequence sequence;

		private float disableValue;

		private static float disableAnimationDuration;

		private static float disableWaitDuration;

		private static float disableSaturation;

		private static float disableBrightness;

		private Sequence summonIconSeq;

		private int currentMaterialIndex;

		private Material[] materials;

		private bool isMultipleSummon;

		private const float multipleSummonIconChangeTime = 2.5f;

		private bool isNewMarkMaterialsCreated;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetAdjustMaterial(Material changeableMaterial, Material disabledMaterial, Material selectedMaterial, Material selectedTextMaterial)
		{
		}

		public void SetBadgeMaterial()
		{
		}

		public void SetSelected(bool isSelected, bool forceReset = false)
		{
		}

		public bool GetSelected()
		{
			return default(bool);
		}

		public bool ShowSummonBanner(SummonDataElement data)
		{
			return default(bool);
		}

		public bool ShowSummonBanners(List<SummonDataElement> bannerData)
		{
			return default(bool);
		}

		private void SetBanner(int index)
		{
		}

		public void HideSummonBanner()
		{
		}

		public void DisableTemporary()
		{
		}

		public void SetTouched(bool isTouched)
		{
		}

		public void SetEnabled(bool isEnabled)
		{
		}

		private IEnumerator SetEnabledCoroutine(bool isEnabled)
		{
			return null;
		}

		private void SetEnabledImpl(bool isEnabled)
		{
		}

		private void CreateNewMarkMaterial()
		{
		}

		private void SetNewMarksEnabled(bool isEnabled)
		{
		}

		private void SetBannerEnabled(bool isEnabled)
		{
		}

		private void SetBadgeEnabled(bool isEnabled)
		{
		}

		public void KickAnimation()
		{
		}
	}
}
