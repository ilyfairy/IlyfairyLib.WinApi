﻿namespace IlyfairyLib.WinApi.KernelBase
{
    public enum PageAccess : uint
    {
        PAGE_NOACCESS = 0x01,
        PAGE_READONLY = 0x02,
        PAGE_READWRITE = 0x04,
        PAGE_WRITECOPY = 0x08,
        PAGE_EXECUTE = 0x10,
        PAGE_EXECUTE_READ = 0x20,
        PAGE_EXECUTE_READWRITE = 0x40,
        PAGE_EXECUTE_WRITECOPY = 0x80,
        PAGE_GUARD = 0x100,
        PAGE_NOCACHE = 0x200,
        PAGE_WRITECOMBINE = 0x400,
        PAGE_GRAPHICS_NOACCESS = 0x0800,
        PAGE_GRAPHICS_READONLY = 0x1000,
        PAGE_GRAPHICS_READWRITE = 0x2000,
        PAGE_GRAPHICS_EXECUTE = 0x4000,
        PAGE_GRAPHICS_EXECUTE_READ = 0x8000,
        PAGE_GRAPHICS_EXECUTE_READWRITE = 0x10000,
        PAGE_GRAPHICS_COHERENT = 0x20000,
        PAGE_GRAPHICS_NOCACHE = 0x40000,
        PAGE_ENCLAVE_THREAD_CONTROL = 0x80000000,
        PAGE_REVERT_TO_FILE_MAP = 0x80000000,
        PAGE_TARGETS_NO_UPDATE = 0x40000000,
        PAGE_TARGETS_INVALID = 0x40000000,
        PAGE_ENCLAVE_UNVALIDATED = 0x20000000,
        PAGE_ENCLAVE_MASK = 0x10000000,
        PAGE_ENCLAVE_DECOMMIT = (PAGE_ENCLAVE_MASK | 0),
        PAGE_ENCLAVE_SS_FIRST = (PAGE_ENCLAVE_MASK | 1),
        PAGE_ENCLAVE_SS_REST = (PAGE_ENCLAVE_MASK | 2),
    }
}