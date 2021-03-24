/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class ShaderParamData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		public ShaderParamFloatArrayData shaderParamFloatArrayData;
		[HideInInspector]
		[SerializeField]
		public ShaderParamColorArrayData shaderParamColorArrayData;
		[HideInInspector]
		[SerializeField]
		public ShaderParamVector3ArrayData shaderParamVector3ArrayData;
		[HideInInspector]
		[SerializeField]
		public ShaderParamHSVArrayData shaderParamHSVArrayData;
	
		// Nested types
		[Flags]
		public enum ResetFlags
		{
			Stop = 1,
			Finish = 2,
			Clear = 4
		}
	
		public abstract class ShaderParamBase
		{
			// Fields
			public string propertyName;
			public bool isEnable;
			public bool isLoop;
			public ResetFlags resetFlags;
			[CompilerGenerated]
			private int _propertyID_k__BackingField;
	
			// Properties
			public int propertyID { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			protected ShaderParamBase();
	
			// Methods
			public virtual void Initialize();
		}
	
		[Serializable]
		public class ShaderParamFloat : ShaderParamBase
		{
			// Fields
			public AnimationCurve curveF;
			public float resetValue;
	
			// Constructors
			public ShaderParamFloat();
		}
	
		[Serializable]
		public class ShaderParamColor : ShaderParamBase
		{
			// Fields
			public Gradient gradient;
			public float startTime;
			public float endTime;
			public Color resetColor;
	
			// Constructors
			public ShaderParamColor();
		}
	
		[Serializable]
		public class ShaderParamVector3 : ShaderParamBase
		{
			// Fields
			public AnimationCurve curveX;
			public AnimationCurve curveY;
			public AnimationCurve curveZ;
			public Vector3 resetVector;
	
			// Constructors
			public ShaderParamVector3();
		}
	
		[Serializable]
		public class ShaderParamHSV : ShaderParamBase
		{
			// Fields
			public AnimationCurve curveHue;
			public AnimationCurve curveSaturation;
			public AnimationCurve curveValue;
			public float resetHue;
			public float resetSaturation;
			public float resetValue;
	
			// Constructors
			public ShaderParamHSV();
		}
	
		[Serializable]
		public class ShaderParamArrayBase<T>
		{
			// Fields
			[SerializeField]
			protected T[] dataArray;
	
			// Constructors
			public ShaderParamArrayBase();
	
			// Methods
			protected virtual void SetPropertyToBlockList(float totalTime, T data, List<MaterialPropertyData> materialPropertyDataList);
			protected virtual void SetResetPropertyToBlockList(T data, List<MaterialPropertyData> materialPropertyDataList);
			public virtual void Initialize();
			protected float GetCurveValue(float totalTime, AnimationCurve curve, bool isLoop);
			protected Color GetGradientValue(float totalTime, Gradient gradient, bool isLoop, float gradientStartTime, float gradientEndTime);
			public void SetAllPropertyToBlockList(float totalTime, List<MaterialPropertyData> materialPropertyDataList);
			public void SetResetPropertyToBlockList(List<MaterialPropertyData> materialPropertyDataList, ResetFlags resetFlag);
		}
	
		[Serializable]
		public class ShaderParamFloatArrayData : ShaderParamArrayBase<ShaderParamFloat>
		{
			// Constructors
			public ShaderParamFloatArrayData();
	
			// Methods
			private void SetPropertyValue(List<MaterialPropertyData> materialPropertyDataList, int propertyID, float value);
			protected override void SetPropertyToBlockList(float totalTime, ShaderParamFloat data, List<MaterialPropertyData> materialPropertyDataList);
			protected override void SetResetPropertyToBlockList(ShaderParamFloat data, List<MaterialPropertyData> materialPropertyDataList);
		}
	
		[Serializable]
		public class ShaderParamColorArrayData : ShaderParamArrayBase<ShaderParamColor>
		{
			// Constructors
			public ShaderParamColorArrayData();
	
			// Methods
			private void SetPropertyValue(List<MaterialPropertyData> materialPropertyDataList, int propertyID, Color value);
			protected override void SetPropertyToBlockList(float totalTime, ShaderParamColor data, List<MaterialPropertyData> materialPropertyDataList);
			protected override void SetResetPropertyToBlockList(ShaderParamColor data, List<MaterialPropertyData> materialPropertyDataList);
		}
	
		[Serializable]
		public class ShaderParamVector3ArrayData : ShaderParamArrayBase<ShaderParamVector3>
		{
			// Constructors
			public ShaderParamVector3ArrayData();
	
			// Methods
			private void SetPropertyValue(List<MaterialPropertyData> materialPropertyDataList, int propertyID, Vector4 value);
			protected override void SetPropertyToBlockList(float totalTime, ShaderParamVector3 data, List<MaterialPropertyData> materialPropertyDataList);
			protected override void SetResetPropertyToBlockList(ShaderParamVector3 data, List<MaterialPropertyData> materialPropertyDataList);
		}
	
		[Serializable]
		public class ShaderParamHSVArrayData : ShaderParamArrayBase<ShaderParamHSV>
		{
			// Fields
			private static HSVParameterBase hsvBufferParameter;
	
			// Constructors
			public ShaderParamHSVArrayData();
			static ShaderParamHSVArrayData();
	
			// Methods
			private void SetPropertyValue(List<MaterialPropertyData> materialPropertyDataList, int propertyID, float hue, float saturation, float value);
			protected override void SetPropertyToBlockList(float totalTime, ShaderParamHSV data, List<MaterialPropertyData> materialPropertyDataList);
			protected override void SetResetPropertyToBlockList(ShaderParamHSV data, List<MaterialPropertyData> materialPropertyDataList);
		}
	
		// Constructors
		public ShaderParamData();
	
		// Methods
		public override void Initialize();
	}
}
