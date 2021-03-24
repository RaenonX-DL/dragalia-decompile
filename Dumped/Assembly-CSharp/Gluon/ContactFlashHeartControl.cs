/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactFlashHeartControl : MonoBehaviour
	{
		// Fields
		private const string singleHeartEmotionPath = "Prefabs/OutGame/DragonContact/FlashEffect/pf_dragon_emotion_note_1";
		private const string FourHeartEmotionPath = "Prefabs/OutGame/DragonContact/FlashEffect/pf_dragon_emotion_note_2";
		private const string SixHeartEmotionPath = "Prefabs/OutGame/DragonContact/FlashEffect/pf_dragon_emotion_note_3";
		private FlashPlayer flashPlayer;
		private int containingHeartCount;
		private ContactReliabilitySlider reliabilitySlider;
		private int arrivalCount;
		private SingleHeartSetting[] hearSettings;
		private int carry;
		private Action<int> onAllCompleted;
		private int targetLevel;
		private Action onTargetHitByAnyHeart;
		private bool motionKilled;
		private const int cameraReturnTimingIndex = 3;
	
		// Nested types
		public enum HeartCountType
		{
			Three = 0,
			Four = 1,
			Six = 2
		}
	
		private class SingleHeartSetting
		{
			// Fields
			public int carryingReliability;
	
			// Constructors
			public SingleHeartSetting();
		}
	
		// Constructors
		public ContactFlashHeartControl();
	
		// Methods
		private void OnHeartArrive(int index);
		public void Setup(FlashPlayerManager flashPlayerManager, HeartCountType type, Transform attachTo, ContactReliabilitySlider reliabilitySlider);
		public void PlayEffect(int carry, Action<int> onAllCompleted, int targetLevel, Action onTargetHitByAnyHeart);
		public void Stop();
		[CompilerGenerated]
		private void _Setup_b__17_0();
		[CompilerGenerated]
		private void _Setup_b__17_1();
		[CompilerGenerated]
		private void _Setup_b__17_2();
		[CompilerGenerated]
		private void _Setup_b__17_3();
		[CompilerGenerated]
		private void _Setup_b__17_4();
		[CompilerGenerated]
		private void _Setup_b__17_5();
	}
}
