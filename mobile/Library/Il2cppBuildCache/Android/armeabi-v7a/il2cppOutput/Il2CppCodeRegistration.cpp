﻿#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif







IL2CPP_EXTERN_C const Il2CppMethodPointer g_ReversePInvokeWrapperPointers[];
IL2CPP_EXTERN_C const Il2CppMethodPointer g_Il2CppGenericMethodPointers[];
IL2CPP_EXTERN_C const Il2CppMethodPointer g_Il2CppGenericAdjustorThunks[];
IL2CPP_EXTERN_C const InvokerMethod g_Il2CppInvokerPointers[];
IL2CPP_EXTERN_C const Il2CppMethodPointer g_UnresolvedVirtualMethodPointers[];
IL2CPP_EXTERN_C Il2CppInteropData g_Il2CppInteropData[];
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_Mono_Security_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_System_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_System_Configuration_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_System_Core_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_System_Xml_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_UnityEngine_AndroidJNIModule_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_UnityEngine_AudioModule_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_UnityEngine_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_UnityEngine_CoreModule_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_UnityEngine_Physics2DModule_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_UnityEngine_SharedInternalsModule_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_Unity_2D_IK_Runtime_CodeGenModule;
IL2CPP_EXTERN_C_CONST Il2CppCodeGenModule g_mscorlib_CodeGenModule;
IL2CPP_EXTERN_C const Il2CppCodeGenModule* g_CodeGenModules[];
const Il2CppCodeGenModule* g_CodeGenModules[13] = 
{
	(&g_Mono_Security_CodeGenModule),
	(&g_System_CodeGenModule),
	(&g_System_Configuration_CodeGenModule),
	(&g_System_Core_CodeGenModule),
	(&g_System_Xml_CodeGenModule),
	(&g_UnityEngine_AndroidJNIModule_CodeGenModule),
	(&g_UnityEngine_AudioModule_CodeGenModule),
	(&g_UnityEngine_CodeGenModule),
	(&g_UnityEngine_CoreModule_CodeGenModule),
	(&g_UnityEngine_Physics2DModule_CodeGenModule),
	(&g_UnityEngine_SharedInternalsModule_CodeGenModule),
	(&g_Unity_2D_IK_Runtime_CodeGenModule),
	(&g_mscorlib_CodeGenModule),
};
IL2CPP_EXTERN_C const Il2CppCodeRegistration g_CodeRegistration;
const Il2CppCodeRegistration g_CodeRegistration = 
{
	1,
	g_ReversePInvokeWrapperPointers,
	3112,
	g_Il2CppGenericMethodPointers,
	g_Il2CppGenericAdjustorThunks,
	1567,
	g_Il2CppInvokerPointers,
	199,
	g_UnresolvedVirtualMethodPointers,
	129,
	g_Il2CppInteropData,
	0,
	NULL,
	13,
	g_CodeGenModules,
};
IL2CPP_EXTERN_C_CONST Il2CppMetadataRegistration g_MetadataRegistration;
static const Il2CppCodeGenOptions s_Il2CppCodeGenOptions = 
{
	true,
	7,
};
void s_Il2CppCodegenRegistration()
{
	il2cpp_codegen_register (&g_CodeRegistration, &g_MetadataRegistration, &s_Il2CppCodeGenOptions);
}
#if RUNTIME_IL2CPP
typedef void (*CodegenRegistrationFunction)();
CodegenRegistrationFunction g_CodegenRegistration = s_Il2CppCodegenRegistration;
#endif