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

public class JSB_UnityEngine_AccelerationEvent
{

////////////////////// AccelerationEvent ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool AccelerationEvent_AccelerationEvent1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.AccelerationEvent());
    }

    return true;
}

// fields

// properties
static void AccelerationEvent_acceleration(JSVCall vc)
{
        UnityEngine.AccelerationEvent _this = (UnityEngine.AccelerationEvent)vc.csObj;
        var result = _this.acceleration;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}
static void AccelerationEvent_deltaTime(JSVCall vc)
{
        UnityEngine.AccelerationEvent _this = (UnityEngine.AccelerationEvent)vc.csObj;
        var result = _this.deltaTime;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.AccelerationEvent);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        AccelerationEvent_acceleration,
        AccelerationEvent_deltaTime,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AccelerationEvent_AccelerationEvent1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
