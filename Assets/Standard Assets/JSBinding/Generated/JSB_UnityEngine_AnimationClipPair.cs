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

public class JSB_UnityEngine_AnimationClipPair
{

////////////////////// AnimationClipPair ///////////////////////////////////////
// constructors

static bool AnimationClipPair_AnimationClipPair1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.AnimationClipPair());
    }

    return true;
}

// fields
static void AnimationClipPair_originalClip(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.AnimationClipPair _this = (UnityEngine.AnimationClipPair)vc.csObj;
        var result = _this.originalClip;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else {
        UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimationClipPair _this = (UnityEngine.AnimationClipPair)vc.csObj;
        _this.originalClip = arg0;
    }
}
static void AnimationClipPair_overrideClip(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.AnimationClipPair _this = (UnityEngine.AnimationClipPair)vc.csObj;
        var result = _this.overrideClip;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else {
        UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimationClipPair _this = (UnityEngine.AnimationClipPair)vc.csObj;
        _this.overrideClip = arg0;
    }
}

// properties

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.AnimationClipPair);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        AnimationClipPair_originalClip,
        AnimationClipPair_overrideClip,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AnimationClipPair_AnimationClipPair1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
