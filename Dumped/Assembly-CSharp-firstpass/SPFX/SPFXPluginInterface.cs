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
	public interface SPFXPluginInterface
	{
		// Methods
		IntPtr GetRenderingCallback();
		InitializeErrorCode Initialize(uint FileLoadCountPerOneFrame, uint MaxFileCount, uint MaxInstanceCount, uint UnitMemorySize, uint TemporaryMemorySize, uint DrawCommandMemorySize, uint VertexBufferSize, byte[] ShaderBinary, bool IsMultithreadUpdate, bool IsGraphicsMultiThreaded, bool IsReversedZBuffer, bool IsAutoViewCullingOn, float AutoViewCullingSize, bool IsAutoDistanceClipEnable, float AutoViewDistanceClipDistance, bool IsEnableCommunicator);
		void Uninitialize();
		bool IsTryRendering(int DrawLayerFlags, int CullingMask, bool IsProjectionMapping);
		void ForceUpdate();
		string GetVersionString();
		void SetLowSpecMode(bool IsLowSpecMode);
		bool GetLowSpecMode();
		uint GetResourceLoaderQueueCount();
		void SetGroundHeight(float Height);
		void SetZSortEnable(int Layer, bool IsEnabled);
		void SetDrawParameter(int CameraID, DRAWPARAMETER Parameter);
		void Update(float DeltaTime, MATRIX4x4 CameraMatrix);
		IntPtr CreateInstance(byte[] FileName, byte[] BytesData, int InstanceID, int UniqueParam, IntPtr[] TextureInfo, bool IsSharedResource);
		void ReleaseInstance(IntPtr Handle);
		void ReleaseInstanceAll();
		uint GetSystemMemory(IntPtr Handle);
		uint GetVideoMemory(IntPtr Handle);
		eFileStatus GetStatus(IntPtr Handle);
		void Play(IntPtr Handle, int StartFrame);
		void Stop(IntPtr Handle);
		void Pause(IntPtr Handle);
		PlayingStatus IsPlaying(IntPtr Handle);
		void SetUpdateStopAtHide(IntPtr Handle, bool IsUpdateStopAtHide);
		void SetViewCullingBoundingSphere(IntPtr Handle, bool IsViewCulling, float Radius);
		void SetCullingMask(IntPtr Handle, int Mask);
		void SetDrawLayer(IntPtr Handle, eDrawLayer Layer);
		void SetDrawPriority(IntPtr Handle, int Priority);
		void SetDepthBiasOffset(IntPtr Handle, float Offset);
		void SetDepthBiasScale(IntPtr Handle, float Scale);
		void SetFogInfluence(IntPtr Handle, float Influence);
		bool KickTrigger(IntPtr Handle, int Trigger);
		void SetLabelTexture(IntPtr handle, string Label, Texture Texture, int MipCount);
		void SetShow(IntPtr Handle, int Index, bool IsShow);
		void SetTransform(IntPtr Handle, float[] WorldMatrix);
		void SetTargetTransform(IntPtr Handle, float[] WorldMatrix);
		void SetColor(IntPtr Handle, float r, float g, float b, float a);
		void SetSpeed(IntPtr Handle, float Speed);
		void SetFogParameters(int Type, float Density, float StartDistance, float EndDistance, float R, float G, float B);
		void SetPolylineManyPointBindData(IntPtr Handle, Transform[] Points, Vector3 Rotation);
		bool GetBoundingSphere(IntPtr Handle, ref BOUNDINGSPHERE Sphere);
		void GetMemoryInfo(ref MemoryInfo Info);
		void EnableUnityCollision(bool IsEnable);
		IntPtr GetCollisionData(ref COLLISIONDATA Parameter);
		void EndCollisionData(IntPtr Unique, bool IsHit, ref COLLISIONDATA Parameter);
		void EnableSoundCallback(bool IsEnable);
		IntPtr GetSoundData(ref SOUNDDATA Parameter);
		void EndSoundData(IntPtr Unique);
		void EnableClipEventCallback(bool IsEnable);
		IntPtr GetClipEventData(ref CLIPEVENTDATA Parameter);
		void EndClipEventData(IntPtr Unique);
		void EnablePositionNotificationCallback(bool IsEnable);
		IntPtr GetPositionNotificationData(ref POSITIONNOTIFICATION_DATA Parameter);
		void EndPositionNotificationData(IntPtr Unique);
		string GetProfileString();
		void ResetProfilingMaxMemory();
		void GetDataCount(ref CountInfo Info);
		void SetProfileColors(ref DEBUG_PROFILE_COLOR[] Colors);
		void ResetProfileMax();
	}
}
