/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StorySettings : MonoBehaviour
	{
		// Fields
		[Header]
		public Setting[] settings;
		[Header]
		[Header]
		[SerializeField]
		public float showOneLetterInterval;
		[Header]
		[SerializeField]
		public float showMonologueOneLineInterval;
		[Header]
		[SerializeField]
		public float hideMonologueSeconds;
		[Header]
		[SerializeField]
		public float rubyUpCoefficient;
		[Header]
		[SerializeField]
		public float rubySizeCoefficient;
		[Header]
		[SerializeField]
		public float outlineRubyUpCoefficient;
		[Header]
		[SerializeField]
		public float outlineRubySizeCoefficient;
		[Header]
		[SerializeField]
		public float autoWaitTime;
		[Header]
		[SerializeField]
		public float autoWaitTimeForVoice;
		[Header]
		[SerializeField]
		public float autoWaitTimeForNextPage;
		[Header]
		[SerializeField]
		public float[] addAutoWaitTimeByLineCount;
		[Header]
		[SerializeField]
		public float windowFadeinTimeForPrintCommand;
		[Header]
		[SerializeField]
		public float windowFadeTimeWithAnimation;
	
		// Nested types
		public enum SettingPattern
		{
			None = -1,
			DoubleByteCharacter = 0,
			SingleByteCharacter = 1,
			Max = 2
		}
	
		[Serializable]
		public class Setting
		{
			// Fields
			[Header]
			[SerializeField]
			public float messageAdjustBaseHeight;
			[Header]
			[SerializeField]
			public int messageLineMax;
			[Header]
			[SerializeField]
			public float messageLineHeightDiff;
			[Header]
			[SerializeField]
			public float monologueAdjustBaseHeight;
			[Header]
			[SerializeField]
			public int monologueLineMax;
			[Header]
			[SerializeField]
			public float monologueLineHeightDiff;
			[Header]
			[SerializeField]
			public float outlineAdjustBaseHeight;
			[Header]
			[SerializeField]
			public int outlineLineMax;
			[Header]
			[SerializeField]
			public float outlineLineHeightDiff;
			[Header]
			[SerializeField]
			public float bookTextAdjustBaseHeight;
			[Header]
			[SerializeField]
			public int bookTextLineMax;
			[Header]
			[SerializeField]
			public float bookTextLineHeightDiff;
			[Header]
			[SerializeField]
			public int nameLineLetterMax;
			[Header]
			[SerializeField]
			public int messageLineLetterMax;
			[Header]
			[SerializeField]
			public int monologueLineLetterMax;
			[Header]
			[SerializeField]
			public Vector2[] chapterIntroductionTextsParentsBasePos;
	
			// Constructors
			public Setting();
	
			// Methods
			public void ReflectionSetting();
		}
	
		// Constructors
		public StorySettings();
	
		// Methods
		public static SettingPattern GetSettingPattern();
		public void ReflectionSetting();
	}
}
