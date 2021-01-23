/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SPFX
{
	public class SPFXPluginNull : SPFXPluginInterface
	{
		// Constructors
		public SPFXPluginNull();
	
		// Methods
		public IntPtr GetRenderingCallback();
		public InitializeErrorCode Initialize(uint FileLoadCountPerOneFrame, uint MaxFileCount, uint MaxInstanceCount, uint UnitMemorySize, uint TemporaryMemorySize, uint DrawCommandMemorySize, uint VertexBufferSize, byte[] ShaderBinary, bool IsMultithreadUpdate, bool IsGraphicsMultiThreaded, bool IsReversedZBuffer, bool IsAutoViewCullingOn, float AutoViewCullingSize, bool IsAutoDistanceClipEnable, float AutoViewDistanceClipDistance, bool IsEnableCommunicator);
		public void Uninitialize();
		public bool IsTryRendering(int DrawLayerFlags, int CullingMask, bool IsProjectionMapping);
		public void ForceUpdate();
		public string GetVersionString();
		public void SetLowSpecMode(bool IsLowSpecMode);
		public bool GetLowSpecMode();
		public uint GetResourceLoaderQueueCount();
		public void SetGroundHeight(float Height);
		public void SetZSortEnable(int Layer, bool IsEnabled);
		public void SetDrawParameter(int CameraID, DRAWPARAMETER Parameter);
		public void Update(float DeltaTime, MATRIX4x4 CameraMatrix);
		public IntPtr CreateInstance(byte[] FileName, byte[] BytesData, int InstanceID, int UniqueParam, IntPtr[] TextureInfo, bool IsSharedResource);
		public void ReleaseInstance(IntPtr Handle);
		public void ReleaseInstanceAll();
		public uint GetSystemMemory(IntPtr Handle);
		public uint GetVideoMemory(IntPtr Handle);
		public eFileStatus GetStatus(IntPtr Handle);
		public void Play(IntPtr Handle, int StartFrame);
		public void Stop(IntPtr Handle);
		public void Pause(IntPtr Handle);
		public PlayingStatus IsPlaying(IntPtr Handle);
		public void SetUpdateStopAtHide(IntPtr Handle, bool IsUpdateStopAtHide);
		public void SetViewCullingBoundingSphere(IntPtr Handle, bool IsViewCulling, float Radius);
		public void SetCullingMask(IntPtr Handle, int Mask);
		public void SetDrawLayer(IntPtr Handle, eDrawLayer Layer);
		public void SetDrawPriority(IntPtr Handle, int Priority);
		public void SetDepthBiasOffset(IntPtr Handle, float Offset);
		public void SetDepthBiasScale(IntPtr Handle, float Scale);
		public void SetFogInfluence(IntPtr Handle, float Influence);
		public bool KickTrigger(IntPtr Handle, int Trigger);
		public void SetLabelTexture(IntPtr handle, string Label, Texture Texture, int MipCount);
		public void SetShow(IntPtr Handle, int Index, bool IsShow);
		public void SetTransform(IntPtr Handle, float[] WorldMatrix);
		public void SetTargetTransform(IntPtr Handle, float[] WorldMatrix);
		public void SetColor(IntPtr Handle, float r, float g, float b, float a);
		public void SetSpeed(IntPtr Handle, float Speed);
		public void SetFogParameters(int Type, float Density, float StartDistance, float EndDistance, float R, float G, float B);
		public void SetPolylineManyPointBindData(IntPtr Handle, Transform[] Points, Vector3 Rotation);
		public bool GetBoundingSphere(IntPtr Handle, ref BOUNDINGSPHERE Sphere);
		public void GetMemoryInfo(ref MemoryInfo Info);
		public void EnableUnityCollision(bool IsEnable);
		public IntPtr GetCollisionData(ref COLLISIONDATA Parameter);
		public void EndCollisionData(IntPtr Unique, bool IsHit, ref COLLISIONDATA Parameter);
		public void EnableSoundCallback(bool IsEnable);
		public IntPtr GetSoundData(ref SOUNDDATA Parameter);
		public void EndSoundData(IntPtr Unique);
		public void EnableClipEventCallback(bool IsEnable);
		public IntPtr GetClipEventData(ref CLIPEVENTDATA Parameter);
		public void EndClipEventData(IntPtr Unique);
		public void EnablePositionNotificationCallback(bool IsEnable);
		public IntPtr GetPositionNotificationData(ref POSITIONNOTIFICATION_DATA Parameter);
		public void EndPositionNotificationData(IntPtr Unique);
		public string GetProfileString();
		public void ResetProfilingMaxMemory();
		public void SetProfileColors(ref DEBUG_PROFILE_COLOR[] Colors);
		public void GetDataCount(ref CountInfo Info);
		public void ResetProfileMax();
	}
}
