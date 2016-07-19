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

public class JSB_UnityEngine_WheelFrictionCurve
{

////////////////////// WheelFrictionCurve ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool WheelFrictionCurve_WheelFrictionCurve1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.WheelFrictionCurve());
    }

    return true;
}

// fields

// properties
static void WheelFrictionCurve_extremumSlip(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.WheelFrictionCurve _this = (UnityEngine.WheelFrictionCurve)vc.csObj;
        var result = _this.extremumSlip;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.WheelFrictionCurve _this = (UnityEngine.WheelFrictionCurve)vc.csObj;
        _this.extremumSlip = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void WheelFrictionCurve_extremumValue(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.WheelFrictionCurve _this = (UnityEngine.WheelFrictionCurve)vc.csObj;
        var result = _this.extremumValue;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.WheelFrictionCurve _this = (UnityEngine.WheelFrictionCurve)vc.csObj;
        _this.extremumValue = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void WheelFrictionCurve_asymptoteSlip(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.WheelFrictionCurve _this = (UnityEngine.WheelFrictionCurve)vc.csObj;
        var result = _this.asymptoteSlip;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.WheelFrictionCurve _this = (UnityEngine.WheelFrictionCurve)vc.csObj;
        _this.asymptoteSlip = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void WheelFrictionCurve_asymptoteValue(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.WheelFrictionCurve _this = (UnityEngine.WheelFrictionCurve)vc.csObj;
        var result = _this.asymptoteValue;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.WheelFrictionCurve _this = (UnityEngine.WheelFrictionCurve)vc.csObj;
        _this.asymptoteValue = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void WheelFrictionCurve_stiffness(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.WheelFrictionCurve _this = (UnityEngine.WheelFrictionCurve)vc.csObj;
        var result = _this.stiffness;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.WheelFrictionCurve _this = (UnityEngine.WheelFrictionCurve)vc.csObj;
        _this.stiffness = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.WheelFrictionCurve);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        WheelFrictionCurve_extremumSlip,
        WheelFrictionCurve_extremumValue,
        WheelFrictionCurve_asymptoteSlip,
        WheelFrictionCurve_asymptoteValue,
        WheelFrictionCurve_stiffness,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(WheelFrictionCurve_WheelFrictionCurve1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
