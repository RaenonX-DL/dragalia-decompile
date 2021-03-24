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
	public class GrowthManaCircleEffectSettings : MonoBehaviour
	{
		// Fields
		public Vector3 pointOffsetHp;
		public Vector3 pointOffsetAtk;
		public Vector3 pointOffsetDef;
		public Vector3 pointOffsetAbiget;
		public Vector3 pointOffsetAbiup;
		public bool playRelaseLimitEffect;
		public float releaseLimitPointAfterPointReleaseDelay;
		public float pointChangeDelay;
		public Vector3 releaseAutoOffset;
		public float pointChangeAutoDelay;
		public float releaseAutoInterval;
		public float releaseAutoDelay;
		public Vector3 releaseAutoCameraOffset;
		public Vector3 releaseAutoCameraRotation;
		public float releaseAutoCameraFirstDelay;
		public float releaseAutoCameraFirstDuration;
		public float releaseAutoCameraSecondDelay;
		public float releaseAutoCameraSecondDuration;
		public float releaseAutoCameraThirdDelay;
		public float circleReleaseEffectDelay;
		public float releaseLimitVanishWaitingEffectDelay;
		public float releaseLimitPointDelay;
		public float releaseLimitFlyingDelay;
		public float releaseLimitObjectChangeDelay;
		public float releaseLimitLockObjectDelay;
		public Vector3 releaseLimitLockObjectPosition;
		public float releaseLimitLockObjectBreakDelay;
		public float releaseLimitLockObjectSoundDelay;
		public float releaseLimitLockObjectVanishDelay;
		public float releaseLimitLockObjectBreakEffectDelay;
		public float releaseLimitFlashDelay;
		public Vector3 releaseLimitCameraOffset;
		public Vector3 releaseLimitCameraRotation;
		public float releaseLimitCameraFirstDelay;
		public float releaseLimitCameraFirstDuration;
		public float releaseLimitCameraSecondDelay;
		public float releaseLimitCameraSecondDuration;
		public float releaseLimitCameraThirdDelay;
		public float allReleasePointDelay;
		public float allReleaseFlyingDelay;
		public float allReleaseManaCircleDelay;
		public float allReleaseCrystalChangeDelay;
		public float allReleaseCrystalDelay;
		public float allReleaseSpaceDelay;
		public Vector3 allReleaseCameraPosition;
		public Vector3 allReleaseCameraRotation;
		public float allReleaseCameraFirstDelay;
		public float allReleaseCameraFirstDuration;
		public float allReleaseCameraSecondDelay;
		public float allReleaseCameraSecondDuration;
		public float allReleaseFlashDelay;
		public float allReleaseKickEffectTriggerDelay;
		public float fogStartDistance;
		public float fogEndDistance;
		public float fogScreenSaverStartDistance;
		public float fogScreenSaverEndDistance;
		public Color fogColorFireNormal;
		public Color fogColorWaterNormal;
		public Color fogColorWindNormal;
		public Color fogColorLightNormal;
		public Color fogColorDarkNormal;
		public Color fogColorFireAll;
		public Color fogColorWaterAll;
		public Color fogColorWindAll;
		public Color fogColorLightAll;
		public Color fogColorDarkAll;
		public float firstEnterEffectFadeInTime;
		public float firstEnterEffectDelay;
		public float symbolEffectDelay;
		[NonSerialized]
		[HideInInspector]
		public GrowthManaCircleScene scene;
	
		// Constructors
		public GrowthManaCircleEffectSettings();
	
		// Methods
		private void OnValidate();
		public void Reset();
	}
}
