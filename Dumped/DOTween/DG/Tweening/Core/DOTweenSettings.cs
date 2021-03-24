/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core.Enums;
using UnityEngine;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Core
{
	public class DOTweenSettings : ScriptableObject
	{
		// Fields
		public const string AssetName = "DOTweenSettings";
		public bool useSafeMode;
		public float timeScale;
		public bool useSmoothDeltaTime;
		public float maxSmoothUnscaledTime;
		public RewindCallbackMode rewindCallbackMode;
		public bool showUnityEditorReport;
		public LogBehaviour logBehaviour;
		public bool drawGizmos;
		public bool defaultRecyclable;
		public AutoPlay defaultAutoPlay;
		public UpdateType defaultUpdateType;
		public bool defaultTimeScaleIndependent;
		public Ease defaultEaseType;
		public float defaultEaseOvershootOrAmplitude;
		public float defaultEasePeriod;
		public bool defaultAutoKill;
		public LoopType defaultLoopType;
		public SettingsLocation storeSettingsLocation;
		public bool showPlayingTweens;
		public bool showPausedTweens;
	
		// Nested types
		public enum SettingsLocation
		{
			AssetsDirectory = 0,
			DOTweenDirectory = 1,
			DemigiantDirectory = 2
		}
	
		// Constructors
		public DOTweenSettings();
	}
}
