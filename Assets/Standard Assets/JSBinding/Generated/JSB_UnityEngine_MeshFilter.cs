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

public class JSB_UnityEngine_MeshFilter
{

////////////////////// MeshFilter ///////////////////////////////////////
// constructors

static bool MeshFilter_MeshFilter1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.MeshFilter());
    }

    return true;
}

// fields

// properties
static void MeshFilter_mesh(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.MeshFilter _this = (UnityEngine.MeshFilter)vc.csObj;
        var result = _this.mesh;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Mesh arg0 = (UnityEngine.Mesh)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.MeshFilter _this = (UnityEngine.MeshFilter)vc.csObj;
        _this.mesh = arg0;
    }
}
static void MeshFilter_sharedMesh(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.MeshFilter _this = (UnityEngine.MeshFilter)vc.csObj;
        var result = _this.sharedMesh;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Mesh arg0 = (UnityEngine.Mesh)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.MeshFilter _this = (UnityEngine.MeshFilter)vc.csObj;
        _this.sharedMesh = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.MeshFilter);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        MeshFilter_mesh,
        MeshFilter_sharedMesh,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(MeshFilter_MeshFilter1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
