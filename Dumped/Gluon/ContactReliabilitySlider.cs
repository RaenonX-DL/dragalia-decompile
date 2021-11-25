using System;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ContactReliabilitySlider : MonoBehaviour
	{
		private enum DragonUnitType
		{
			Dragon = 1,
			Warker
		}

		[SerializeField]
		[Header("Slider")]
		public Slider afterSlider;

		public Slider slider;

		public Text reliabilityParamText;

		public Text levelText;

		[SerializeField]
		[Header("OnOff")]
		public GameObject normalStateGO;

		public GameObject maxStateGO;

		[SerializeField]
		private Text overText;

		public float defaultDigestionTime;

		public Ease digestionEase;

		[HideInInspector]
		public bool isSending;

		private int currentValue;

		private int afterValue;

		[HideInInspector]
		public int overValue;

		private int totalMaxValue;

		private int maxLevel;

		private int currentLevel;

		[HideInInspector]
		public int afterLevel;

		private DragonUnitType dragonUnitType;

		public int GetCurrentLevel()
		{
			return default(int);
		}

		public int GetMaxLevel()
		{
			return default(int);
		}

		public int GetCurrentValue()
		{
			return default(int);
		}

		public void InitFromDragonId(int dragonId)
		{
		}

		public void AddPulse(int value, float digestionTime, Action<int> onAllCompleted, int carry, int targetLevel)
		{
		}

		private void AdjustSlider()
		{
		}

		private void AdjustAfterSlider()
		{
		}

		public void SetAfterSlider(int incremental)
		{
		}

		private void SetReliabilityText(int nowReliability, int nextReliability)
		{
		}

		public int GetCurrentReliabilityIndex(int level)
		{
			return default(int);
		}

		private DragonReliabilityLevelElement GetDragonReliabilityElement(int level)
		{
			return null;
		}
	}
}
