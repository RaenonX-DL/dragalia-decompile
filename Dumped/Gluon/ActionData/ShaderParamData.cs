using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ShaderParamData : ActionParts.PartsData
	{
		[Flags]
		public enum ResetFlags
		{
			Stop = 0x1,
			Finish = 0x2,
			Clear = 0x4
		}

		public abstract class ShaderParamBase
		{
			public string propertyName;

			public bool isEnable;

			public bool isLoop;

			public ResetFlags resetFlags;

			public int propertyID
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public virtual void Initialize()
			{
			}
		}

		[Serializable]
		public class ShaderParamFloat : ShaderParamBase
		{
			public AnimationCurve curveF;

			public float resetValue;
		}

		[Serializable]
		public class ShaderParamColor : ShaderParamBase
		{
			public Gradient gradient;

			public float startTime;

			public float endTime;

			public Color resetColor;
		}

		[Serializable]
		public class ShaderParamVector3 : ShaderParamBase
		{
			public AnimationCurve curveX;

			public AnimationCurve curveY;

			public AnimationCurve curveZ;

			public Vector3 resetVector;
		}

		[Serializable]
		public class ShaderParamHSV : ShaderParamBase
		{
			public AnimationCurve curveHue;

			public AnimationCurve curveSaturation;

			public AnimationCurve curveValue;

			public float resetHue;

			public float resetSaturation;

			public float resetValue;
		}

		[Serializable]
		public class ShaderParamArrayBase<T>
		{
			[SerializeField]
			protected T[] dataArray;

			protected virtual void SetPropertyToBlockList(float totalTime, T data, List<MaterialPropertyData> materialPropertyDataList)
			{
			}

			protected virtual void SetResetPropertyToBlockList(T data, List<MaterialPropertyData> materialPropertyDataList)
			{
			}

			public virtual void Initialize()
			{
			}

			protected float GetCurveValue(float totalTime, AnimationCurve curve, bool isLoop)
			{
				return default(float);
			}

			protected Color GetGradientValue(float totalTime, Gradient gradient, bool isLoop, float gradientStartTime, float gradientEndTime)
			{
				return default(Color);
			}

			public void SetAllPropertyToBlockList(float totalTime, List<MaterialPropertyData> materialPropertyDataList)
			{
			}

			public void SetResetPropertyToBlockList(List<MaterialPropertyData> materialPropertyDataList, ResetFlags resetFlag)
			{
			}
		}

		[Serializable]
		public class ShaderParamFloatArrayData : ShaderParamArrayBase<ShaderParamFloat>
		{
			private void SetPropertyValue(List<MaterialPropertyData> materialPropertyDataList, int propertyID, float value)
			{
			}

			protected override void SetPropertyToBlockList(float totalTime, ShaderParamFloat data, List<MaterialPropertyData> materialPropertyDataList)
			{
			}

			protected override void SetResetPropertyToBlockList(ShaderParamFloat data, List<MaterialPropertyData> materialPropertyDataList)
			{
			}
		}

		[Serializable]
		public class ShaderParamColorArrayData : ShaderParamArrayBase<ShaderParamColor>
		{
			private void SetPropertyValue(List<MaterialPropertyData> materialPropertyDataList, int propertyID, Color value)
			{
			}

			protected override void SetPropertyToBlockList(float totalTime, ShaderParamColor data, List<MaterialPropertyData> materialPropertyDataList)
			{
			}

			protected override void SetResetPropertyToBlockList(ShaderParamColor data, List<MaterialPropertyData> materialPropertyDataList)
			{
			}
		}

		[Serializable]
		public class ShaderParamVector3ArrayData : ShaderParamArrayBase<ShaderParamVector3>
		{
			private void SetPropertyValue(List<MaterialPropertyData> materialPropertyDataList, int propertyID, Vector4 value)
			{
			}

			protected override void SetPropertyToBlockList(float totalTime, ShaderParamVector3 data, List<MaterialPropertyData> materialPropertyDataList)
			{
			}

			protected override void SetResetPropertyToBlockList(ShaderParamVector3 data, List<MaterialPropertyData> materialPropertyDataList)
			{
			}
		}

		[Serializable]
		public class ShaderParamHSVArrayData : ShaderParamArrayBase<ShaderParamHSV>
		{
			private static HSVParameterBase hsvBufferParameter;

			private void SetPropertyValue(List<MaterialPropertyData> materialPropertyDataList, int propertyID, float hue, float saturation, float value)
			{
			}

			protected override void SetPropertyToBlockList(float totalTime, ShaderParamHSV data, List<MaterialPropertyData> materialPropertyDataList)
			{
			}

			protected override void SetResetPropertyToBlockList(ShaderParamHSV data, List<MaterialPropertyData> materialPropertyDataList)
			{
			}
		}

		[SerializeField]
		[HideInInspector]
		public ShaderParamFloatArrayData shaderParamFloatArrayData;

		[SerializeField]
		[HideInInspector]
		public ShaderParamColorArrayData shaderParamColorArrayData;

		[SerializeField]
		[HideInInspector]
		public ShaderParamVector3ArrayData shaderParamVector3ArrayData;

		[SerializeField]
		[HideInInspector]
		public ShaderParamHSVArrayData shaderParamHSVArrayData;

		public override void Initialize()
		{
		}
	}
}
