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

public class JSB_UnityEngine_TrailRenderer
{

////////////////////// TrailRenderer ///////////////////////////////////////
// constructors

static bool TrailRenderer_TrailRenderer1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.TrailRenderer());
    }

    return true;
}

// fields

// properties
static void TrailRenderer_time(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.TrailRenderer _this = (UnityEngine.TrailRenderer)vc.csObj;
        var result = _this.time;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.TrailRenderer _this = (UnityEngine.TrailRenderer)vc.csObj;
        _this.time = arg0;
    }
}
static void TrailRenderer_startWidth(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.TrailRenderer _this = (UnityEngine.TrailRenderer)vc.csObj;
        var result = _this.startWidth;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.TrailRenderer _this = (UnityEngine.TrailRenderer)vc.csObj;
        _this.startWidth = arg0;
    }
}
static void TrailRenderer_endWidth(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.TrailRenderer _this = (UnityEngine.TrailRenderer)vc.csObj;
        var result = _this.endWidth;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.TrailRenderer _this = (UnityEngine.TrailRenderer)vc.csObj;
        _this.endWidth = arg0;
    }
}
static void TrailRenderer_autodestruct(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.TrailRenderer _this = (UnityEngine.TrailRenderer)vc.csObj;
        var result = _this.autodestruct;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.TrailRenderer _this = (UnityEngine.TrailRenderer)vc.csObj;
        _this.autodestruct = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.TrailRenderer);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        TrailRenderer_time,
        TrailRenderer_startWidth,
        TrailRenderer_endWidth,
        TrailRenderer_autodestruct,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(TrailRenderer_TrailRenderer1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
