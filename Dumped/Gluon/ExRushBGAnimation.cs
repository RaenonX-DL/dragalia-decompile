using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ExRushBGAnimation : MonoBehaviour
	{
		[SerializeField]
		[Header("ScrollingObjs")]
		public Image[] bgScrollTexts;

		public Image[] bgScrollSquares;

		[SerializeField]
		[Header("ScanLine")]
		public GameObject bgLine;

		[SerializeField]
		[Header("Circles")]
		public GameObject[] bgCircle01;

		public GameObject[] bgCircle01Small;

		public GameObject[] bgCircle01B;

		public GameObject[] bgCircle02;

		public GameObject[] bgCircle02B;

		public GameObject[] bgCircle03;

		public GameObject[] bgCircle04;

		public CanvasGroup[] bgCircle06;

		public CanvasGroup[] bgCircle06B;

		[SerializeField]
		[Header("Parameters")]
		public float bgSquareScrollSpeedX;

		public float bgSquareScrollSpeedY;

		public float bgTextScrollSpeedY;

		public float bgCircle01Speed;

		public float bgCircle01SmallSpeed;

		public float bgCircle01BSpeed;

		public float bgCircle02Speed;

		public float bgCircle02BSpeed;

		public float bgCircle03Speed;

		public float bgCircle04Speed;

		[SerializeField]
		[Header("Intervals")]
		public float BgCircle02BInterval;

		public float BgCircle03Interval;

		private Material newBGScrollMat;

		private Material newBGSquareMat;

		private float oriLinePosY;

		private Coroutine enableCoroutine;

		private List<Tweener> runningTweeners;

		private List<Sequence> runningSequences;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private IEnumerator EnableCoroutine()
		{
			return null;
		}
	}
}
