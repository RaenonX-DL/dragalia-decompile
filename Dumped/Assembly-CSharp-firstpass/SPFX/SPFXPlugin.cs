/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SPFX
{
	public class SPFXPlugin : SPFXPluginInterface
	{
		// Fields
		private const string PLUGIN_NAME = "SPFXUnityPlugin";
		public const CallingConvention CONVENTION = CallingConvention.Winapi;
	
		// Constructors
		public SPFXPlugin();
	
		// Methods
		private static extern IntPtr SPFX_PLUGIN_GetRenderingCallback();
		public IntPtr GetRenderingCallback();
		private static extern int SPFX_PLUGIN_Initialize(uint FileLoadCountPerOneFrame, uint MaxFileCount, uint MaxInstanceCount, uint UnitMemorySize, uint TemporaryMemorySize, uint DrawCommandMemorySize, uint VertexBufferSize, byte[] ShaderBinary, int ShaderBinarySize, int IsMultithreadUpdate, int IsGraphicsMultiThreaded, int IsReversedZBuffer, int IsAutoViewCullingOn, float AutoViewCullingSize, int IsAutoDistanceClipEnable, float AutoViewDistanceClipDistance, int IsEnableCommunicator);
		public InitializeErrorCode Initialize(uint FileLoadCountPerOneFrame, uint MaxFileCount, uint MaxInstanceCount, uint UnitMemorySize, uint TemporaryMemorySize, uint DrawCommandMemorySize, uint VertexBufferSize, byte[] ShaderBinary, bool IsMultithreadUpdate, bool IsGraphicsMultiThreaded, bool IsReversedZBuffer, bool IsAutoViewCullingOn, float AutoViewCullingSize, bool IsAutoDistanceClipEnable, float AutoViewDistanceClipDistance, bool IsEnableCommunicator);
		private static extern void SPFX_PLUGIN_Uninitialize();
		public void Uninitialize();
		private static extern bool SPFX_PLUGIN_IsTryRendering(int DrawLayerFlags, int CullingMask, int IsProjectionMapping);
		public bool IsTryRendering(int DrawLayerFlags, int CullingMask, bool IsProjectionMapping);
		private static extern void SPFX_PLUGIN_ForceUpdate();
		public void ForceUpdate();
		private static extern IntPtr SPFX_PLUGIN_GetVersionString();
		public string GetVersionString();
		private static extern void SPFX_PLUGIN_SetLowSpecMode(int IsLowSpecMode);
		public void SetLowSpecMode(bool IsLowSpecMode);
		private static extern int SPFX_PLUGIN_GetLowSpecMode();
		public bool GetLowSpecMode();
		private static extern uint SPFX_PLUGIN_GetResourceLoaderQueueCount();
		public uint GetResourceLoaderQueueCount();
		private static extern void SPFX_PLUGIN_SetGroundHeight(float Height);
		public void SetGroundHeight(float Height);
		private static extern void SPFX_PLUGIN_SetZSortEnable(int Layer, int IsEnabled);
		public void SetZSortEnable(int Layer, bool IsEnabled);
		private static extern void SPFX_PLUGIN_SetDrawParameter(int CameraID, ref DRAWPARAMETER Parameter);
		public void SetDrawParameter(int CameraID, DRAWPARAMETER Parameter);
		private static extern void SPFX_PLUGIN_Update(float DeltaTime, ref MATRIX4x4 CameraMatrix);
		public void Update(float DeltaTime, MATRIX4x4 CameraMatrix);
		private static extern IntPtr SPFX_PLUGIN_Instance_Create(byte[] FileName, byte[] ResourceAddress, int ResourceLength, int InstanceID, int UniqueParam, IntPtr[] TextureInfo, int TextureInfoCount, int IsSharedResource);
		public IntPtr CreateInstance(byte[] FileName, byte[] BytesData, int InstanceID, int UniqueParam, IntPtr[] TextureInfo, bool IsSharedResource);
		private static extern void SPFX_PLUGIN_Instance_Delete(IntPtr Handle);
		public void ReleaseInstance(IntPtr Handle);
		private static extern void SPFX_PLUGIN_DeleteAllInstanceAndResource();
		public void ReleaseInstanceAll();
		private static extern uint SPFX_PLUGIN_Instance_GetSystemMemory(IntPtr Handle);
		public uint GetSystemMemory(IntPtr Handle);
		private static extern uint SPFX_PLUGIN_Instance_GetVideoMemory(IntPtr Handle);
		public uint GetVideoMemory(IntPtr Handle);
		private static extern int SPFX_PLUGIN_Instance_GetStatus(IntPtr Handle);
		public eFileStatus GetStatus(IntPtr Handle);
		private static extern void SPFX_PLUGIN_Instance_Play(IntPtr Handle, int StartFrame);
		public void Play(IntPtr Handle, int StartFrame);
		private static extern void SPFX_PLUGIN_Instance_Stop(IntPtr Handle);
		public void Stop(IntPtr Handle);
		private static extern void SPFX_PLUGIN_Instance_Pause(IntPtr Handle);
		public void Pause(IntPtr Handle);
		private static extern int SPFX_PLUGIN_Instance_IsPlaying(IntPtr Handle);
		public PlayingStatus IsPlaying(IntPtr Handle);
		private static extern void SPFX_PLUGIN_Instance_SetUpdateStopAtHide(IntPtr Handle, int IsUpdateStopAtHide);
		public void SetUpdateStopAtHide(IntPtr Handle, bool IsUpdateStopAtHide);
		private static extern void SPFX_PLUGIN_Instance_SetViewCullingBoundingSphere(IntPtr Handle, int IsViewCulling, float Radius);
		public void SetViewCullingBoundingSphere(IntPtr Handle, bool IsViewCulling, float Radius);
		private static extern void SPFX_PLUGIN_Instance_SetCullingMask(IntPtr Handle, int Mask);
		public void SetCullingMask(IntPtr Handle, int Mask);
		private static extern void SPFX_PLUGIN_Instance_SetDrawLayer(IntPtr Handle, int Layer);
		public void SetDrawLayer(IntPtr Handle, eDrawLayer Layer);
		private static extern void SPFX_PLUGIN_Instance_SetDrawPriority(IntPtr Handle, int Priority);
		public void SetDrawPriority(IntPtr Handle, int Priority);
		private static extern void SPFX_PLUGIN_Instance_SetDepthBiasOffset(IntPtr Handle, float Offset);
		public void SetDepthBiasOffset(IntPtr Handle, float Offset);
		private static extern void SPFX_PLUGIN_Instance_SetDepthBiasScale(IntPtr Handle, float Scale);
		public void SetDepthBiasScale(IntPtr Handle, float Scale);
		private static extern void SPFX_PLUGIN_Instance_SetFogInfluence(IntPtr Handle, float Influence);
		public void SetFogInfluence(IntPtr Handle, float Influence);
		private static extern int SPFX_PLUGIN_Instance_KickTrigger(IntPtr Handle, int Trigger);
		public bool KickTrigger(IntPtr Handle, int Trigger);
		private static extern void SPFX_PLUGIN_Instance_SetLabelTexture(IntPtr handle, string Label, IntPtr Texture, int MipCount);
		public void SetLabelTexture(IntPtr handle, string Label, Texture Texture, int MipCount);
		private static extern void SPFX_PLUGIN_Instance_SetShow(IntPtr Handle, int Index, int IsShow);
		public void SetShow(IntPtr Handle, int Index, bool IsShow);
		private static extern void SPFX_PLUGIN_Instance_SetTransform(IntPtr Handle, float[] WorldMatrix);
		public void SetTransform(IntPtr Handle, float[] WorldMatrix);
		private static extern void SPFX_PLUGIN_Instance_SetTargetTransform(IntPtr Handle, float[] WorldMatrix);
		public void SetTargetTransform(IntPtr Handle, float[] WorldMatrix);
		private static extern void SPFX_PLUGIN_Instance_SetColor(IntPtr Handle, float r, float g, float b, float a);
		public void SetColor(IntPtr Handle, float r, float g, float b, float a);
		private static extern void SPFX_PLUGIN_Instance_SetSpeed(IntPtr Handle, float Speed);
		public void SetSpeed(IntPtr Handle, float Speed);
		private static extern void SPFX_PLUGIN_SetFogParameters(int Type, float Density, float StartDistance, float EndDistance, float R, float G, float B);
		public void SetFogParameters(int Type, float Density, float StartDistance, float EndDistance, float R, float G, float B);
		private static extern void SPFX_PLUGIN_Instance_SetPolylineManyPointBindData(IntPtr Handle, VECTOR3[] Points, VECTOR3[] Normals, int Count);
		public void SetPolylineManyPointBindData(IntPtr Handle, Transform[] Points, Vector3 Rotation);
		private static extern int SPFX_PLUGIN_Instance_GetBoundingSphere(IntPtr Handle, ref BOUNDINGSPHERE Sphere);
		public bool GetBoundingSphere(IntPtr Handle, ref BOUNDINGSPHERE Sphere);
		private static extern void SPFX_PLUGIN_GetMemoryInfo(ref MemoryInfo Info);
		public void GetMemoryInfo(ref MemoryInfo Info);
		private static extern void SPFX_PLUGIN_EnableUnityCollision(int IsEnable);
		public void EnableUnityCollision(bool IsEnable);
		private static extern IntPtr SPFX_PLUGIN_GetCollisionData(ref COLLISIONDATA Parameter);
		public IntPtr GetCollisionData(ref COLLISIONDATA Parameter);
		private static extern void SPFX_PLUGIN_EndCollisionData(IntPtr Unique, int IsHit, ref COLLISIONDATA Parameter);
		public void EndCollisionData(IntPtr Unique, bool IsHit, ref COLLISIONDATA Parameter);
		private static extern void SPFX_PLUGIN_EnableSoundCallback(int IsEnable);
		public void EnableSoundCallback(bool IsEnable);
		private static extern IntPtr SPFX_PLUGIN_GetSoundData(ref SOUNDDATA Parameter);
		public IntPtr GetSoundData(ref SOUNDDATA Parameter);
		private static extern void SPFX_PLUGIN_EndSoundData(IntPtr Unique);
		public void EndSoundData(IntPtr Unique);
		private static extern void SPFX_PLUGIN_EnableEventCallback(int IsEnable);
		public void EnableClipEventCallback(bool IsEnable);
		private static extern IntPtr SPFX_PLUGIN_GetClipEventData(ref CLIPEVENTDATA Parameter);
		public IntPtr GetClipEventData(ref CLIPEVENTDATA Parameter);
		private static extern void SPFX_PLUGIN_EndClipEventData(IntPtr Unique);
		public void EndClipEventData(IntPtr Unique);
		private static extern void SPFX_PLUGIN_EnablePositionNotificationCallback(int IsEnable);
		public void EnablePositionNotificationCallback(bool IsEnable);
		private static extern IntPtr SPFX_PLUGIN_GetPositionNotificationData(ref POSITIONNOTIFICATION_DATA Parameter);
		public IntPtr GetPositionNotificationData(ref POSITIONNOTIFICATION_DATA Parameter);
		private static extern void SPFX_PLUGIN_EndPositionNotificationData(IntPtr Unique);
		public void EndPositionNotificationData(IntPtr Unique);
		private static extern IntPtr SPFX_PLUGIN_GetProfileString();
		public string GetProfileString();
		private static extern void SPFX_PLUGIN_ResetProfilingMaxMemory();
		public void ResetProfilingMaxMemory();
		private static extern void SPFX_PLUGIN_SetProfileColors(ref DEBUG_PROFILE_COLOR pColor, uint Count);
		public void SetProfileColors(ref DEBUG_PROFILE_COLOR[] Colors);
		private static extern void SPFX_PLUGIN_GetDataCount(ref CountInfo Info);
		public void GetDataCount(ref CountInfo Info);
		private static extern void SPFX_PLUGIN_ResetProfileMax();
		public void ResetProfileMax();
	}
}
