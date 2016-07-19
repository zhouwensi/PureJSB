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

public class JSB_UnityEngine_GUIStyle
{

////////////////////// GUIStyle ///////////////////////////////////////
// constructors

static bool GUIStyle_GUIStyle1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.GUIStyle());
    }

    return true;
}

static bool GUIStyle_GUIStyle2(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 1)
    {
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.GUIStyle(arg0));
    }

    return true;
}

// fields

// properties
static void GUIStyle_name(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.name;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.name = arg0;
    }
}
static void GUIStyle_normal(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.normal;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyleState arg0 = (UnityEngine.GUIStyleState)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.normal = arg0;
    }
}
static void GUIStyle_hover(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.hover;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyleState arg0 = (UnityEngine.GUIStyleState)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.hover = arg0;
    }
}
static void GUIStyle_active(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.active;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyleState arg0 = (UnityEngine.GUIStyleState)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.active = arg0;
    }
}
static void GUIStyle_onNormal(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.onNormal;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyleState arg0 = (UnityEngine.GUIStyleState)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.onNormal = arg0;
    }
}
static void GUIStyle_onHover(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.onHover;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyleState arg0 = (UnityEngine.GUIStyleState)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.onHover = arg0;
    }
}
static void GUIStyle_onActive(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.onActive;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyleState arg0 = (UnityEngine.GUIStyleState)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.onActive = arg0;
    }
}
static void GUIStyle_focused(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.focused;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyleState arg0 = (UnityEngine.GUIStyleState)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.focused = arg0;
    }
}
static void GUIStyle_onFocused(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.onFocused;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyleState arg0 = (UnityEngine.GUIStyleState)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.onFocused = arg0;
    }
}
static void GUIStyle_border(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.border;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.RectOffset arg0 = (UnityEngine.RectOffset)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.border = arg0;
    }
}
static void GUIStyle_margin(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.margin;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.RectOffset arg0 = (UnityEngine.RectOffset)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.margin = arg0;
    }
}
static void GUIStyle_padding(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.padding;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.RectOffset arg0 = (UnityEngine.RectOffset)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.padding = arg0;
    }
}
static void GUIStyle_overflow(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.overflow;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.RectOffset arg0 = (UnityEngine.RectOffset)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.overflow = arg0;
    }
}
static void GUIStyle_imagePosition(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.imagePosition;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ImagePosition arg0 = (UnityEngine.ImagePosition)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.imagePosition = arg0;
    }
}
static void GUIStyle_alignment(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.alignment;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.TextAnchor arg0 = (UnityEngine.TextAnchor)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.alignment = arg0;
    }
}
static void GUIStyle_wordWrap(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.wordWrap;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.wordWrap = arg0;
    }
}
static void GUIStyle_clipping(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.clipping;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.TextClipping arg0 = (UnityEngine.TextClipping)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.clipping = arg0;
    }
}
static void GUIStyle_contentOffset(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.contentOffset;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.contentOffset = arg0;
    }
}
static void GUIStyle_fixedWidth(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.fixedWidth;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.fixedWidth = arg0;
    }
}
static void GUIStyle_fixedHeight(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.fixedHeight;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.fixedHeight = arg0;
    }
}
static void GUIStyle_stretchWidth(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.stretchWidth;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.stretchWidth = arg0;
    }
}
static void GUIStyle_stretchHeight(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.stretchHeight;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.stretchHeight = arg0;
    }
}
static void GUIStyle_font(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.font;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Font arg0 = (UnityEngine.Font)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.font = arg0;
    }
}
static void GUIStyle_fontSize(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.fontSize;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.fontSize = arg0;
    }
}
static void GUIStyle_fontStyle(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.fontStyle;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.FontStyle arg0 = (UnityEngine.FontStyle)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.fontStyle = arg0;
    }
}
static void GUIStyle_richText(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.richText;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        _this.richText = arg0;
    }
}
static void GUIStyle_lineHeight(JSVCall vc)
{
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.lineHeight;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void GUIStyle_none(JSVCall vc)
{
        var result = UnityEngine.GUIStyle.none;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void GUIStyle_isHeightDependantOnWidth(JSVCall vc)
{
        UnityEngine.GUIStyle _this = (UnityEngine.GUIStyle)vc.csObj;
        var result = _this.isHeightDependantOnWidth;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}

// methods

static bool GUIStyle_CalcHeight__GUIContent__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(((UnityEngine.GUIStyle)vc.csObj).CalcHeight(arg0, arg1)));
    }

    return true;
}

static bool GUIStyle_CalcMinMaxWidth__GUIContent__Single__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        int r_arg1 = JSApi.incArgIndex();
        System.Single arg1;
        int r_arg2 = JSApi.incArgIndex();
        System.Single arg2;
        ((UnityEngine.GUIStyle)vc.csObj).CalcMinMaxWidth(arg0, out arg1, out arg2);
        JSApi.setArgIndex(r_arg1);
        JSApi.setSingle((int)JSApi.SetType.ArgRef, arg1);
        JSApi.setArgIndex(r_arg2);
        JSApi.setSingle((int)JSApi.SetType.ArgRef, arg2);
    }

    return true;
}

static bool GUIStyle_CalcScreenSize__Vector2(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
                JSApi.setVector2S((int)JSApi.SetType.Rval, ((UnityEngine.GUIStyle)vc.csObj).CalcScreenSize(arg0));
    }

    return true;
}

static bool GUIStyle_CalcSize__GUIContent(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                JSApi.setVector2S((int)JSApi.SetType.Rval, ((UnityEngine.GUIStyle)vc.csObj).CalcSize(arg0));
    }

    return true;
}

static bool GUIStyle_Draw__Rect__String__Boolean__Boolean__Boolean__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 6) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Boolean arg2 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg3 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg4 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg5 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        ((UnityEngine.GUIStyle)vc.csObj).Draw(arg0, arg1, arg2, arg3, arg4, arg5);
    }

    return true;
}

static bool GUIStyle_Draw__Rect__Texture__Boolean__Boolean__Boolean__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 6) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Texture arg1 = (UnityEngine.Texture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Boolean arg2 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg3 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg4 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg5 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        ((UnityEngine.GUIStyle)vc.csObj).Draw(arg0, arg1, arg2, arg3, arg4, arg5);
    }

    return true;
}

static bool GUIStyle_Draw__Rect__GUIContent__Boolean__Boolean__Boolean__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 6) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Boolean arg2 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg3 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg4 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg5 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        ((UnityEngine.GUIStyle)vc.csObj).Draw(arg0, arg1, arg2, arg3, arg4, arg5);
    }

    return true;
}

static bool GUIStyle_Draw__Rect__Boolean__Boolean__Boolean__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 5) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Boolean arg1 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg2 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg3 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg4 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        ((UnityEngine.GUIStyle)vc.csObj).Draw(arg0, arg1, arg2, arg3, arg4);
    }

    return true;
}

static bool GUIStyle_Draw__Rect__GUIContent__Int32__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Boolean arg3 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        ((UnityEngine.GUIStyle)vc.csObj).Draw(arg0, arg1, arg2, arg3);
    }

    return true;
}

static bool GUIStyle_Draw__Rect__GUIContent__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.GUIStyle)vc.csObj).Draw(arg0, arg1, arg2);
    }

    return true;
}

static bool GUIStyle_DrawCursor__Rect__GUIContent__Int32__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg3 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.GUIStyle)vc.csObj).DrawCursor(arg0, arg1, arg2, arg3);
    }

    return true;
}

static bool GUIStyle_DrawWithTextSelection__Rect__GUIContent__Int32__Int32__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 5) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg3 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg4 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.GUIStyle)vc.csObj).DrawWithTextSelection(arg0, arg1, arg2, arg3, arg4);
    }

    return true;
}

static bool GUIStyle_GetCursorPixelPosition__Rect__GUIContent__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setVector2S((int)JSApi.SetType.Rval, ((UnityEngine.GUIStyle)vc.csObj).GetCursorPixelPosition(arg0, arg1, arg2));
    }

    return true;
}

static bool GUIStyle_GetCursorStringIndex__Rect__GUIContent__Vector2(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(((UnityEngine.GUIStyle)vc.csObj).GetCursorStringIndex(arg0, arg1, arg2)));
    }

    return true;
}

static bool GUIStyle_ToString(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setStringS((int)JSApi.SetType.Rval, ((UnityEngine.GUIStyle)vc.csObj).ToString());
    }

    return true;
}

static bool GUIStyle_op_Implicit__String_to_GUIStyle(JSVCall vc, int argc)
{
    System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, (UnityEngine.GUIStyle)arg0);
    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.GUIStyle);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        GUIStyle_name,
        GUIStyle_normal,
        GUIStyle_hover,
        GUIStyle_active,
        GUIStyle_onNormal,
        GUIStyle_onHover,
        GUIStyle_onActive,
        GUIStyle_focused,
        GUIStyle_onFocused,
        GUIStyle_border,
        GUIStyle_margin,
        GUIStyle_padding,
        GUIStyle_overflow,
        GUIStyle_imagePosition,
        GUIStyle_alignment,
        GUIStyle_wordWrap,
        GUIStyle_clipping,
        GUIStyle_contentOffset,
        GUIStyle_fixedWidth,
        GUIStyle_fixedHeight,
        GUIStyle_stretchWidth,
        GUIStyle_stretchHeight,
        GUIStyle_font,
        GUIStyle_fontSize,
        GUIStyle_fontStyle,
        GUIStyle_richText,
        GUIStyle_lineHeight,
        GUIStyle_none,
        GUIStyle_isHeightDependantOnWidth,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(GUIStyle_GUIStyle1, ".ctor"),
        new JSMgr.MethodCallBackInfo(GUIStyle_GUIStyle2, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(GUIStyle_CalcHeight__GUIContent__Single, "CalcHeight"),
        new JSMgr.MethodCallBackInfo(GUIStyle_CalcMinMaxWidth__GUIContent__Single__Single, "CalcMinMaxWidth"),
        new JSMgr.MethodCallBackInfo(GUIStyle_CalcScreenSize__Vector2, "CalcScreenSize"),
        new JSMgr.MethodCallBackInfo(GUIStyle_CalcSize__GUIContent, "CalcSize"),
        new JSMgr.MethodCallBackInfo(GUIStyle_Draw__Rect__String__Boolean__Boolean__Boolean__Boolean, "Draw"),
        new JSMgr.MethodCallBackInfo(GUIStyle_Draw__Rect__Texture__Boolean__Boolean__Boolean__Boolean, "Draw"),
        new JSMgr.MethodCallBackInfo(GUIStyle_Draw__Rect__GUIContent__Boolean__Boolean__Boolean__Boolean, "Draw"),
        new JSMgr.MethodCallBackInfo(GUIStyle_Draw__Rect__Boolean__Boolean__Boolean__Boolean, "Draw"),
        new JSMgr.MethodCallBackInfo(GUIStyle_Draw__Rect__GUIContent__Int32__Boolean, "Draw"),
        new JSMgr.MethodCallBackInfo(GUIStyle_Draw__Rect__GUIContent__Int32, "Draw"),
        new JSMgr.MethodCallBackInfo(GUIStyle_DrawCursor__Rect__GUIContent__Int32__Int32, "DrawCursor"),
        new JSMgr.MethodCallBackInfo(GUIStyle_DrawWithTextSelection__Rect__GUIContent__Int32__Int32__Int32, "DrawWithTextSelection"),
        new JSMgr.MethodCallBackInfo(GUIStyle_GetCursorPixelPosition__Rect__GUIContent__Int32, "GetCursorPixelPosition"),
        new JSMgr.MethodCallBackInfo(GUIStyle_GetCursorStringIndex__Rect__GUIContent__Vector2, "GetCursorStringIndex"),
        new JSMgr.MethodCallBackInfo(GUIStyle_ToString, "ToString"),
        new JSMgr.MethodCallBackInfo(GUIStyle_op_Implicit__String_to_GUIStyle, "op_Implicit"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
