﻿namespace EfiSharp
{
    //TODO Support 32bit codes? No real point until ilcompiler works for 32bit as well
    public enum EFI_STATUS : ulong
    {
        //Success Codes
        EFI_SUCCESS = 0,

        //Warning Codes
        EFI_WARN_UNKNOWN_GLYPH = 1,
        //EFI_WARN_DELETE_FAILURE = 2,
        //EFI_WARN_WRITE_FAILURE = 3,
        //EFI_WARN_BUFFER_TOO_SMALL = 4,
        //EFI_WARN_STALE_DATA = 5,
        //EFI_WARN_FILE_SYSTEM = 6,
        //EFI_WARN_RESET_REQUIRED = 7,

        //Error Codes
        //Unused but convenient to represent high bit being set for error status codes
        EFI_ERROR = 0x8000000000000000,
        
        //EFI_LOAD_ERROR = 0x8000000000000001,
        EFI_INVALID_PARAMETER = 2 | EFI_ERROR,
        EFI_UNSUPPORTED = 3 | EFI_ERROR,
        //EFI_BAD_BUFFER_SIZE = 0x8000000000000004,
        EFI_BUFFER_TOO_SMALL = 5 | EFI_ERROR,
        EFI_NOT_READY = 6 | EFI_ERROR,
        EFI_DEVICE_ERROR = 7 | EFI_ERROR,
        //EFI_WRITE_PROTECTED = 0x8000000000000008,
        EFI_OUT_OF_RESOURCES = 9 | EFI_ERROR,
        //EFI_VOLUME_CORRUPTED = 0x800000000000000A,
        //EFI_VOLUME_FULL = 0x800000000000000B,
        //EFI_NO_MEDIA = 0x800000000000000C,
        //EFI_MEDIA_CHANGED = 0x800000000000000D,
        EFI_NOT_FOUND = 14 | EFI_ERROR,
        EFI_ACCESS_DENIED = 15 | EFI_ERROR,
        //EFI_NO_RESPONSE = 0x8000000000000010,
        //EFI_NO_MAPPING = 0x8000000000000011,
        //EFI_TIMEOUT = 0x8000000000000012,
        //EFI_NOT_STARTED = 0x8000000000000013,
        EFI_ALREADY_STARTED = 20 | EFI_ERROR,
        //EFI_ABORTED = 0x8000000000000015,
        //EFI_ICMP_ERROR = 0x8000000000000016,
        //EFI_TFTP_ERROR = 0x8000000000000017,
        //EFI_PROTOCOL_ERROR = 0x8000000000000018,
        //EFI_INCOMPATIBLE_VERSION = 0x8000000000000019,
        //EFI_SECURITY_VIOLATION = 0x800000000000001A,
        //EFI_CRC_ERROR = 0x800000000000001B,
        //EFI_END_OF_MEDIA = 0x800000000000001C,
        //EFI_END_OF_FILE = 0x800000000000001F,
        //EFI_INVALID_LANGUAGE = 0x8000000000000020,
        //EFI_COMPROMISED_DATA = 0x8000000000000021,
        //EFI_IP_ADDRESS_CONFLICT = 0x8000000000000022,
        //EFI_HTTP_ERROR = 0x8000000000000023
    }
}
