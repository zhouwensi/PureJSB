﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by CSGenerator.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using jsval = JSApi.jsval;

public class JSB_UnityEngine_QualitySettings
{

////////////////////// QualitySettings ///////////////////////////////////////
// constructors

static bool QualitySettings_QualitySettings1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.QualitySettings());
    }

    return true;
}

// fields

// properties
static void QualitySettings_names(JSVCall vc)
{
        var result = UnityEngine.QualitySettings.names;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setStringS((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
}
static void QualitySettings_pixelLightCount(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.pixelLightCount;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.pixelLightCount = arg0;
    }
}
static void QualitySettings_shadowProjection(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.shadowProjection;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ShadowProjection arg0 = (UnityEngine.ShadowProjection)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.shadowProjection = arg0;
    }
}
static void QualitySettings_shadowCascades(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.shadowCascades;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.shadowCascades = arg0;
    }
}
static void QualitySettings_shadowDistance(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.shadowDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.shadowDistance = arg0;
    }
}
static void QualitySettings_masterTextureLimit(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.masterTextureLimit;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.masterTextureLimit = arg0;
    }
}
static void QualitySettings_anisotropicFiltering(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.anisotropicFiltering;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.AnisotropicFiltering arg0 = (UnityEngine.AnisotropicFiltering)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.anisotropicFiltering = arg0;
    }
}
static void QualitySettings_lodBias(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.lodBias;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.lodBias = arg0;
    }
}
static void QualitySettings_maximumLODLevel(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.maximumLODLevel;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.maximumLODLevel = arg0;
    }
}
static void QualitySettings_particleRaycastBudget(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.particleRaycastBudget;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.particleRaycastBudget = arg0;
    }
}
static void QualitySettings_softVegetation(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.softVegetation;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.softVegetation = arg0;
    }
}
static void QualitySettings_maxQueuedFrames(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.maxQueuedFrames;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.maxQueuedFrames = arg0;
    }
}
static void QualitySettings_vSyncCount(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.vSyncCount;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.vSyncCount = arg0;
    }
}
static void QualitySettings_antiAliasing(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.antiAliasing;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.antiAliasing = arg0;
    }
}
static void QualitySettings_desiredColorSpace(JSVCall vc)
{
        var result = UnityEngine.QualitySettings.desiredColorSpace;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
}
static void QualitySettings_activeColorSpace(JSVCall vc)
{
        var result = UnityEngine.QualitySettings.activeColorSpace;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
}
static void QualitySettings_blendWeights(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.QualitySettings.blendWeights;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.BlendWeights arg0 = (UnityEngine.BlendWeights)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.blendWeights = arg0;
    }
}

// methods

static bool QualitySettings_DecreaseLevel__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.DecreaseLevel(arg0);
    }

    return true;
}

static bool QualitySettings_DecreaseLevel(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        UnityEngine.QualitySettings.DecreaseLevel();
    }

    return true;
}

static bool QualitySettings_GetQualityLevel(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(UnityEngine.QualitySettings.GetQualityLevel()));
    }

    return true;
}

static bool QualitySettings_IncreaseLevel__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.IncreaseLevel(arg0);
    }

    return true;
}

static bool QualitySettings_IncreaseLevel(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        UnityEngine.QualitySettings.IncreaseLevel();
    }

    return true;
}

static bool QualitySettings_SetQualityLevel__Int32__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Boolean arg1 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.SetQualityLevel(arg0, arg1);
    }

    return true;
}

static bool QualitySettings_SetQualityLevel__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.QualitySettings.SetQualityLevel(arg0);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.QualitySettings);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        QualitySettings_names,
        QualitySettings_pixelLightCount,
        QualitySettings_shadowProjection,
        QualitySettings_shadowCascades,
        QualitySettings_shadowDistance,
        QualitySettings_masterTextureLimit,
        QualitySettings_anisotropicFiltering,
        QualitySettings_lodBias,
        QualitySettings_maximumLODLevel,
        QualitySettings_particleRaycastBudget,
        QualitySettings_softVegetation,
        QualitySettings_maxQueuedFrames,
        QualitySettings_vSyncCount,
        QualitySettings_antiAliasing,
        QualitySettings_desiredColorSpace,
        QualitySettings_activeColorSpace,
        QualitySettings_blendWeights,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(QualitySettings_QualitySettings1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(QualitySettings_DecreaseLevel__Boolean, "DecreaseLevel"),
        new JSMgr.MethodCallBackInfo(QualitySettings_DecreaseLevel, "DecreaseLevel"),
        new JSMgr.MethodCallBackInfo(QualitySettings_GetQualityLevel, "GetQualityLevel"),
        new JSMgr.MethodCallBackInfo(QualitySettings_IncreaseLevel__Boolean, "IncreaseLevel"),
        new JSMgr.MethodCallBackInfo(QualitySettings_IncreaseLevel, "IncreaseLevel"),
        new JSMgr.MethodCallBackInfo(QualitySettings_SetQualityLevel__Int32__Boolean, "SetQualityLevel"),
        new JSMgr.MethodCallBackInfo(QualitySettings_SetQualityLevel__Int32, "SetQualityLevel"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
