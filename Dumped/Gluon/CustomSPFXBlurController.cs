using UnityEngine;

namespace Gluon
{
	public class CustomSPFXBlurController : FixedImageEffect
	{
		public enum BlurSampleLabel
		{
			Sample3,
			Sample5,
			Sample7,
			Sample9
		}

		public const float minDebugPower = 0f;

		public const float maxDebugPower = 10f;

		private static readonly string[] BlurSamplingCountKeywords;

		[Header("Radial blur")]
		public Material CopyMaterial;

		public Material BlurMaterial;

		private Vector3 BlurOffset;

		private float BlurTimeLength;

		private float BlurTime;

		private float BlurStrength;

		private BlurSampleLabel BlurSample;

		private AnimationCurve BlurPowerCurve;

		private float BlurPower;

		private float BlurAttenuation;

		[Header("Camera Motion blur")]
		public Material MotionBlurMaterial;

		public bool EnableMotionBlur;

		public float movementScale;

		public float rotationScale;

		public float MaxVelocity;

		public float MinVelocity;

		public float VelocityScale;

		private Camera RefCamera;

		private int ParametersID;

		private int BlurPowerID;

		private int BlurAttenuationID;

		private int MaxVelocityID;

		private int MinVelocityID;

		private int VelocityScaleID;

		private int BlurDirectionPackedID;

		private Vector3 BlurPosition;

		private GameObject BlurTarget;

		private bool IsBlurFollow;

		private int PrevFrameCount;

		private Vector3 PrevFrameForward;

		private Vector3 PrevFrameUp;

		private Vector3 PrevFramePos;

		public bool isBlurPlaying => default(bool);

		protected override void Awake()
		{
		}

		private void Remember()
		{
		}

		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
		{
			return default(bool);
		}

		public void OnRenderImageRadialBlur(RenderTexture src, RenderTexture dst)
		{
		}

		public void OnRenderImageCameraMotionBlur(RenderTexture src, RenderTexture dst)
		{
		}

		public void SetRadialBlur(GameObject Target, bool IsFollow, Vector3 Offset, float Time, float Strength, BlurSampleLabel Sample, AnimationCurve PowerCurve, float Power, float Attenuation)
		{
		}

		public void ResetRadialBlur(GameObject Target)
		{
		}
	}
}
