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

public class JSB_UnityEngine_PlatformEffector2D
{

////////////////////// PlatformEffector2D ///////////////////////////////////////
// constructors

static bool PlatformEffector2D_PlatformEffector2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.PlatformEffector2D());
    }

    return true;
}

// fields

// properties
static void PlatformEffector2D_useOneWay(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        var result = _this.useOneWay;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        _this.useOneWay = arg0;
    }
}
static void PlatformEffector2D_useOneWayGrouping(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        var result = _this.useOneWayGrouping;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        _this.useOneWayGrouping = arg0;
    }
}
static void PlatformEffector2D_useSideFriction(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        var result = _this.useSideFriction;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        _this.useSideFriction = arg0;
    }
}
static void PlatformEffector2D_useSideBounce(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        var result = _this.useSideBounce;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        _this.useSideBounce = arg0;
    }
}
static void PlatformEffector2D_surfaceArc(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        var result = _this.surfaceArc;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        _this.surfaceArc = arg0;
    }
}
static void PlatformEffector2D_sideArc(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        var result = _this.sideArc;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.PlatformEffector2D _this = (UnityEngine.PlatformEffector2D)vc.csObj;
        _this.sideArc = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.PlatformEffector2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        PlatformEffector2D_useOneWay,
        PlatformEffector2D_useOneWayGrouping,
        PlatformEffector2D_useSideFriction,
        PlatformEffector2D_useSideBounce,
        PlatformEffector2D_surfaceArc,
        PlatformEffector2D_sideArc,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(PlatformEffector2D_PlatformEffector2D1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}