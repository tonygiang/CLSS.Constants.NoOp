// A part of the C# Language Syntactic Sugar suite.
using System;

#pragma warning disable IDE0060 // Remove unused parameter
namespace CLSS
{
  public partial class NoOp
  {
    /// <summary>
    /// A 0-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method() { }

    /// <summary>
    /// A 1-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T>(T arg)
    { }

    /// <summary>
    /// A 2-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2>(T1 arg1, T2 arg2)
    { }


    /// <summary>
    /// A 3-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
    { }

    /// <summary>
    /// A 4-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3,
      T4 arg4)
    { }

    /// <summary>
    /// A 5-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3,
      T4 arg4, T5 arg5)
    { }

    /// <summary>
    /// A 6-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3,
      T4 arg4, T5 arg5, T6 arg6)
    { }

    /// <summary>
    /// A 7-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5, T6, T7>(T1 arg1, T2 arg2,
      T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
    { }

    /// <summary>
    /// A 8-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5, T6, T7, T8>(T1 arg1, T2 arg2,
      T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
    { }

    /// <summary>
    /// A 9-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 arg1,
      T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
    { }

    /// <summary>
    /// A 10-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 arg1,
      T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
      T10 arg10)
    { }

    /// <summary>
    /// A 11-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
      T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
      T9 arg9, T10 arg10, T11 arg11)
    { }

    /// <summary>
    /// A 12-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
      T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
      T9 arg9, T10 arg10, T11 arg11, T12 arg12)
    { }

    /// <summary>
    /// A 13-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
      T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
      T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
    { }

    /// <summary>
    /// A 14-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
      T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
      T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
    { }

    /// <summary>
    /// A 15-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
      T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
      T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
    { }

    /// <summary>
    /// A 16-argument no-op function. Use this to initialize non-null delegates
    /// without runtime allocation.
    /// </summary>
    public static void Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
      T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
      T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15,
      T16 arg16)
    { }
  }
}
#pragma warning restore IDE0060 // Remove unused parameter