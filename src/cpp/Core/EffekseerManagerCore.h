#pragma once

#include "EffekseerBackendCore.h"
#include <d3d11.h>

class EffekseerEffectCore;

namespace EffekseerRenderer
{
class Renderer;
}

class EffekseerManagerCore
{
private:
	::Effekseer::ManagerRef manager_ = nullptr;
	::EffekseerRenderer::RendererRef renderer_ = nullptr;
	float restDeltaTime_ = 0.0f;
	::Effekseer::Backend::TextureRef backgroundtx_;
	::Effekseer::Backend::TextureRef depthtx_;

public:
	EffekseerManagerCore() = default;
	~EffekseerManagerCore();

	bool InitializeOpenGL(int32_t spriteMaxCount, bool srgbMode = false);

	bool InitializeDX11(void* device, void* context, int32_t spriteMaxCount, D3D11_COMPARISON_FUNC comparisonFunc = D3D11_COMPARISON_FUNC::D3D11_COMPARISON_LESS_EQUAL, bool srgbMode = false, bool isMSAAEnabled = false);

	void Update(float deltaFrames);

	void UpdateHandle(int handle);

	void UpdateHandle(int handle, float deltaFrames);
	
	void BeginUpdate();

	void EndUpdate();

	bool BeginRendering();

	bool EndRendering();

	void UpdateHandleToMoveToFrame(int handle, float v);

	int Play(EffekseerEffectCore* effect, float x = 0, float y = 0, float z = 0, int32_t startFrame = 0);

	void StopAllEffects();

	void Stop(int handle);

	void SetPaused(int handle, bool v);

	void SetShown(int handle, bool v);

	void SendTrigger(int handle, int index);

	void SetEffectPosition(int handle, float x, float y, float z);

	void SetEffectRotation(int handle, float x, float y, float z);

	void SetEffectRotation(int handle, float axis_x, float axis_y, float axis_z, float angle);

	void SetEffectScale(int handle, float x, float y, float z);

	void SetLayerParameter(int layer, float viewerPosX, float viewerPosY, float viewerPosZ, float distanceBias);

	void SetEffectTransformMatrix(int handle,
								  float v0,
								  float v1,
								  float v2,
								  float v3,
								  float v4,
								  float v5,
								  float v6,
								  float v7,
								  float v8,
								  float v9,
								  float v10,
								  float v11);

	void SetEffectTransformBaseMatrix(int handle,
									  float v0,
									  float v1,
									  float v2,
									  float v3,
									  float v4,
									  float v5,
									  float v6,
									  float v7,
									  float v8,
									  float v9,
									  float v10,
									  float v11);

	void DrawBack(int layer = 1);

	void DrawFront(int layer = 1);

	void DrawHandle(int handle, float zNear = 0, float zFar = 1);

	void SetLayer(int handle, int layer);

	void SetCameraParameter(float frontX, float frontY, float frontZ, float posX, float posY, float posZ);

	void SetProjectionMatrix(float v0,
							 float v1,
							 float v2,
							 float v3,
							 float v4,
							 float v5,
							 float v6,
							 float v7,
							 float v8,
							 float v9,
							 float v10,
							 float v11,
							 float v12,
							 float v13,
							 float v14,
							 float v15);

	void SetCameraMatrix(float v0,
						 float v1,
						 float v2,
						 float v3,
						 float v4,
						 float v5,
						 float v6,
						 float v7,
						 float v8,
						 float v9,
						 float v10,
						 float v11,
						 float v12,
						 float v13,
						 float v14,
						 float v15);

	bool Exists(int handle);

	void SetViewProjectionMatrixWithSimpleWindow(int32_t windowWidth, int32_t windowHeight);

	void SetDynamicInput(int handle, int32_t index, float value);

	float GetDynamicInput(int handle, int32_t index);

	void LaunchWorkerThreads(int32_t n);

	void SetBackground(uint32_t glid, bool hasMipmap);

	void UnsetBackground();

	void SetDepth(uint32_t glid, bool hasMipmap);

	void UnsetDepth();

	int GetInstanceCount(int handle);

	int GetTotalInstanceCount() const;
};
