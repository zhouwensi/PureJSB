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

public class JSB_UnityEngine_Joint2D
{

////////////////////// Joint2D ///////////////////////////////////////
// constructors

static bool Joint2D_Joint2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Joint2D());
    }

    return true;
}

// fields

// properties
static void Joint2D_connectedBody(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Joint2D _this = (UnityEngine.Joint2D)vc.csObj;
        var result = _this.connectedBody;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Rigidbody2D arg0 = (UnityEngine.Rigidbody2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Joint2D _this = (UnityEngine.Joint2D)vc.csObj;
        _this.connectedBody = arg0;
    }
}
static void Joint2D_collideConnected(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Joint2D _this = (UnityEngine.Joint2D)vc.csObj;
        var result = _this.collideConnected;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.Joint2D _this = (UnityEngine.Joint2D)vc.csObj;
        _this.collideConnected = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Joint2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Joint2D_connectedBody,
        Joint2D_collideConnected,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Joint2D_Joint2D1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
