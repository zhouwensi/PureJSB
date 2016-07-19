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

public class JSB_UnityEngine_InteractiveCloth
{

////////////////////// InteractiveCloth ///////////////////////////////////////
// constructors

static bool InteractiveCloth_InteractiveCloth1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.InteractiveCloth());
    }

    return true;
}

// fields

// properties
static void InteractiveCloth_mesh(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        var result = _this.mesh;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Mesh arg0 = (UnityEngine.Mesh)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        _this.mesh = arg0;
    }
}
static void InteractiveCloth_friction(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        var result = _this.friction;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        _this.friction = arg0;
    }
}
static void InteractiveCloth_density(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        var result = _this.density;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        _this.density = arg0;
    }
}
static void InteractiveCloth_pressure(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        var result = _this.pressure;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        _this.pressure = arg0;
    }
}
static void InteractiveCloth_collisionResponse(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        var result = _this.collisionResponse;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        _this.collisionResponse = arg0;
    }
}
static void InteractiveCloth_tearFactor(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        var result = _this.tearFactor;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        _this.tearFactor = arg0;
    }
}
static void InteractiveCloth_attachmentTearFactor(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        var result = _this.attachmentTearFactor;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        _this.attachmentTearFactor = arg0;
    }
}
static void InteractiveCloth_attachmentResponse(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        var result = _this.attachmentResponse;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        _this.attachmentResponse = arg0;
    }
}
static void InteractiveCloth_isTeared(JSVCall vc)
{
        UnityEngine.InteractiveCloth _this = (UnityEngine.InteractiveCloth)vc.csObj;
        var result = _this.isTeared;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}

// methods

static bool InteractiveCloth_AddForceAtPosition__Vector3__Vector3__Single__ForceMode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ForceMode arg3 = (UnityEngine.ForceMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        ((UnityEngine.InteractiveCloth)vc.csObj).AddForceAtPosition(arg0, arg1, arg2, arg3);
    }

    return true;
}

static bool InteractiveCloth_AddForceAtPosition__Vector3__Vector3__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        ((UnityEngine.InteractiveCloth)vc.csObj).AddForceAtPosition(arg0, arg1, arg2);
    }

    return true;
}

static bool InteractiveCloth_AttachToCollider__Collider__Boolean__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Collider arg0 = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Boolean arg1 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg2 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        ((UnityEngine.InteractiveCloth)vc.csObj).AttachToCollider(arg0, arg1, arg2);
    }

    return true;
}

static bool InteractiveCloth_AttachToCollider__Collider__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Collider arg0 = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Boolean arg1 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        ((UnityEngine.InteractiveCloth)vc.csObj).AttachToCollider(arg0, arg1);
    }

    return true;
}

static bool InteractiveCloth_AttachToCollider__Collider(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Collider arg0 = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.InteractiveCloth)vc.csObj).AttachToCollider(arg0);
    }

    return true;
}

static bool InteractiveCloth_DetachFromCollider__Collider(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Collider arg0 = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.InteractiveCloth)vc.csObj).DetachFromCollider(arg0);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.InteractiveCloth);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        InteractiveCloth_mesh,
        InteractiveCloth_friction,
        InteractiveCloth_density,
        InteractiveCloth_pressure,
        InteractiveCloth_collisionResponse,
        InteractiveCloth_tearFactor,
        InteractiveCloth_attachmentTearFactor,
        InteractiveCloth_attachmentResponse,
        InteractiveCloth_isTeared,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(InteractiveCloth_InteractiveCloth1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(InteractiveCloth_AddForceAtPosition__Vector3__Vector3__Single__ForceMode, "AddForceAtPosition"),
        new JSMgr.MethodCallBackInfo(InteractiveCloth_AddForceAtPosition__Vector3__Vector3__Single, "AddForceAtPosition"),
        new JSMgr.MethodCallBackInfo(InteractiveCloth_AttachToCollider__Collider__Boolean__Boolean, "AttachToCollider"),
        new JSMgr.MethodCallBackInfo(InteractiveCloth_AttachToCollider__Collider__Boolean, "AttachToCollider"),
        new JSMgr.MethodCallBackInfo(InteractiveCloth_AttachToCollider__Collider, "AttachToCollider"),
        new JSMgr.MethodCallBackInfo(InteractiveCloth_DetachFromCollider__Collider, "DetachFromCollider"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
