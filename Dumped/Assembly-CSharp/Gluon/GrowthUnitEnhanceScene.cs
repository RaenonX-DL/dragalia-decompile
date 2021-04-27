/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthUnitEnhanceScene : SceneBase
	{
		// Fields
		public static GrowthUnitEnhanceModel.DataType unitDataType;
		public static int targetUnitId;
		public Camera uiCamera;
		public Camera flashCamera;
		public Canvas bgCanvas;
		public Camera frontEffectCamera;
		public Camera backEffectCamera;
		public Transform overlayParent;
		public Camera render3dCamera;
		public GrowthWeaponObjectsSettings objectsSettings;
		public RawImageWithAlphaBlend modelViewImage;
		[HideInInspector]
		public TouchGuardObject uiLoadTouchGuard;
		[HideInInspector]
		public BackButton backButton;
		private GrowthUnitEnhanceMainCanvas unitEnhanceMainCanvas;
		private GrowthUnitEnhanceModel unitModel;
		[CompilerGenerated]
		private UnitDetailUnitShaderSettings _growthWeaponShaderSetting_k__BackingField;
		private static readonly string shaderSettingPath;
	
		// Properties
		public UnitDetailUnitShaderSettings growthWeaponShaderSetting { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private struct _SendWeaponEnhanceData_d__29 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthUnitEnhanceSendData[] sendDatas;
			public GrowthUnitEnhanceScene __4__this;
			public Action completeCallBack;
			private TaskAwaiter<WeaponBodyBuildupPieceResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _SendCrestEnhanceData_d__30 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthUnitEnhanceSendData[] sendDatas;
			public GrowthUnitEnhanceScene __4__this;
			public Action completeCallBack;
			private TaskAwaiter<AbilityCrestBuildupPieceResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _SendCrestPlusParamData_d__31 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int hpPlus;
			public int atkPlus;
			public GrowthUnitEnhanceScene __4__this;
			public Action completeCallBack;
			private TaskAwaiter<AbilityCrestBuildupPlusCountResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GrowthUnitEnhanceScene();
		static GrowthUnitEnhanceScene();
	
		// Methods
		private void Awake();
		private void Start();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		private void OnEnterScene();
		public void SetupModelViewImage(bool enableAlphaBlend);
		public static void SetupSceneByUnitId(int unitId);
		public override void OnPresentReceived();
		public void BackButtonPressed();
		public async void SendWeaponEnhanceData(GrowthUnitEnhanceSendData[] sendDatas, Action completeCallBack = null);
		public async void SendCrestEnhanceData(GrowthUnitEnhanceSendData[] sendDatas, Action completeCallBack = null);
		public async void SendCrestPlusParamData(int hpPlus, int atkPlus, Action completeCallBack = null);
		private void SetupFlashCamera();
		private void SetupRenderCamera();
	}
}
