using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SupportButton : FastUpdateMonoBehaviour
	{
		public delegate void ButtonDelegate(SupportButton sender);

		private enum ButtonStep
		{
			Initialize,
			EnableFirst,
			EnableWait,
			Cutin,
			Recast,
			Empty
		}

		[SerializeField]
		[Header("component")]
		private Button button;

		[SerializeField]
		private SpriteRenderer imageBase;

		[SerializeField]
		private RectTransform imageInvalidObjRt;

		[SerializeField]
		private RectTransform offset;

		[SerializeField]
		private RectTransform[] countRt;

		[SerializeField]
		private GameObject shadow;

		[SerializeField]
		private SpriteRenderer noUseImage;

		[SerializeField]
		private SpriteRenderer effectImage;

		[SerializeField]
		[Header("parameter")]
		private float expansionTime;

		[SerializeField]
		private int flashCount;

		[SerializeField]
		private float flashTime;

		[SerializeField]
		private float maxFlashPower;

		private const int numCounter = 3;

		[HideInInspector]
		public RectTransform ownTransform;

		private int enableCount;

		private int restCount;

		private bool isActive;

		private bool validate;

		private bool isClonedMaterial;

		private Color noUseHideColor;

		private Tweener tweenerExpansion;

		private Tweener tweenerEffectFlash;

		private RectTransform effectRt;

		private const float tweenerExpansionEndValue = 1f;

		private bool isLeftFlag;

		private ButtonStep buttonStep;

		public static SupportButton Create(GameObject parent, int index, ButtonDelegate click, bool isLeft)
		{
			return null;
		}

		public void Initialize(ButtonDelegate func, bool isLeft)
		{
		}

		public void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		public bool SetImage(string skillName)
		{
			return default(bool);
		}

		public void Attach(RectTransform parentRT)
		{
		}

		public void Visible(bool b)
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void Validate(bool b)
		{
		}

		private bool IsFullRecastGauge()
		{
			return default(bool);
		}

		private void CheckInvalidObj()
		{
		}

		public Vector2 GetButtonPosition()
		{
			return default(Vector2);
		}

		public void SetCount(int n)
		{
		}

		private void StartExpansionEffect()
		{
		}

		private void OnUpdateExpansion(float value)
		{
		}

		private void OnCompleteExpansion()
		{
		}

		private void OnUpdateButtonEffectFlash(float value)
		{
		}
	}
}
