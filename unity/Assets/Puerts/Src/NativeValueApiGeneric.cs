/*
* Tencent is pleased to support the open source community by making Puerts available.
* Copyright (C) 2020 THL A29 Limited, a Tencent company.  All rights reserved.
* Puerts is licensed under the BSD 3-Clause License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
* This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
*/

using System;

namespace Puerts
{
    public static class NativeValueApi
    {
        public static IGetValueFromJs GetValueFromArgument = new GetValueFromArgumentImpl();

        public static IGetValueFromJs GetValueFromResult = new GetValueFromResultImpl();

        public static ISetValueToJs SetValueToIndexResult = new SetValueToIndexResultImpl();

        public static ISetValueToJs SetValueToResult = new SetValueToResultImpl();

        public static ISetValueToJs SetValueToByRefArgument = new SetValueToByRefArgumentImpl();

        public static ISetValueToJs SetValueToArgument = new SetValueToArgumentImpl();
    }

    public interface ISetValueToJs
    {
        void SetObject(IntPtr isolate, IntPtr holder, int classID, IntPtr self);

        void SetNumber(IntPtr isolate, IntPtr holder, double number);

        void SetString(IntPtr isolate, IntPtr holder, string str);

        void SetBigInt(IntPtr isolate, IntPtr holder, long number);

        void SetBoolean(IntPtr isolate, IntPtr holder, bool b);

        void SetDate(IntPtr isolate, IntPtr holder, double date);

        void SetNull(IntPtr isolate, IntPtr holder);
    }

    public interface IGetValueFromJs
    {
        JsValueType GetJsValueType(IntPtr isolate, IntPtr holder, bool isByRef);

        double GetNumber(IntPtr isolate, IntPtr holder, bool isByRef);

        double GetDate(IntPtr isolate, IntPtr holder, bool isByRef);

        string GetString(IntPtr isolate, IntPtr holder, bool isByRef);

        bool GetBoolean(IntPtr isolate, IntPtr holder, bool isByRef);

        long GetBigInt(IntPtr isolate, IntPtr holder, bool isByRef);

        IntPtr GetObject(IntPtr isolate, IntPtr holder, bool isByRef);

        int GetTypeId(IntPtr isolate, IntPtr holder, bool isByRef);

        IntPtr GetFunction(IntPtr isolate, IntPtr holder, bool isByRef);
    }

    public class GetValueFromResultImpl : IGetValueFromJs
    {
        public long GetBigInt(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetBigIntFromResult(holder);
        }

        public bool GetBoolean(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetBooleanFromResult(holder);
        }

        public double GetDate(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetDateFromResult(holder);
        }

        public IntPtr GetFunction(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetFunctionFromResult(holder);
        }

        public JsValueType GetJsValueType(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetResultType(holder);
        }

        public double GetNumber(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetNumberFromResult(holder);
        }

        public IntPtr GetObject(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetObjectFromResult(holder);
        }

        public int GetTypeId(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetTypeIdFromResult(holder);
        }

        public string GetString(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetStringFromResult(holder);
        }
    }

    public class GetValueFromArgumentImpl : IGetValueFromJs
    {
        public long GetBigInt(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetBigIntFromValue(isolate, holder, isByRef);
        }

        public bool GetBoolean(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetBooleanFromValue(isolate, holder, isByRef);
        }

        public double GetDate(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetDateFromValue(isolate, holder, isByRef);
        }

        public IntPtr GetFunction(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetFunctionFromValue(isolate, holder, isByRef);
        }

        public JsValueType GetJsValueType(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetJsValueType(isolate, holder, isByRef);
        }

        public double GetNumber(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetNumberFromValue(isolate, holder, isByRef);
        }

        public IntPtr GetObject(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetObjectFromValue(isolate, holder, isByRef);
        }

        public int GetTypeId(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetTypeIdFromValue(isolate, holder, isByRef);
        }

        public string GetString(IntPtr isolate, IntPtr holder, bool isByRef)
        {
            return PuertsDLL.GetStringFromValue(isolate, holder, isByRef);
        }
    }

    public class SetValueToIndexResultImpl : ISetValueToJs
    {
        public void SetBigInt(IntPtr isolate, IntPtr holder, long number)
        {
            PuertsDLL.PropertyReturnBigInt(isolate, holder, number);
        }

        public void SetBoolean(IntPtr isolate, IntPtr holder, bool b)
        {
            PuertsDLL.PropertyReturnBoolean(isolate, holder, b);
        }

        public void SetDate(IntPtr isolate, IntPtr holder, double date)
        {
            PuertsDLL.PropertyReturnDate(isolate, holder, date);
        }

        public void SetNull(IntPtr isolate, IntPtr holder)
        {
            PuertsDLL.PropertyReturnNull(isolate, holder);
        }

        public void SetNumber(IntPtr isolate, IntPtr holder, double number)
        {
            PuertsDLL.PropertyReturnNumber(isolate, holder, number);
        }

        public void SetObject(IntPtr isolate, IntPtr holder, int classID, IntPtr self)
        {
            PuertsDLL.PropertyReturnObject(isolate, holder, classID, self);
        }

        public void SetString(IntPtr isolate, IntPtr holder, string str)
        {
            PuertsDLL.PropertyReturnString(isolate, holder, str);
        }
    }

    public class SetValueToResultImpl : ISetValueToJs
    {
        public void SetBigInt(IntPtr isolate, IntPtr holder, long number)
        {
            PuertsDLL.ReturnBigInt(isolate, holder, number);
        }

        public void SetBoolean(IntPtr isolate, IntPtr holder, bool b)
        {
            PuertsDLL.ReturnBoolean(isolate, holder, b);
        }

        public void SetDate(IntPtr isolate, IntPtr holder, double date)
        {
            PuertsDLL.ReturnDate(isolate, holder, date);
        }

        public void SetNull(IntPtr isolate, IntPtr holder)
        {
            PuertsDLL.ReturnNull(isolate, holder);
        }

        public void SetNumber(IntPtr isolate, IntPtr holder, double number)
        {
            PuertsDLL.ReturnNumber(isolate, holder, number);
        }

        public void SetObject(IntPtr isolate, IntPtr holder, int classID, IntPtr self)
        {
            PuertsDLL.ReturnObject(isolate, holder, classID, self);
        }

        public void SetString(IntPtr isolate, IntPtr holder, string str)
        {
            PuertsDLL.ReturnString(isolate, holder, str);
        }
    }

    public class SetValueToByRefArgumentImpl : ISetValueToJs
    {
        public void SetBigInt(IntPtr isolate, IntPtr holder, long number)
        {
            PuertsDLL.SetBigIntToOutValue(isolate, holder, number);
        }

        public void SetBoolean(IntPtr isolate, IntPtr holder, bool b)
        {
            PuertsDLL.SetBooleanToOutValue(isolate, holder, b);
        }

        public void SetDate(IntPtr isolate, IntPtr holder, double date)
        {
            PuertsDLL.SetDateToOutValue(isolate, holder, date);
        }

        public void SetNull(IntPtr isolate, IntPtr holder)
        {
            PuertsDLL.SetNullToOutValue(isolate, holder);
        }

        public void SetNumber(IntPtr isolate, IntPtr holder, double number)
        {
            PuertsDLL.SetNumberToOutValue(isolate, holder, number);
        }

        public void SetObject(IntPtr isolate, IntPtr holder, int classID, IntPtr self)
        {
            PuertsDLL.SetObjectToOutValue(isolate, holder, classID, self);
        }

        public void SetString(IntPtr isolate, IntPtr holder, string str)
        {
            PuertsDLL.SetStringToOutValue(isolate, holder, str);
        }
    }


    public class SetValueToArgumentImpl : ISetValueToJs
    {
        public void SetBigInt(IntPtr isolate, IntPtr holder, long number)
        {
            PuertsDLL.PushBigIntForJSFunction(holder, number);
        }

        public void SetBoolean(IntPtr isolate, IntPtr holder, bool b)
        {
            PuertsDLL.PushBooleanForJSFunction(holder, b);
        }

        public void SetDate(IntPtr isolate, IntPtr holder, double date)
        {
            PuertsDLL.PushDateForJSFunction(holder, date);
        }

        public void SetNull(IntPtr isolate, IntPtr holder)
        {
            PuertsDLL.PushNullForJSFunction(holder);
        }

        public void SetNumber(IntPtr isolate, IntPtr holder, double number)
        {
            PuertsDLL.PushNumberForJSFunction(holder, number);
        }

        public void SetObject(IntPtr isolate, IntPtr holder, int classID, IntPtr self)
        {
            PuertsDLL.PushObjectForJSFunction(holder, classID, self);
        }

        public void SetString(IntPtr isolate, IntPtr holder, string str)
        {
            PuertsDLL.PushStringForJSFunction(holder, str);
        }
    }

}