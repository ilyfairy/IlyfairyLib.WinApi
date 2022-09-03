using System;

namespace IlyfairyLib.WinApi.Utils
{
    public static class Utils
    {
        /// <summary>
        /// Get the address of a variable on the stack
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <returns>address</returns>
        public static unsafe IntPtr GetVarAddress<T>(ref T val)
        {
            var r = __makeref(val);
            return *((IntPtr*)&r);
        }

        /// <summary>
        /// Get the address of the reference type in the heap
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <returns>address</returns>
        public static unsafe IntPtr GetObjectAddress<T>(T val) where T : class
        {
            var r = __makeref(val);
            return *(IntPtr*)*((IntPtr*)&r);
        }

        public static unsafe IntPtr ToIntPtr(this string str)
        {
            return GetObjectAddress(str) + 4 + sizeof(IntPtr);
        }

        public static unsafe char* ToPointer(this string str)
        {
            return (char*)(GetObjectAddress(str) + 4 + sizeof(IntPtr)).ToPointer();
        }

        public static unsafe T* ToPointer<T>(this T[] str) where T : unmanaged
        {
            return (T*)(GetObjectAddress(str) + 8 + sizeof(IntPtr)).ToPointer();
        }

        public static unsafe IntPtr ToIntPtr<T>(this T[] str) where T : unmanaged
        {
            return (GetObjectAddress(str) + 8 + sizeof(IntPtr));
        }

    }
}
