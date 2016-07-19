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

public class JSB_UnityEngine_HumanTrait
{

////////////////////// HumanTrait ///////////////////////////////////////
// constructors

static bool HumanTrait_HumanTrait1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.HumanTrait());
    }

    return true;
}

// fields

// properties
static void HumanTrait_MuscleCount(JSVCall vc)
{
        var result = UnityEngine.HumanTrait.MuscleCount;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void HumanTrait_MuscleName(JSVCall vc)
{
        var result = UnityEngine.HumanTrait.MuscleName;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setStringS((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
}
static void HumanTrait_BoneCount(JSVCall vc)
{
        var result = UnityEngine.HumanTrait.BoneCount;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void HumanTrait_BoneName(JSVCall vc)
{
        var result = UnityEngine.HumanTrait.BoneName;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setStringS((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
}
static void HumanTrait_RequiredBoneCount(JSVCall vc)
{
        var result = UnityEngine.HumanTrait.RequiredBoneCount;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}

// methods

static bool HumanTrait_BoneFromMuscle__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(UnityEngine.HumanTrait.BoneFromMuscle(arg0)));
    }

    return true;
}

static bool HumanTrait_GetMuscleDefaultMax__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.HumanTrait.GetMuscleDefaultMax(arg0)));
    }

    return true;
}

static bool HumanTrait_GetMuscleDefaultMin__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.HumanTrait.GetMuscleDefaultMin(arg0)));
    }

    return true;
}

static bool HumanTrait_MuscleFromBone__Int32__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(UnityEngine.HumanTrait.MuscleFromBone(arg0, arg1)));
    }

    return true;
}

static bool HumanTrait_RequiredBone__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.HumanTrait.RequiredBone(arg0)));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.HumanTrait);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        HumanTrait_MuscleCount,
        HumanTrait_MuscleName,
        HumanTrait_BoneCount,
        HumanTrait_BoneName,
        HumanTrait_RequiredBoneCount,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(HumanTrait_HumanTrait1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(HumanTrait_BoneFromMuscle__Int32, "BoneFromMuscle"),
        new JSMgr.MethodCallBackInfo(HumanTrait_GetMuscleDefaultMax__Int32, "GetMuscleDefaultMax"),
        new JSMgr.MethodCallBackInfo(HumanTrait_GetMuscleDefaultMin__Int32, "GetMuscleDefaultMin"),
        new JSMgr.MethodCallBackInfo(HumanTrait_MuscleFromBone__Int32__Int32, "MuscleFromBone"),
        new JSMgr.MethodCallBackInfo(HumanTrait_RequiredBone__Int32, "RequiredBone"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
