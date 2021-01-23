/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactReliabilitySlider : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Slider afterSlider;
		public Slider slider;
		public UnityEngine.UI.Text reliabilityParamText;
		public UnityEngine.UI.Text levelText;
		[Header]
		[SerializeField]
		public GameObject normalStateGO;
		public GameObject maxStateGO;
		[SerializeField]
		private UnityEngine.UI.Text overText;
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
	
		// Nested types
		private enum DragonUnitType
		{
			Dragon = 1,
			Warker = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public int lastVal;
			public ContactReliabilitySlider __4__this;
			public Action<int> onAllCompleted;
			public int carry;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _AddPulse_b__0(float x);
			internal void _AddPulse_b__1();
		}
	
		// Constructors
		public ContactReliabilitySlider();
	
		// Methods
		public int GetCurrentLevel();
		public int GetMaxLevel();
		public int GetCurrentValue();
		public void InitFromDragonId(int dragonId);
		public void AddPulse(int value, float digestionTime, Action<int> onAllCompleted, int carry, int targetLevel);
		private void AdjustSlider();
		private void AdjustAfterSlider();
		public void SetAfterSlider(int incremental);
		private void SetReliabilityText(int nowReliability, int nextReliability);
		public int GetCurrentReliabilityIndex(int level);
		private DragonReliabilityLevelElement GetDragonReliabilityElement(int level);
	}
}
